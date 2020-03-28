using System;
using System.Linq;
namespace SEDC.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region TASK I
            //Console.WriteLine("Enter a number: ");
            //bool isNumberParsed = int.TryParse(Console.ReadLine(), out int inputNumber);
            //if (isNumberParsed && inputNumber > 2)
            //{
            //    for (int i = 1; i <= inputNumber; i++)
            //    {
            //        if (i % 3 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter number bigger than 2");
            //}

            //#endregion
            //#region TASK II
            //Console.WriteLine("Enter a number: ");
            //bool isNumberParsedTwo = int.TryParse(Console.ReadLine(), out int inputNumberTwo);
            //if (isNumberParsedTwo && inputNumberTwo > 5)
            //{
            //    for (int i = 1; i <= inputNumberTwo; i++)
            //    {
            //        if (i % 2 == 0 && i % 3 == 0)
            //            Console.WriteLine(i);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a number bigger than 5");
            //}
            //#endregion
            //#region TASK III
            //Console.WriteLine("Enter a number:");
            //bool isNumberParsedThree = int.TryParse(Console.ReadLine(), out int inputNumberThree);
            //if (isNumberParsedThree)
            //{
            //    int productOfDigits = 1;
            //    while (inputNumberThree != 0)
            //    {
            //        productOfDigits *= (inputNumberThree % 10);
            //        inputNumberThree /= 10;
            //    }
            //    Console.WriteLine("Product of digits of this number is: " + productOfDigits);
            //}
            //#endregion
            //#region TASK IV
            //Console.WriteLine("Enter a number:");
            //bool isNumberParsedFour = int.TryParse(Console.ReadLine(), out int inputNumberFour);
            //if (isNumberParsedFour)
            //{
            //    int sumOfAllEvens = 0;
            //    for (int i = 1; i <= inputNumberFour; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            sumOfAllEvens += i;
            //        }
            //    }
            //    Console.WriteLine("The sum of all even numbers from 1 to " + inputNumberFour + " is: " + sumOfAllEvens);
            //}
            //#endregion
            //#region TASK V
            //Console.WriteLine("Enter a number:");
            //bool isNumberParsedFive = int.TryParse(Console.ReadLine(), out int inputNumberFive);
            //if (isNumberParsedFive)
            //{
            //    int sumOfAllOdds = 0;
            //    for (int i = 1; i <= inputNumberFive; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            sumOfAllOdds += i;
            //        }
            //    }
            //    Console.WriteLine("The sum of all odd numbers from 1 to " + inputNumberFive + " is: " + sumOfAllOdds);
            //}
            //#endregion
            //#region TASK VI
            //Console.WriteLine("Enter a number:");
            //bool isNumberParsedSix = int.TryParse(Console.ReadLine(), out int inputNumberSix);
            //if (isNumberParsedSix)
            //{
            //    int sumOfAllNumbersDividingFive = 0;
            //    for (int i = 1; i <= inputNumberSix; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            sumOfAllNumbersDividingFive += i;
            //        }
            //    }
            //    Console.WriteLine("The sum of all numbers that are dividing with 5, from 1 to " + inputNumberSix + " is: " + sumOfAllNumbersDividingFive);
            //}
            //#endregion
            //#region TASK VII
            //string[] arrayTaskSeven = new string[] { "a", "b", "c", "d" };
            //// CHECK BEFORE REVERSING
            //Console.WriteLine(arrayTaskSeven[0] + arrayTaskSeven[1] + arrayTaskSeven[2] + arrayTaskSeven[3]);
            //Array.Reverse(arrayTaskSeven);
            //// CHECK AFTER REVERSING
            //Console.WriteLine(arrayTaskSeven[0] + arrayTaskSeven[1] + arrayTaskSeven[2] + arrayTaskSeven[3]);
            //#endregion
            //#region TASK VIII
            //// PLEASE HELP ME IF YOU HAVE FREE TIME
            //#endregion
            //#region TASK IX
            //int sumOfDigits = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    while (i != 0)
            //    {
            //        sumOfDigits += i % 10;
            //        i /= 10;
            //    }
            //    Console.WriteLine(sumOfDigits);
            //}
            //#endregion
            //#region TASK X
            //// PLEASE HELP ME IF YOU HAVE FREE TIME !
            //#endregion
            #region TASK XI
            for (int i = 10; i > 100; i++)
            {
                if ((i /= 10) > (i % 10))
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            //#region TASK XII
            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 3 == 0 && i % 5 == 0)
            //    {
            //        string dividedBy3And5 = i.ToString("Fizz Buzz");
            //        Console.WriteLine(dividedBy3And5);

            //    }else if(i % 5 == 0)
            //    {
            //        string dividedBy5 = i.ToString("Buzz");
            //        Console.WriteLine(dividedBy5);
            //    }else if(i % 3 == 0)
            //    {
            //        string dividedBy3 = i.ToString("Fizz");
            //        Console.WriteLine(dividedBy3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //#endregion
            Console.ReadLine();
        }
    }
}