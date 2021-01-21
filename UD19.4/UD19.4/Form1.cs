using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD19._4
{
    public partial class Form1 : Form
    {
        double num = 0;
        double op = 0;
        string simb = "";

        bool punto = false;
        bool isOp = false;
        bool nuevaOp = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "1";
            }
            else
            {
                richTextBox1.Text += "1";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "0";
            }
            else
            {
                richTextBox1.Text += "0";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "2";
            }
            else
            {
                richTextBox1.Text += "2";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "3";
            }
            else
            {
                richTextBox1.Text += "3";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "4";
            }
            else
            {
                richTextBox1.Text += "4";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "5";
            }
            else
            {
                richTextBox1.Text += "5";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "6";
            }
            else
            {
                richTextBox1.Text += "6";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "7";
            }
            else
            {
                richTextBox1.Text += "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "8";
            }
            else
            {
                richTextBox1.Text += "8";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }

            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "9";
            }
            else
            {
                richTextBox1.Text += "9";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (nuevaOp)
            {
                Reset();
            }

            if (isOp)
            {
                Operacion();
            }
            if (!punto)
            {
                richTextBox1.Text += ",";
            }
            punto = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            simb = "+";

            isOp = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            simb = "-";

            isOp = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            simb = "*";

            isOp = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            simb = "/";

            isOp = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operacion();
            richTextBox1.Text = Convert.ToString(op);

            nuevaOp = true;
        }

        public void Reset()
        {
            nuevaOp = false;
            punto = false;
            simb = "";
            op = 0;
            richTextBox1.Text = "0";
        }

        public void Operacion()
        {
            num = Convert.ToDouble(richTextBox1.Text);
            punto = false;

            if (op != 0)
            {
                switch (simb)
                {
                    case "+":
                        op += num;
                        break;
                    case "-":
                        op -= num;
                        break;
                    case "*":
                        op *= num;
                        break;
                    case "/":
                        op /= num;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                op = num;
            }

            richTextBox1.Text = "0";
            isOp = false;
        }
    }
}
