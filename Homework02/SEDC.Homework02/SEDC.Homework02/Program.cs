using System;
using System.Threading;


namespace SEDC.Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise VI
            Console.WriteLine("Please enter the first number");
            bool firstNumberToInput = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please enter the second number");
            bool secondNumberToInput = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (firstNumberToInput && secondNumberToInput)
            {
                 if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber + " is bigger than " + secondNumber);
                int biggerNumber = firstNumber;
                if(biggerNumber % 2 == 0)
                {
                    Console.WriteLine("Number " + biggerNumber + " is even.");
                }
                else
                {
                    Console.WriteLine("Number " + biggerNumber + " is odd.");
                }
            }
            else if(firstNumber < secondNumber)
            {
                Console.WriteLine(secondNumber + " is bigger than " + firstNumber);
                int biggerNumber = secondNumber;
                if (biggerNumber % 2 == 0)
                {
                    Console.WriteLine("Number " + biggerNumber + " is even.");
                }
                else
                {
                    Console.WriteLine("Number " + biggerNumber + " is odd.");
                }
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }
            }else
            {
                Console.WriteLine("There was an error!");
            }
            Console.ReadLine();

            #endregion

            #region Exercise VII
            Console.ReadLine();
            Console.WriteLine("Let me generate a random number for you ...");
            Thread.Sleep(1500);
            Random random = new Random();
            int enteredNumber = random.Next(1,3);
                switch (enteredNumber)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("There was some error.");
                    break;

            }

            Console.ReadLine();
            #endregion

            #region Task I
            Console.WriteLine("Please enter the first number");
            bool inputAToNumber = double.TryParse(Console.ReadLine(), out double numberA);
            Console.WriteLine("Enter the second number");
            bool inputBToNumber = double.TryParse(Console.ReadLine(), out double numberB);
            Console.WriteLine("Enter the operation");
            bool inputOperation = char.TryParse(Console.ReadLine(), out char operation);
            if (inputAToNumber && inputBToNumber && inputOperation )
            {
                if(operation == '+')
            {
                double resultFromAdding = numberA + numberB;
                Console.WriteLine("The result is: " + resultFromAdding);
            }else if(operation == '-')
            {
                double resultFromSubstracting = numberA - numberB;
                Console.WriteLine("The result is: " + resultFromSubstracting);
            }else if(operation == '*')
            {
                double resultFromMultiplying = numberA * numberB;
                Console.WriteLine("The result is: " + resultFromMultiplying);
            }
            else if(operation == '/')
            {
                double resultFromDividing = numberA / numberB;
                Console.WriteLine("The result is: " + resultFromDividing);
            }
            else
            {
                Console.WriteLine("There was an error");
            }

            }else
            {
                Console.WriteLine("There was an error!");
            }
            Console.ReadLine();
            #endregion

            #region Task II
            Console.WriteLine("Enter the first number");
            bool taskTwoInputOneToNumber = double.TryParse(Console.ReadLine(), out double taskTwoNumberOne);
            Console.WriteLine("Enter the second number");
            bool taskTwoInputTwoToNumber = double.TryParse(Console.ReadLine(), out double taskTwoNumberTwo);
            Console.WriteLine("Enter the third number");
            bool taskTwoInputThreeToNumber = double.TryParse(Console.ReadLine(), out double taskTwoNumberThree);
            Console.WriteLine("Enter the fourth number");
            bool taskTwoInputFourToNumber = double.TryParse(Console.ReadLine(), out double taskTwoNumberFour);
            if(taskTwoInputOneToNumber && taskTwoInputTwoToNumber && taskTwoInputThreeToNumber && taskTwoInputFourToNumber){
                double averageFromFourNumbers = ( taskTwoNumberOne + taskTwoNumberTwo + taskTwoNumberThree + taskTwoNumberFour ) / 4;
            Console.WriteLine("The average of " + taskTwoNumberOne + ", " + taskTwoNumberTwo + ", " + taskTwoNumberThree +  " and " + taskTwoNumberFour + " is: " + averageFromFourNumbers);
            }
            else
            {
                Console.WriteLine("There was an error");
            }
            Console.ReadLine();
            #endregion

            #region Task III
            Console.WriteLine("Enter the first Number");
            bool firstInputForSwappingToNumber = int.TryParse(Console.ReadLine(), out int firstNumberForSwapping);
            Console.WriteLine("Enter the second Number");
            bool secondInputForSwappingToNumber = int.TryParse(Console.ReadLine(), out int secondNumberForSwapping);
            if(firstInputForSwappingToNumber && secondInputForSwappingToNumber){
             Console.WriteLine("Before swapping: First Number = " + firstNumberForSwapping + " Second Number = " + secondNumberForSwapping);
            firstNumberForSwapping += secondNumberForSwapping;
            secondNumberForSwapping = firstNumberForSwapping - secondNumberForSwapping;
            firstNumberForSwapping -= secondNumberForSwapping;
            Console.WriteLine("After swapping: First Number = " + firstNumberForSwapping + " Second Number = " + secondNumberForSwapping);
            }else
            {
                Console.WriteLine("There was an error!");
            }
            

            #endregion
            Console.ReadLine();
        }
    }
}
