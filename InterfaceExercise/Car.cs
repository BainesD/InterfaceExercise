using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public double FuelEconomy { get; set; }
        public double NumberOfDoors { get; set; }
        public int NumberOfWheels { get ; set ; }
        public string Color { get ; set ; }
        public double Mileage { get ; set ; }
        public double Year { get ; set ; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
        public string Model { get ; set ; }
        public void ListCarProperties()
        {
            Console.WriteLine("This Car has the following properties.");
            Console.WriteLine($"Make: {this.Name}\nModel: {this.Model}\nYear: {this.Year}\nColor: {this.Color}\nMileage: {this.Mileage}\n" +
                $"This {this.Model} is a {this.NumberOfDoors} door, {this.NumberOfWheels} wheeled car. It has a fuel economy of {this.FuelEconomy} mpg. {this.Name}'s have the following logo:\n{this.Logo}");
            Console.WriteLine("--------------------------");
        }
    }
}
