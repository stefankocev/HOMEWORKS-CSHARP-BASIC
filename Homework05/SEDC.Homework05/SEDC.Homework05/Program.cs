using System;

namespace SEDC.Homework05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name, dog's race and dog's color(click enter everytime you write any of the properties):");
            Dog dog = new Dog(Console.ReadLine().ToUpper(), Console.ReadLine(), Console.ReadLine());
            Console.WriteLine("What is dog doing?(eat, play, chase tail)");
            string dogIs = Console.ReadLine().ToLower();
            if(dogIs == "eat")
                Console.WriteLine(dog.Eat());
            else if(dogIs == "play")
                Console.WriteLine(dog.Play());
            else if(dogIs == "chase tail")
                Console.WriteLine(dog.ChaseTail());
            else
                Console.WriteLine("Please enter one of the following(eat,play,case tail)");
            Console.ReadLine();
        }
    }
}
