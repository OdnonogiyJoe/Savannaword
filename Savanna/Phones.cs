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
                    ListPhones.Add(DefaultPhone);
            }
                else
            {
                    ListPhones.Add(mp);
            }
        }
        public void ChangeTypePhone(IPhone phone)
        {
            int index = ListPhones.IndexOf(phone);
            if (index == -1) { return; }
            else
            {
                if (phone is MobilePhone)//3a
                {
                    TownPhone newTypePhone = new TownPhone { Number = phone.Number };
                }
                else
                if (phone is TownPhone)//3b
                {
                    MobilePhone newTypePhone = new MobilePhone { Number = phone.Number };
                }
                if (phone == DefaultPhone) //3c
                    DefaultPhone = phone;

                ListPhones.RemoveAt(index);//3d
                ListPhones.Add(phone);//3e
            }


        }
    }
}
