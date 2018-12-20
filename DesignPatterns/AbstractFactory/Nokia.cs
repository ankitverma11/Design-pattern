using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Nokia : IMobilePhone
    {
        //ConcreteFactory - Nokia, Samsung
        public INormalPhone GetNormalPhone()
        {
            return new NokiaPixel();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new Nokia1600();
        }
    }
    //Product- NokiaPixel, Nokia1600, 
    internal class Nokia1600 : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "1600";
        }
    }

    internal class NokiaPixel : INormalPhone
    {
        public string GetModelDetails()
        {
            return "pixel";
        }
    }



}
