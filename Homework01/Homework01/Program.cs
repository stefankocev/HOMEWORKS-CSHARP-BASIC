using System;
using System.Threading;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Light...");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red Light - Stop!");
            Console.WriteLine("");
            Thread.Sleep(9000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow Light - Prepare...");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green Light - GO!");
            Console.WriteLine("");
            Thread.Sleep(6000);
            Console.ResetColor();

        }
    }
}
