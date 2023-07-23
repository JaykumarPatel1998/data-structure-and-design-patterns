using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01540305_Lab1
{
    public partial class Form1 : Form

    {
        ArrayList aList = new ArrayList();
        List<String> list = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            aList.Add(txt_arraylist.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            aList.Remove(txt_arraylist.Text);
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            foreach (Object obj in aList)
            {
                lbx_arraylist.Items.Add(obj.ToString());
            }
        }

        private void btn_addList_Click(object sender, EventArgs e)
        {
            list.Add(txt_list.Text);
        }

        private void btn_ListRemove_Click(object sender, EventArgs e)
        {
            list.Remove(txt_list.Text);
        }

        private void btn_ListDisplay_Click(object sender, EventArgs e)
        {
            foreach (Object obj in list)
            {
                lbx_list.Items.Add(obj.ToString());
            }
        }
    }
}
