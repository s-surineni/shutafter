namespace ShutAfter
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
            this.button1 = new System.Windows.Forms.Button();
            this.hrs = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hrs
            // 
            this.hrs.Location = new System.Drawing.Point(91, 111);
            this.hrs.Name = "hrs";
            this.hrs.Size = new System.Drawing.Size(55, 20);
            this.hrs.TabIndex = 2;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(172, 111);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(59, 20);
            this.min.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hrs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shutAfter);
            this.Name = "Form1";
            this.Text = "ShutAfter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shutAfter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hrs;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

