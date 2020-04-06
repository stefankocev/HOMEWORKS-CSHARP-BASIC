using SEDC.Homework05.Task02.Business.Services;
using System;

namespace SEDC.Homework05.Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver bob = new Driver("Bob", 6);
            Driver greg = new Driver("Greg", 9);
            Driver jill = new Driver("Jill", 10);
            Driver anne = new Driver("Anne", 4);
            Driver[] drivers = new Driver[] { bob, greg, jill, anne };
            Car hyundai = new Car("Hyundai", 100);
            Car mazda = new Car("Mazda", 120);
            Car ferrari = new Car("Ferrari", 160);
            Car porsche = new Car("Porsche", 220);
            Car[] cars = new Car[] { hyundai, mazda, ferrari, porsche };

            Console.WriteLine("Choose a car no.1:");
            string firstCarModel = Console.ReadLine();
            int firstCarSpeed = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (firstCarModel == cars[i].Model)
                {
                    firstCarModel = cars[i].Model;
                    firstCarSpeed = cars[i].Speed;
               
                }
            }
         
            Console.WriteLine("Choose driver:");
            string firstDriverName = Console.ReadLine();
            int firstDriverSkill = 0;
            for (int i = 0; i < drivers.Length; i++)
            {
                if (firstDriverName == drivers[i].Name)
                {
                    firstDriverName = drivers[i].Name;
                    firstDriverSkill = drivers[i].Skill;
                }
            }


            Driver driverOne = new Driver(firstDriverName, firstDriverSkill);
            Car carOne = new Car(firstCarModel, firstCarSpeed);
            carOne.Driver = driverOne;


            Console.WriteLine("Choose a car no.2:");
            string secondCarModel = Console.ReadLine();
            int secondCarSpeed = 0;
            for (int i = 0; i < cars.Length; i++)
            {
                if (secondCarModel == cars[i].Model)
                {
                    secondCarModel = cars[i].Model;
                    secondCarSpeed = cars[i].Speed;
                }
            }

            Console.WriteLine("Choose driver:");
            string secondDriverName = Console.ReadLine();
            int secondDriverSkill = 0;
            for (int i = 0; i < drivers.Length; i++)
            {
                if (secondDriverName == drivers[i].Name)
                {
                    secondDriverName = drivers[i].Name;
                    secondDriverSkill = drivers[i].Skill;
                }
            }

            Driver driverTwo = new Driver(secondDriverName, secondDriverSkill);
            Car carTwo = new Car(secondCarModel, secondCarSpeed);
            carTwo.Driver = driverTwo;

            var raceMethod = new RaceMethods();
            raceMethod.RaceCars(carOne, carTwo);
            Console.ReadLine();
        }
    }
}

