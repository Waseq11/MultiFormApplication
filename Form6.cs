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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        DateTime currentDateTime = DateTime.Now;
        string Path = Environment.CurrentDirectory + "/" + "Temperature.txt";
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Text = "F";
            }
            if (radioButton2.Checked == true)
            {
                label4.Text = "C";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = "C";
            }
            if (radioButton1.Checked == true)
            {
                label4.Text = "F";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Code for the radio button
            if(radioButton1.Checked == true)
            {   
                textBox2.Text = Convert.ToString((Convert.ToInt16(textBox1.Text) * 9 / 5) + 32); 
            }
            if(radioButton2.Checked == true)
            {
                textBox2.Text = Convert.ToString((Convert.ToInt16(textBox1.Text) - 32) * 5/9 );
            }

            //Code for the message box
            if (textBox1.Text == "100" || textBox2.Text == "212")
            {
                textBox3.Text = "Water Boils";
            }

            if (textBox1.Text == "40" || textBox2.Text == "104")
            {
                textBox3.Text = "Hot Bath";
            }

            if (textBox1.Text == "37" || textBox2.Text == "98.6")
            {
                textBox3.Text = "Body Temperature";
            }

            if (textBox1.Text == "30" || textBox2.Text == "86")
            {
                textBox3.Text = "Beach Weather";
            }

            if (textBox1.Text == "21" || textBox2.Text == "70")
            {
                textBox3.Text = "Room Temperature";
            }

            if (textBox1.Text == "10" || textBox2.Text == "50")
            {
                textBox3.Text = "Cool Day";
            }

            if (textBox1.Text == "0" || textBox2.Text == "32")
            {
                textBox3.Text = "Freezing Point Of Water";
            }

            if (textBox1.Text == "-18" || textBox2.Text == "0")
            {
                textBox3.Text = "Very Cold Day";
            }

            if (textBox1.Text == "-40" || textBox2.Text == "-40")
            {
                textBox3.Text = "Extremely Cold Day (and the Same Number!)";
            }

            //Code for the Text File
            FileStream fs = null;
            string filePath = Path;
            try
            {
                fs = new FileStream(Path, FileMode.Append);
                StreamWriter textOut = new StreamWriter(fs);
                textOut.WriteLine(textBox1.Text.Trim() + " " + "=" + " " + textBox2.Text.Trim() + " " + "," + " " + currentDateTime);
                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + "not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(Path + "not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally { if (fs != null) fs.Close(); }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

 
        }   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().ToLower() == "yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Path);
            MessageBox.Show(sr.ReadToEnd(), "Conversion Data - Mohammed Waseq");
            sr.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
