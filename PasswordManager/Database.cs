using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasswordManager
{
    internal class Database
    {
        public List<Folder> folders= new List<Folder>();
        public String path;

        public Database()
        {

        }

        public void SaveToFile()
        {
            using (FileStream fs = new(this.path, FileMode.OpenOrCreate))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Database));
                xmlSerializer.Serialize(fs,this);
            }
        }
        public Database LoadFromFile()
        {
            using (FileStream fs = new(this.path, FileMode.Open))
            {
                XmlSerializer xmlSerializer= new XmlSerializer(typeof(Database));
                return (Database) xmlSerializer.Deserialize(fs);
            }
        }
    }
}
