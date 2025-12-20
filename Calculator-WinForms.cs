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

         private void  EnterNumber()
        {
            if (int.TryParse(textBox1.Text, out int value) && IsSecondNum == false)
            {
                num1 = value;
                IsSecondNum = true;
            }
            else if(int.TryParse(textBox1.Text, out int value1) && IsSecondNum == true)
            {
                num2 = value1;
            }
        }

        void SetOp(Button btn)
        {
            EnterNumber();

            if (btn == AddOP)
            {
                Operation = op.Add;
                textdisplay = num1 + " + ";
            }
            else if (btn == SubstructOP)
            {
                Operation = op.Sub;
                textdisplay = num1 + " - ";
            }
            else if (btn == MultiOP)
            {
                Operation = op.Mul;
                textdisplay = num1 + " * ";
            }
            else if (btn == divOP)
            {
                Operation = op.Div;
                textdisplay = num1 + " / ";
            }

            textBox1.Text = textdisplay;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = string.Empty;
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
        string GetOpSymbol()
        {
            switch (Operation)
            {
                case op.Add:
                    return "+";
                case op.Sub:
                    return "-";
                case op.Mul:
                    return "*";
                case op.Div:
                    return "/";
                default:
                    return "";
            }
        }

        private void Equalbtn_Click(object sender, EventArgs e)
        {
            string[] parts = textdisplay.Split(' ');

            if (parts.Length < 3) return;

            num2 = int.Parse(parts[2]);

            int result = 0;

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
                    if (num2 == 0)
                    {
                        textBox1.Text = "Error";
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            textBox1.Text = $"{num1} {GetOpSymbol()} {num2} = {result}";

            num1 = result;
            num2 = 0;
            IsSecondNum = false;
            Operation = op.NotSelectedYet;
            textdisplay = result.ToString();
        }

    }
}
