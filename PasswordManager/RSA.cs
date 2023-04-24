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

        public RSA(string dataToEncrypt) { 
            DataStringToBytes(dataToEncrypt);
        }
        public byte[] Encrypt() {
            try
            {
                using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSA.ExportParameters(false));
                    RSA.PersistKeyInCsp = false;
                    RSA.FromXmlString(@"C:\Users\marcel.kunert\Desktop\PasswordManager\PasswordManager\pub_key.xml");
                    encryptedData = RSA.Encrypt(bytesToEncrypt, false);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return encryptedData;
        }
        public byte[] Decrypt() {
            try
            {
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSA.ExportParameters(false));
                    RSA.PersistKeyInCsp = false;
                    RSA.FromXmlString(@"C:\Users\marcel.kunert\Desktop\PasswordManager\PasswordManager\priv_key.txt");
                    decryptedData = RSA.Decrypt(encryptedData, false);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return decryptedData;
        }

        private void DataStringToBytes(String dataToEncrypt) {
            UnicodeEncoding byteConverter = new();
            this.bytesToEncrypt= byteConverter.GetBytes(dataToEncrypt);
        }
    }
}
