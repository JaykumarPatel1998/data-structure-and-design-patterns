using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01540305_Lab4
{
    public partial class Form2 : Form
    {
        Form1 f1;
        private HashSet<string> hset1;
        private HashSet<string> hset2;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.f1 = form1;
            hset1 = new HashSet<string>();
            hset2 = new HashSet<string>();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            hset1.Add(txt_input.Text);
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            hset2.Add(txt_input.Text);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            hset1.Remove(txt_input.Text);
        }

        private void btn_remove2_Click(object sender, EventArgs e)
        {
            hset2.Remove(txt_input.Text);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            hset1.Clear();
            hset2.Clear();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbx_set1.Items.Clear();
            lbx_set2.Items.Clear();
            foreach (string s in hset1)
            {
                lbx_set1.Items.Add(s);
            }
            foreach (string s in hset2)
            {
                lbx_set2.Items.Add(s);
            }
        }

        private void btn_intersection_Click(object sender, EventArgs e)
        {
            hset1.IntersectWith(hset2);
        }

        private void btn_union_Click(object sender, EventArgs e)
        {
            hset1.UnionWith(hset2);
        }

        private void btn_subset_Click(object sender, EventArgs e)
        {
            lbl_result.Text = hset1.IsSubsetOf(hset2).ToString();
        }

        private void btn_superset_Click(object sender, EventArgs e)
        {
            lbl_result.Text = hset1.IsSupersetOf(hset2).ToString();
        }

        private void btn_form1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
