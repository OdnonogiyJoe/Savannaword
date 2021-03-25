using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    public class TownPhone : IPhone
    {
        public string Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetTypeName(string Number)
        {
            throw new NotImplementedException();
        }
    }
}
