using System;

namespace SEDC.Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise VI
            Console.WriteLine("Please enter the first number");
            int firstNumber = 0;
            bool firstInputToNumber = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Please enter the second number");
            int secondNumber = 0;
            bool secondInputToNumber = int.TryParse(Console.ReadLine(), out secondNumber);

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
            #endregion

            #region Exercise VII
            Console.WriteLine("Please enter a number from 1 to 3");
            int enteredNumber = 0;
            bool inputToNumber = int.TryParse(Console.ReadLine(), out enteredNumber);
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
                    Console.WriteLine("You've entered a wrong number!");
                    break;

            }
            #endregion

            #region Task I
            Console.WriteLine("Please enter the first number");
            double numberA = 0;
            bool aInputToNumber = double.TryParse(Console.ReadLine(), out numberA);
            Console.WriteLine("Please enter the second number");
            double numberB = 0;
            bool bInputToNumber = double.TryParse(Console.ReadLine(), out numberB);
            Console.WriteLine("Please enter the operation");
            char operation = '\0';
            bool operationInput = char.TryParse(Console.ReadLine(), out operation);
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

            #endregion

            #region Task II
            Console.WriteLine("Enter the first number");
            double taskTwoNumberOne = 0;
            bool taskTwoInputOneToNumber = double.TryParse(Console.ReadLine(), out taskTwoNumberOne);
            Console.WriteLine("Enter the second number");
            double taskTwoNumberTwo = 0;
            bool taskTwoInputTwoToNumber = double.TryParse(Console.ReadLine(), out taskTwoNumberTwo);
            Console.WriteLine("Enter the third number");
            double taskTwoNumberThree = 0;
            bool taskTwoInputThreeToNumber = double.TryParse(Console.ReadLine(), out taskTwoNumberThree);
            Console.WriteLine("Enter the fourth number");
            double taskTwoNumberFour = 0;
            bool taskTwoInputFourToNumber = double.TryParse(Console.ReadLine(), out taskTwoNumberFour);
            double averageFromFourNumbers = ( taskTwoNumberOne + taskTwoNumberTwo + taskTwoNumberThree + taskTwoNumberFour ) / 4;
            Console.WriteLine("The average of " + taskTwoNumberOne + ", " + taskTwoNumberTwo + ", " + taskTwoNumberThree +  " and " + taskTwoNumberFour + " is: " + averageFromFourNumbers);
            #endregion

            #region Task III
            Console.WriteLine("Enter the first Number");
            int firstNumberForSwapping = 0;
            bool firstInputForSwappingToNumber = int.TryParse(Console.ReadLine(), out firstNumberForSwapping);
            Console.WriteLine("Enter the second Number");
            int secondNumberForSwapping = 0;
            bool secondInputForSwappingToNumber = int.TryParse(Console.ReadLine(), out secondNumberForSwapping);
            Console.WriteLine("Before swapping: First Number = " + firstNumberForSwapping + " Second Number = " + secondNumberForSwapping);
            firstNumberForSwapping = firstNumberForSwapping + secondNumberForSwapping;
            secondNumberForSwapping = firstNumberForSwapping - secondNumberForSwapping;
            firstNumberForSwapping = firstNumberForSwapping - secondNumberForSwapping;
            Console.WriteLine("After swapping: First Number = " + firstNumberForSwapping + " Second Number = " + secondNumberForSwapping);

            #endregion
            Console.ReadLine();
        }
    }
}
