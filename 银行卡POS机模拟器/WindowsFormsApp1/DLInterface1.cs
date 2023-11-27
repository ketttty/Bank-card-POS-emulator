using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 银行卡登录验证
    /// </summary>
    public class DLinterface : YZinterface
    {
        /// <summary>
        /// 银行卡信息验证接口
        /// </summary>
        /// <param name="card">银行卡</param>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool Validate(Card card, string id, string password)
        {
            if (card == null) return false;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password))
                return false;
            if (string.IsNullOrEmpty(card.Id) || string.IsNullOrEmpty(card.Password)) return false;
            return card.Id.Equals(id) && card.Password.Equals(password);
        }
    }
}
