using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calci
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }
       

        int i = 0;
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "0";
                i = 1;
            }
            else
            {

                textBox1.Text += "0";
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "1";
                i = 1;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "2";
                i = 1;
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "3";
                i = 1;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "6";
                i = 1;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "5";
                i = 1;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "4";
                i = 1;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "9";
                i = 1;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "8";
                i = 1;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = "7";
                i = 1;
            }
            else
            {
                textBox1.Text += "7";
            }
        }
        double num1 = 0.0, num2 = 0.0;
        string op = "";
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                num1 = Convert.ToDouble(textBox1.Text);

                op = "+";
                string s = textBox1.Text;
                label1.Text = s + " " + op;
                i = 0;


            }

           

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                num1 = Convert.ToDouble(textBox1.Text);

                op = "-";
                string s = textBox1.Text;
                label1.Text = s + " " + op;
                i = 0;


            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                num1 = Convert.ToDouble(textBox1.Text);

                op = "×";
                string s = textBox1.Text;
                label1.Text = s + " " + op;
                i = 0;


            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text != ".")
            {
                num1 = Convert.ToDouble(textBox1.Text);

                op = "%";
                string s = textBox1.Text;
                label1.Text = s + " " + op;
                i = 0;


            }

        }
        double res = 0.0;
        private void buttonEquals_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox1.Text) && op != "" && textBox1.Text != ".")
            {
                num2 = Convert.ToDouble(textBox1.Text);
                if (op == "+")
                {
                    res = num1 + num2;

                }
                else if (op == "-")
                {
                    res = num1 - num2;

                }
                else if (op == "%")
                {    
                    if(num1 > num2 && num2==0)
                    { textBox1.Text = "Not Allowed";
                    
                        label1.Text = "Cannot Divide by Zero";

                    }
                    else
                    res = num1 / num2;

                }
                else if (op == "×")
                {
                    res = num1 * num2;

                }
                textBox1.Text = res.ToString();

            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0.0;
            num2 = 0.0;
            i = 0;
            label1.Text = "";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                textBox1.Text = ".";
                i = 1;
            }
            else if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

    }
}
