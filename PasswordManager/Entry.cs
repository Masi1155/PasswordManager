using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class Entry
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string url { get; set; }
        public string? encriptionMethod { get; }
        private RSA RSAEncrypt;
        private string ceaserCypher = "";

        public Entry(string name, string username, string password, string url, string encriptionMethod = "RSA")
        {
            Name = name;
            Username = username;
            Password = password;
            this.url = url;
            if (encriptionMethod == "CC")
            {
                this.encriptionMethod = "CC";
                this.ceaserCypher = password;
            }
            else if (encriptionMethod == "RSA")
            {
                this.encriptionMethod = "RSA";
                RSAEncrypt = new(password);
            } else
            {
                throw new Exception("Invalid Decription Method");
            }
        }

        public String getPassword()
        {
            if(encriptionMethod == "RSA")
            {
                byte[] databytes = RSAEncrypt.Decrypt();
                UnicodeEncoding byteConverter = new();
                return byteConverter.GetString(databytes, 0, databytes.Length);
            }
            else
            {
                return ceaserCypher;
            }
        }
        public void Encrypt()
        {
            if(encriptionMethod == "CC")
            {
                // CeaserCypher Encript call here
            } else if(encriptionMethod == "RSA")
            {
                RSAEncrypt.Encrypt();
            }
        }


    }
}
