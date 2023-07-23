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
    public partial class Form1 : Form
    {
        Stack<Course> coursesStack = new Stack<Course>();
        Queue<Course> courseQueue = new Queue<Course>();
        string emptyFieldError = "The fields cannot be empty!";
        string emptyCollection = "The collection is empty!";
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_stack_push_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (txt_stack_course.Text.Equals(String.Empty) || txt_stack_score.Text.Equals(String.Empty))
            {
                lbl_error.Text = emptyFieldError;
            }
            else
            {
                Course c = new Course(txt_stack_course.Text, Int32.Parse(txt_stack_score.Text));
                coursesStack.Push(c);
            }
        }

        private void btn_stack_pop_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (coursesStack.Count != 0)
            {
                coursesStack.Pop(); 
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_stack_display_Click(object sender, EventArgs e)
        {
            lbx_stack.Items.Clear();
            lbl_error.Text = String.Empty;
            if (coursesStack.Count != 0)
            {
                foreach (Course c in coursesStack)
                {
                    lbx_stack.Items.Add(c.courseName + "-" + c.Score);
                }
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_queue_enqueue_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (txt_queue_course.Text.Equals(String.Empty) || txt_queue_score.Text.Equals(String.Empty))
            {
                lbl_error.Text = emptyFieldError;
            }
            else
            {
                Course c = new Course(txt_queue_course.Text, Int32.Parse(txt_queue_score.Text));
                courseQueue.Enqueue(c);
            }
        }

        private void btn_queue_dequeue_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (courseQueue.Count != 0)
            {
                courseQueue.Dequeue();
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_queue_display_Click(object sender, EventArgs e)
        {
            lbx_queue.Items.Clear();
            lbl_error.Text = String.Empty;
            if (courseQueue.Count != 0)
            {
                foreach (Course c in courseQueue)
                {
                    lbx_queue.Items.Add(c.courseName + "-" + c.Score);
                }
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_peek_stck_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (coursesStack.Count != 0)
            {
                Course c = coursesStack.Peek();
                lbx_stack.Items.Add(c.courseName + "-" + c.Score);
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_peek_queue_Click(object sender, EventArgs e)
        {
            lbl_error.Text = String.Empty;
            if (courseQueue.Count != 0)
            {
                Course c = courseQueue.Peek();
                lbx_queue.Items.Add(c.courseName + "-" + c.Score);
            }
            else
            {
                lbl_error.Text = emptyCollection;
            }
        }

        private void btn_ToForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
