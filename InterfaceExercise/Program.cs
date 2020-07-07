using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

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
            var vehicleList = new List<IVehicle>();
            var newCar = new Car("Sedan", "Honda", true, "automatic");
            var newTruck = new Truck("Ford", "diesel", 96.5);
            var newSUV = new SUV("Jeep", "sport", 65.7);
            vehicleList.Add(newCar);
            vehicleList.Add(newSUV);
            vehicleList.Add(newTruck);
            foreach(var vehicle in vehicleList)
            {
                Console.WriteLine($"Engine Type: {vehicle.EngineType}");
                Console.WriteLine($"Number of Wheels: {vehicle.NumWheels}");
            }
            newCar.Drive();
            newTruck.HaulTrailer();
            newSUV.GoOffroad();
            newCar.MakeMoney();
        }
    }
}
