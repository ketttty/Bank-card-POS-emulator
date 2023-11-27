using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Card yinlianCard;
        Card xinyongCard;
        Card visaCard;
        /// <summary>
        /// 付款事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string address = radioButton1.Checked ? "北京" : "上海";
            decimal money = numericUpDown1.Value;
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("请选择付款币种");
                return;
            }
            else if (zhanghu.c == comboBox1.Text)
            {
                switch (comboBox1.Text)
                {
                    case "银联卡":
                        yinlianCard.Payment(money, address, comboBox2.Text);
                        break;
                    case "信用卡":
                        xinyongCard.Payment(money, address, comboBox2.Text);
                        break;
                    case "VISA卡":
                        visaCard.Payment(money, address, comboBox2.Text);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("未查询到此账户！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// 加载用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            if (zhanghu.c == "信用卡")
            {
                xinyongCard = new XinyongCard(zhanghu.a, zhanghu.b, zhanghu.d, decimal.Parse(zhanghu.e), decimal.Parse(zhanghu.f));
            }
            else if (zhanghu.c == "银联卡")
            {
                yinlianCard = new YinglianCard(zhanghu.a, zhanghu.b, zhanghu.d, decimal.Parse(zhanghu.e));
            }
            else if (zhanghu.c == "VISA卡")
            {
                visaCard = new VISACard(zhanghu.a, zhanghu.b, zhanghu.d, decimal.Parse(zhanghu.e), 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
