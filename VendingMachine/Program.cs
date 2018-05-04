using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
       
        public static Product pr;

        static void Main(string[] args)
        {
           

             while (true)   // As long as the While condition is true, We remain in the Vending Machine, and Exit it by Pressing 0.
             {
                Pepsi pepsi = new Pepsi { Name = "Pepsi", Type = "Soft Drink", Price = 10 };
                Fanta fanta = new Fanta { Name = "Fanta", Type = "Soft Drink", Price = 15 };
                Chocolate chocolate = new Chocolate { Name = "Snicker", Type = "Eatable", Price = 5 };
                Coke coke = new Coke { Name = "Coke", Type = "Soft Drink", Price = 10 };
                Sandwich sandwich = new Sandwich { Name = "Sandwich", Type = "Eatable", Price = 30 };

                List<Product> products = new List<Product> { pepsi, fanta, coke, chocolate, sandwich }; //   List of Products
                Console.WriteLine("    Välja produkt från Menu...\n");
                Console.WriteLine($"     1: {"Pepsi"}\n     2: {"Fanta"}\n     3: {"Coke"}\n     4: {"Chocolate"}\n     5: {"Sandwich"}\n" +
                    $"     0: {"To Exit Vending Machine"}");

                int a = int.Parse(Console.ReadKey().KeyChar.ToString());

                for (int i = 0; i < products.Count; i++)  // Loop around the List of products and select the one, the Customer has choosen for Purchse
                {
                    if (i == a-1)
                    {
                        pr = products[i];
                        pr.Examine();  // Send the Selected product for Examination

                        Console.WriteLine($"     1: {"To Purchase the Products "}\n     2: {"To return to main Menu"}\n");
                        int b = int.Parse(Console.ReadKey().KeyChar.ToString());
                        

                        if (b == 1)
                        {
                            Console.Clear();
                            pr.Purchase(products[i]);  // Send the Selected product to the Purchase 
                            
                        }
                        else
                            Console.Clear();
                            break;                   
                         
                    }

                    else if(a== 0)
                    {
                       Environment.Exit(0);   // Exit the Vending Machine if Press 0 
                    }
                    

                }

             }

        }
    }
}
