using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEncryption.Services.Abstracion
{
    public interface IDecryption
    {
        string DecryptFinalText(string encryptedText);
    }
}