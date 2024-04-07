using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double balance = 0;

        private int PIN = 0000;

        
         

        public void Begin()
        {
            Console.WriteLine("PLease Enter PIN to begin");
            var userInput1 = int.Parse(Console.ReadLine());
            if (userInput1 == PIN) 
            {
                Start();
            }
            else
            {
                Console.WriteLine("Sorry Wrong PIN");
            }

        }

        public void Start()
        {
            Console.WriteLine("Hello, Welcome Please, type Deposit, Withdraw Or Get Balance");
            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Deposit":
                    Deposit();
                    break;
                case "Withdraw":
                    Withdraw(); 
                    break;
                case "Get Balance":
                    GetBalance();
                    break;
                default: Console.WriteLine("Sorry try again");
                    break;





            } 
           

        }

        public void Deposit()
        {
            Console.WriteLine("Please enter amount to Deposit");
            var userInput1 = double.Parse(Console.ReadLine());

            balance += userInput1;
            
           

        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Please enter amount to WithDraw");
            double userInput2 = double.Parse(Console.ReadLine());

            balance -= userInput2;
        }



    }

}