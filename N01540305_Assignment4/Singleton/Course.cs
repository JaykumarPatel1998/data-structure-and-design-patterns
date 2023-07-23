using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Assignment4.Singleton
{
    public sealed class Course
    {
        private static Course _course;
        private Course() { }
        public static Course GetCourse()
        {
            if (_course == null)
            {
                _course = new Course();

            }
            return _course;
        }
    }
}
