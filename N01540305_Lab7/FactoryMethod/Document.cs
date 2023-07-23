using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.FactoryMethod
{
    public abstract class Document { 
    
        private List<Page> _pages = new List<Page>();

        public Document() 
        {
            this.addPages();
        }

        public List<Page> getPages() {  return _pages; }

        public abstract void addPages();
    }
}
