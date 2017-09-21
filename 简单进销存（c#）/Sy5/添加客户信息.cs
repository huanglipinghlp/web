using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy5
{
    public partial class 添加客户信息 : Form
    {
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
        public 添加客户信息()
        {
            InitializeComponent();
            //初始化
            textBoxX1.Text = "";
            textBoxX2.Text = "";
            textBoxX3.Text = "";
            textBoxX4.Text = "";
            textBoxX5.Text = "";
            labelX7.Text = "";
            labelX8.Text = "";
            labelX9.Text = "";
        }
       
        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //获取输入框的值
            string id = textBoxX1.Text.Trim();
            string name = textBoxX2.Text.Trim();
            string phone = textBoxX3.Text.Trim();
            DateTime birthday = dateTimeInput1.Value;
            string email = textBoxX4.Text.Trim();
            string remark = textBoxX5.Text.Trim();

            if (id == null)
            {
                labelX7.Text = "编号不能为空！";
                textBoxX1.Focus();
            }
            else if (name == null)
            {
                labelX8.Text = "姓名不能为空！";
                textBoxX2.Focus();
            }
            else if (phone == null)
            {
                labelX9.Text = "联系方式不能为空！";
                textBoxX3.Focus();
            }
            else
            {
                labelX7.Text = "";
                labelX8.Text = "";
                labelX9.Text = "";
            }
            DBCL2.Client model = new DBCL2.Client();
            model.Client_ID = id;
            model.Client_Name = name;
            model.Client_PhoneNumber = phone;
            model.Client_Birthday = birthday;
            model.Client_Email = email;
            model.Client_Remark = remark;

            try
            {
                db.Client.Add(model);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("添加失败！");
                return;
            }
            MessageBox.Show("添加成功！");

        }
    }
}
