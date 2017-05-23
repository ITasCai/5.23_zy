using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3：编写一个类Books，代表教材：具有属性：名称（title）、页数（pageNum）、类型（type） 具有方法：detail，用来在控制台输出每本教材的名称、页数、类型      具有两个带参构造方法：第一个构造方法中，设置教材类型为“计算机”（固定）， 其余属性的值由参数给定；第二个构造方法中，所有属性的值都由参数给定分别以两种方式完成对两个Book对象的初始化工作，并分别调用它们的detail方法，看看输出是否正确

            Console.WriteLine("请输入教材的名称：");
            string title = Console.ReadLine();
            Console.WriteLine("请输入教材的页数：");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入教材的类型：");
            string type = Console.ReadLine();
            Books b1 = new Books(title,pageNum);
            b1.Detail();


            //Books b2 = new Books(title, pageNum,type);
            //b2.Detail();

            Console.ReadKey();



            #endregion
        }
    }
}
