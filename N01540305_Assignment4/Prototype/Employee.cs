using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.Prototype
{
    public class Employee : MemberPrototype
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public override MemberPrototype getClone()
        {
            return this.MemberwiseClone() as MemberPrototype;
        }
    }
}
