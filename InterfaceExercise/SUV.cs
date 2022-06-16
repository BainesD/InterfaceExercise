using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasFourWheelDrive { get; set; }
        public double CargoSpace { get; set; }
        public int NumberOfWheels { get ; set ; }
        public string Color { get ; set ; }
        public double Mileage { get ; set ; }
        public double Year { get ; set ; }
        public string Logo { get ; set ; }
        public string Name { get ; set ; }
        public string Model { get ; set ; }


        public void ListSUVProperties()
        {
            string yesOrNo = this.HasFourWheelDrive ? "has" : "does not have";
            Console.WriteLine("This SUV has the following properties.");
            Console.WriteLine($"Make: {this.Name}\nModel: {this.Model}\nYear: {this.Year}\nColor: {this.Color}\nMileage: {this.Mileage}\n" +
                $"It is {this.HasFourWheelDrive} that this {this.Model} has four wheel drive. This {this.Model} has a cargo space of {this.CargoSpace} feet cubed. {this.Name}'s have the following logo:\n{this.Logo}");
            Console.WriteLine("--------------------------");
        }
    }
}
