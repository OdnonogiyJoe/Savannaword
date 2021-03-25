using System;
using System.Collections.Generic;
using System.Text;

namespace Savanna
{
    class Phones
    {
        public List<IPhone> ListPhones { get; set; } = new List<IPhone>();
        public IPhone DefaultPhone { get; set; }

        public void AddPhone(string number)
        {
            
            MobilePhone mp = new MobilePhone(number);
            mp.Number = number;
            if (ListPhones != null && ListPhones.Count == 0)
            {
                    ListPhones = new List<IPhone>();
                    ListPhones.Add(mp);
            }
                else
            {
                    ListPhones.Add(DefaultPhone);
            }
        }
        public void ChangeTypePhone(IPhone phone)
        {
            List<Phones> = 
        }
    }
}
