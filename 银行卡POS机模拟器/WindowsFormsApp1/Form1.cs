using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 让标签动起来
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = label1.Location.X - 1;
            int y = label1.Location.Y;
            if (x < (0 - label1.Width))
            {
                x = this.Width;
            }
            Point newPoint = new Point(x, y);
            label1.Location = newPoint;
        }

        public string Id { get; set; }
        public string Password { get; set; }
        /// <summary>
        /// 获取用户输入信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Id = textBox1.Text;
            Password = textBox2.Text;
            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("请输入账户！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("请输入密码！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(Id.Equals("runxin")&&Password.Equals("123"))//测试用账户
            {
                zhanghu.a = "runxin";
                zhanghu.b = "123";
                zhanghu.c = "VISA卡";
                zhanghu.d = "上海";
                zhanghu.e = "10000000000";
                zhanghu.f = "0";
                MessageBox.Show("欢迎进入POS机", "登录成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else if(Id.Equals(zhanghu.a) && Password.Equals(zhanghu.b))//用户注册账户
            {
                MessageBox.Show("欢迎进入POS机", "登录成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("账户或密码错误！", "警告", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 打开开户页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
        /// <summary>
        /// 鼠标移动到label4时变成手型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
