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
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_stack_push_Click(object sender, EventArgs e)
        {
            Course c = new Course(txt_stack_course.Text, Int32.Parse(txt_stack_score.Text));
            coursesStack.Push(c);
        }

        private void btn_stack_pop_Click(object sender, EventArgs e)
        {
            coursesStack.Pop();
        }

        private void btn_stack_display_Click(object sender, EventArgs e)
        {
            foreach(Course c in coursesStack)
            {
                lbx_stack.Items.Add(c.courseName + "-" + c.Score);
            }
        }

        private void btn_queue_enqueue_Click(object sender, EventArgs e)
        {
            Course c = new Course(txt_queue_course.Text, Int32.Parse(txt_queue_score.Text));
            courseQueue.Enqueue(c);
        }

        private void btn_queue_dequeue_Click(object sender, EventArgs e)
        {
            courseQueue.Dequeue();
        }
        private void btn_queue_display_Click(object sender, EventArgs e)
        {
            foreach(Course c in courseQueue)
            {
                lbx_queue.Items.Add(c.courseName + "-" + c.Score);
            }
        }
    }
}
