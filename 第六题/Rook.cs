using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第六题
{
    /// <summary>
    /// 车类
    /// </summary>
    class Rook
    {
        private int count;
        private double velocity;
        private double payload;
        private string type;

        /// <summary>
        /// 轮胎的个数
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        /// <summary>
        /// 最高速度
        /// </summary>
        public double Velocity
        {
            get
            {
                return velocity;
            }

            set
            {
                velocity = value;
            }
        }

        /// <summary>
        /// 载重量
        /// </summary>
        public double Payload
        {
            get
            {
                return payload;
            }

            set
            {
                payload = value;
            }
        }

        /// <summary>
        /// 载物类型
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        /// <summary>
        /// 加速的方法
        /// </summary>
        public virtual void speedUp() {

        }
    }
}
