using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        int time = 60;//记录时间
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int yanzhengma = ran.Next(1000, 10000);
            label9.Text = yanzhengma.ToString();//用一个不可见的label控件存储随机获取的验证码
            if (textBox2.Text.Length != 11 || int.TryParse(textBox2.Text, out _) || "1".Equals(textBox2.Text[0]))//判断输入的手机号是否为11位、纯数字，开头是否为1
                MessageBox.Show("请输入正确的手机号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                MessageBox.Show("验证码为" + yanzhengma, "提示", MessageBoxButtons.OK, MessageBoxIcon.None);
                button1.Visible = false;
                timer1.Enabled = true;
                label10.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// 重新获取验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time >= 0)
                label10.Text = time + "秒后重新获取验证码";
            else
            {
                label10.Visible = false;
                timer1.Enabled = false;
                button1.Visible = true;
                time = 60;
                label10.Text = "60秒后重新获取验证码";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 开户事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 11 || int.TryParse(textBox2.Text, out _) || "1".Equals(textBox2.Text[0]))//判断输入的手机号是否为11位、纯数字，开头是否为1
                MessageBox.Show("请输入正确的手机号！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
            {
                zhanghu.a = textBox1.Text;//存放注册的用户名
                if (textBox3.Text.Length < 8 || textBox3.Text.IndexOf(" ") > 0)//判断密码不能低于8位，不能有空格
                {
                    MessageBox.Show("密码不能低于8位或密码中含有空格！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    zhanghu.b = textBox3.Text;//存放注册的密码
                    if (textBox4.Text != textBox3.Text)
                    {
                        MessageBox.Show("两次输入的密码不相同！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(comboBox1.Text))
                        {
                            MessageBox.Show("请选择付款币种");
                            return;
                        }
                        else
                        {
                            zhanghu.c = comboBox1.Text;
                            if(!(radioButton1.Checked|| radioButton2.Checked))
                            {
                                MessageBox.Show("请选择开户地");
                            }
                            else
                            {
                               zhanghu.d = radioButton1.Checked ? "北京" : "上海";
                                if(string.IsNullOrEmpty(comboBox2.Text))
                                {
                                    MessageBox.Show("不支持无金额开户！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                                else
                                {
                                    zhanghu.e = comboBox2.Text;
                                    zhanghu.f=textBox6.Text;
                                    if (textBox5.Text == label9.Text)
                                    {
                                        MessageBox.Show("开户成功！", "开户成功", MessageBoxButtons.OK, MessageBoxIcon.None);
                                        this.Hide();
                                        Form1 form = new Form1();
                                        form.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("验证码不正确！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 开户金额支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessStartInfo f = new ProcessStartInfo(@"收款码.jpg");
            Process p = new Process();
            p.StartInfo = f;
            p.Start();
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        /// <summary>
        /// 信用卡申请信用额度
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text.Equals("信用卡"))
            {
                label12.Visible = true;
                textBox6.Visible = true;
            }
            else
            {
                label12.Visible = false;
                textBox6.Visible = false;
            }
        }
    }
}
    