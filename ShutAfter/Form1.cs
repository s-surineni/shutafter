using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShutAfter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            popHrs();
            popMins();
            
        }

        void popHrs()
        {
            for (int i = 0; i <= 24; i++)
            {
                hrs.Items.Add(i);
            }
            hrs.SelectedIndex = 0;
            hrs.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void popMins()
        {
            for (int i = 0; i <= 60; i++)
            {
                min.Items.Add(i);
            }
            min.SelectedIndex = 0;
            min.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hours = Convert.ToInt32(hrs.Text);
            int mints = Convert.ToInt32(min.Text);
            long sec = (hours * 60 * 60) + (mints * 60);
            //System.Diagnostics.Process prcs = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/c shutdown /s /t "+ sec;
            //prcs.StartInfo = startInfo;
            //prcs.Start();
            System.Diagnostics.Process.Start("shutdown", "/s /t "+sec);
            this.Visible = false;


        }

        private void hrs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
