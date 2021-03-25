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

        public string Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetTypeName(string Number)
        {
            throw new NotImplementedException();
        }
    }
}
