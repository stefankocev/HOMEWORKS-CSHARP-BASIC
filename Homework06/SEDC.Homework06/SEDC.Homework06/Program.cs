using SEDC.Homework06.Library;
using SEDC.Homework06.Library.Models;
using System;

namespace SEDC.Homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerOne = new Customer("Stefan", "Kocev");
            Customer customerTwo = new Customer("Kire", "Spasovski");
            CreditCard creditCardOne = new CreditCard("1234-1234-1234-1234", 7777, customerOne, 12500);
            CreditCard creditCardTwo = new CreditCard("5678-5678-5678-5678", 1111, customerTwo, 14000);
            CreditCard[] creditCards = new CreditCard[] { creditCardOne, creditCardTwo };
            Console.WriteLine("Please enter your card number:");
            string cardNumberInput = Console.ReadLine();
            Console.WriteLine("Please enter your pin:");
            int cardPinInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < creditCards.Length; i++)
            {
                if (cardNumberInput == creditCards[i].Number && cardPinInput == creditCards[i].Pin)
                {
                    Console.WriteLine(creditCards[i].GreetingCustomer());
                }
            }
            Console.ReadLine();
        }
    }
}
