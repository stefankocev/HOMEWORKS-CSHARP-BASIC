using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework06.Library.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
       
    }
}
