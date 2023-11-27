using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = zhanghu.a;
            label7.Text = zhanghu.c;
            label9.Text = zhanghu.d;
            label11.Text = zhanghu.e;
            if(zhanghu.c=="信用卡")
            {
                label12.Visible = true;
                label13.Visible = true;
                label13.Text = zhanghu.f;
            }
            if (zhanghu.c == "VISA卡")
            {
                label5.Visible = true;
                label13.Visible = true;
                label13.Text = zhanghu.f;
            }
        }
        /// <summary>
        /// 向银行卡内转账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo f=new ProcessStartInfo(@"收款码.jpg");
            Process p=new Process();
            p.StartInfo = f;
            p.Start();
            Thread.Sleep(10000);
            MessageBox.Show("成功向银行卡转入100元", "充值成功",MessageBoxButtons.OK, MessageBoxIcon.None);
            decimal m = decimal.Parse(zhanghu.e);
            m += 100;
            zhanghu.e=m.ToString();
            label11.Text = zhanghu.e;
        }
        /// <summary>
        /// 关闭当前窗体，打开上一个窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }
    }
}
