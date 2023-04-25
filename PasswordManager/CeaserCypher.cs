using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class CeaserCypher
    {
        private string securityPass;
        public string VerschleusslungVonCeaser(int passLength, int schluessel)
        {
            string Capital = "QWERTZUIOPASDFGHJKLYXCVBNM";
            string Small = "qwertzuiopasdfghjklyxcvbnm";
            string Digits = "1234567890";
            string Special = "~`!@#$%^&*()-_+={}[]|/:;'<>,.?";
            string all = Capital + Small + Digits + Special; // Hier werden alle Symbole gespeichert
            List<int> zahl = new List<int>(); //Hier werden alle Positionen der Symbole die in Passwort verwendet werden, gespeichert 
            string pass = ""; // Variable für nicht verschlüsseltes Passwort
            string securityPass = ""; // Variable für verschlüsseltes Passwort
            Random rnd = new Random();

            for (int i = 0; i < passLength; i++)
            {
                zahl.Add(rnd.Next(all.Length)); // Zufällige zahl von 0 bis 92(anzahl der Symbole) wird in Liste gespeichert
                pass += all[zahl[i]]; // Symbol mit zufällige Position von oben wird in der Variable pass gespeichert
            }

            for (int i = 0; i < passLength; i++)
            {
                int var = zahl[i] + schluessel;
                while (var > all.Length)
                {
                    var = (all.Length - (zahl[i] + schluessel)) * -1; // Unterschied wird gerechnet und positiv gesetzt
                }
                securityPass += all[var];
            }
            return this.securityPass = securityPass;
        }

        public override string ToString()
        {
            return this.securityPass;
        }
    }
}
