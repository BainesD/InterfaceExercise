using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle,ICompany
    {
        public double BedArea { get; set; }
        public double PayloadCapacity { get; set; }
        public int NumberOfWheels { get ; set ; }
        public string Color { get ; set ; }
        public double Mileage { get ; set ; }
        public double Year { get ; set ; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
        public string Model { get ; set ; }
        public void ListTruckProperties()
        {
            Console.WriteLine("This Truck has the following properties.");
            Console.WriteLine($"Make: {this.Name}\nModel: {this.Model}\nYear: {this.Year}\nColor: {this.Color}\nMileage: {this.Mileage}\n" +
                $"This {this.Model} is a {this.NumberOfWheels} wheeled truck. It has a paylod capacity of {this.PayloadCapacity} lbs and a bed area of {this.BedArea} inches squared. {this.Name}'s have the following logo:\n{this.Logo}");
            Console.WriteLine("--------------------------");
        }
    }
}
