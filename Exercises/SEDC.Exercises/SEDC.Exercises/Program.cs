using System;

namespace SEDC.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK I
            Console.WriteLine("Enter a number: ");
            bool isNumberParsed = int.TryParse(Console.ReadLine(), out int inputNumber);
            if (isNumberParsed && inputNumber > 2)
            {
                for (int i = 1; i <= inputNumber; i++)
                {
                    if(i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Please enter number bigger than 2");
            }

            #endregion
            #region TASK II
            Console.WriteLine("Enter a number: ");
            bool isNumberParsedTwo = int.TryParse(Console.ReadLine(), out int inputNumberTwo);
            if (isNumberParsedTwo && inputNumberTwo > 5)
            {
                for (int i = 1; i <= inputNumberTwo; i++)
                {
                    if(i % 2 == 0 && i % 3 == 0)
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Please enter a number bigger than 5");
            }
            #endregion
            #region TASK III
            Console.WriteLine("Enter a number:");
            bool isNumberParsedThree = int.TryParse(Console.ReadLine(), out int inputNumberThree);
            if (isNumberParsedThree)
            {
                int productOfDigits = 1;
                while (inputNumberThree != 0)
                {
                    productOfDigits = productOfDigits * (inputNumberThree % 10);
                    inputNumberThree = inputNumberThree / 10;
                }
                Console.WriteLine("Product of digits of this number is: " + productOfDigits);
            }
            #endregion
            #region TASK IV
            Console.WriteLine("Enter a number:");
            bool isNumberParsedFour = int.TryParse(Console.ReadLine(), out int inputNumberFour);
            if (isNumberParsedFour)
            {
                int sumOfAllEvens = 0;
                for(int i = 1; i <= inputNumberFour; i++)
                {
                    if(i % 2 == 0)
                    {
                        sumOfAllEvens += i;
                    }
                }
                Console.WriteLine("The sum of all even numbers from 1 to " + inputNumberFour + " is: " + sumOfAllEvens);
            }
            #endregion
            #region TASK V
            Console.WriteLine("Enter a number:");
            bool isNumberParsedFive = int.TryParse(Console.ReadLine(), out int inputNumberFive);
            if (isNumberParsedFive)
            {
                int sumOfAllOdds = 0;
                for (int i = 1; i <= inputNumberFive; i++)
                {
                    if (i % 2 != 0)
                    {
                        sumOfAllOdds += i;
                    }
                }
                Console.WriteLine("The sum of all odd numbers from 1 to " + inputNumberFive + " is: " + sumOfAllOdds);
            }
            #endregion
            #region TASK VI
            Console.WriteLine("Enter a number:");
            bool isNumberParsedSix = int.TryParse(Console.ReadLine(), out int inputNumberSix);
            if (isNumberParsedSix)
            {
                int sumOfAllNumbersDividingFive = 0;
                for (int i = 1; i <= inputNumberSix; i++)
                {
                    if (i % 5 == 0)
                    {
                        sumOfAllNumbersDividingFive += i;
                    }
                }
                Console.WriteLine("The sum of all numbers that are dividing with 5, from 1 to " + inputNumberSix + " is: " + sumOfAllNumbersDividingFive);
            }
            #endregion
            Console.ReadLine();
        }
    }
}