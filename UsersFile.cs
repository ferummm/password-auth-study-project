using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Org.Mentalis.Security.Cryptography;
using System.Security.Cryptography;

namespace LR1
{
    class UsersFile
    {
        private static readonly string _pathToFile = "users.txt";
        public readonly bool IsExist = false;

        public UsersFile()
        {
            if (File.Exists(_pathToFile))
            {
                IsExist = true;
            }
        }
        public static bool IsCorrectPP()
        {
            try
            {
                using (var reader = new BinaryReader(AuthorizeForm.ms, Encoding.Unicode, true))
                {
                    while (reader.PeekChar() != -1)
                    {
                        AuthorizeForm.usersSet.Add(new User(reader.ReadString(), reader.ReadString(), reader.ReadBoolean(), reader.ReadBoolean(), reader.ReadBoolean()));
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return AuthorizeForm.usersSet.Contains(new User(AuthorizeForm.admin_name));
        }
        public static byte[] GetKey(string passphrase, byte[] salt)
        {

            byte[] pwd = Encoding.Unicode.GetBytes(passphrase);
            RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(pwd, salt);
            return pdb.CryptDeriveKey("RC2", "MD2", 128, rc2CSP.IV);
        }
        public static void Encrypt(MemoryStream finStream, string passphrase)
        {
            RC4CryptoServiceProvider rc4CSP = new RC4CryptoServiceProvider();
            RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
            byte[] randBytes = new byte[8];
            rand.GetBytes(randBytes);
            rc4CSP.Key = GetKey(passphrase, randBytes);
            ICryptoTransform encryptor = rc4CSP.CreateEncryptor(rc4CSP.Key, rc4CSP.IV);
            FileStream foutStream = new FileStream(_pathToFile, FileMode.Create);
            foutStream.Write(randBytes, 0, 8);
            CryptoStream CrStream = new CryptoStream(foutStream, encryptor, CryptoStreamMode.Write);
            byte[] bytes = new byte[finStream.Length];
            int numBytesToRead = (int)finStream.Length;
            int n = finStream.Read(bytes, 0, numBytesToRead);
            numBytesToRead = n;
            CrStream.Write(bytes, 0, numBytesToRead);

            
            rc4CSP.Clear();
            CrStream.Close();
            foutStream.Close();
        }

        public static void Decrypt(MemoryStream foutStream, string passphrase)
        {
            RC4CryptoServiceProvider rc4CSP = new RC4CryptoServiceProvider();

            RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider();

            FileStream finStream = new FileStream(_pathToFile, FileMode.Open);

            byte[] randBytes = new byte[8];
            finStream.Read(randBytes, 0, 8);

            rc4CSP.Key = GetKey(passphrase,randBytes);
            ICryptoTransform decryptor = rc4CSP.CreateDecryptor(rc4CSP.Key, rc4CSP.IV);
            CryptoStream CrStream = new CryptoStream(finStream, decryptor, CryptoStreamMode.Read);

            
            byte[] bytes = new byte[finStream.Length - 8];
            int numBytesToRead = (int)(finStream.Length) - 8;
            
            int n = CrStream.Read(bytes, 0, numBytesToRead);
            
            numBytesToRead = n;
            
            foutStream.Write(bytes, 0, numBytesToRead);
            rc2CSP.Clear();
            CrStream.Close();
            finStream.Close();
        }

    }
}
