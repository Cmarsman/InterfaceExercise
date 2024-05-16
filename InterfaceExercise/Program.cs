using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "Corolla";
            carOne.Year = 2016;
            carOne.WheelCount = 4;
            carOne.CoName = "Toyota Inc";
            carOne.Logo = "Toyota Logo";
            carOne.HasTrunk = true;
            carOne.TrunkSpace = 50;

            var truckOne = new Truck()
            {
                Make = "Toyota",
                Model = "Tacoma",
                Year = 1985,
                WheelCount = 4,
                CoName = "Toyota Inc",
                Logo = "Toyota Log",
                TruckBedSpace = 20, 
                HasTruckBed = true
            };

            var suvOne = new SUV();
            suvOne.Make = "Lamborghini";
            suvOne.Model = "Urus";
            suvOne.Year = 2024;
            suvOne.WheelCount= 4;
            suvOne.CoName = "Lamborghini";
            suvOne.Logo = "Lamborghini Logo";
            suvOne.RowSeating = 2;
            suvOne.CargoHoldSpace = 40;

            var parkingLot = new List<IVehicle>() { carOne, truckOne, suvOne };

            foreach (var vehicle in parkingLot) 
            {
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model}, made in the year {vehicle.Year}.\nWheels: {vehicle.WheelCount}\n");
            }
           
        }
    }
}
