using System;
using System.IO;
using System.Security.Cryptography;
using System.Text; 

namespace MainForm
{
    class Cipher
    {


        private static byte[] desKey = { 0x01, 0x02, 0xAB, 0xAC, 0xBA, 0xBB, 0xCC, 0xCD };
        private static byte[] desiv = { 0x01, 0x02, 0xAB, 0xAC, 0xBA, 0xBB, 0xCC, 0xCD };


        //{ 0x01, 0x02, 0xAB, 0xAC, 0xBA, 0xBB, 0xCC, 0xCD };
        public Cipher(string key, string iv)
        {
            // key와 vector 값을 byte[] 형으로 변환시킵니다.  
            desKey = System.Text.Encoding.Default.GetBytes(key);
            desiv = System.Text.Encoding.Default.GetBytes(iv);

            if (desKey.Length != 8 || desiv.Length != 8)
            {
                // DES 암호화키는 8자리입니다.  
                throw (new Exception("Invalid key. Key length must be 8 byte."));
            }

        }

        public static string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                throw new Exception("the string which needs to be encrypted can not be null.");
            }

            // DES 암호화 관련 클래스를 생성합니다.  
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            // cipher 모드를 CBC 방식으로 사용합니다.  
            cryptoProvider.Mode = CipherMode.CBC;
            // Padding Mode 를 PKCS7 으로 사용합니다.(PKCS5 와 동일합니다.)  
            cryptoProvider.Padding = PaddingMode.PKCS7;

            // Step 4. 암호화할 문자열을 Byte[]로 변환
            //System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
            //byte[] DataToEncrypt = utf8.GetBytes(plainText);   

            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateEncryptor(desKey, desiv), CryptoStreamMode.Write);
            StreamWriter writer = new StreamWriter(cryptoStream, Encoding.UTF8);

            writer.Write(plainText);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();

            String cypherText = Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
            return cypherText;
        }

        public static string Decrypt(string cypherText)
        {
            string plainText;
            System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
            // DES 암호화 관련 클래스를 생성합니다.  
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();

            if (string.IsNullOrEmpty(cypherText))
            {
                //throw new ArgumentException("the string which needs to be encrypted can not be null.");
                return null;
            }

            // cipher 모드를 CBC 방식으로 사용합니다.  
            cryptoProvider.Mode = CipherMode.CBC;
            // Padding Mode 를 PKCS7 으로 사용합니다.(PKCS5 와 동일합니다.)  
            cryptoProvider.Padding = PaddingMode.PKCS7;

            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cypherText));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoProvider.CreateDecryptor(desKey, desiv), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);

            plainText = reader.ReadToEnd();

            byte[] btTemp = utf8.GetBytes(plainText);
            plainText = utf8.GetString(btTemp);


            return plainText;
        }

        /*
        static void Main(string[] args)
        {
            string cypherText = Cipher.Encrypt("test string");
            console.WriteLine(cypherText);

            string plainText = Cipher.Decrypt(cypherText);
            console.WriteLine(plainText);
        }*/
    }  
}
