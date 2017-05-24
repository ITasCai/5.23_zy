using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十题
{
    /// <summary>
    /// 自行车类
    /// </summary>
    class Bike : Vehicle
    {
        /// <summary>
        /// 实现开始功能（自行车）
        /// </summary>
        public void start()
        {
            Console.WriteLine("我是自行车，我要开始行使了！");
        }
        /// <summary>
        /// 实现结束功能（自行车）
        /// </summary>
        public void stop()
        {
            Console.WriteLine("我是自行车，我结束不了行使！"); ;
        }
    }
}
