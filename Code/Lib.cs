//injecting dlls is usually in c++, but here we have a c# library that we want to inject
//a normal c++ dll has a DllMain which gets excecuted when it is executed, but c# does not have that
//there isnt really an equivalent but we can get around that by calling our class 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SkidClientLibrary
{
    class Lib
    {
        static Lib()
        {
            //here you would write all your code 
            MessageBox.Show("This was an injected dll test");
        }
    }
}
