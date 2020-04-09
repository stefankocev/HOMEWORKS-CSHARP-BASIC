using SEDC.Homework07.Enumeration;
using SEDC.Homework07.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homework07.Business.Models
{
   public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public ElectricCar(string brand, string model, int doors, int topSpeed, Consumption consumption, int batteryCapacity, int batteryUsage)
            :base(brand, model, doors, topSpeed, consumption, EngineType.Electric)
        {
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }
        public void Recharge(int minutes)
        {
           int lastDigitOfMinutes = minutes % 10;
           int minutesRounded =  minutes - lastDigitOfMinutes;
           int minutesForChargingLeft = (BatteryCapacity - BatteryUsage) * 10;
            if(minutesForChargingLeft < minutes)
                Console.WriteLine($"Can't charge longer than {minutesForChargingLeft} minutes");
            else
            {
                while (minutesRounded > 0 && BatteryUsage < 100)
                {
                    BatteryUsage++;
                    minutesRounded -= 10;
                }
                Console.WriteLine($"Your car has been charged to {BatteryUsage}%");
            }
        }
       
    }
}
