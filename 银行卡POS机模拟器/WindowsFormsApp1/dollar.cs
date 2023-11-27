using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 美元
    /// </summary>
    public class dollar : IExchangeMoney
    {
        decimal rate = 7.0m;
        /// <summary>
        /// 美元转换为人民币
        /// </summary>
        /// <param name="value">转换金额</param>
        /// <returns></returns>
        public decimal ToRMB(decimal value)
        {
            return rate * value;
        }
    }
}
