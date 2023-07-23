using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.AbsractFactory
{
    public class VehicleFactoryA : VehicleFactory
    {
        public override FourWheelVehicle createFourWheelVehicle()
        {
            return new Truck();
        }

        public override TwoWheelVehicle createTwoWheelVehicle()
        {
            return new Bicycle();
        }
    }
}
