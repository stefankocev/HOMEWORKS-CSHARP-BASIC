using System;
using System.Linq;
namespace SEDC.Homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            Substring();
            Console.WriteLine("Enter the word:");
            string isAPalindromeInput = Console.ReadLine().ToLower();
            IsAPalindome(isAPalindromeInput);
            BiggestNumberInAnArray(new int[] { 4, 1, 5, 99, 8, 168, 120 });
            NumberOfVowels("In the farm, there are 5 cows, 35 chickens, 438 goats and 1000 eggs".ToLower());
            NumberOfDigits("In the farm, there are 5 cows, 35 chickens, 438 goats and 1000 eggs".ToLower());
            Console.WriteLine("Enter the sentence:");
            string sentenceInput = Console.ReadLine();
            LetterReplacing(sentenceInput);
            Console.WriteLine("Enter a character:");
            char characterInput = (char)Console.Read();
            IsACharacterAlphabetical(characterInput);
            SubstringInAStringCounter();
            Console.WriteLine("Enter the first Integer:");
            bool firstIntegerToNumber = int.TryParse(Console.ReadLine(), out int integerOne);
            Console.WriteLine("Enter the second Integer:");
            bool secondIntegerToNumber = int.TryParse(Console.ReadLine(), out int integerTwo);
            if (firstIntegerToNumber && secondIntegerToNumber)
            {
                RaisingAnIntegerToAnInteger(integerOne, integerTwo);
            }
            Console.WriteLine("Enter the date when you were born:");
            DateTime myBirthDate = DateTime.Parse(Console.ReadLine());
            AgeCalculator(myBirthDate);
            Console.ReadLine();
            Console.ReadLine();
        }
        #region TASK 00
        public static void Substring()
        {
            string stringText = "Hello from SEDC Codecademy v7.0";
            Console.WriteLine("Please enter a number:");
            bool userInputToNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (userInputToNumber && userInput > 0)
            {
               string substringedText =  stringText.Substring(0, userInput);
                Console.WriteLine(substringedText);
            }else
                Console.WriteLine("Enter a number bigger than 0");
        }
        #endregion
        #region TASK I
        public static void IsAPalindome(string isAPalindromeInput)
        {
            char[] arrayFromInput = isAPalindromeInput.ToCharArray();
            if (isAPalindromeInput.SequenceEqual(arrayFromInput.Reverse()))
                Console.WriteLine("The word is a Palindrome");
            else
                Console.WriteLine("The word is not a palindrome");
        }
        #endregion
        #region TASK II
        public static int BiggestNumberInAnArray(int[] arrayWithNumbers)
        {
            int biggestNumber = arrayWithNumbers[0];
            for (int i = 0; i < arrayWithNumbers.Length; i++)
            {
                if (biggestNumber < arrayWithNumbers[i])
                {
                    biggestNumber = arrayWithNumbers[i];
                }
            }
            Console.WriteLine($"The biggest number in this array is: {biggestNumber}");
            return biggestNumber;
        }
        #endregion
        #region TASK III
        public static int NumberOfVowels(string text)
        {
            int vowelsNumber = 0;
            foreach (char vowel in text)
            {
                if ("aeiou".Contains(vowel))
                {
                    vowelsNumber++;
                }
            }
            Console.WriteLine($"The number of vowels in this text is: {vowelsNumber}");
            return vowelsNumber;
        }
        public static int NumberOfDigits(string text)
        {
            int digitsNumber = 0;
            foreach (char digit in text)
            {
                if (Char.IsDigit(digit))
                {
                    digitsNumber++;
                }
            }
            Console.WriteLine($"The number of digits in this text is: {digitsNumber}");
            return digitsNumber;
        }
        #endregion
        #region TASK IV

        public static void LetterReplacing(string sentenceInput)
        {
            char[] charArray = sentenceInput.ToCharArray();
            for (int i = 0; i < sentenceInput.Length; i++)
            {
                char character = charArray[i];
                if (Char.IsUpper(character))
                {
                    Console.Write($"{Char.ToLower(character)}");
                }
                else
                {
                    Console.Write($"{Char.ToUpper(character)}");
                }
            }

        }

        #endregion
        #region TASK V
        public static void IsACharacterAlphabetical(char characterInput)
        {
            if (Char.IsLetter(characterInput))
            {
                if (Char.IsUpper(characterInput))
                    Console.WriteLine($"The character {characterInput} is alphabetical and is uppercase.");
                else
                    Console.WriteLine($"The character {characterInput} is alphabetical and is lowercase.");
            }
            else
                Console.WriteLine($"The character {characterInput} is not an alphabetical character");
        }
            #endregion
        #region TASK VI
           public static int SubstringInAStringCounter()
            {
                string givenString = "Oh girl, you are so beautiful girl, girl, girl";
                string userInput = Console.ReadLine();
                int numberOfTimes = 0;
           // I DON'T KNOW, IF YOU HAVE FREE TIME, YOU CAN HELP ME FIND A SOLUTION !
            Console.WriteLine(numberOfTimes);
                return numberOfTimes;
            }
        #endregion
        #region TASK VII
        public static double RaisingAnIntegerToAnInteger(int integerOne, int integerTwo)
        {
          double resultOfRaising =  Math.Pow(integerOne, integerTwo);
            Console.WriteLine($"The result of raising {integerOne}, to {integerTwo} is: {resultOfRaising}");
            return resultOfRaising;
        }
        #endregion
        #region TASK VIII - BONUS
        public static void AgeCalculator(DateTime myBirthDate)
        {
            DateTime todayDate = DateTime.Today;
            int myAge = todayDate.Year - myBirthDate.Year;
            Console.WriteLine($"You have {myAge} ages.");
        }
        #endregion
    }
}


