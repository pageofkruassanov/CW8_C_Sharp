using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW8_C_Sharp.Properties
{
    internal class Car : IVehicle, IDriveable
    {
        private string _model;

        private int _side;

        public int GetSide()
        { 
            return _side; 
        }


        public Car(string model)
        {
            _model = model;
        }
        public override int Speed { get; set; }

        public override double FuelLevel { get; set; }

        public override void Start()
        {
            Console.WriteLine($"{_model} начинает движение");
        }

        public override void Stop()
        {
            Console.WriteLine($"{_model} заканчивает движение");
        }

        public void Accelerate(int speed)
        {
            Speed += speed;
        }
        public void Brake(int speed)
        {
            Speed -= speed;
        }
        public void Turn(int side)
        {
            _side = side;
        }

    }
}
