namespace N01540305_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_arraylist = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_arraylist = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.lbx_arraylist = new System.Windows.Forms.ListBox();
            this.lbl_list = new System.Windows.Forms.Label();
            this.txt_list = new System.Windows.Forms.TextBox();
            this.btn_addList = new System.Windows.Forms.Button();
            this.btn_ListRemove = new System.Windows.Forms.Button();
            this.btn_ListDisplay = new System.Windows.Forms.Button();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.lbl_arraylist_error = new System.Windows.Forms.Label();
            this.lbl_list_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_arraylist
            // 
            this.lbl_arraylist.AutoSize = true;
            this.lbl_arraylist.Location = new System.Drawing.Point(342, 51);
            this.lbl_arraylist.Name = "lbl_arraylist";
            this.lbl_arraylist.Size = new System.Drawing.Size(63, 20);
            this.lbl_arraylist.TabIndex = 0;
            this.lbl_arraylist.Text = "arraylist";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(225, 154);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(76, 32);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_arraylist
            // 
            this.txt_arraylist.Location = new System.Drawing.Point(330, 91);
            this.txt_arraylist.Name = "txt_arraylist";
            this.txt_arraylist.Size = new System.Drawing.Size(100, 26);
            this.txt_arraylist.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(330, 154);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(116, 32);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(472, 153);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(84, 33);
            this.btn_display.TabIndex = 4;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // lbx_arraylist
            // 
            this.lbx_arraylist.FormattingEnabled = true;
            this.lbx_arraylist.ItemHeight = 20;
            this.lbx_arraylist.Location = new System.Drawing.Point(617, 62);
            this.lbx_arraylist.Name = "lbx_arraylist";
            this.lbx_arraylist.Size = new System.Drawing.Size(134, 124);
            this.lbx_arraylist.TabIndex = 5;
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(346, 332);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(34, 20);
            this.lbl_list.TabIndex = 6;
            this.lbl_list.Text = "List";
            // 
            // txt_list
            // 
            this.txt_list.Location = new System.Drawing.Point(346, 376);
            this.txt_list.Name = "txt_list";
            this.txt_list.Size = new System.Drawing.Size(100, 26);
            this.txt_list.TabIndex = 7;
            // 
            // btn_addList
            // 
            this.btn_addList.Location = new System.Drawing.Point(203, 434);
            this.btn_addList.Name = "btn_addList";
            this.btn_addList.Size = new System.Drawing.Size(98, 41);
            this.btn_addList.TabIndex = 8;
            this.btn_addList.Text = "ListAdd";
            this.btn_addList.UseVisualStyleBackColor = true;
            this.btn_addList.Click += new System.EventHandler(this.btn_addList_Click);
            // 
            // btn_ListRemove
            // 
            this.btn_ListRemove.Location = new System.Drawing.Point(334, 428);
            this.btn_ListRemove.Name = "btn_ListRemove";
            this.btn_ListRemove.Size = new System.Drawing.Size(112, 47);
            this.btn_ListRemove.TabIndex = 9;
            this.btn_ListRemove.Text = "ListRemove";
            this.btn_ListRemove.UseVisualStyleBackColor = true;
            this.btn_ListRemove.Click += new System.EventHandler(this.btn_ListRemove_Click);
            // 
            // btn_ListDisplay
            // 
            this.btn_ListDisplay.Location = new System.Drawing.Point(472, 426);
            this.btn_ListDisplay.Name = "btn_ListDisplay";
            this.btn_ListDisplay.Size = new System.Drawing.Size(114, 49);
            this.btn_ListDisplay.TabIndex = 10;
            this.btn_ListDisplay.Text = "ListDisplay";
            this.btn_ListDisplay.UseVisualStyleBackColor = true;
            this.btn_ListDisplay.Click += new System.EventHandler(this.btn_ListDisplay_Click);
            // 
            // lbx_list
            // 
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.ItemHeight = 20;
            this.lbx_list.Location = new System.Drawing.Point(617, 351);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.Size = new System.Drawing.Size(134, 124);
            this.lbx_list.TabIndex = 11;
            // 
            // lbl_arraylist_error
            // 
            this.lbl_arraylist_error.AutoSize = true;
            this.lbl_arraylist_error.Location = new System.Drawing.Point(225, 204);
            this.lbl_arraylist_error.Name = "lbl_arraylist_error";
            this.lbl_arraylist_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_arraylist_error.TabIndex = 12;
            this.lbl_arraylist_error.UseMnemonic = false;
            // 
            // lbl_list_error
            // 
            this.lbl_list_error.AutoSize = true;
            this.lbl_list_error.Location = new System.Drawing.Point(203, 503);
            this.lbl_list_error.Name = "lbl_list_error";
            this.lbl_list_error.Size = new System.Drawing.Size(0, 20);
            this.lbl_list_error.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 562);
            this.Controls.Add(this.lbl_list_error);
            this.Controls.Add(this.lbl_arraylist_error);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.btn_ListDisplay);
            this.Controls.Add(this.btn_ListRemove);
            this.Controls.Add(this.btn_addList);
            this.Controls.Add(this.txt_list);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.lbx_arraylist);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txt_arraylist);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_arraylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_arraylist;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_arraylist;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ListBox lbx_arraylist;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.TextBox txt_list;
        private System.Windows.Forms.Button btn_addList;
        private System.Windows.Forms.Button btn_ListRemove;
        private System.Windows.Forms.Button btn_ListDisplay;
        private System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.Label lbl_arraylist_error;
        private System.Windows.Forms.Label lbl_list_error;
    }
}

