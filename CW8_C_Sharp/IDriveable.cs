using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW8_C_Sharp
{
    // интерфейс, который предоставляет методы для управления движением автомобиля
    internal interface IDriveable
    {
        void Accelerate(int speed);
        void Brake(int speed);
        void Turn(int side);
    }
}
