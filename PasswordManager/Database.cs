using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasswordManager
{
    public class Database
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
        public static Database LoadFromFile(string path)
        {
            using (FileStream fs = new(path, FileMode.Open))
            {
                XmlSerializer xmlSerializer= new XmlSerializer(typeof(Database));
                return (Database) xmlSerializer.Deserialize(fs);
            }
        }
        public void AddFolder()
        {
            folders.Add(new Folder());
        }
    }
}
