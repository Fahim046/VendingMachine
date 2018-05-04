using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Sandwich : Product
    {
        
        public override void Use()
        {
            Console.WriteLine("Enjoy your Sandwich");
        }
    }
}
