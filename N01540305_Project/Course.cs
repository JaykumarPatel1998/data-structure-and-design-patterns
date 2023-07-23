using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Project
{
    public class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Department { get; set; }
        public int CreditHours { get; set; }
        public string Description { get; set; }
        public Faculty AssignedFaculty { get; set; }

        public Course(string courseName, string courseCode, string department, string creditHours, string description)
        {
            CourseName = courseName;
            CourseCode = courseCode;
            Department = department;
            CreditHours = Int32.Parse(creditHours);
            Description = description;
        }

        public override string ToString()
        {
            return "Course{" + this.CourseCode + " - " + this.CourseName + "}";
        }

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   CourseName == course.CourseName &&
                   CourseCode == course.CourseCode &&
                   Department == course.Department &&
                   CreditHours == course.CreditHours &&
                   Description == course.Description;
        }
    }
}
