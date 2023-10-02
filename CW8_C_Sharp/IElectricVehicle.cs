using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW8_C_Sharp
{
    internal interface IElectricVehicle
    {
        void Charge(double power);
        double GetCharge();
    }
}
