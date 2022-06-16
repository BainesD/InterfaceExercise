using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces 

            //Create 2 Interfaces called IVehicle & ICompany X

            //Create 3 classes called Car , Truck , & SUV X

            //In your IVehicle X

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany X

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes 

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car jetta = new Car() { Color = "Black", FuelEconomy = 30, Logo = "VW", Mileage = 130011, Name = "Volkswagen", NumberOfDoors = 4, NumberOfWheels = 4, Year = 2011, Model = "Jetta" };
            Truck ranger = new Truck() { Year = 1996, Color = "Gold", Logo = "Blue Oval with Script 'Ford'", Mileage = 250531, Name = "Ford", Model = "Ranger", BedArea = 54.3, NumberOfWheels = 4, PayloadCapacity = 1300 };
            SUV forester = new SUV() { NumberOfWheels = 4, Model = "Forester", Name = "Subaru", CargoSpace = 69.2, Color = "Green", HasFourWheelDrive = true, Logo ="Blue oval enclosed in a silver oval with one large and five small stars", Mileage = 2985, Year = 2021 };
            jetta.ListCarProperties();
            ranger.ListTruckProperties();
            forester.ListSUVProperties();
        }
    }
}
