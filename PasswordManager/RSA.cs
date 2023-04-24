using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace PasswordManager
{
    internal class RSA
    {
        private byte[] bytesToEncrypt;
        private byte[] encryptedData;
        private byte[] decryptedData;
        private byte[] pubKey;
        private byte[] privKey;

        public RSA(string dataToEncrypt) { 
            DataStringToBytes(dataToEncrypt);
            GetPrivKeyFromFile();
            GetPubKeyFromFile();
        }
        public void Encrypt() {
            try
            {
                using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSA.ExportParameters(false));
                    encryptedData = RSA.Encrypt(bytesToEncrypt, false);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }           
        }
        public void Decrypt() {
            try
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSA.ExportParameters(false));
                    decryptedData = RSA.Decrypt(encryptedData, false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void DataStringToBytes(String dataToEncrypt) {
            UnicodeEncoding byteConverter = new();
            this.bytesToEncrypt= byteConverter.GetBytes(dataToEncrypt);
        }

        private void GetPubKeyFromFile(string path = @"C:\Users\marcel.kunert\Desktop\PasswordManager\PasswordManager\pub_key.txt") {
            using(FileStream stream = new(path, FileMode.Open))
            {
                using (StreamReader sr = new(stream))
                {
                    string data = sr.ReadToEnd();
                    UnicodeEncoding byteConverter = new();
                    this.pubKey = byteConverter.GetBytes(data);
                }
            }
        }
        private void GetPrivKeyFromFile(String path = @"C:\Users\marcel.kunert\Desktop\PasswordManager\PasswordManager\priv_key.txt") {
            using (FileStream stream = new(path, FileMode.Open))
            {
                using (StreamReader sr = new(stream))
                {
                    string data = sr.ReadToEnd();
                    UnicodeEncoding byteConverter = new();
                    this.privKey = byteConverter.GetBytes(data);
                }
            }
        }
    }
}
