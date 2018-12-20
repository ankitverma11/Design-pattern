using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ApllicationState
    {
        private static ApllicationState instance = null;

        public string LoginID { get; set; }
        public string RoleID { get; set; }

        private static object lockthis = new object();
        private ApllicationState()
        { }

        public static ApllicationState GetState()
        {
            lock (lockthis)
            {
                if (ApllicationState.instance == null)
                    instance = new ApllicationState();
            }
            return instance;
        }
    }
}
