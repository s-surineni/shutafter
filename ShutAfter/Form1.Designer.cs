﻿namespace ShutAfter
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
            this.shutAfter = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hrs = new System.Windows.Forms.ComboBox();
            this.min = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // shutAfter
            // 
            this.shutAfter.AutoSize = true;
            this.shutAfter.Location = new System.Drawing.Point(12, 111);
            this.shutAfter.Name = "shutAfter";
            this.shutAfter.Size = new System.Drawing.Size(54, 13);
            this.shutAfter.TabIndex = 0;
            this.shutAfter.Text = "Shut After";
            this.shutAfter.Click += new System.EventHandler(this.label1_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(91, 149);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Set";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hours";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minutes";
            // 
            // hrs
            // 
            this.hrs.FormattingEnabled = true;
            this.hrs.Location = new System.Drawing.Point(91, 103);
            this.hrs.Name = "hrs";
            this.hrs.Size = new System.Drawing.Size(50, 21);
            this.hrs.TabIndex = 6;
            // 
            // min
            // 
            this.min.FormattingEnabled = true;
            this.min.Location = new System.Drawing.Point(185, 100);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(41, 21);
            this.min.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hrs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.shutAfter);
            this.Name = "Form1";
            this.Text = "ShutAfter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shutAfter;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox hrs;
        private System.Windows.Forms.ComboBox min;
    }
}

