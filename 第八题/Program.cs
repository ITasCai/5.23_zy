using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第八题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8: 设计一个计算器应用程序，能够完成基本的加、减、乘、除操作。要求：（1）使用面向对象思想使程序具有良好的扩展性，以适应未来的变化，比如未来可能要增加取余操作、自身加1操作、三元操作符运算等。（2）在增加新功能时，尽可能不影响原有代码。

            Console.WriteLine("请输入第一个操作数：");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入操作符:");
            char operators = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("请输入第二个操作数：");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Calculator c = new Calculator(num1, operators,num2);
            c.Result();
            Console.ReadLine();

            #endregion
        }
    }
}
