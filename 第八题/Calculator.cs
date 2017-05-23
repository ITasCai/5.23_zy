using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八题
{
/// <summary>
/// 计算器类
/// </summary>
    class Calculator
    {
        private double num1;
        private char operators;
        private double num2;


        /// <summary>
        /// 计算机类的构造寒素
        /// </summary>
        /// <param name="num1">第一个操作数</param>
        /// <param name="operators">操作符</param>
        /// <param name="num2">第二个操作数</param>
        public Calculator(double num1,char operators,double num2) {
            this.num1 = num1;
            this.operators = operators;
            this.num2 = num2;
        }
        /// <summary>
        /// 第一个操作数
        /// </summary>
        public double Num1
        {
            get
            {
                return num1;
            }

            set
            {
                num1 = value;
            }
        }
        /// <summary>
        /// 第二个操作数
        /// </summary>
        public double Num2
        {
            get
            {
                return num2;
            }

            set
            {
                num2 = value;
            }
        }

        /// <summary>
        /// 操作符
        /// </summary>
        public char Operators
        {
            get
            {
                return operators;
            }

            set
            {
                operators = value;
            }
        }

        /// <summary>
        /// 计算结果
        /// </summary>
        public void Result() {
            switch (operators)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}",num1,num2,num1+num2);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", num1, num2, num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("{0}x{1}={2}", num1, num2, num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", num1, num2, num1 / num2);
                    break;
                default:
                    break;
            }
        }
    }
}
