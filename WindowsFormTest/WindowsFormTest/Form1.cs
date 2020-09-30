using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.ForeColor = Color.Red;
            }
        }

        private void Small_CheckedChanged(object sender, EventArgs e)
        {
            if (Small.Checked)
            {
                label1.Font = new Font("Arial", 12);
            }
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            if (Medium.Checked)
            {
                label1.Font = new Font("Arial", 24);
            }
        }

        private void Large_CheckedChanged(object sender, EventArgs e)
        {
            if (Large.Checked)
            {
                label1.Font = new Font("Arial", 36);
            }
        }
    }
}
