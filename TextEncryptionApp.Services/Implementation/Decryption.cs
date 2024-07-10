using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TextEncryption.Services.Abstracion;
using static System.Net.Mime.MediaTypeNames;

namespace TextEncryption.Services.Implementation
{
    public class Decryption : IDecryption
    {
        private Dictionary<int, int> emoticons = new Dictionary<int, int>()
        {
            {128582, 97},
            {128000, 115},
            {128011, 107},
            {128008, 111},
            {127914, 122},
            {129337, 99}
        };

        public string DecryptFinalText(string encryptedText)
        {
            string textWithoutEmoticons = ReplaceEmoticons(encryptedText);
            string encryptedTextOnly = RemoveGuidFromText(textWithoutEmoticons);

            string decryptedText = DecryptText(encryptedTextOnly);

            return decryptedText;
        }
        private string ReplaceEmoticons(string text)
        {
            StringBuilder result = new StringBuilder();
            int i = 0;
            while (i < text.Length)
            {
                if (char.IsSurrogatePair(text, i))
                {
                    int emoticonUnicodeValue = char.ConvertToUtf32(text, i);
                    if (emoticons.ContainsKey(emoticonUnicodeValue))
                    {
                        int originalUnicodeValue = emoticons[emoticonUnicodeValue];
                        char[] originalChars = char.ConvertFromUtf32(originalUnicodeValue).ToCharArray();
                        result.Append(originalChars);
                    }
                    else
                    {
                        result.Append(text[i]);
                        result.Append(text[i + 1]);
                    }
                    i += 2;
                }
                else
                {
                    result.Append(text[i]);
                    i++;
                }
            }
            return result.ToString();
        }

        private string RemoveGuidFromText(string text)
        {
            string textGuid = "D84FB779-c32F-49B0-Bc99-2823DF5DE31E";
            int guidLength = textGuid.Length;
            return text.Substring(guidLength);
        }

        private string DecryptText(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] reversedBytes = OriginalBytes(encryptedBytes);
            byte[] decryptedBytes = Decrypt(reversedBytes);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        private byte[] Decrypt(byte[] encryptedBytes)
        {
            string key = "k31";
            byte sum = (byte)Encoding.UTF8.GetBytes(key).Sum(b => b); 

            List<byte> decryptedBytesList = new List<byte>();

            for (int i = 0; i < encryptedBytes.Length; i++)
            {
                if (!(encryptedBytes[i] == sum))
                {
                    decryptedBytesList.Add(encryptedBytes[i]);
                }
            }

            return decryptedBytesList.ToArray();
        }


        private byte[] OriginalBytes(byte[] reversedBytes)
        {
            byte[] originalBytes = new byte[reversedBytes.Length];
            int length = reversedBytes.Length;

            bool isEvenLength = length % 2 == 0;

            for (int i = 0; i < length; i += 2)
            {
                if (isEvenLength)
                {
                    originalBytes[i] = reversedBytes[i + 1];
                    originalBytes[i + 1] = reversedBytes[i];
                }
                else
                {
                    if (i < length - 1)
                    {
                        originalBytes[i] = reversedBytes[i + 1];
                        originalBytes[i + 1] = reversedBytes[i];
                    }
                    else
                    {
                        originalBytes[i] = reversedBytes[i];
                    }
                }
            }

            return originalBytes;
        }
    }

    
}
