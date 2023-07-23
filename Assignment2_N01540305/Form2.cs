using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_N01540305
{
    public partial class Form2 : Form
    {
        LinkedList<Course> courseList;
        string emptyFieldError = "The fields cannot be empty!";
        string emptyCollection = "The collection is empty!";
        public Form2()
        {
            InitializeComponent();
            courseList = new LinkedList<Course>();
        }

        private void btn_addLast_Click(object sender, EventArgs e)
        {
            lbl_errorLinkedList.Text = String.Empty;
            if (txt_courseName.Text.Equals(String.Empty) || txt_courseScore.Text.Equals(String.Empty))
            {
                lbl_errorLinkedList.Text = emptyFieldError;
            }
            else
            {
                Course c1 = new Course(txt_courseName.Text,
                Int32.Parse(txt_courseScore.Text));
                courseList.AddLast(c1);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (courseList.Count != 0)
            {
                Course c1 = new Course(txt_courseName.Text,
                Int32.Parse(txt_courseScore.Text));
                bool c = courseList.Remove(c1);
                lbx_linkedList.Items.Clear();
                if (c == true)
                {
                    lbx_linkedList.Items.Add(
                        "Remove successful"
                        );
                }
                else
                {
                    lbx_linkedList.Items.Add(
                       "Remove not successful"
                       );
                }
            }
            else
            {

            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbx_linkedList.Items.Clear();
            lbl_errorLinkedList.Text = String.Empty;
            if (courseList.Count != 0)
            {
                foreach (Course c in courseList)
                {
                    lbx_linkedList.Items.Add(
                        c.courseName.ToString() + "-" + c.Score.ToString()
                        );

                }
            }
            else
            {
                lbl_errorLinkedList.Text = emptyCollection;
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Course c1 = new Course(txt_courseName.Text,
                Int32.Parse(txt_courseScore.Text));
            var c = courseList.Find(c1);
            lbx_linkedList.Items.Clear();
            lbx_linkedList.Items.Add(
                    c.Value.courseName.ToString() + "-" + c.Value.Score.ToString()
                    );
        }

        private void btn_addFirst_Click(object sender, EventArgs e)
        {
            lbl_errorLinkedList.Text = String.Empty;
            if (txt_courseName.Text.Equals(String.Empty) || txt_courseScore.Text.Equals(String.Empty))
            {
                lbl_errorLinkedList.Text = emptyFieldError;
            }
            else
            {
                Course c1 = new Course(txt_courseName.Text,
                Int32.Parse(txt_courseScore.Text));
                courseList.AddFirst(c1);
            }
        }

        private void btn_remove_first_Click(object sender, EventArgs e)
        {
            if (courseList.Count != 0)
            {
                courseList.RemoveFirst();
            }
            else
            {
                lbl_errorLinkedList.Text = emptyCollection;
            }
        }

        private void btn_remove_last_Click(object sender, EventArgs e)
        {
            if (courseList.Count != 0)
            {
                courseList.RemoveLast();
            }
            else
            {
                lbl_errorLinkedList.Text = emptyCollection;
            }
        }

        private void btn_ToForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
