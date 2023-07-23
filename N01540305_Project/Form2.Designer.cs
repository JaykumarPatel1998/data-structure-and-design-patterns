namespace N01540305_Project
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
            this.lbl_faculty_id = new System.Windows.Forms.Label();
            this.lbl_course_name = new System.Windows.Forms.Label();
            this.txt_faculty_id = new System.Windows.Forms.TextBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_assign = new System.Windows.Forms.Button();
            this.btn_unassign = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.lbx_relationship = new System.Windows.Forms.ListBox();
            this.btn_toForm1 = new System.Windows.Forms.Button();
            this.err_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_faculty_id
            // 
            this.lbl_faculty_id.AutoSize = true;
            this.lbl_faculty_id.Location = new System.Drawing.Point(219, 85);
            this.lbl_faculty_id.Name = "lbl_faculty_id";
            this.lbl_faculty_id.Size = new System.Drawing.Size(78, 20);
            this.lbl_faculty_id.TabIndex = 0;
            this.lbl_faculty_id.Text = "Faculty Id";
            this.lbl_faculty_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_course_name
            // 
            this.lbl_course_name.AutoSize = true;
            this.lbl_course_name.Location = new System.Drawing.Point(483, 85);
            this.lbl_course_name.Name = "lbl_course_name";
            this.lbl_course_name.Size = new System.Drawing.Size(106, 20);
            this.lbl_course_name.TabIndex = 1;
            this.lbl_course_name.Text = "Course Name";
            // 
            // txt_faculty_id
            // 
            this.txt_faculty_id.Location = new System.Drawing.Point(223, 137);
            this.txt_faculty_id.Name = "txt_faculty_id";
            this.txt_faculty_id.Size = new System.Drawing.Size(100, 26);
            this.txt_faculty_id.TabIndex = 2;
            // 
            // txt_course_name
            // 
            this.txt_course_name.Location = new System.Drawing.Point(487, 137);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(100, 26);
            this.txt_course_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Assign / unassign faculty-course relationship";
            // 
            // btn_assign
            // 
            this.btn_assign.Location = new System.Drawing.Point(223, 215);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(100, 32);
            this.btn_assign.TabIndex = 5;
            this.btn_assign.Text = "Assign";
            this.btn_assign.UseVisualStyleBackColor = true;
            this.btn_assign.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_unassign
            // 
            this.btn_unassign.Location = new System.Drawing.Point(358, 215);
            this.btn_unassign.Name = "btn_unassign";
            this.btn_unassign.Size = new System.Drawing.Size(92, 32);
            this.btn_unassign.TabIndex = 6;
            this.btn_unassign.Text = "unassign";
            this.btn_unassign.UseVisualStyleBackColor = true;
            this.btn_unassign.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(499, 215);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(131, 52);
            this.btn_display.TabIndex = 7;
            this.btn_display.Text = "display Faculty taught courses";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // lbx_relationship
            // 
            this.lbx_relationship.FormattingEnabled = true;
            this.lbx_relationship.ItemHeight = 20;
            this.lbx_relationship.Location = new System.Drawing.Point(223, 302);
            this.lbx_relationship.Name = "lbx_relationship";
            this.lbx_relationship.Size = new System.Drawing.Size(390, 124);
            this.lbx_relationship.TabIndex = 8;
            // 
            // btn_toForm1
            // 
            this.btn_toForm1.Location = new System.Drawing.Point(681, 390);
            this.btn_toForm1.Name = "btn_toForm1";
            this.btn_toForm1.Size = new System.Drawing.Size(91, 36);
            this.btn_toForm1.TabIndex = 9;
            this.btn_toForm1.Text = "Form 1";
            this.btn_toForm1.UseVisualStyleBackColor = true;
            this.btn_toForm1.Click += new System.EventHandler(this.btn_toForm1_Click);
            // 
            // err_label
            // 
            this.err_label.AutoSize = true;
            this.err_label.Location = new System.Drawing.Point(287, 477);
            this.err_label.Name = "err_label";
            this.err_label.Size = new System.Drawing.Size(0, 20);
            this.err_label.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 530);
            this.Controls.Add(this.err_label);
            this.Controls.Add(this.btn_toForm1);
            this.Controls.Add(this.lbx_relationship);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_unassign);
            this.Controls.Add(this.btn_assign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_course_name);
            this.Controls.Add(this.txt_faculty_id);
            this.Controls.Add(this.lbl_course_name);
            this.Controls.Add(this.lbl_faculty_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_faculty_id;
        private System.Windows.Forms.Label lbl_course_name;
        private System.Windows.Forms.TextBox txt_faculty_id;
        private System.Windows.Forms.TextBox txt_course_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Button btn_unassign;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.ListBox lbx_relationship;
        private System.Windows.Forms.Button btn_toForm1;
        private System.Windows.Forms.Label err_label;
    }
}