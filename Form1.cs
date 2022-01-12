//Current date is 14th of April
//I am Mohammed Waseq Rahman
//This application has 5 programs and one exit button. It has lotto machines and also converters
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cal = new Form3();
            cal.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var cal = new Form6();
            cal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cal = new Form4();
            cal.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cal = new Form2();
            cal.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().ToLower() == "yes")
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cal = new Form5();
            cal.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var cal = new Form7();
            cal.ShowDialog();
        }
    }
}
