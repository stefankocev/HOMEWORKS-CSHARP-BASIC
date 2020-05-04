using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework06.Library.Models
{
   public class CreditCard
    {
        public string Number { get; set; }
        public int Pin { get; set; }
        public Customer Customer { get; set; }
        public double Money { get; set; }
        public CreditCard(string number, int pin, Customer customer, double money)
        {
            Number = number;
            Pin = pin;
            Customer = customer;
            Money = money;
        }
        public string GreetingCustomer()
        {
            return $"Welcome {Customer.FullName()}";
        }
    }
}
