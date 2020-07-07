using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public SUV(string company, string engine, double cargo)
        {
            NumWheels = 4;
            EngineType = engine;
            Logo = company;
            CargoHoldSize = cargo;
        }
        public string Logo { get; set; }
        public int NumWheels { get; set; }
        public string EngineType { get; set; }
        public double CargoHoldSize { get; set; }

        public void Drive()
        {
            Console.WriteLine("The SUV is in drive");
        }

        public void MakeMoney()
        {
            Console.WriteLine("The SUV was sold");
        }

        public void Reverse()
        {
            Console.WriteLine("The SUV is in reverse");
        }
        public void GoOffroad()
        {
            Console.WriteLine("The SUV is now offroad");
        }
    }
}
