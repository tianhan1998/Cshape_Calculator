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
    }
}
