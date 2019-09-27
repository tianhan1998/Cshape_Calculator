using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器
{
    public static class Power
    {
        public static int GetPower(char op)
        {
            switch(op)
            {
                case '+':return 1;
                case '-':return 1;
                case '*':return 2;
                case '/':return 2;
                case '%':return 2;
                case '(':return 3;
            }
            return -1;
        }
    }
}
