using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    public class Bank
    {
        private double balance = 20000;
        public double accessedBalance
        {
            get { return balance; }
            set { balance = value; }

        }
    }

    class NewBank
    {
        Bank Suleiman = new Bank();
        string name;
        int account;
        double withdraw;
        double deposit;
        double total;


        public void ReceiveMoney()
        {
            Console.WriteLine("\nWelcome to Suleiman Bank.", "\nEnter name of depositior");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your account number");
            account = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the amount you want to deposit");
            deposit = double.Parse(Console.ReadLine());
            total = Suleiman.accessedBalance + deposit;


            Console.WriteLine($"Total Balance is now ${total}");


        }

        public void SendMoney()
        {
            Console.WriteLine("please enter your account number");
            account = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the amount you want to withdraw");
            withdraw = double.Parse(Console.ReadLine());

            if (withdraw <= Suleiman.accessedBalance)
            {
                total = Suleiman.accessedBalance - withdraw;
                Console.WriteLine("your new balance is :" + total);
                
            }
            else
            {
                Console.WriteLine("Insufficient Balance");

            }


        }
        public void checkBalance()
        {
            Console.WriteLine("your account balance is :" + total);

        }
    }
}
