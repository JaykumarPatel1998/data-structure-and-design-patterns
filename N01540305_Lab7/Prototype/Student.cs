using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab7.Prototype
{
    public class Student : MemberPrototype
    {
        public string Name { get; set; }
        public string description { get; set; }
        public override MemberPrototype getClone()
        {
            return this.MemberwiseClone() as MemberPrototype;
        }
    }
}
