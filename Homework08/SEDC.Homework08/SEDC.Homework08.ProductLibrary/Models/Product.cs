using SEDC.Homework08.ProductLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework08.ProductLibrary.Models
{
    public class Product
    {
        private static int _idGenerator = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            _idGenerator++;
            Id = _idGenerator;
        }

        public void GetInfo()
        {
            Console.WriteLine( $"Id: {Id}, Name: {Name}, Price: {Price}, Category: {Category}");
        }
        public int GetProductsId()
        {
            return Id;
        }
    }
}
