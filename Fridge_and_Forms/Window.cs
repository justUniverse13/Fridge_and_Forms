using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    class Window : IHomeConstruction
    {
       public void IsOpened()
        {
            Console.WriteLine("Window is already open!");
        }
    }
}
