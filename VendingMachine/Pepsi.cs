using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Pepsi : Product 
    {
                  
        public override void Use()
        {
            Console.WriteLine("Enjoy your Pepsi");
        }
    }
}
