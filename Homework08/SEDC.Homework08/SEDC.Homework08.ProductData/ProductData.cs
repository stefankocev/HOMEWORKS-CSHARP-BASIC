using SEDC.Homework08.ProductLibrary.Enums;
using SEDC.Homework08.ProductLibrary.Models;
using System;
using System.Collections.Generic;



namespace SEDC.Homework08.Data
{
    public class ProductData
    {
        List<Product> products = new List<Product>
            {
                new Product() { Name = "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name = "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name = "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name = "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name = "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name = "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name = "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name = "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name = "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name = "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name = "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name = "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name = "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name = "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name = "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name = "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name = "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name = "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name = "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name = "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name = "Samsung Oval", Price = 247999, Category = Category.TV}
            };

        public List<Product> SeachByCategory(string category)
        {
            var productList = new List<Product>();
            foreach (var product in products)
            {
                if(category == product.Category.ToString())
                    productList.Add(product);
            }
            return productList;
        }
        public List<Product> GetProductsByPriceRange(int min, int max)
        {
            var productList = new List<Product>();
            foreach (var product in products)
            {
                if (product.Price >= min && product.Price <= max)
                    productList.Add(product);
            }
            return productList;
        }

        public List<Product> GetProductsByPartOfName(string namePart)
        {
            var productList = new List<Product>();
            foreach (var product in products)
            {
                if (!product.Name.Contains(namePart))
                    Console.WriteLine("There are not products with given input.");
                else
                    productList.Add(product);
            }
            return productList;
        }   
        public void GetProductsById()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"Id:{product.GetProductsId()}");
            }
            
        }
        public string GetProductsByPrice(int id)
        {
            int result = 0;
            foreach (var product in products)
            {
                if (id == product.Id)
                 result = product.Price;
            }
            if (result == 0)
                return "There is not product with that ID ";
            return $"The price is {result}";
        }
        public Product GetCheapestProduct()
        {
            Product cheapestProduct = new Product();
            int cheapestProductPrice = 99999999;
            foreach (var product in products)
            {
                if (cheapestProductPrice > product.Price)
                {
                    cheapestProductPrice = product.Price;
                    cheapestProduct = product;
                }
            }
            return cheapestProduct;
        }
        public Product GetMostExpensiveProduct()
        {
            Product mostExpensiveProduct = new Product();
            int mostExpensiveProductPrice = 0;
            foreach (var product in products)
            {
                if (mostExpensiveProductPrice < product.Price)
                {
                    mostExpensiveProductPrice = product.Price;
                    mostExpensiveProduct = product;
                }
            }
            return mostExpensiveProduct;
        }
        public List<Product> AddProduct(Product newProduct)
        {
            products.Add(newProduct);
            return products;
        }
        public List<Product> RemoveProduct(int id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (id == products[i].Id)
                {
                    products.Remove(products[i]);
                }
            }
            return products;
        }
    }
}
