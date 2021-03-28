using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class ContactsDB
    {
        List<Contact> AllContacts = new List<Contact>();
        int autoincrementIdContact = 1;
        string fileName = "db.bin";
        public void Save()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            DirectoryInfo dirInfo = new DirectoryInfo(fileName);
            dirInfo.Create();
            using (FileStream fstream = new FileStream(fileName))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(autoincrementIdContact);
                fstream.Write(array, 4, array.Length);
            }
        }
    }
}
