using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class VISACard : Card
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id">账号</param>
        /// <param name="password">密码</param>
        /// <param name="address">开卡地址</param>
        /// <param name="money">金额</param>
        /// <param name="overMoney">透支额度</param>
        public VISACard(string id, string password, string address, decimal money, decimal overMoney) : base(id, password, address, money)
        {
            OverMoney = overMoney;
        }
        /// <summary>
        /// 信用额度
        /// </summary>
        public decimal OverMoney { get; set; }
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
                    payment = dollorExchange.ToRMB(payment); break;
                case "欧元":
                    payment = euroExchange.ToRMB(payment); break;
                case "英镑":
                    payment = poundExchange.ToRMB(payment); break;
                default:
                    break;
            }
            // 异地消费，扣除手续费
            if (!address.Equals(Address))
                payment = payment + payment * 0.01m;
            Money = decimal.Parse(zhanghu.e);
            Money = Money - payment;
            OverMoney = decimal.Parse(zhanghu.f);
            zhanghu.e = Money.ToString();
            if (Money < 0)
            {
                OverMoney = OverMoney - Money;
                zhanghu.f = OverMoney.ToString();
                Money = 0;
                zhanghu.e = "0";
            }
            MessageBox.Show($"消费成功，余额：{Money}");
        }
    }
}
