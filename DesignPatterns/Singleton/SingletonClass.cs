using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    //intialization of singlton pattern
    public class SingletonClass
    {
        private static SingletonClass instance = new SingletonClass();

        //The constructor of a class is marked as private. This prevents any external classes from creating new instances.
        private SingletonClass()
        {

        }

        public static SingletonClass getInstance
        {
            get
            {
                return instance;
            }
        }
    }

    //Lazy initialization of singleton pattern

    public class lazySingloton
    {
        private static lazySingloton Instance = null;
        private lazySingloton()
        {

        }
        public static lazySingloton getinstance
        {
            get
            {
                if (Instance == null)
                    Instance = new lazySingloton();
                return Instance;
            }
        }
    }
}
