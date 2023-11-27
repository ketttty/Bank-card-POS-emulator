using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 开户信息
    /// </summary>
    public struct zhanghu//存放注册的账户信息
    {
        public static string a;//账户
        public static string b;//密码
        public static string c;//卡类
        public static string d;//地址
        public static string e;//余额
        public static string f;//信用额度
    }
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
