using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.FactoryMethod
{
    public class EBook : Document
    {
        public override void addPages()
        {
            getPages().Add(new TitlePage());
            getPages().Add(new DescriptionPage());
            getPages().Add(new CreditsPage());
        }
    }
}
