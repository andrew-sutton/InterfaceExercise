using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumWheels { get; set; }
        public string EngineType { get; set; }
        public void Drive();
        public void Reverse();
    }
}
