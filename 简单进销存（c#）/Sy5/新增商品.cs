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
    public partial class 新增商品 : Form
    {
      
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
        public 新增商品()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 新增商品_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet5.Season”中。您可以根据需要移动或删除它。
            this.seasonTableAdapter.Fill(this.notemanagementDataSet5.Season);
            // TODO:  这行代码将数据加载到表“notemanagementDataSet4.size”中。您可以根据需要移动或删除它。
            this.sizeTableAdapter.Fill(this.notemanagementDataSet4.size);
            // TODO:  这行代码将数据加载到表“notemanagementDataSet3.Brand”中。您可以根据需要移动或删除它。
            this.brandTableAdapter.Fill(this.notemanagementDataSet3.Brand);
            textBoxX1.Text = "";
            textBoxX3.Text = "";
            textBoxX4.Text = "";
            textBoxX6.Text = "";
            textBoxX7.Text = "";
            textBoxX8.Text = "";
            textBoxX9.Text = "";
            System.DateTime currentTime = System.DateTime.Now;
            this.textBoxX1.Text = currentTime.ToString("hmmss");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string strID = "";
            string strBName = "";
            string strName = "";
            string strColour = "";
            string strSize = "";
            string strMaterial = "";
            string strClean = "";
            string strSeason = "";
            string strMadeBy = "";
            string strRemark = "";

            if (textBoxX1.Text.Trim() == "")
            {
                MessageBox.Show("商品编号不能为空！");
                textBoxX1.Focus();
                return;
            }
            if (db.Goods.Any(m => m.Goods_ID == textBoxX1.Text.Trim()) == true)
            {
                MessageBox.Show("商品编号重复！");
                textBoxX1.Focus();
                return;
            }
            strID = textBoxX1.Text.Trim();
            strBName = comboBox2.SelectedValue.ToString();
            strName = textBoxX3.Text.Trim();
            strColour = textBoxX4.Text.Trim();
            strSize = comboBox3.SelectedValue.ToString();
            strMaterial = textBoxX6.Text.Trim();
            strClean = textBoxX7.Text.Trim();
            strSeason = comboBox4.SelectedValue.ToString();
            strMadeBy = textBoxX8.Text.Trim();
            //MessageBox.Show(comboBoxEx1.SelectedItem.ToString());
            strRemark = textBoxX9.Text.Trim();
            DBCL2.Goods model = new DBCL2.Goods();

            model.Goods_ID = strID;
            model.Goods_Name = strName;
            model.Brand_Name = strBName;
            model.Goods_Colour = strColour;
            model.Goods_Size = strSize;
            model.Goods_Material = strMaterial;
            model.Goods_Clean = strClean;
            model.Goods_Season = strSeason;
            model.Goods_MadeBy = strMadeBy;
            model.Goods_ramarks = strRemark;
            model.Goods_Sum_Number = "0";
            model.Goods_danjia = "0";

            try
            {
                db.Goods.Add(model);
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
