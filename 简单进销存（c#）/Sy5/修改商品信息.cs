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
    public partial class 修改商品信息 : Form
    {
        private string ID = "";
        DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();

        public 修改商品信息()
        {
            InitializeComponent();
        }
        public 修改商品信息(string id)
        {
            InitializeComponent();
            ID  = id;
        }

        private void 修改商品信息_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet8.Season”中。您可以根据需要移动或删除它。
            this.seasonTableAdapter.Fill(this.notemanagementDataSet8.Season);
            // TODO:  这行代码将数据加载到表“notemanagementDataSet7.size”中。您可以根据需要移动或删除它。
            this.sizeTableAdapter.Fill(this.notemanagementDataSet7.size);
            // TODO:  这行代码将数据加载到表“notemanagementDataSet6.Brand”中。您可以根据需要移动或删除它。
            this.brandTableAdapter.Fill(this.notemanagementDataSet6.Brand);
            textBoxX1.Text = ID;
            var model = db.Goods .FirstOrDefault(m=>m.Goods_ID==ID );
            comboBox1.Text = model.Brand_Name;
            textBoxX3.Text = model.Goods_Name;
            textBoxX4.Text = model.Goods_Colour;
            comboBox2.Text = model.Goods_Size;
            textBoxX6.Text = model.Goods_Material;
            textBoxX7.Text = model.Goods_Clean;
            comboBox3.Text = model.Goods_Season;
            textBoxX8.Text = model.Goods_MadeBy;
            textBoxX9.Text = model.Goods_ramarks;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string id = textBoxX1.Text.Trim();
            string bname = comboBox1.SelectedValue.ToString();
            string name = textBoxX3.Text.Trim();
            string color = textBoxX4.Text.Trim();
            string size = comboBox2.SelectedValue.ToString();
            string material = textBoxX6.Text.Trim();
            string clean = textBoxX7.Text.Trim();
            string season = comboBox3.SelectedValue.ToString();
            string madeby = textBoxX8.Text.Trim();
            string ramark = textBoxX9.Text.Trim();

            var model = db.Goods.FirstOrDefault(m => m.Goods_ID == ID);
            model.Goods_ID = ID;
            model.Brand_Name = bname;
            model.Goods_Name = name;
            model.Goods_Colour = color;
            model.Goods_Size = size;
            model.Goods_Material = material;
            model.Goods_Clean = clean;
            model.Goods_Season = season;
            model.Goods_MadeBy = madeby;
            model.Goods_ramarks = ramark;

            try
            {
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("更新失败！");
                return;
            }
            MessageBox.Show("更新成功！");
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
