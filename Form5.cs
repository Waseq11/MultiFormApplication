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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string Path = Environment.CurrentDirectory + "/" + "MoneyExchange.txt";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked && radioButton6.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (radioButton1.Checked && radioButton8.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.703).ToString();
                }
                else if (radioButton1.Checked && radioButton10.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.656).ToString();
                }
                else if (radioButton1.Checked && radioButton9.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.577).ToString();
                }
                else if (radioButton1.Checked && radioButton7.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 5.044).ToString();
                }
                else if (radioButton2.Checked && radioButton6.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.408).ToString();
                }
                else if (radioButton2.Checked && radioButton8.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (radioButton2.Checked && radioButton10.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.928).ToString();
                }
                else if (radioButton2.Checked && radioButton9.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.809).ToString();
                }
                else if (radioButton2.Checked && radioButton7.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 107.673).ToString();
                }
                else if (radioButton3.Checked && radioButton6.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.516).ToString();
                }
                else if (radioButton3.Checked && radioButton8.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.076).ToString();
                }
                else if (radioButton3.Checked && radioButton10.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (radioButton3.Checked && radioButton9.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.871).ToString();
                }
                else if (radioButton3.Checked && radioButton7.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 115.944).ToString();
                }
                else if (radioButton4.Checked && radioButton6.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.739).ToString();
                }
                else if (radioButton4.Checked && radioButton8.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.234).ToString();
                }
                else if (radioButton4.Checked && radioButton10.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 1.146).ToString();
                }
                else if (radioButton4.Checked && radioButton9.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (radioButton4.Checked && radioButton7.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 132.944).ToString();
                }
                else if (radioButton5.Checked && radioButton6.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.013).ToString();
                }
                else if (radioButton5.Checked && radioButton8.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.00928).ToString();
                }
                else if (radioButton5.Checked && radioButton10.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.00862).ToString();
                }
                else if (radioButton5.Checked && radioButton9.Checked)
                {
                    textBox2.Text = (Convert.ToInt32(textBox1.Text) * 0.00752).ToString();
                }
                else if (radioButton5.Checked && radioButton7.Checked)
                {
                    textBox2.Text = textBox1.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton6.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" CAD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" CAD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString(),"Money Exchange Text File");
                stream.Close();
            }
            else if (radioButton1.Checked && radioButton8.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" CAD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" USD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton1.Checked && radioButton10.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" CAD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" EUR");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton1.Checked && radioButton9.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" CAD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" GBP");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton1.Checked && radioButton7.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" CAD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" YEN");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton2.Checked && radioButton6.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" USD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" CAD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton2.Checked && radioButton8.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" USD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" USD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton2.Checked && radioButton10.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" USD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" EUR");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton2.Checked && radioButton9.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" USD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" GBP");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton2.Checked && radioButton7.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" USD");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" YEN");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton3.Checked && radioButton6.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" EUR");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" CAD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton3.Checked && radioButton8.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" EUR");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" USD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton3.Checked && radioButton10.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" EUR");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" EUR");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton3.Checked && radioButton9.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" EUR");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" GBP");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton3.Checked && radioButton7.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" EUR");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" YEN");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton4.Checked && radioButton6.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" GBP");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" CAD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton4.Checked && radioButton8.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" GBP");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" USD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton4.Checked && radioButton10.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" GBP");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" EUR");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton4.Checked && radioButton9.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" GBP");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" GBP");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton4.Checked && radioButton7.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" GBP");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" YEN");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton5.Checked && radioButton6.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" YEN");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" CAD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton5.Checked && radioButton8.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" YEN");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" USD");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton5.Checked && radioButton10.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" YEN");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" EUR");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton5.Checked && radioButton9.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" YEN");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" GBP");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
            }
            else if (radioButton5.Checked && radioButton7.Checked)
            {
                StreamWriter sw = new StreamWriter(Path);
                string time = DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss tt");
                sw.Write(textBox1.Text);
                sw.Write(" YEN");
                sw.Write(" = ");
                sw.Write(textBox2.Text);
                sw.Write(" YEN");
                sw.Write(", ");
                sw.Write(time);
                sw.Close();
                string path = Path;
                StreamReader stream = new StreamReader(path);
                string filedata = stream.ReadToEnd();
                MessageBox.Show(filedata.ToString());
                stream.Close();
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
