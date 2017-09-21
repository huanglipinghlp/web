using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;//将子窗口放在父窗口所有控件之上

namespace Sy5
{
    public partial class Main : Form
    {
       // public static extern int SetParent(int hWndChild, int hWndNewParent);

        private int m_LeftWidth = 0;
        public Main()
        {
            InitializeComponent();
        }
        /**
         * 控制功能栏的伸缩
         * 
         * */
        private void expandableSplitter1_Click(object sender, EventArgs e)
        {
            if (expandableSplitter1.Expanded)
            {
                m_LeftWidth = 0;
                this.expandablePanel1.Width = m_LeftWidth;
            }
            else
            {
                this.expandablePanel1.Width = 228;

            }
        }

        private void expandableSplitter1_MouseMove(object sender, MouseEventArgs e)
        {
            expandableSplitter1.Width = 20;
        }

        private void expandableSplitter1_MouseLeave(object sender, EventArgs e)
        {
            expandableSplitter1.Width = 10;
        }
     
        private void buttonX6_Click(object sender, EventArgs e)
        {
            新增商品 xz = new 新增商品();
            xz.TopLevel = false;
            xz.MdiParent = this;
            xz.Dock = DockStyle.Fill;
            xz.Show();
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            所有商品信息 sygood = new 所有商品信息();
            sygood.TopLevel = false;
            sygood.MdiParent = this;
            sygood.Dock = DockStyle.Fill;
            sygood.Show();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            mainRight f4 = new mainRight();
            f4.TopLevel = false;//不是顶级窗口
            f4.MdiParent = this;
            f4.Dock = DockStyle.Fill;
            f4.Show();

            //SetParent((int)f4.Handle, (int)this.Handle);
       
        }

        private void buttonX9_Click(object sender, EventArgs e)
        {
            客户信息 khxx = new 客户信息();
            khxx.MdiParent = this;
            khxx.TopLevel = false;
            khxx.FormBorderStyle = FormBorderStyle.None;
            khxx.Dock = DockStyle.Fill;
            khxx.Show();
        }

        private void buttonX10_Click(object sender, EventArgs e)
        {
            员工信息 y = new 员工信息();
            y.MdiParent = this;
            y.TopLevel = false;
            y.FormBorderStyle = FormBorderStyle.None;
            y.Dock = DockStyle.Fill;
            y.Show();
        }

        private void buttonX11_Click(object sender, EventArgs e)
        {
            添加客户信息 tj = new 添加客户信息();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX13_Click(object sender, EventArgs e)
        {
            添加员工信息 tj = new 添加员工信息();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX14_Click(object sender, EventArgs e)
        {
            系统用户管理 tj = new 系统用户管理();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX12_Click(object sender, EventArgs e)
        {
            进货单管理 tj = new 进货单管理();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX15_Click(object sender, EventArgs e)
        {
            退货单管理 tj = new 退货单管理();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX16_Click(object sender, EventArgs e)
        {
            售货 tj = new 售货();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX17_Click(object sender, EventArgs e)
        {
            顾客退货 tj = new 顾客退货();
            tj.MdiParent = this;
            tj.TopLevel = false;
            tj.FormBorderStyle = FormBorderStyle.None;
            tj.Dock = DockStyle.Fill;
            tj.Show();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            库存 k = new 库存();
            k.MdiParent = this;
            k.TopLevel = false;
            k.Dock = DockStyle.Fill;
            k.FormBorderStyle = FormBorderStyle.None;
            k.Show();
        }

       
    }
}
