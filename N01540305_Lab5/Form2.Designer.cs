namespace N01540305_Lab4
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
            this.lbx_set1 = new System.Windows.Forms.ListBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_intersection = new System.Windows.Forms.Button();
            this.btn_subset = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_union = new System.Windows.Forms.Button();
            this.btn_superset = new System.Windows.Forms.Button();
            this.lbx_set2 = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.btn_add2 = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_form1 = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_set1
            // 
            this.lbx_set1.FormattingEnabled = true;
            this.lbx_set1.ItemHeight = 20;
            this.lbx_set1.Location = new System.Drawing.Point(154, 112);
            this.lbx_set1.Name = "lbx_set1";
            this.lbx_set1.Size = new System.Drawing.Size(145, 124);
            this.lbx_set1.TabIndex = 0;
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(351, 112);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(101, 37);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_intersection
            // 
            this.btn_intersection.Location = new System.Drawing.Point(351, 155);
            this.btn_intersection.Name = "btn_intersection";
            this.btn_intersection.Size = new System.Drawing.Size(101, 41);
            this.btn_intersection.TabIndex = 2;
            this.btn_intersection.Text = "Intersection";
            this.btn_intersection.UseVisualStyleBackColor = true;
            this.btn_intersection.Click += new System.EventHandler(this.btn_intersection_Click);
            // 
            // btn_subset
            // 
            this.btn_subset.Location = new System.Drawing.Point(351, 202);
            this.btn_subset.Name = "btn_subset";
            this.btn_subset.Size = new System.Drawing.Size(101, 40);
            this.btn_subset.TabIndex = 3;
            this.btn_subset.Text = "Subset?";
            this.btn_subset.UseVisualStyleBackColor = true;
            this.btn_subset.Click += new System.EventHandler(this.btn_subset_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(510, 111);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(85, 38);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_union
            // 
            this.btn_union.Location = new System.Drawing.Point(510, 154);
            this.btn_union.Name = "btn_union";
            this.btn_union.Size = new System.Drawing.Size(85, 42);
            this.btn_union.TabIndex = 5;
            this.btn_union.Text = "Union";
            this.btn_union.UseVisualStyleBackColor = true;
            this.btn_union.Click += new System.EventHandler(this.btn_union_Click);
            // 
            // btn_superset
            // 
            this.btn_superset.Location = new System.Drawing.Point(510, 202);
            this.btn_superset.Name = "btn_superset";
            this.btn_superset.Size = new System.Drawing.Size(85, 40);
            this.btn_superset.TabIndex = 6;
            this.btn_superset.Text = "Superset?";
            this.btn_superset.UseVisualStyleBackColor = true;
            this.btn_superset.Click += new System.EventHandler(this.btn_superset_Click);
            // 
            // lbx_set2
            // 
            this.lbx_set2.FormattingEnabled = true;
            this.lbx_set2.ItemHeight = 20;
            this.lbx_set2.Location = new System.Drawing.Point(681, 112);
            this.lbx_set2.Name = "lbx_set2";
            this.lbx_set2.Size = new System.Drawing.Size(144, 124);
            this.lbx_set2.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(154, 333);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 38);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(288, 332);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(82, 39);
            this.btn_remove.TabIndex = 9;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(725, 333);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(76, 38);
            this.btn_remove2.TabIndex = 10;
            this.btn_remove2.Text = "Remove";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // btn_add2
            // 
            this.btn_add2.Location = new System.Drawing.Point(623, 331);
            this.btn_add2.Name = "btn_add2";
            this.btn_add2.Size = new System.Drawing.Size(82, 40);
            this.btn_add2.TabIndex = 11;
            this.btn_add2.Text = "Add";
            this.btn_add2.UseVisualStyleBackColor = true;
            this.btn_add2.Click += new System.EventHandler(this.btn_add2_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(456, 333);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 26);
            this.txt_input.TabIndex = 12;
            // 
            // btn_form1
            // 
            this.btn_form1.Location = new System.Drawing.Point(721, 533);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(100, 39);
            this.btn_form1.TabIndex = 13;
            this.btn_form1.Text = "Form 1>>";
            this.btn_form1.UseVisualStyleBackColor = true;
            this.btn_form1.Click += new System.EventHandler(this.btn_form1_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(452, 275);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(48, 20);
            this.lbl_result.TabIndex = 14;
            this.lbl_result.Text = "result";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 648);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_form1);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_add2);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbx_set2);
            this.Controls.Add(this.btn_superset);
            this.Controls.Add(this.btn_union);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_subset);
            this.Controls.Add(this.btn_intersection);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.lbx_set1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_set1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_intersection;
        private System.Windows.Forms.Button btn_subset;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_union;
        private System.Windows.Forms.Button btn_superset;
        private System.Windows.Forms.ListBox lbx_set2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_remove2;
        private System.Windows.Forms.Button btn_add2;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Label lbl_result;
    }
}