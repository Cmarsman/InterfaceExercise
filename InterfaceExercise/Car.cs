﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public bool HasTrunk { get ; set ; }  
        public int TrunkSpace { get ; set ; }
        public int WheelCount { get; set; } 
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Logo { get; set; }
        public string CoName { get; set; }
       
    }
}
