using System;
using System.Collections.Generic;
using System.Text;

namespace GD_Cryptage
{
    class CryptageNET
    {
        
         //Write encryption and decryption function in c# that take textAcrypter as text to encrypt and clef as key

//public class Crypter 
//{ 
//   public static string Encrypt(string textAcrypter, string clef) 
//   { 
//      // Convert the text to bytes
//      byte[] inputArray = UTF8Encoding.UTF8.GetBytes(textAcrypter); 
//      TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider(); 
//      tripleDES.Key = UTF8Encoding.UTF8.GetBytes(clef); 
//      tripleDES.Mode = CipherMode.ECB; 
//      tripleDES.Padding = PaddingMode.PKCS7; 
//      ICryptoTransform cTransform = tripleDES.CreateEncryptor(); 
//      byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length); 
//      tripleDES.Clear(); 
//      return Convert.ToBase64String(resultArray, 0, resultArray.Length); 
//   } 

//   public static string Decrypt(string textAcrypter, string clef) 
//   { 
//      byte[] inputArray = Convert.FromBase64String(textAcrypter); 
//      TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider(); 
//      tripleDES.Key = UTF8Encoding.UTF8.GetBytes(clef); 
//      tripleDES.Mode = CipherMode.ECB; 
//      tripleDES.Padding = PaddingMode.PKCS7; 
//      ICryptoTransform cTransform = tripleDES.CreateDecryptor(); 
//      byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length); 
//      tripleDES.Clear(); 
//      return UTF8Encoding.UTF8.GetString(resultArray); 
//   } 
//}
         
    }
}
