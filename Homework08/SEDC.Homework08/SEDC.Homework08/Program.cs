using SEDC.Homework08.Data;
using SEDC.Homework08.ProductLibrary.Enums;
using SEDC.Homework08.ProductLibrary.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Homework08
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataBase = new ProductData();
            //#region SEARCH BY CATEGORY
            //Console.WriteLine("please enter one of the following categories: itequipment, laptop, pc, tv");
            //var searchByCategory = dataBase.SeachByCategory(Console.ReadLine());
            //PrintList(searchByCategory);
            //#endregion
            //#region PRODUCTS BY PRICE RANGE 
            //Console.WriteLine("Enter the min price:");
            //bool minRangeInput = int.TryParse(Console.ReadLine(), out int minRange);
            //Console.WriteLine("Enter the max price:");
            //bool maxRangeInput = int.TryParse(Console.ReadLine(), out int maxRange);
            //if (!minRangeInput && !maxRangeInput)
            //    Console.WriteLine("There was an error");
            //else
            //{
            //    var productsByPriceRange = dataBase.GetProductsByPriceRange(minRange, maxRange);
            //    PrintList(productsByPriceRange);
            //}
            //#endregion
            //#region PRODUCTS BY PART OF NAME
            //Console.WriteLine("Search by letters. Write a part of some product!");
            //var productsByPartOfName = dataBase.GetProductsByPartOfName(Console.ReadLine());
            //PrintList(productsByPartOfName);
            //#endregion
            #region GET PRODUCTS BY ID
            var idList = dataBase.GetProductsById();
            foreach (var id in idList)
            {
                Console.WriteLine(id);
            }
            #endregion
            //#region GET PRODUCTS BY PRICE
            //Console.WriteLine("Enter the product Id:");
            //bool idInput = int.TryParse(Console.ReadLine(), out int id);
            //if (!idInput)
            //    Console.WriteLine("There was an error!");
            //else
            //    Console.WriteLine(dataBase.GetProductsByPrice(id));
            //#endregion
            //#region GET CHEAPEST PRODUCT
            //var cheapestProduct = dataBase.GetCheapestProduct();
            //Console.WriteLine($"Id: {cheapestProduct.Id}, Name: {cheapestProduct.Name}, Price: {cheapestProduct.Price}, Category: {cheapestProduct.Category}");

            //#endregion
            //#region GET MOST EXPENSIVE PRODUCT
            //var mostExpensiveProduct = dataBase.GetMostExpensiveProduct();
            //Console.WriteLine($"Id: {mostExpensiveProduct.Id}, Name: {mostExpensiveProduct.Name}, Price: {mostExpensiveProduct.Price}, Category: {mostExpensiveProduct.Category}");

            //#endregion
            //#region ADD PRODUCT
            //Product product1 = new Product() { Name = "Sony TV", Price = 3000000, Category = Category.TV };
            //var addProduct = dataBase.AddProduct(product1);
            //PrintList(addProduct);
            //#endregion
            //#region REMOVE PRODUCT
            //var removeProduct = dataBase.RemoveProduct(4);
            //PrintList(removeProduct);
            //#endregion
            Console.ReadLine();
        }
        public static void PrintList(List<Product> products)
        {
            foreach (var product in products)
            {
                product.GetInfo();
            }
        }
    }
}
