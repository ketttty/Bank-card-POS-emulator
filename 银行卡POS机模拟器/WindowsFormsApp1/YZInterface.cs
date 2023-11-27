using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 银行卡信息验证接口
    /// </summary>
    public interface YZinterface
    {
        /// <summary>
        /// 银行卡信息验证
        /// </summary>
        /// <param name="card">银行卡信息</param>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        bool Validate(Card card, string id, string password);
    }
}
