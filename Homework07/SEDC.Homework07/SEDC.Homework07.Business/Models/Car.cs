using SEDC.Homework07.Enumeration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework07.Business.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }

        public Car(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engineType)
        {
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engineType;
        }
        public string Drive(int distance, int energy, string name)
        {
            int drivingCapacity = 0;
            switch (Consumption)
            {
                case Consumption.Economic:
                    drivingCapacity = energy * 10;
                    break;
                case Consumption.Medium:
                    drivingCapacity = (energy * 10) / 2;
                    break;
                case Consumption.High:
                    drivingCapacity = (energy * 10) / 3;
                    break;
            }
            if (drivingCapacity < distance)
            {
                return $"You cannot drive more than {drivingCapacity} km. ";
            }
            else
            {
                int energyUsed = 0;
                switch (Consumption)
                {
                    case Consumption.Economic:
                        energyUsed = (1 * distance) / 10;
                        break;
                    case Consumption.Medium:
                        energyUsed = (2 * distance) / 10;
                        break;
                    case Consumption.High:
                        energyUsed = (3 * distance) / 10;
                        break;
                }
                return $"You used {energyUsed} {name}.";
            }
           
        }
        public string PrintInfo()
        {
            return $"Car Brand: {Brand}, Car Model: {Model}, Doors: {Doors}, Top Speed: {TopSpeed}, Consumption {Consumption}, Engine Type: {EngineType}";

        }
    }
}