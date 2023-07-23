using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_N01540305
{
    internal class Course
    {
        public string courseName { get; set; }
        public int Score { get; set; }

        public Course(string courseName, int score) 
        {
            this.courseName = courseName;
            this.Score = score;
        }

        //public string getCourseName()
        //{
        //    return this.courseName;
        //}
        //public int getScore()
        //{
        //    return this.Score;
        //}
        //public void setScore(int score)
        //{
        //    this.Score = score;
        //}
        //public void setCourseName(string courseName)
        //{
        //    this.courseName = courseName;
        //}

        public override bool Equals(object obj)
        {
            Course p = obj as Course;
            if (p.courseName == this.courseName && p.Score == this.Score)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
