using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{  /// <summary>
   /// 普通银行卡抽象类，本身没任何功能
   /// </summary>
    public abstract class Card
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <param name="address">开卡地址</param>
        /// <param name="money">余额</param>
        public Card(string id, string password, string address, decimal money)
        {
            Id = id;
            Password = password;
            Address = address;
            Money = money;
        }
        YZinterface cardValidate = new DLinterface();
        protected IExchangeMoney dollorExchange = new dollar();
        protected IExchangeMoney euroExchange = new Euro();
        protected IExchangeMoney poundExchange = new Pound();
        /// <summary>
        /// 账号
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 办卡地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 付款方法
        /// </summary>
        /// <param name="money">金额</param>
        /// <param name="address">开卡地址</param>
        /// <param name="kind">货币种类</param>
        public abstract void Payment(decimal money, string address, string kind);

        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        private bool ValidateLogin(string id, string password)
        {
            return cardValidate.Validate(this, id, password);
        }
    }
}
