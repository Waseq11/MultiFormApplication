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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DateTime currentDateTime = DateTime.Now;
        string Path = Environment.CurrentDirectory + "/" + "Lotto649.txt";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 49);
            textBox1.Text = randomNumber.ToString();
            for (int i = 1; i <= 6; i++)
            {
                randomNumber = random.Next(1, 49);
                textBox1.Text = textBox1.Text + "," + randomNumber.ToString();
            }
            {

                FileStream fs = null;
                string filePath = Path;
                try
                {
                    fs = new FileStream(Path, FileMode.Append);
                    StreamWriter textOut = new StreamWriter(fs);
                    textOut.WriteLine("Max" + ";" + currentDateTime + ";" + textBox1.Text.Trim());
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().ToLower() == "yes")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Path);
            MessageBox.Show(sr.ReadToEnd(), "Lotto 649 Numbers in the Text File");
            sr.Close();
        }
    }
}
