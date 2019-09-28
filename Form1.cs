using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace 计算器
{
    public partial class Form1 : Form
    {
        private int leftb = 0;
        private int rightb = 0;
        private Stack<decimal> digit = new Stack<decimal>();
        private Stack<char> oper = new Stack<char>();
        [DllImport("user32", EntryPoint = "HideCaret")]
        private static extern bool HideCaret(IntPtr hWnd);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Divide_Click(object sender, EventArgs e)
        {

        }

        private void Display_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(((TextBox)sender).Handle);
        }

        private void Op_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(((TextBox)sender).Handle);
        }

        private void MemoryStack_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(((TextBox)sender).Handle);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "1";
            else display.Text = "1";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            digit.Clear();
            oper.Clear();
            display.Text = "0";
            alldisplay.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "2";
            else display.Text = "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "3";
            else display.Text = "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "4";
            else display.Text = "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "5";
            else display.Text = "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "6";
            else display.Text = "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "7";
            else display.Text = "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "8";
            else display.Text = "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
                display.Text += "9";
            else display.Text = "9";
        }

        private void Negative_Click(object sender, EventArgs e)
        {
            if (display.Text.Length != 0)
            {
                if (display.Text[0] != '-')
                {
                    display.Text = "-" + display.Text;
                }
                else
                {
                    display.Text = display.Text.Substring(1);
                }
            }
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (display.Text.Length != 0)
            {
                if (display.Text.IndexOf('.') == -1)
                {
                    display.Text += '.';
                }
            }
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (display.Text != "0")
            {
                display.Text += "0";
            }

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            digit.Push(decimal.Parse(display.Text));
            oper.Push('+');
            alldisplay.Text += display.Text + "+";
            display.Text = "0";
            if (Power.GetPower(oper.Peek()) > Power.GetPower('+'))
            {
                display.Text = CalculateOne('+').ToString();
            }
        }
        private decimal CalculateOne(char now)//计算一次符号（符号栈遇到比自己权值更大的）
        {
            decimal left = digit.Pop();
            char op = oper.Pop();
            decimal right = digit.Pop();
            decimal answer = 0;
            switch (op)
            {
                case '+': answer = left + right; break;
                case '-': answer = left - right; break;
                case '*': answer = left * right; break;
                case '/': answer = left / right; break;
                case '%': answer = left % right; break;
            }
            digit.Push(answer);
            oper.Push(now);
            return answer;
        }
        private decimal CalculatePart()
        {
            while (oper.Peek() != '(')
            {
                CalStack();
            }
            oper.Pop();
            leftb--;
            rightb--;
            return digit.Pop();
        }
        private void CalStack()
        {
                decimal left = digit.Pop();
                char op = oper.Pop();
                decimal right = digit.Pop();
                decimal answer = 0;
                switch (op)
                {
                    case '+': answer = left + right; break;
                    case '-': answer = left - right; break;
                    case '*': answer = left * right; break;
                    case '/': answer = left / right; break;
                    case '%': answer = left % right; break;
                }
                digit.Push(answer);
        }
        private decimal Calculate()
        {
            while (digit.Count() >= 2)
            {
                CalStack();
            }
            return digit.Pop();
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            digit.Push(decimal.Parse(display.Text));
            alldisplay.Text += display.Text + "=";
            display.Text=Calculate().ToString();
            memoryStack.Text += alldisplay.Text + "\r\n" + display.Text+"\r\n\r\n";
            clear.PerformClick();
        }

        private void Backspce_Click(object sender, EventArgs e)
        {
            if (display.TextLength > 1)
            {
                display.Text=display.Text.Substring(0, display.TextLength - 1);
            }
            else
            {
                display.Text = "0";
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if(rightb<leftb)
            {
                rightb++;
                alldisplay.Text += display.Text+")";
                digit.Push(decimal.Parse(display.Text));
                display.Text=CalculatePart().ToString();
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            leftb++;
            alldisplay.Text += "(";
            oper.Push('(');
        }
    }
}
