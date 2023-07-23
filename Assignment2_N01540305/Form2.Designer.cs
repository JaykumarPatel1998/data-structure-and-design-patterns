namespace LAB2_N01540305
{
    partial class Form2
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
            this.lbl_linkedList = new System.Windows.Forms.Label();
            this.txt_courseName = new System.Windows.Forms.TextBox();
            this.txt_courseScore = new System.Windows.Forms.TextBox();
            this.btn_addLast = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.lbx_linkedList = new System.Windows.Forms.ListBox();
            this.lbl_errorLinkedList = new System.Windows.Forms.Label();
            this.btn_ToForm1 = new System.Windows.Forms.Button();
            this.btn_addFirst = new System.Windows.Forms.Button();
            this.btn_remove_first = new System.Windows.Forms.Button();
            this.btn_remove_last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_linkedList
            // 
            this.lbl_linkedList.AutoSize = true;
            this.lbl_linkedList.Location = new System.Drawing.Point(225, 66);
            this.lbl_linkedList.Name = "lbl_linkedList";
            this.lbl_linkedList.Size = new System.Drawing.Size(85, 20);
            this.lbl_linkedList.TabIndex = 0;
            this.lbl_linkedList.Text = "Linked List";
            // 
            // txt_courseName
            // 
            this.txt_courseName.Location = new System.Drawing.Point(99, 121);
            this.txt_courseName.Name = "txt_courseName";
            this.txt_courseName.Size = new System.Drawing.Size(100, 26);
            this.txt_courseName.TabIndex = 1;
            // 
            // txt_courseScore
            // 
            this.txt_courseScore.Location = new System.Drawing.Point(330, 121);
            this.txt_courseScore.Name = "txt_courseScore";
            this.txt_courseScore.Size = new System.Drawing.Size(100, 26);
            this.txt_courseScore.TabIndex = 2;
            // 
            // btn_addLast
            // 
            this.btn_addLast.Location = new System.Drawing.Point(62, 188);
            this.btn_addLast.Name = "btn_addLast";
            this.btn_addLast.Size = new System.Drawing.Size(82, 35);
            this.btn_addLast.TabIndex = 3;
            this.btn_addLast.Text = "Add";
            this.btn_addLast.UseVisualStyleBackColor = true;
            this.btn_addLast.Click += new System.EventHandler(this.btn_addLast_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(59, 255);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(85, 36);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(194, 256);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(84, 35);
            this.btn_find.TabIndex = 5;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(330, 188);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(79, 35);
            this.btn_display.TabIndex = 6;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // lbx_linkedList
            // 
            this.lbx_linkedList.FormattingEnabled = true;
            this.lbx_linkedList.ItemHeight = 20;
            this.lbx_linkedList.Location = new System.Drawing.Point(546, 66);
            this.lbx_linkedList.Name = "lbx_linkedList";
            this.lbx_linkedList.Size = new System.Drawing.Size(198, 144);
            this.lbx_linkedList.TabIndex = 7;
            // 
            // lbl_errorLinkedList
            // 
            this.lbl_errorLinkedList.AutoSize = true;
            this.lbl_errorLinkedList.Location = new System.Drawing.Point(62, 271);
            this.lbl_errorLinkedList.Name = "lbl_errorLinkedList";
            this.lbl_errorLinkedList.Size = new System.Drawing.Size(0, 20);
            this.lbl_errorLinkedList.TabIndex = 8;
            // 
            // btn_ToForm1
            // 
            this.btn_ToForm1.Location = new System.Drawing.Point(330, 365);
            this.btn_ToForm1.Name = "btn_ToForm1";
            this.btn_ToForm1.Size = new System.Drawing.Size(100, 34);
            this.btn_ToForm1.TabIndex = 9;
            this.btn_ToForm1.Text = "Form1 >>";
            this.btn_ToForm1.UseVisualStyleBackColor = true;
            this.btn_ToForm1.Click += new System.EventHandler(this.btn_ToForm1_Click);
            // 
            // btn_addFirst
            // 
            this.btn_addFirst.Location = new System.Drawing.Point(194, 188);
            this.btn_addFirst.Name = "btn_addFirst";
            this.btn_addFirst.Size = new System.Drawing.Size(98, 35);
            this.btn_addFirst.TabIndex = 10;
            this.btn_addFirst.Text = "AddFirst";
            this.btn_addFirst.UseVisualStyleBackColor = true;
            this.btn_addFirst.Click += new System.EventHandler(this.btn_addFirst_Click);
            // 
            // btn_remove_first
            // 
            this.btn_remove_first.Location = new System.Drawing.Point(330, 256);
            this.btn_remove_first.Name = "btn_remove_first";
            this.btn_remove_first.Size = new System.Drawing.Size(111, 35);
            this.btn_remove_first.TabIndex = 11;
            this.btn_remove_first.Text = "remove first";
            this.btn_remove_first.UseVisualStyleBackColor = true;
            this.btn_remove_first.Click += new System.EventHandler(this.btn_remove_first_Click);
            // 
            // btn_remove_last
            // 
            this.btn_remove_last.Location = new System.Drawing.Point(59, 318);
            this.btn_remove_last.Name = "btn_remove_last";
            this.btn_remove_last.Size = new System.Drawing.Size(107, 33);
            this.btn_remove_last.TabIndex = 12;
            this.btn_remove_last.Text = "remove last";
            this.btn_remove_last.UseVisualStyleBackColor = true;
            this.btn_remove_last.Click += new System.EventHandler(this.btn_remove_last_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_remove_last);
            this.Controls.Add(this.btn_remove_first);
            this.Controls.Add(this.btn_addFirst);
            this.Controls.Add(this.btn_ToForm1);
            this.Controls.Add(this.lbl_errorLinkedList);
            this.Controls.Add(this.lbx_linkedList);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_addLast);
            this.Controls.Add(this.txt_courseScore);
            this.Controls.Add(this.txt_courseName);
            this.Controls.Add(this.lbl_linkedList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_linkedList;
        private System.Windows.Forms.TextBox txt_courseName;
        private System.Windows.Forms.TextBox txt_courseScore;
        private System.Windows.Forms.Button btn_addLast;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ListBox lbx_linkedList;
        private System.Windows.Forms.Label lbl_errorLinkedList;
        private System.Windows.Forms.Button btn_ToForm1;
        private System.Windows.Forms.Button btn_addFirst;
        private System.Windows.Forms.Button btn_remove_first;
        private System.Windows.Forms.Button btn_remove_last;
    }
}