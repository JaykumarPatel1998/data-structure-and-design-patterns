﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.AbstractFactory
{
    public abstract class Store
    {
        public abstract Furniture createFurniture();
        public abstract Bedding createBedding();
    }
}
