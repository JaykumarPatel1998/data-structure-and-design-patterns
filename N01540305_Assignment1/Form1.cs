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
        private String Empty_Text_Field_Error_Msg =
            "Please enter some text in the text-field before you add/remove item";

        private String Duplicate_Error_Msg =
            "Adding duplicates is not allowed";

        private String Remove_Not_Allowed_Error =
            "Course not found to remove";

        private String Empty_Text = "";
        public Form1()
        {
            InitializeComponent();
        }


        //arraylist implementation
        //add button functionality for the arraylist
        private void btn_add_Click(object sender, EventArgs e)
        {
            lbl_arraylist_error.Text = Empty_Text;
            //validating if text already exists in arraylist
            foreach (Object obj in aList)
            {
                if (txt_arraylist.Text == obj.ToString())
                {
                    lbl_arraylist_error.Text = Duplicate_Error_Msg;
                    txt_arraylist.Text = "";
                    return; //The following code will not execute when duplicate entry is found in the arraylist
                }
            }

            //validating if the text is empty
            if (txt_arraylist.Text == "")
            {
                lbl_arraylist_error.Text = Empty_Text_Field_Error_Msg;
            }
            else
            {
                lbl_arraylist_error.Text = Empty_Text;
                aList.Add(txt_arraylist.Text);
                txt_arraylist.Text = "";
            }
        }

        //remove button functionality for the arraylist
        private void btn_remove_Click(object sender, EventArgs e)
        {
            lbl_arraylist_error.Text = Empty_Text;
            if (txt_arraylist.Text == "")
            {
                lbl_arraylist_error.Text = Empty_Text_Field_Error_Msg;
            }
            else
            {
                //validating if text exists in arraylist before removing
                foreach (Object obj in aList)
                {
                    if (txt_arraylist.Text == obj.ToString())
                    {
                        aList.Remove(txt_arraylist.Text);
                        txt_arraylist.Text = "";
                        lbl_arraylist_error.Text = Empty_Text;
                        return; //The following code will not execute when duplicate entry is found in the arraylist
                    }
                }
                lbl_arraylist_error.Text = Remove_Not_Allowed_Error;
            }
        }

        //display button functionality for the arraylist
        private void btn_display_Click(object sender, EventArgs e)
        {
            if (aList.Count == 0)
            {
                lbl_arraylist_error.Text = "Arraylist is empty!";
                return;
            }
            lbx_arraylist.Items.Clear();
            aList.Sort();
            lbl_arraylist_error.Text = Empty_Text;
            foreach (Object obj in aList)
            {
                lbx_arraylist.Items.Add(obj.ToString());
            }
        }




        //list implementation
        //add button functionality for the list
        private void btn_addList_Click(object sender, EventArgs e)
        {
            lbl_list_error.Text = Empty_Text;
            //validating if text already exists in list
            foreach (Object obj in list)
            {
                if (txt_list.Text == obj.ToString())
                {
                    lbl_list_error.Text = Duplicate_Error_Msg;
                    txt_list.Text = "";
                    return; //The following code will not execute when duplicate entry is found in the list
                }
            }

            if (txt_list.Text == "")
            {
                lbl_list_error.Text = Empty_Text_Field_Error_Msg;
            }
            else
            {
                lbl_list_error.Text= Empty_Text;
                list.Add(txt_list.Text);
                txt_list.Text = "";
            }
        }

        //remove button functionality for the arraylist
        private void btn_ListRemove_Click(object sender, EventArgs e)
        {
            lbl_list_error.Text = Empty_Text;
            if (txt_list.Text == "")
            {
                lbl_list_error.Text = Empty_Text_Field_Error_Msg;
            }
            else
            {
                //validating if text exists in list before removing
                foreach (Object obj in list)
                {
                    if (txt_list.Text == obj.ToString())
                    {
                        list.Remove(txt_list.Text);
                        txt_list.Text = "";
                        lbl_list_error.Text = Empty_Text;
                        return; //The following code will not execute when duplicate entry is found in the list
                    }
                }
                lbl_list_error.Text = Remove_Not_Allowed_Error;
            }
        }

        //display button functionality for the arraylist
        private void btn_ListDisplay_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                lbl_list_error.Text = "List is empty!";
                return;
            }
            list.Sort();
            lbx_list.Items.Clear();
            lbl_list_error.Text = Empty_Text;
            foreach (Object obj in list)
            {
                lbx_list.Items.Add(obj.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this method was added by mistake due to double click on form element
        }
    }
}
