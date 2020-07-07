using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public Truck(string company, string engine, double bedSize)
        {
            NumWheels = 4;
            EngineType = engine;
            Logo = company;
            BedSize = bedSize;
        }
        public int NumWheels { get; set; }
        public string EngineType { get; set; }
        public string Logo { get; set; }
        public double BedSize { get; set; }

        public void Drive()
        {
            Console.WriteLine("The truck is in drive");
        }

        public void MakeMoney()
        {
            Console.WriteLine("The truck was sold");
        }

        public void Reverse()
        {
            Console.WriteLine("The truck is in reverse");
        }
        
        public void HaulTrailer()
        {
            Console.WriteLine("The truck is hauling a trailer");
        }
    }
}
