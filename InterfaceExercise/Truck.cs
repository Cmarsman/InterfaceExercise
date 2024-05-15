using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 5.3;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Siverado";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "General Motors";
        public string Motto { get; set; } = "Like a Rock";
        public bool HasChangedGears { get; set; } = true;
        public bool HasFourWheelDrive {  get; set; } = true;
        public bool HasBedLiner { get; set; } = true;

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward..");
            }
            else 
            {
                Console.WriteLine($"{GetType().Name} now driving forward..");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing..");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }

        }
    }
}
