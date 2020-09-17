using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        bool seconds = false;
        bool milliseconds = false;
        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                seconds = true;
                milliseconds = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                if (seconds)
                {
                    stopwatch.Stop();
                    label1.Text = stopwatch.Elapsed.ToString();
                }
                else if (milliseconds)
                {
                    stopwatch.Stop();
                    label1.Text = stopwatch.ElapsedMilliseconds.ToString();
                }
                
            }
            else
            {
                if (seconds)
                {
                    stopwatch.Start();
                }
                else if (!seconds)
                {
                    stopwatch.Start();
                }
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Console.WriteLine("Milliseconds");
                seconds = false;
                milliseconds = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
