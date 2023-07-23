using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.AbstractFactory
{
    public class Client
    {
        private Furniture f;
        private Bedding b;
        public Client(Store factory)
        {
            f = factory.createFurniture();
            b = factory.createBedding();
        }

        public Furniture getFurniture()
        {
            return f;
        }

        public Bedding getBedding() {
            return b;
        }
    }
}
