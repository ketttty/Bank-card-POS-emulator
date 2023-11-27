using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 货币换算接口
    /// </summary>
    public interface IExchangeMoney
    {
        /// <summary>
        /// 货币换算
        /// </summary>
        /// <param name="value">金额</param>
        /// <returns></returns>
        decimal ToRMB(decimal value);
    }
}
