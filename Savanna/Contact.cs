using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phones { get; set; }
        public DateTime Birthday { get; set; }
        public NickNames NickNames { get; set; }
        
    }
}
