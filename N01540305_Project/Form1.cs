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
    public partial class Form1 : Form
    {
        public List<Course> courses;
        public List<Faculty> faculties;
        public string EMPTY_STRING = string.Empty;
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            courses = new List<Course>();
            faculties = new List<Faculty>();

            if (form2 == null)
            {
                form2 = new Form2(this, faculties, courses);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            faculties.Clear();
        }

        private void btn_add_faculty_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            if (isStringBlank(txt_faculty_id.Text) || isStringBlank(txt_faculty_name.Text) || isStringBlank(txt_faculty_email.Text) || isStringBlank(txt_faculty_department.Text) || isStringBlank(txt_phone_number.Text))
            {
                err_label.Text = "Missing field values !!";
            }
            else
            {
                foreach (Faculty faculty in faculties)
                {
                    if (txt_faculty_id.Text == faculty.FacultyID)
                    {
                        err_label.Text = "Faculty record already exist for the enetered faculty id !!";
                        return;
                    }
                }
                Faculty f = new Faculty(txt_faculty_id.Text, txt_faculty_name.Text, txt_faculty_email.Text, txt_faculty_department.Text, txt_phone_number.Text);
                faculties.Add(f);
            }
        }

        private void btn_remove_faculty_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            bool faculty_detected = false;
            foreach (Faculty faculty in faculties)
            {
                if (faculty.FacultyID ==  txt_faculty_id.Text)
                {
                    faculty_detected = true;
                    faculties.Remove(faculty);
                    break;
                }
            }
            if (!faculty_detected)
            {
                err_label.Text = "Faculty does not exist for entered faculty id!!";
            }
        }

        private bool isStringBlank(string str)
        {
            if (str == null) return true;
            if (str.Length == 0) return true;
            if (str == EMPTY_STRING) return true;
            return false;
        }

        private void btn_display_faculty_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            lbx_faculty.Items.Clear();
            if (faculties.Count == 0)
            {
                err_label.Text = "faculty list is empty !!";
            }
            else
            {
                foreach (Faculty faculty in faculties)
                {
                    lbx_faculty.Items.Add(faculty);
                }
            }
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            if (isStringBlank(txt_course_name.Text) || isStringBlank(txt_course_code.Text) || isStringBlank(txt_course_department.Text) || isStringBlank(txt_credit_hours.Text) || isStringBlank(txt_course_description.Text))
            {
                err_label.Text = "Missing field values !!";
            }
            else
            {
                foreach (Course course in courses)
                {
                    if (txt_course_name.Text == course.CourseName)
                    {
                        err_label.Text = "Course record already exist for the enetered course name !!";
                        return;
                    }
                }
                Course c = new Course(txt_course_name.Text, txt_course_code.Text, txt_course_department.Text, txt_credit_hours.Text, txt_course_description.Text);
                courses.Add(c);
            }
        }

        private void btn_remove_course_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            bool course_detected = false;
            foreach (Course course in courses)
            {
                if (course.CourseName == txt_course_name.Text)
                {
                    course_detected = true;
                    courses.Remove(course);
                    break;
                }
            }
            if (!course_detected)
            {
                err_label.Text = "Course does not exist for entered course id!!";
            }
        }

        private void btn_clear_course_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            courses.Clear();
        }

        private void btn_display_course_Click(object sender, EventArgs e)
        {
            err_label.Text = EMPTY_STRING;
            lbx_course.Items.Clear();
            if (courses.Count == 0)
            {
                err_label.Text = "course list is empty !!";
            }
            else
            {
                foreach (Course course in courses)
                {
                    lbx_course.Items.Add(course);
                }
            }
        }

        private void btn_toForm2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }
    }
}
