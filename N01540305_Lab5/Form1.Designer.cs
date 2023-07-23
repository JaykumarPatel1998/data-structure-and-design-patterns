namespace N01540305_Lab4
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_CName = new System.Windows.Forms.TextBox();
            this.txt_CScore = new System.Windows.Forms.TextBox();
            this.btn_AddHashTable = new System.Windows.Forms.Button();
            this.btn_RemoveHashTable = new System.Windows.Forms.Button();
            this.lbl_DisplayHashTable = new System.Windows.Forms.Button();
            this.btn_ClearHashTable = new System.Windows.Forms.Button();
            this.btn_AddDict = new System.Windows.Forms.Button();
            this.btn_RemoveDict = new System.Windows.Forms.Button();
            this.btn_DisplayDict = new System.Windows.Forms.Button();
            this.btn_ClearDict = new System.Windows.Forms.Button();
            this.lbl_HashTable = new System.Windows.Forms.Label();
            this.lbl_Dictionary = new System.Windows.Forms.Label();
            this.lbx_display = new System.Windows.Forms.ListBox();
            this.btn_form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(162, 158);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 26);
            this.txt_id.TabIndex = 0;
            // 
            // txt_CName
            // 
            this.txt_CName.Location = new System.Drawing.Point(297, 158);
            this.txt_CName.Name = "txt_CName";
            this.txt_CName.Size = new System.Drawing.Size(100, 26);
            this.txt_CName.TabIndex = 1;
            // 
            // txt_CScore
            // 
            this.txt_CScore.Location = new System.Drawing.Point(446, 158);
            this.txt_CScore.Name = "txt_CScore";
            this.txt_CScore.Size = new System.Drawing.Size(100, 26);
            this.txt_CScore.TabIndex = 2;
            // 
            // btn_AddHashTable
            // 
            this.btn_AddHashTable.Location = new System.Drawing.Point(125, 256);
            this.btn_AddHashTable.Name = "btn_AddHashTable";
            this.btn_AddHashTable.Size = new System.Drawing.Size(75, 34);
            this.btn_AddHashTable.TabIndex = 3;
            this.btn_AddHashTable.Text = "Add";
            this.btn_AddHashTable.UseVisualStyleBackColor = true;
            this.btn_AddHashTable.Click += new System.EventHandler(this.btn_AddHashTable_Click);
            // 
            // btn_RemoveHashTable
            // 
            this.btn_RemoveHashTable.Location = new System.Drawing.Point(247, 256);
            this.btn_RemoveHashTable.Name = "btn_RemoveHashTable";
            this.btn_RemoveHashTable.Size = new System.Drawing.Size(85, 34);
            this.btn_RemoveHashTable.TabIndex = 4;
            this.btn_RemoveHashTable.Text = "Remove";
            this.btn_RemoveHashTable.UseVisualStyleBackColor = true;
            this.btn_RemoveHashTable.Click += new System.EventHandler(this.btn_RemoveHashTable_Click);
            // 
            // lbl_DisplayHashTable
            // 
            this.lbl_DisplayHashTable.Location = new System.Drawing.Point(366, 256);
            this.lbl_DisplayHashTable.Name = "lbl_DisplayHashTable";
            this.lbl_DisplayHashTable.Size = new System.Drawing.Size(89, 34);
            this.lbl_DisplayHashTable.TabIndex = 5;
            this.lbl_DisplayHashTable.Text = "Display";
            this.lbl_DisplayHashTable.UseVisualStyleBackColor = true;
            this.lbl_DisplayHashTable.Click += new System.EventHandler(this.lbl_DisplayHashTable_Click);
            // 
            // btn_ClearHashTable
            // 
            this.btn_ClearHashTable.Location = new System.Drawing.Point(496, 255);
            this.btn_ClearHashTable.Name = "btn_ClearHashTable";
            this.btn_ClearHashTable.Size = new System.Drawing.Size(75, 35);
            this.btn_ClearHashTable.TabIndex = 6;
            this.btn_ClearHashTable.Text = "Clear";
            this.btn_ClearHashTable.UseVisualStyleBackColor = true;
            this.btn_ClearHashTable.Click += new System.EventHandler(this.btn_ClearHashTable_Click);
            // 
            // btn_AddDict
            // 
            this.btn_AddDict.Location = new System.Drawing.Point(125, 359);
            this.btn_AddDict.Name = "btn_AddDict";
            this.btn_AddDict.Size = new System.Drawing.Size(85, 37);
            this.btn_AddDict.TabIndex = 7;
            this.btn_AddDict.Text = "Add";
            this.btn_AddDict.UseVisualStyleBackColor = true;
            this.btn_AddDict.Click += new System.EventHandler(this.btn_AddDict_Click);
            // 
            // btn_RemoveDict
            // 
            this.btn_RemoveDict.Location = new System.Drawing.Point(247, 359);
            this.btn_RemoveDict.Name = "btn_RemoveDict";
            this.btn_RemoveDict.Size = new System.Drawing.Size(85, 37);
            this.btn_RemoveDict.TabIndex = 8;
            this.btn_RemoveDict.Text = "Remove";
            this.btn_RemoveDict.UseVisualStyleBackColor = true;
            this.btn_RemoveDict.Click += new System.EventHandler(this.btn_RemoveDict_Click);
            // 
            // btn_DisplayDict
            // 
            this.btn_DisplayDict.Location = new System.Drawing.Point(366, 359);
            this.btn_DisplayDict.Name = "btn_DisplayDict";
            this.btn_DisplayDict.Size = new System.Drawing.Size(89, 37);
            this.btn_DisplayDict.TabIndex = 9;
            this.btn_DisplayDict.Text = "Display";
            this.btn_DisplayDict.UseVisualStyleBackColor = true;
            this.btn_DisplayDict.Click += new System.EventHandler(this.btn_DisplayDict_Click);
            // 
            // btn_ClearDict
            // 
            this.btn_ClearDict.Location = new System.Drawing.Point(496, 358);
            this.btn_ClearDict.Name = "btn_ClearDict";
            this.btn_ClearDict.Size = new System.Drawing.Size(85, 38);
            this.btn_ClearDict.TabIndex = 10;
            this.btn_ClearDict.Text = "Clear";
            this.btn_ClearDict.UseVisualStyleBackColor = true;
            this.btn_ClearDict.Click += new System.EventHandler(this.btn_ClearDict_Click);
            // 
            // lbl_HashTable
            // 
            this.lbl_HashTable.AutoSize = true;
            this.lbl_HashTable.Location = new System.Drawing.Point(324, 211);
            this.lbl_HashTable.Name = "lbl_HashTable";
            this.lbl_HashTable.Size = new System.Drawing.Size(90, 20);
            this.lbl_HashTable.TabIndex = 11;
            this.lbl_HashTable.Text = "Hash Table";
            // 
            // lbl_Dictionary
            // 
            this.lbl_Dictionary.AutoSize = true;
            this.lbl_Dictionary.Location = new System.Drawing.Point(328, 320);
            this.lbl_Dictionary.Name = "lbl_Dictionary";
            this.lbl_Dictionary.Size = new System.Drawing.Size(79, 20);
            this.lbl_Dictionary.TabIndex = 12;
            this.lbl_Dictionary.Text = "Dictionary";
            // 
            // lbx_display
            // 
            this.lbx_display.FormattingEnabled = true;
            this.lbx_display.ItemHeight = 20;
            this.lbx_display.Location = new System.Drawing.Point(695, 190);
            this.lbx_display.Name = "lbx_display";
            this.lbx_display.Size = new System.Drawing.Size(208, 164);
            this.lbx_display.TabIndex = 13;
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(695, 454);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(108, 39);
            this.btn_form2.TabIndex = 14;
            this.btn_form2.Text = "Form2>";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 544);
            this.Controls.Add(this.btn_form2);
            this.Controls.Add(this.lbx_display);
            this.Controls.Add(this.lbl_Dictionary);
            this.Controls.Add(this.lbl_HashTable);
            this.Controls.Add(this.btn_ClearDict);
            this.Controls.Add(this.btn_DisplayDict);
            this.Controls.Add(this.btn_RemoveDict);
            this.Controls.Add(this.btn_AddDict);
            this.Controls.Add(this.btn_ClearHashTable);
            this.Controls.Add(this.lbl_DisplayHashTable);
            this.Controls.Add(this.btn_RemoveHashTable);
            this.Controls.Add(this.btn_AddHashTable);
            this.Controls.Add(this.txt_CScore);
            this.Controls.Add(this.txt_CName);
            this.Controls.Add(this.txt_id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_CName;
        private System.Windows.Forms.TextBox txt_CScore;
        private System.Windows.Forms.Button btn_AddHashTable;
        private System.Windows.Forms.Button btn_RemoveHashTable;
        private System.Windows.Forms.Button lbl_DisplayHashTable;
        private System.Windows.Forms.Button btn_ClearHashTable;
        private System.Windows.Forms.Button btn_AddDict;
        private System.Windows.Forms.Button btn_RemoveDict;
        private System.Windows.Forms.Button btn_DisplayDict;
        private System.Windows.Forms.Button btn_ClearDict;
        private System.Windows.Forms.Label lbl_HashTable;
        private System.Windows.Forms.Label lbl_Dictionary;
        private System.Windows.Forms.ListBox lbx_display;
        private System.Windows.Forms.Button btn_form2;
    }
}

