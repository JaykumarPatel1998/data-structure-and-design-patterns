using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Lab4
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public Course(string id, string name, string Score) { 
            this.Id = Int32.Parse(id);
            this.Name = name;
            this.Score = Int32.Parse(Score);    
        }
    }
}
