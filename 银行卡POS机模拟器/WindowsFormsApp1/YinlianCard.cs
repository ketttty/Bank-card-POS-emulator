using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 银联卡类
    /// </summary>
    public class YinglianCard : Card
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <param name="address">地址</param>
        /// <param name="money">金额</param>
        public YinglianCard(string id, string password, string address, decimal money) : base(id, password, address, money) { }
        /// <summary>
        /// 付款方法
        /// </summary>
        /// <param name="money">消费金额</param>
        /// <param name="address">消费地址</param>
        /// <param name="kind">币种</param>
        public override void Payment(decimal money, string address, string kind)
        {
            decimal payment = money;
            switch (kind)
            {
                case "人民币":
                    break;
                case "美元":
                case "欧元":
                case "英镑":
                    MessageBox.Show("银联卡无法进行国际货币支付");
                    return;
                default:
                    break;
            }
            // 异地消费，扣除手续费
            if (!address.Equals(Address))
                payment = payment + payment * 0.01m;
            Money = decimal.Parse(zhanghu.e);
            if (Money < payment)
            {
                MessageBox.Show("金额不足");
                return;
            }
            Money = Money - payment;
            MessageBox.Show($"消费成功，余额：{Money}");
        }
    }
}
