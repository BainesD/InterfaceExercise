using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }
        public double Year { get; set; }
        public string Model { get; set; }


    }
}
