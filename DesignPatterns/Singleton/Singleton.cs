using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.Singleton
{
    public partial class Singleton : Form
    {

        public Singleton()
        {
            //This pattern ensures that the class has only one instance and provides a global point of access to it. 
            // The pattern ensures that only one object of a specific class is ever created. 
            // All further references to objects of the singleton class refer to the same underlying instance.ss
            InitializeComponent();
            GetStateInfo();
            //There are situations in a project where we want only one instance of the object to be created and shared among the clients.
            //No client can create an instance from outside.It is more appropriate than creating a global variable since this may be copied and leads to multiple access points.


            //In the singleton pattern, all the methods and instances are defined as static. The static keyword ensures that only one instance of the object is created and you can call methods of the class without creating an object.

            //The constructor of a class is marked as private. This prevents any external classes from creating new instances.The class is also sealed to prevent inheritance, that could lead to sub classing that breaks the singleton rules.


        }

        public void GetStateInfo()
        {
            ApllicationState state = ApllicationState.GetState();
             state.LoginID = "Ankit verma";
             state.RoleID = "Admin";

            ApllicationState state2 = ApllicationState.GetState();
            label3.Text = state.LoginID;
            label4.Text = state.RoleID;
            label5.Text = (state == state2).ToString();

            
        }
    }
}
