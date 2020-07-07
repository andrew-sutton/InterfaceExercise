using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public Car(string type, string company, bool compact, string engine)
        {
            NumWheels = 4;
            CarType = type;
            Logo = company;
            IsCompact = compact;
            EngineType = engine;
        }
        public string CarType { get; set; }
        public bool IsCompact { get; set; }
        public string Logo { get; set; }
        public int NumWheels { get; set; }
        public string EngineType { get; set; }


        public void Drive()
        {
            Console.WriteLine("The Car drives");
        }

        public void MakeMoney()
        {
            Console.WriteLine("The Car just got sold");
        }

        public void Reverse()
        {
            Console.WriteLine("The Car is in reverse");
        }
    }
}
