﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project30
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }   
            textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            if (button15.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button15.Text;
                }   
            }else
                textBox1.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        public void compute()
        {   //Code for Operations
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {   
            //Code for = button
            compute();
            label1.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo).ToString().ToLower() == "yes")
            {
                this.Close();
            }
        }
    }
}
