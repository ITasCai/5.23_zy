using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    /// <summary>
    /// 自行车类
    /// </summary>
    class Bicycle:Rook
    {
        /// <summary>
        /// 重写父类的加速方法
        /// </summary>
        public override void speedUp()
        {
            Console.WriteLine("要啥自行车？");

        }
    }
}
