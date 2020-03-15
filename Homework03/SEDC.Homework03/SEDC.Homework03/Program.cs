using System;

namespace SEDC.Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK I
            int[] arrayOfNumbers = new int[6];
            Console.WriteLine("Enter First Number:");
            arrayOfNumbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            arrayOfNumbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            arrayOfNumbers[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth Number:");
            arrayOfNumbers[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fifth Number:");
            arrayOfNumbers[4] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sixth Number:");
            arrayOfNumbers[5] = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    result += arrayOfNumbers[i];
                }
            }
            Console.WriteLine("The result is: " + result);
            
            #endregion
            #region TASK II
            string[] studentG1 = new string[] { "Stefan", "Darko", "Vasil", "Kire", "Filip"};
            string[] studentG2 = new string[] { "Simona", "Ivona", "Valerija", "Kristina", "Marijana" };
            Console.WriteLine("1 or 2");
            int numberFromInput = int.Parse(Console.ReadLine());
            if(numberFromInput == 1)
            {
                Console.WriteLine("The students in G1 are: " + studentG1[0] + "," + studentG1[1] + "," + studentG1[2] + "," + studentG1[3] + "," + studentG1[4]);
            }else if(numberFromInput == 2)
            {
                Console.WriteLine("The students in G2 are: " + studentG2[0] + "," + studentG2[1] + "," + studentG2[2] + "," + studentG2[3] + "," + studentG2[4]);
            }
            else
            {
                Console.WriteLine("You have entered a wrong number.");
            }
            #endregion
            #region EXERCISE V
            int[] numberArray = new int[5];
             Console.WriteLine("Enter First Number:");
            numberArray[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            numberArray[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number:");
            numberArray[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fourth Number:");
            numberArray[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fifth Number:");
            numberArray[4] = int.Parse(Console.ReadLine());
            int resultFromArray = 0;
            for(int i = 0; i < numberArray.Length; i++)
            {
                resultFromArray += numberArray[i];
            }
            Console.WriteLine("The result from all numbers in the array is: " + resultFromArray);
            #endregion
            Console.ReadLine();
        }
    }
}
    
