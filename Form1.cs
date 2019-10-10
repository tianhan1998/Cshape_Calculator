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
using System.IO;

namespace 计算器
{
    public partial class Form1 : Form
    {
        private int leftb = 0;
        private int rightb = 0;
        bool divideZero = false;
        private Stack<decimal> digit = new Stack<decimal>();
        private Stack<char> oper = new Stack<char>();
        private string back = "";
        private string mid = "";
        [DllImport("user32", EntryPoint = "HideCaret")]
        private static extern bool HideCaret(IntPtr hWnd);
        public void MidToBack()
        {
            mid = alldisplay.Text;
            for(int i = 0; i < mid.Length; i++)
            {
                if (char.IsDigit(mid[i]))
                {
                    string digit = "" + mid[i];
                    int j = i;
                    while (j<mid.Length-1&&(char.IsDigit(mid[++j])||mid[j]=='.'))
                        digit += mid[j];
                    back += digit+' ';
                    i = j-1;
                    if (j == mid.Length - 1)
                        break;
                }
                else
                {
                    if (oper.Count == 0 || mid[i]=='(' ||Power.GetPower(oper.Peek()) < Power.GetPower(mid[i]))
                    {
                        oper.Push(mid[i]);
                    }
                    else if (mid[i] == ')')
                    {
                        while (oper.Peek() != '(')
                        {
                            back += oper.Pop();
                        }
                        oper.Pop();
                    }
                    else if(Power.GetPower(oper.Peek()) >= Power.GetPower(mid[i])&&oper.Peek()!='(')
                    {
                        while (oper.Count!=0&&(Power.GetPower(oper.Peek()) >= Power.GetPower(mid[i]))&&oper.Peek()!='(')
                        {
                            back += oper.Pop();
                        }
                        oper.Push(mid[i]);
                    }
                    else
                    {
                        oper.Push(mid[i]);
                    }
                }
            }
            while (oper.Count != 0)
            {
                if (oper.Peek() != '(')
                    back += oper.Pop();
                else
                    oper.Pop();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
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
            else  display.Text = "1";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            digit.Clear();
            oper.Clear();
            back = "";
            mid = "";
            display.Text = "0";
            alldisplay.Clear();
            leftb = 0;
            rightb = 0;
            divideZero = false;
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
            if (display.Text.Length != 0&&display.Text!="0")
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
        private void Multiply_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text + "*";
            display.Text = "0";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text + "÷";
            display.Text = "0";
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text + "-";
            display.Text = "0";
        }
        private void Mod_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text + "%";
            display.Text = "0";
        }
        private void Plus_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text + "+";
            display.Text = "0";
        }
        private void CalStack()//栈计算操作
        {
            for (int i = 0; i < back.Length; i++)
            {
                if (char.IsDigit(back[i]))
                {
                    string digits = "" + back[i];
                    int j = i;
                    while (j+1 < back.Length && (char.IsDigit(back[++j])||back[j]=='.'))
                        digits += back[j];
                    i = j;
                    digit.Push(decimal.Parse(digits));
                    if (i == back.Length - 1)
                        break;
                }
                else
                {
                    decimal right = digit.Pop();
                    decimal left = digit.Pop();
                    char opers = back[i];
                    decimal answer=-1;
                    try
                    {
                        switch (opers)
                        {
                            case '+': answer = left + right; break;
                            case '-': answer = left - right; break;
                            case '*': answer = left * right; break;
                            case '÷': answer = left / right; break;
                            case '%': answer = left % right; break;
                        }
                    }
                    catch (DivideByZeroException e)
                    {
                        MessageBox.Show("尝试除以零", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        divideZero = true;
                        return;
                    }
                    digit.Push(answer);
                }
            }
            display.Text = digit.Pop().ToString();
        }

        private void PartMatch()
        {
            int time = leftb - rightb;
            for (int i = 0; i < time; i++)
                alldisplay.Text += ')';
        }
        private void Equals_Click(object sender, EventArgs e)
        {
            alldisplay.Text += display.Text;
            PartMatch();
            MidToBack();
            CalStack();
            alldisplay.Text += '=';
            if (divideZero)
            {
                clear.PerformClick();
                return;
            }
            memoryStack.Text += alldisplay.Text + "\r\n" + display.Text + "\r\n\r\n";
            clear.PerformClick();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (display.TextLength > 1)
            {
                display.Text = display.Text.Substring(0, display.TextLength - 1);
            }
            else
            {
                display.Text = "0";
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (rightb < leftb)
            {
                rightb++;
                alldisplay.Text += display.Text + ")";
                display.Text = "";
                if (divideZero)
                {
                    clear.PerformClick();
                    return;
                }
            }
        }

        private void Left_Click(object sender, EventArgs e)
        {
            leftb++;
            alldisplay.Text += "(";
            display.Text = "0";
        }

        private void Pow3_Click(object sender, EventArgs e)
        {
            display.Text = Math.Pow((double)decimal.Parse(display.Text), 3).ToString();
        }

        private void Pow2_Click(object sender, EventArgs e)
        {
            display.Text = Math.Pow((double)decimal.Parse(display.Text), 2).ToString();
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            display.Text = Math.Sqrt((double)decimal.Parse(display.Text)).ToString();

        }
        private decimal Calculate()//'='算到头
        {
            while (digit.Count() >= 2)
            {
                CalStack();
                if (divideZero)
                    return -1;
            }
            return digit.Pop();
        }


        private void 保存记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "文本文件|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFile.FileName);
                streamWriter.Write(memoryStack.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void 载入记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "文本文件|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(openFile.FileName);
                memoryStack.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            if (oper.Count != 0)
                op.Text = oper.Peek().ToString();
            else
                op.Text = "";
        }
    }
}
