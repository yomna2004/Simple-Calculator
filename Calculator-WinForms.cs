using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        bool IsSecondNum = false;
        string textdisplay = "";
        enum op { Add, Sub, Mul, Div, NotSelectedYet };
        op Operation = op.NotSelectedYet;
        public Form1()
        {
            InitializeComponent();
        }
        void PrintNum(Button btn)
        {
            textdisplay += btn.Text;
            textBox1.Text = textdisplay;
        }
        void SetOp(Button btn)
        {
            if (btn == AddOP)
            {
                Operation = op.Add;
               textBox1.Text = textdisplay = "";

            }
            if (btn == SubstructOP)
            {
                Operation = op.Sub;
               textBox1.Text = textdisplay = "";

            }
            if (btn == MultiOP)
            {
                Operation = op.Mul;
                textBox1.Text = textdisplay = "";

            }
            if (btn == divOP)
            {
                Operation = op.Div;
                textBox1.Text = textdisplay = "";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            PrintNum((Button)sender);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetOp(divOP);
        }

        private void x_Click(object sender, EventArgs e)
        {
            SetOp(MultiOP);
        }

        private void AddOP_Click(object sender, EventArgs e)
        {
            SetOp(AddOP);
        }

        private void Substruct_Click(object sender, EventArgs e)
        {
            SetOp(SubstructOP);
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value) && IsSecondNum == false)
            {
                num1 = value;
                IsSecondNum = true;
            }
            else if (int.TryParse(textBox1.Text, out int value2) && IsSecondNum == true)
            {
                num2 = value2;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintNum(button6);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = textdisplay = "";
            num1 = 0;
            num2 = 0;
            Operation = op.NotSelectedYet;
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(textBox1.Text, out int value))
            {
                num2 = value;

                switch (Operation)
                {
                    case op.Add:
                        result = num1 + num2;
                        break;
                    case op.Sub:
                        result = num1 - num2;
                        break;
                    case op.Mul:
                        result = num1 * num2;
                        break;
                    case op.Div:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            return;
                        }
                        break;
                }

                textBox1.Text = result.ToString();
                num1 = result;
                num2 = 0;
                IsSecondNum = false;
                Operation = op.NotSelectedYet;
                textdisplay = result.ToString();
            }
        }
    }
}
