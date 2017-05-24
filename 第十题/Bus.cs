using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十题
{
    /// <summary>
    /// 公共汽车类
    /// </summary>
    class Bus : Vehicle
    {
        /// <summary>
        /// 实现开始功能（公共汽车）
        /// </summary>
        public void start()
        {
            Console.WriteLine("我是公共汽车，我要开始行使了！");
        }

        /// <summary>
        /// 实现结束功能（公共汽车）
        /// </summary>
        public void stop()
        {
            Console.WriteLine("我是公共汽车，我结束不了行使！"); ;
        }
    }
}
