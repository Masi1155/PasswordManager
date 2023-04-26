using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class Folder
    {
        private List<Entry> entries = new List<Entry>();
        public Folder() { }

        public void EncryptEntires()
        {
            foreach (Entry e in entries)
            {
                e.Encrypt();
            }
        }

        public void Add(Entry e)
        {
            entries.Add(e);
        }
    }
}
