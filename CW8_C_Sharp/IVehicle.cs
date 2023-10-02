using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CW8_C_Sharp
{
    //  абстрактный класс, который будет содержать общие методы и свойства для всех типов автомобилей
    internal abstract class IVehicle
    {
        public abstract void Start();
        public abstract void Stop();
        public abstract int Speed { get; set; }
        public abstract double FuelLevel { get; set; }
    }
}
