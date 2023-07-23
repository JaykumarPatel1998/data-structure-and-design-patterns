using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N01540305_Project
{
    public class Faculty
    {
        public string FacultyID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string PhoneNumber { get; set; }

        public Faculty(string facultyID, string name, string email, string department, string phoneNumber)
        {
            FacultyID = facultyID;
            Name = name;
            Email = email;
            Department = department;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "Faculty{" + this.FacultyID + " - " + this.Name + "}";
        }

        public override bool Equals(object obj)
        {
            return obj is Faculty faculty &&
                   FacultyID == faculty.FacultyID &&
                   Name == faculty.Name &&
                   Email == faculty.Email &&
                   Department == faculty.Department &&
                   PhoneNumber == faculty.PhoneNumber;
        }
    }
}
