using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.AbstractFactory
{
    public partial class AbstractFactory : Form
    {
        public AbstractFactory()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
        //Creates a set of related objects or dependent objects. 
        //The "family" of objects created by the factory is determined at run-time depending on the selection of concrete factory classes.

        //An abstract factory interface is responsible for creating a set of related objects or dependent objects without specifying their concrete classes.
    }
}
