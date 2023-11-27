using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 英镑
    /// </summary>
    public class Pound : IExchangeMoney
    {
        decimal rate = 8.7m;
        /// <summary>
        /// 欧元转换为人民币
        /// </summary>
        /// <param name="value">转换金额</param>
        /// <returns></returns>
        public decimal ToRMB(decimal value)
        {
            return rate * value;
        }
    }
}
