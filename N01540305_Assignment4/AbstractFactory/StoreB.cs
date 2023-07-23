using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.AbstractFactory
{
    public class StoreB : Store
    {
        public override Bedding createBedding()
        {
            return new Pillow();
        }

        public override Furniture createFurniture()
        {
            return new Chair();
        }
    }
}
