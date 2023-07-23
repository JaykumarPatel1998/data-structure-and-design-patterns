using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.AbsractFactory
{
    public class Truck : FourWheelVehicle
    {
        public override void Compare(TwoWheelVehicle t)
        {
            Console.WriteLine("Comparing " + this.GetType().Name + " with " + t.GetType().Name);
        }
    }
}
