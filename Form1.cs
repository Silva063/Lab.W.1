using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += enableButtons;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        button3.Enabled = false;
        }


        private void button4_Click(object sender, EventArgs e)
        {
        button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
        button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
        button7.Enabled = false;
        }


        private void enableButtons(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;

        }
    }
}
