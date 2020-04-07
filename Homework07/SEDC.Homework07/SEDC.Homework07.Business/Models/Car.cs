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
        public double Drive(double distance)
        {
            double result = 0;
            switch (Consumption)
            {
                case Consumption.Economic:
                    result = (1 * distance) / 10;
                    break;
                case Consumption.Medium:
                    result = (2 * distance) / 10;
                    break;
                case Consumption.High:
                    result = (3 * distance) / 10;
                    break;
            }
            return result;
        }
        public string PrintInfo()
        {
            return $"Car Brand: {Brand}, Car Model: {Model}, Doors: {Doors}, Top Speed: {TopSpeed}, Consumption {Consumption}, Engine Type: {EngineType}";

        }
    }
}