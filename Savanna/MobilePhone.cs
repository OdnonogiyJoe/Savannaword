using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    public class MobilePhone : IPhone
    {

        public MobilePhone(string number)
        {
            Number = number;
        }

        public string Number { get ; set ; }

        public string GetTypeName(string Number)
        {
            return "мобильный телефон";
        }
    }
}
