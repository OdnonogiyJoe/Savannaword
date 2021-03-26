using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    public class TownPhone : IPhone
    {
        public string Number { get ; set ; }

        public string GetTypeName(string Number)
        {
            return "Городской телефон";
        }
    }
}
