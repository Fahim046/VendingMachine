using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Product : Interface1
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public static int Moneypool { get; set; }

        public int[] denomination = { 1, 5, 10, 20, 50, 100, 500, 1000 };

        
        public abstract void Use(); // Abstract Method, All Child Classes must implement it ...
   
        // *****************  Purchase Function ******************************

        public void Purchase(Product pr)    
        {

          //  Moneypool += Addmoney();

          //  if (Moneypool < pr.Price)
          //  {
                while (!(Moneypool >= pr.Price)) // Remain in the loop until moneypool exceeds Product Price 
                {
                    Moneypool += Addmoney();     // Call add money function  
                    //Console.WriteLine("Your credit is" + " " + Moneypool + " " + "Please add more money to the money Pool.");
                    Console.WriteLine("Your credit is" + " " + Moneypool);
                }
            //}
           

            Moneypool = Moneypool - pr.Price;
            Console.WriteLine("Remaining credit is :" + Moneypool);

            pr.Use(); // Call the override Use function in the respective Product class (Pepsi, Fanta, Coke etc)

            Console.WriteLine($"     1: {"Press 1 to Return to main Menu"}\n     2: {"Press 2 to take back your Change"}");

            int Choice = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (Choice)
            {
                case 1:  break;
                case 2:  CalculateChange(Moneypool); // Call the Calculate Change Function
                         break;
            }

                //Console.Clear();
        }
        // ***********************  Calculate Change Function ****************************

        public void CalculateChange(int change)
        {
                          
            for (int i=denomination.Length-1; i>=0; i--)
            {
                int amount = 0;
                while (change>=denomination[i])
                {
                    change -= denomination[i];
                    amount++;

                    if (!(change >= denomination[i]))
                    {
                        Console.WriteLine("\nChangeReturned " + amount + ": " + denomination[i]);
                    }
                }
            }
            Console.ReadLine();
        }
            
       // ***********************   Add Money Function  ************************************* 

      public static int Addmoney()
      {
            Console.WriteLine("\nAdd Money to the MoneyPool");
        int money = 0;
        Console.WriteLine($"     1: {"To add 1kr:"}\n   " +
            $"  2: {"To add 5kr"}\n  " +

            $"   3: {"To add 10kr"}\n     4: {"To add 20"}\n     5: {"To add 50"}\n     6: { "To add 100"}\n     7:  {"To add 500"}\n     8: {"To add 1000"}");
        string st1 = Console.ReadLine();
        switch (st1)
        {
            case "1": money += 1; break;
            case "2": money += 5; break;
            case "3": money += 10; break;
            case "4": money += 20; break;
            case "5": money += 50; break;
            case "6": money += 100; break;
            case "7": money += 500; break;
            case "8": money += 1000; break;
        }
        return money;
      }
        // *********** Examine Method *********  

        public void Examine()
        {
            Console.WriteLine($"\n Name: {Name}  Price: {Price} Type: {Type}\n");
        }
    }
}
    

                   