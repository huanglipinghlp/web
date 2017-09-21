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
    public partial class 所有商品信息 : Form
    {
         
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
        public 所有商品信息()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void 所有商品信息_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet.Goods”中。您可以根据需要移动或删除它。
            this.goodsTableAdapter.Fill(this.notemanagementDataSet.Goods);

            /**
             * 
             * 以下为自动调整列宽的代码
             * 
             * */
            int width = 0;
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)//对于DataGridView的每一个列都调整
            {
                this.dataGridView1.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);//将每一列都调整为自动适应模式
                width += this.dataGridView1.Columns[i].Width;//记录整个DataGridView的宽度
            }

            if (width > this.dataGridView1.Size.Width)//判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，则将DataGridView的列自动调整模式设置为显示的列即可，如果是小于原来设定的宽度，将模式改为填充。
            {
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }
                  
     
      
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
          }

        
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("update");
            int i = this.dataGridView1.CurrentCell.RowIndex;
            //MessageBox.Show("增加！");
           // MessageBox.Show("当前行数为：" + i);
            add(i);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show((this.dataGridView1.CurrentCell.RowIndex + 1).ToString());
            int i = this.dataGridView1.CurrentCell.RowIndex;
            int j = this.dataGridView1.CurrentCell.ColumnIndex;
            i = i + 1;
            j = j + 1;
            string D = this.dataGridView1.CurrentCell.Value.ToString();
            MessageBox.Show(D);
            string ID = this.dataGridView1.Rows[i-1].Cells[0].Value.ToString();
            //向数据库中发送ID
            var model = db.Goods.FirstOrDefault(m => m.Goods_ID == ID);
            if (model == null)
            {
                MessageBox.Show("不存在该值！");
                return;
            }
            else
            {
                MessageBox.Show("删除！");
                db.Goods.Remove(model);
                db.SaveChanges();
                // MessageBox.Show("品牌为：" + model.Goods_Name);
            }
        }
        public void add(int i)
        {
            string id = "";
            string bname = "";
            string name = "";
            string color = "";
            string size = "";
            string material = "";
            string clean = "";
            string madeby = "";
            string season = "";
            string remark = "";
            /**
             * 将表中的数据赋值给以上定义的变量；
             * */
            id = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            bname = this.dataGridView1.Rows[i].Cells[1].Value.ToString();
            name = this.dataGridView1.Rows[i].Cells[2].Value.ToString();
            color = this.dataGridView1.Rows[i].Cells[3].Value.ToString();
            size = this.dataGridView1.Rows[i].Cells[4].Value.ToString();
            material = this.dataGridView1.Rows[i].Cells[5].Value.ToString();
            clean = this.dataGridView1.Rows[i].Cells[6].Value.ToString();
            madeby = this.dataGridView1.Rows[i].Cells[7].Value.ToString();
            season = this.dataGridView1.Rows[i].Cells[8].Value.ToString();
            remark = this.dataGridView1.Rows[i].Cells[9].Value.ToString();

            DBCL2.Goods model   = new DBCL2.Goods();
            model.Goods_ID     = id;
            model.Brand_Name   = bname;
            model.Goods_Name   = name;
            model.Goods_Colour = color;
            model.Goods_Size   = size;
            model.Goods_Material = material;
            model.Goods_Clean  = clean;
            model.Goods_MadeBy = madeby;
            model.Goods_Season = season;
            model.Goods_ramarks = remark;

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

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            int i = this.dataGridView1.CurrentCell.RowIndex;
            string id = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
            修改商品信息 xg = new 修改商品信息(id);
            xg.ShowDialog(this);
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            this.goodsTableAdapter.Fill(this.notemanagementDataSet.Goods);

            /**
             * 
             * 以下为自动调整列宽的代码
             * 
             * */
            int width = 0;
            for (int i = 0; i < this.dataGridView1.Columns.Count; i++)//对于DataGridView的每一个列都调整
            {
                this.dataGridView1.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);//将每一列都调整为自动适应模式
                width += this.dataGridView1.Columns[i].Width;//记录整个DataGridView的宽度
            }

            if (width > this.dataGridView1.Size.Width)//判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，则将DataGridView的列自动调整模式设置为显示的列即可，如果是小于原来设定的宽度，将模式改为填充。
            {
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.goodsTableAdapter.FillBy(this.notemanagementDataSet.Goods);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.goodsTableAdapter.FillBy(this.notemanagementDataSet.Goods);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
