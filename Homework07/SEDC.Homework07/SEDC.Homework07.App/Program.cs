using SEDC.Homework07.Business.Models;
using SEDC.Homework07.Enumeration;
using System;

namespace SEDC.Homework07.App
{
    class Program
    {
        static void Main(string[] args)
        { 

            ElectricCar firstECar = new ElectricCar("Tesla", "X", 5, 220, Consumption.Economic, 100, 35);
            FuelCar firstFCar = new FuelCar("Bugatti", "Veyron", 3, 300, Consumption.High, EngineType.Diesel, 60, 12);
            //firstECar.Recharge(572);
            //firstECar.Recharge(5000);
            //firstFCar.Refuel(45);
            //firstFCar.Refuel(50);

            Console.ReadLine();
        }
    }
}
