using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class CeaserCypher
    {
        public void Cypher()
        {
            string Capital = "QWERTZUIOPASDFGHJKLYXCVBNM";
            string Small = "qwertzuiopasdfghjklyxcvbnm";
            string Digits = "1234567890";
            string Special = "~`!@#$%^&*()-_+={}[]|/:;'<>,.?";
            string all = Capital + Small + Digits + Special;
            List<char> list = new List<char>();
            List<int> zahl = new List<int>();
            string pass = "";
            string securityPass = "";
            int schluessel = 3;
            Random rnd = new Random();
            Console.WriteLine(all.Length);
            for (int i = 0; i < all.Length; i++)
            {
                list.Add(all[i]);
            }

            for (int i = 0; i < 8; i++)
            {
                zahl.Add(rnd.Next(list.Count));
                pass += list[zahl[i]];
            }
            Console.WriteLine(pass);

            for (int i = 0; i < 8; i++)
            {
                if (zahl[i] + schluessel > all.Length)
                {
                    int var = (all.Length - (zahl[i] + schluessel)) * -1;
                    securityPass += list[var - 1];
                }
                else
                {
                    securityPass += list[zahl[i] + schluessel];
                }
            }
            Console.WriteLine(securityPass);
        }
    }
}
