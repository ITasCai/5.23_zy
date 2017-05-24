using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    /// <summary>
    /// 山地车类
    /// </summary>
    class MTB:Rook
    {
        /// <summary>
        /// 山地车的独立方法，用于信息的输出
        /// </summary>
        public  void show()
        {
            Console.WriteLine("骑上山地车，腰也不酸了，腿也不疼了，能参加比赛了！");
                    
        }
        /// <summary>
        /// 调用直行车类中的加速方法
        /// </summary>
        public void GetBicycle() {
            Rook r = new Bicycle();
            r.speedUp();
        }
    }
}
