using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using TextEncryption.Services.Abstracion;

namespace TextEncryption.Services.Implementation
{
    public class Encryption : IEncryption
    {
        public string GetTextToEncryptFinal(string text)
        {
            var firstEncryption = GetTextToEncryptFirst(text);
            StringBuilder result = new StringBuilder();
            foreach (char c in firstEncryption)
            {
                int unicodeValue = c;
                result.Append(emoticons.ContainsKey(unicodeValue) ? Char.ConvertFromUtf32(emoticons[unicodeValue]) : c.ToString());
            }
            return result.ToString();
        }
        private string GetTextToEncryptFirst(string text)
        {
            string textGuid = "D84FB779-c32F-49B0-Bc99-2823DF5DE31E";
            string encryptedText = EncryptText(text);
            string combinedText = $"{textGuid}{encryptedText}";
            return combinedText;
        }

        private string EncryptText(string text)
        {

            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] encryptedBytes = Encrypt(textBytes);
            byte[] reversedBytes = ReverseBytes(encryptedBytes);
            return Convert.ToBase64String(reversedBytes);

        }
        private byte[] Encrypt(byte[] textBytes)
        {
            byte[] result = new byte[textBytes.Length*2];

            string key = "k31";
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte sum = (byte)(Encoding.UTF8.GetBytes(key).Sum(b => b)); //tworzę nowy klucz

            int j = 0;

            for (int i = 0; i < textBytes.Length; i++)
            {
                result[j++] = textBytes[i]; //kopiuję bajt tekstu

                //jeśli nie jestem na ostatnim bajcie tekstu i jest to co drugi bajt, dodaję klucz
                if (i < textBytes.Length - 1 && (i + 1) % 2 == 0)
                {
                    result[j++] = sum; //dodaje klucz
                }
            }

            return result;
        }

        private byte[] ReverseBytes(byte[] bytes)
        {
            byte[] reversedBytes = new byte[bytes.Length];
            int length = bytes.Length;
            if (length % 2 == 0) 
            { 
                for (int i = 0; i < length; i += 2)
                {
                    reversedBytes[i] = bytes[i + 1];
                    reversedBytes[i + 1] = bytes[i];
                }
            }
            else
            {
                length = length - 1;
                for (int i = 0; i < length; i += 2)
                {
                    reversedBytes[i] = bytes[i + 1];
                    reversedBytes[i + 1] = bytes[i];
                }
            }
            return reversedBytes;
        }

        Dictionary<int, int> emoticons = new Dictionary<int, int>()
        {
            {97, 128582},
            {115, 128000},
            {107, 128011},
            {111, 128008},
            {122, 127914},
            {99, 129337}
        };
    }
}