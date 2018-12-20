using DesignPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class Samsung : IMobilePhone
    {
        //ConcreteFactory - Nokia, Samsung
        public INormalPhone GetNormalPhone()
        {
            return new SamsungGalaxy();
        }

        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGuru();
        }
    }
    //Product- SamsungGalaxy, SamsungGuru
    internal class SamsungGuru : ISmartPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }

    internal class SamsungGalaxy : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy\nRAM: 2GB\nCamera: 13MP\n";
        }
    }
}
