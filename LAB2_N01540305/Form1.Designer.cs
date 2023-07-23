namespace LAB2_N01540305
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
            this.lbl_stack = new System.Windows.Forms.Label();
            this.txt_stack_course = new System.Windows.Forms.TextBox();
            this.txt_stack_score = new System.Windows.Forms.TextBox();
            this.lbx_stack = new System.Windows.Forms.ListBox();
            this.btn_stack_push = new System.Windows.Forms.Button();
            this.btn_stack_pop = new System.Windows.Forms.Button();
            this.btn_stack_display = new System.Windows.Forms.Button();
            this.lbl_queue = new System.Windows.Forms.Label();
            this.txt_queue_course = new System.Windows.Forms.TextBox();
            this.txt_queue_score = new System.Windows.Forms.TextBox();
            this.btn_queue_enqueue = new System.Windows.Forms.Button();
            this.btn_queue_dequeue = new System.Windows.Forms.Button();
            this.btn_queue_display = new System.Windows.Forms.Button();
            this.lbx_queue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_stack
            // 
            this.lbl_stack.AutoSize = true;
            this.lbl_stack.Location = new System.Drawing.Point(309, 29);
            this.lbl_stack.Name = "lbl_stack";
            this.lbl_stack.Size = new System.Drawing.Size(50, 20);
            this.lbl_stack.TabIndex = 0;
            this.lbl_stack.Text = "Stack";
            // 
            // txt_stack_course
            // 
            this.txt_stack_course.Location = new System.Drawing.Point(211, 81);
            this.txt_stack_course.Name = "txt_stack_course";
            this.txt_stack_course.Size = new System.Drawing.Size(100, 26);
            this.txt_stack_course.TabIndex = 1;
            // 
            // txt_stack_score
            // 
            this.txt_stack_score.Location = new System.Drawing.Point(356, 81);
            this.txt_stack_score.Name = "txt_stack_score";
            this.txt_stack_score.Size = new System.Drawing.Size(100, 26);
            this.txt_stack_score.TabIndex = 2;
            // 
            // lbx_stack
            // 
            this.lbx_stack.FormattingEnabled = true;
            this.lbx_stack.ItemHeight = 20;
            this.lbx_stack.Location = new System.Drawing.Point(605, 29);
            this.lbx_stack.Name = "lbx_stack";
            this.lbx_stack.Size = new System.Drawing.Size(162, 144);
            this.lbx_stack.TabIndex = 3;
            // 
            // btn_stack_push
            // 
            this.btn_stack_push.Location = new System.Drawing.Point(220, 153);
            this.btn_stack_push.Name = "btn_stack_push";
            this.btn_stack_push.Size = new System.Drawing.Size(91, 39);
            this.btn_stack_push.TabIndex = 4;
            this.btn_stack_push.Text = "Push";
            this.btn_stack_push.UseVisualStyleBackColor = true;
            this.btn_stack_push.Click += new System.EventHandler(this.btn_stack_push_Click);
            // 
            // btn_stack_pop
            // 
            this.btn_stack_pop.Location = new System.Drawing.Point(333, 152);
            this.btn_stack_pop.Name = "btn_stack_pop";
            this.btn_stack_pop.Size = new System.Drawing.Size(88, 40);
            this.btn_stack_pop.TabIndex = 5;
            this.btn_stack_pop.Text = "Pop";
            this.btn_stack_pop.UseVisualStyleBackColor = true;
            this.btn_stack_pop.Click += new System.EventHandler(this.btn_stack_pop_Click);
            // 
            // btn_stack_display
            // 
            this.btn_stack_display.Location = new System.Drawing.Point(453, 151);
            this.btn_stack_display.Name = "btn_stack_display";
            this.btn_stack_display.Size = new System.Drawing.Size(88, 41);
            this.btn_stack_display.TabIndex = 6;
            this.btn_stack_display.Text = "Display";
            this.btn_stack_display.UseVisualStyleBackColor = true;
            this.btn_stack_display.Click += new System.EventHandler(this.btn_stack_display_Click);
            // 
            // lbl_queue
            // 
            this.lbl_queue.AutoSize = true;
            this.lbl_queue.Location = new System.Drawing.Point(313, 245);
            this.lbl_queue.Name = "lbl_queue";
            this.lbl_queue.Size = new System.Drawing.Size(57, 20);
            this.lbl_queue.TabIndex = 7;
            this.lbl_queue.Text = "Queue";
            // 
            // txt_queue_course
            // 
            this.txt_queue_course.Location = new System.Drawing.Point(211, 286);
            this.txt_queue_course.Name = "txt_queue_course";
            this.txt_queue_course.Size = new System.Drawing.Size(100, 26);
            this.txt_queue_course.TabIndex = 8;
            // 
            // txt_queue_score
            // 
            this.txt_queue_score.Location = new System.Drawing.Point(356, 285);
            this.txt_queue_score.Name = "txt_queue_score";
            this.txt_queue_score.Size = new System.Drawing.Size(100, 26);
            this.txt_queue_score.TabIndex = 9;
            // 
            // btn_queue_enqueue
            // 
            this.btn_queue_enqueue.Location = new System.Drawing.Point(220, 353);
            this.btn_queue_enqueue.Name = "btn_queue_enqueue";
            this.btn_queue_enqueue.Size = new System.Drawing.Size(91, 38);
            this.btn_queue_enqueue.TabIndex = 10;
            this.btn_queue_enqueue.Text = "Enqueue";
            this.btn_queue_enqueue.UseVisualStyleBackColor = true;
            this.btn_queue_enqueue.Click += new System.EventHandler(this.btn_queue_enqueue_Click);
            // 
            // btn_queue_dequeue
            // 
            this.btn_queue_dequeue.Location = new System.Drawing.Point(333, 353);
            this.btn_queue_dequeue.Name = "btn_queue_dequeue";
            this.btn_queue_dequeue.Size = new System.Drawing.Size(91, 38);
            this.btn_queue_dequeue.TabIndex = 11;
            this.btn_queue_dequeue.Text = "Dequeue";
            this.btn_queue_dequeue.UseVisualStyleBackColor = true;
            this.btn_queue_dequeue.Click += new System.EventHandler(this.btn_queue_dequeue_Click);
            // 
            // btn_queue_display
            // 
            this.btn_queue_display.Location = new System.Drawing.Point(464, 353);
            this.btn_queue_display.Name = "btn_queue_display";
            this.btn_queue_display.Size = new System.Drawing.Size(88, 38);
            this.btn_queue_display.TabIndex = 12;
            this.btn_queue_display.Text = "Display";
            this.btn_queue_display.UseVisualStyleBackColor = true;
            this.btn_queue_display.Click += new System.EventHandler(this.btn_queue_display_Click);
            // 
            // lbx_queue
            // 
            this.lbx_queue.FormattingEnabled = true;
            this.lbx_queue.ItemHeight = 20;
            this.lbx_queue.Location = new System.Drawing.Point(605, 245);
            this.lbx_queue.Name = "lbx_queue";
            this.lbx_queue.Size = new System.Drawing.Size(162, 144);
            this.lbx_queue.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 571);
            this.Controls.Add(this.lbx_queue);
            this.Controls.Add(this.btn_queue_display);
            this.Controls.Add(this.btn_queue_dequeue);
            this.Controls.Add(this.btn_queue_enqueue);
            this.Controls.Add(this.txt_queue_score);
            this.Controls.Add(this.txt_queue_course);
            this.Controls.Add(this.lbl_queue);
            this.Controls.Add(this.btn_stack_display);
            this.Controls.Add(this.btn_stack_pop);
            this.Controls.Add(this.btn_stack_push);
            this.Controls.Add(this.lbx_stack);
            this.Controls.Add(this.txt_stack_score);
            this.Controls.Add(this.txt_stack_course);
            this.Controls.Add(this.lbl_stack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stack;
        private System.Windows.Forms.TextBox txt_stack_course;
        private System.Windows.Forms.TextBox txt_stack_score;
        private System.Windows.Forms.ListBox lbx_stack;
        private System.Windows.Forms.Button btn_stack_push;
        private System.Windows.Forms.Button btn_stack_pop;
        private System.Windows.Forms.Button btn_stack_display;
        private System.Windows.Forms.Label lbl_queue;
        private System.Windows.Forms.TextBox txt_queue_course;
        private System.Windows.Forms.TextBox txt_queue_score;
        private System.Windows.Forms.Button btn_queue_enqueue;
        private System.Windows.Forms.Button btn_queue_dequeue;
        private System.Windows.Forms.Button btn_queue_display;
        private System.Windows.Forms.ListBox lbx_queue;
    }
}

