using ES.BLL.Interfaces;
using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace ES.BLL.Metodos
{
    public class MHerramientas : IHerramientas
    {
        private DAL.Interfaces.IHerramientas _herra;
        public MHerramientas()
        {
            _herra = new DAL.Metodos.MHerramientas();
        }
        
        #region Encryption

        // SecretKey (16 Characters)
        public string secretKey = "DrNbEsuT8y9YT2k2";

        // Encrypt()
        public string Encrypt(string data)
        {
            byte[] keyArray;
            byte[] encrypt = Encoding.UTF8.GetBytes(data);

            keyArray = Encoding.UTF8.GetBytes(secretKey);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] res = cTransform.TransformFinalBlock(encrypt, 0, encrypt.Length);
            tdes.Clear();

            return Convert.ToBase64String(res, 0, res.Length);
        }

        // Decrypt()
        public string Decrypt(string data)
        {
            byte[] keyArray;
            byte[] decrypt = Convert.FromBase64String(data);

            keyArray = Encoding.UTF8.GetBytes(secretKey);

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] res = cTransform.TransformFinalBlock(decrypt, 0, decrypt.Length);
            tdes.Clear();

            return Encoding.UTF8.GetString(res);
        }

        #endregion

        // CapitalizeByWord()
        public string CapitalizeByWord(string data)
        {
            return _herra.CapitalizeByWord(data) ;
        }

        // Capitalize()
        public string Capitalize(string data)
        {
            return _herra.Capitalize(data);
        }
    }
}
