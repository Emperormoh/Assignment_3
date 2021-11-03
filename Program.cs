
using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char run;

            do
            {
                NewBank Wema = new NewBank();
                int num;
                Console.WriteLine("Please Select an Action");
                Console.WriteLine("\nFor Deposit, Press 1");
                Console.WriteLine("\nFor withdrawal, Press 2");
                Console.WriteLine("\nFor baalance, Press 3");

                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Wema.ReceiveMoney();
                        break;
                    case 2:
                        Wema.SendMoney();
                        break;
                    case 3:
                        Wema.checkBalance();
                        break;
                    default:

                        Console.WriteLine("Invalid Isnput!");
                        break;


                }
                Console.WriteLine("\nDo you want to carry out another transaction?. (y/n)");
                run = char.Parse(Console.ReadLine());

            }
            while (run == 'y');
            {
                Console.ReadKey();

            }
        }
    }
   
}
