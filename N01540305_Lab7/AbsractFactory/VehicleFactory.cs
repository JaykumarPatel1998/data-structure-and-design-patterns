using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.AbsractFactory
{
    public abstract class VehicleFactory
    {
        public abstract TwoWheelVehicle createTwoWheelVehicle();
        public abstract FourWheelVehicle createFourWheelVehicle();
    }
}
