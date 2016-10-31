using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //puts numbers into textbox when clicked


        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        //SEE 0 AT BOTTOM OF CODE

        //clears textbox
        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        //stores what the user clicked
        private void bAdd_Click(object sender, EventArgs e)
        {
            b1.Tag = "+";
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            b1.Tag = "-";
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            b1.Tag = "*";
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            b1.Tag = "/";
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        private void bPow_Click(object sender, EventArgs e)
        {
            b1.Tag = "^";//to the power of
            textBox1.Tag = textBox1.Text;
            textBox1.Text = "";
        }

        //preforms opperations when = button is clicked
        private void bE_Click(object sender, EventArgs e)
        {
            try
            {
                if (b1.Tag.Equals("+"))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) + Convert.ToDouble(textBox1.Text));
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
                else if (b1.Tag.Equals("-"))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) - Convert.ToDouble(textBox1.Text));
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
                else if (b1.Tag.Equals("*"))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) * Convert.ToDouble(textBox1.Text));
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
                else if (b1.Tag.Equals("/"))
                {
                    textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Tag) / Convert.ToDouble(textBox1.Text));
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
                else if (b1.Tag.Equals("^"))
                {
                    textBox1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Tag), Convert.ToDouble(textBox1.Text)));
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
                else
                {
                    MessageBox.Show("please select a opperator");
                    textBox1.Tag = "";
                    b1.Tag = "";
                }
            }
            catch
            {
                MessageBox.Show("please only type in numbers");
            }
        }

        //if the user clicks the sqr root button
        private void bSqrR_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
            }
            catch
            {
                MessageBox.Show("please type a number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}