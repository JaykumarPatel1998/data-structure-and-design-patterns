﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.FactoryMethod
{
    public class SalesReport: Document
    {
        public override void addPages()
        {
            getPages().Add(new IntroductionPage());
            getPages().Add(new ResultsPage());
            getPages().Add(new ConclusionPage());
        }
    }
}