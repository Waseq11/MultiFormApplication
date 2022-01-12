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
using System.Text.RegularExpressions;
namespace Project30
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("MMMM-dd-yy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool test = false;
            Regex myRegex = new Regex(@"^(192)([\.])([0-9])([0-9])([0-9])([\.])([0-9])([\.])([0-9])([0-9])");
            test = myRegex.IsMatch(textBox1.Text.Trim());
            if (test)
            {
                MessageBox.Show(textBox1.Text + "   " + "The IP is Correct", "Valid IP");
            }
            else
            {
                MessageBox.Show("The IP must have 4 bytes integer number between 0 to 255 seperated by a dot(255.255.255.255)","Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().ToLower() == "yes")
            {
                this.Close();
            }
        }
    }
}
