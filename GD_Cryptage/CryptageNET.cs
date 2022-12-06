using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GD_Cryptage
{
    class CryptageNET
    {

        //Write encryption and decryption function in c# that take input as text to encrypt and clef as key

            private string input;
            private string clef;


            public CryptageNET(string input, string clef)
            {
                this.input = input;
                this.clef = clef;
            }
        /*
            public string Encrypt()
            {
                // Convert the text to bytes
                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(clef);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }

            public string Decrypt()
            {
                byte[] inputArray = Convert.FromBase64String(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(clef);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
        
        */
        public string Encrypt()
        {
            try
            {

                byte[] MyEncryptedArray = UTF8Encoding.UTF8.GetBytes(input);

                MD5CryptoServiceProvider MyMD5CryptoService = new
                   MD5CryptoServiceProvider();

                byte[] clefArray = MyMD5CryptoService.ComputeHash
                   (UTF8Encoding.UTF8.GetBytes(clef));

                MyMD5CryptoService.Clear();

                var MyTripleDESCryptoService = new
                   TripleDESCryptoServiceProvider();

                MyTripleDESCryptoService.Key = clefArray;

                MyTripleDESCryptoService.Mode = CipherMode.ECB;

                MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                var MyCrytpoTransform = MyTripleDESCryptoService
                   .CreateEncryptor();

                byte[] MyresultArray = MyCrytpoTransform
                   .TransformFinalBlock(MyEncryptedArray, 0,
                   MyEncryptedArray.Length);

                MyTripleDESCryptoService.Clear();

                return Convert.ToBase64String(MyresultArray, 0,
                   MyresultArray.Length);
            }
            catch (Exception e)
            {
                return "";
                throw;
            }
        }



        public string Decrypt()
        {
            try
            {

                byte[] MyDecryptArray = Convert.FromBase64String(input);

                MD5CryptoServiceProvider MyMD5CryptoService = new
                   MD5CryptoServiceProvider();

                byte[] clefArray = MyMD5CryptoService.ComputeHash
                   (UTF8Encoding.UTF8.GetBytes(clef));

                MyMD5CryptoService.Clear();

                var MyTripleDESCryptoService = new
                   TripleDESCryptoServiceProvider();

                MyTripleDESCryptoService.Key = clefArray;

                MyTripleDESCryptoService.Mode = CipherMode.ECB;

                MyTripleDESCryptoService.Padding = PaddingMode.PKCS7;

                var MyCrytpoTransform = MyTripleDESCryptoService
                   .CreateDecryptor();

                byte[] MyresultArray = MyCrytpoTransform
                   .TransformFinalBlock(MyDecryptArray, 0,
                   MyDecryptArray.Length);

                MyTripleDESCryptoService.Clear();

                return UTF8Encoding.UTF8.GetString(MyresultArray);
            }
            catch (Exception e)
            {
                return "";
                throw;
            }

        }
    }
}
