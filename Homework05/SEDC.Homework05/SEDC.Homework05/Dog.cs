using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework05
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }
        public string Eat()
        {
            return $"The dog {Name} is now eating.";
        }
        public string Play()
        {
            return $"The dog {Name} is now playing.";
        }
        public string ChaseTail()
        {
            return $"The dog {Name} is now chasing its tail.";
        }
    }
}
