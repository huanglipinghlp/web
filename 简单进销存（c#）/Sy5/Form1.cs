using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Sy5
{
    public partial class Form1 : Form
    {
        /**
         * 变量*****************************************************************************
         * */
     // private string mstrID = "";
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
      
        public Form1()
        {
            InitializeComponent();
        }
        public static string MD5(string strText)
        {
            string strResult = "";
            // 加密密钥
            char[] keys = { '3', 'e', 'd', 'c', '1', 'q', 'a', 'z', '7', 'u', 'j', 'm', '5', 't', 'g', 'z' };
            // 获取字符串	
            byte[] source = Encoding.UTF8.GetBytes(strText);
            MD5CryptoServiceProvider MD5CSP = new MD5CryptoServiceProvider();
            // MD5的计算结果是一个128位的长整数，用字节表示就是16个字节
            byte[] tmp = MD5CSP.ComputeHash(source);
            // 每个字节用16进制表示所以表示成16进制需要32个字符    
            char[] str = new char[16 * 2];
            // 表示转换结果中对应的字符位置		        
            int k = 0;
            // 循环	                                
            for (int i = 0; i < 16; i++)
            {
                // 取第i个字节
                byte byte0 = tmp[i];
                // 取字节中高4位的数字转换,>>> 为补零右移(即无符号)                str[k++] = keys[byte0 >> 4 & 0xf]; 
                // 取字节中低4位的数字转换	   
                str[k++] = keys[byte0 & 0xf];
            }
            // 换后的结果转换为字符串
            strResult = new String(str);
            return strResult;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strUserName = "";
            string strPWD = "";

            strUserName = textBox1.Text.Trim();
            strPWD = textBox2.Text.Trim();
            var model = db.LoginUser.FirstOrDefault(m=>m.name==strUserName);
            if (model == null)
            {
                IbMessage.Text = "用户名不存在";
                IbMassage2.Text = "";
            }
            else
            {
                if (strPWD == model.password)
                {
                    IbMassage2.Text = "";
                    IbMessage.Text = "";
                    MessageBox.Show("验证成功！");
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    IbMassage2.Text = "密码错误!";
                    IbMessage.Text = "";
                    return;
                }
            }

        }

   
      
    }
}
