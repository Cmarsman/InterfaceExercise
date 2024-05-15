using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 5.3;
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "Tahoe";
        public int SeatCount { get; set; } = 7;
        public string CompanyName { get; set; } = "General Motors";
        public string Motto { get; set; } = "Like a Rock";
        public bool HasChangedGears { get; set; }

        public bool HasSeatWarmers { get; set; } = true;
        public bool HasCaptainChairs { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward..");
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

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}

