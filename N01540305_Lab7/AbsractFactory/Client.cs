using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.AbsractFactory
{
    public class Client
    {
        private TwoWheelVehicle t;
        private FourWheelVehicle f;
        public Client(VehicleFactory factory)
        {
            f = factory.createFourWheelVehicle();
            t = factory.createTwoWheelVehicle();
        }

        public void Compare()
        {
            f.Compare(t);
        }
    }
}
