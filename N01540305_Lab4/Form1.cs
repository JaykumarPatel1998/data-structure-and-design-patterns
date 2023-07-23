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

namespace N01540305_Lab4
{
    public partial class Form1 : Form
    {
        private Hashtable ht;
        private Dictionary<int, Course> dict;
        public Form1()
        {
            InitializeComponent();
            ht = new Hashtable();
            dict = new Dictionary<int, Course>();
        }

        private void btn_AddHashTable_Click(object sender, EventArgs e)
        {
            Course c = new Course(txt_id.Text, txt_CName.Text, txt_CScore.Text);
            ht.Add(c.Id, c);
        }

        private void btn_RemoveHashTable_Click(object sender, EventArgs e)
        {
            ht.Remove(Int32.Parse(txt_id.Text));
        }

        private void lbl_DisplayHashTable_Click(object sender, EventArgs e)
        {
            lbx_display.Items.Clear();
            foreach(DictionaryEntry de in ht)
            {
                lbx_display.Items.Add(de.Key +  "-" + ((Course)de.Value).Name + "-"
                    + ((Course)de.Value).Score);
            }
        }

        private void btn_ClearHashTable_Click(object sender, EventArgs e)
        {
            ht.Clear();
        }

        private void btn_AddDict_Click(object sender, EventArgs e)
        {
            Course c = new Course(txt_id.Text, txt_CName.Text, txt_CScore.Text);
            dict.Add(c.Id, c);
        }

        private void btn_RemoveDict_Click(object sender, EventArgs e)
        {
            dict.Remove(Int32.Parse(txt_id.Text));
        }

        private void btn_DisplayDict_Click(object sender, EventArgs e)
        {
            lbx_display.Items.Clear();
            foreach(KeyValuePair<int, Course> kv in dict)
            {
                lbx_display.Items.Add(kv.Key + "-" + kv.Value.Name + "-"
                    + kv.Value.Score);
            }
        }

        private void btn_ClearDict_Click(object sender, EventArgs e)
        {
            dict.Clear();
        }
    }
}
