using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01540305_Project
{
    public partial class Form2 : Form
    {
        Form1 f1;
        List<Faculty> faculties;
        List<Course> courses;
        public string EMPTY_STRING = string.Empty;
        public Form2(Form1 form1, List<Faculty> facultyList, List<Course> courseList)
        {
            InitializeComponent();
            this.f1 = form1;
            this.faculties = facultyList;
            this.courses = courseList;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //added due to mis-click please ignore
        }


        private void btn_toForm1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        //assign button logic
        private void button1_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            if (isStringBlank(txt_faculty_id.Text) || isStringBlank(txt_course_name.Text))
            {
                err_label.Text = "Missing field values !!";
            }
            else
            {
                Faculty assigned_faculty = null;
                Course assigned_course = null;
                bool foundCourse = false;
                bool foundFaculty = false;

                foreach (Faculty faculty in faculties)
                {
                    if (txt_faculty_id.Text == faculty.FacultyID)
                    {
                        assigned_faculty = faculty;
                        foundFaculty = true;
                    }
                }

                foreach (Course course in courses)
                {
                    if (txt_course_name.Text == course.CourseName)
                    {
                        assigned_course = course;
                        foundCourse = true;
                    }
                }

                if (foundCourse && foundFaculty)
                {
                    assigned_course.AssignedFaculty = assigned_faculty;
                    err_label.Text = "Assigned successfully";
                }
                else
                {
                    err_label.Text = "Invalid values entered for faculty and/or courses !!";
                }
                
            }
        }

        //unassign button logic
        private void button2_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            if (isStringBlank(txt_faculty_id.Text) || isStringBlank(txt_course_name.Text))
            {
                err_label.Text = "Missing field values !!";
            }
            else
            {
                Faculty assigned_faculty = null;
                Course assigned_course = null;
                bool foundCourse = false;
                bool foundFaculty = false;

                foreach (Faculty faculty in faculties)
                {
                    if (txt_faculty_id.Text == faculty.FacultyID)
                    {
                        assigned_faculty = faculty;
                        foundFaculty = true;
                    }
                }

                foreach (Course course in courses)
                {
                    if (txt_course_name.Text == course.CourseName)
                    {
                        assigned_course = course;
                        foundCourse = true;
                    }
                }

                if (foundCourse && foundFaculty)
                {
                    assigned_course.AssignedFaculty = null;
                    err_label.Text = "Unassigned successfully";
                }
                else
                {
                    err_label.Text = "Invalid values entered for faculty and/or courses !!";
                }

            }
        }

        private bool isStringBlank(string str)
        {
            if (str == null) return true;
            if (str.Length == 0) return true;
            if (str == EMPTY_STRING) return true;
            return false;
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbx_relationship.Items.Clear();
            foreach (Course course in courses)
            {
                lbx_relationship.Items.Add(course.CourseName + " - " + course.AssignedFaculty);
            }
        }
    }
}
