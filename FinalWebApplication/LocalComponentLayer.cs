using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalWebApplication
{
    public class LocalComponentLayer
    {
        public string Encrypt(string text)
        {
            EncryptAndDecrypt.ServiceClient ED = new EncryptAndDecrypt.ServiceClient();
            string output = ED.Encrypt(text);
            return output;
        }

        public string Decrypt(string text)
        {
            EncryptAndDecrypt.ServiceClient ED = new EncryptAndDecrypt.ServiceClient();
            string output = ED.Decrypt(text);
            return output;
        }
    }
}