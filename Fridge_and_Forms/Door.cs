using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    class Door : IHomeConstruction
    {
        public void IsOpened()
        {
            Console.WriteLine("Door is already open!");
        }
    }
}
