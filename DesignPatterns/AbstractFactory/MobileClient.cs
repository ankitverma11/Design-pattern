using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Client
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public Client(IMobilePhone factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneModelDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneModelDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
}
