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
    public partial class 进货单管理 : Form
    {
        public int xuhao=1;
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
        public 进货单管理()
        {
            InitializeComponent();
        }

        private void 进货单管理_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet10.size”中。您可以根据需要移动或删除它。
            this.sizeTableAdapter.Fill(this.notemanagementDataSet10.size);
            // TODO:  这行代码将数据加载到表“notemanagementDataSet9.Goods”中。您可以根据需要移动或删除它。
            this.goodsTableAdapter.Fill(this.notemanagementDataSet9.Goods);

            /**
             * 
             * 以下为自动调整列宽的代码
             * 
             * */
            int width = 0;
            for (int i = 0; i < this.dataGridViewX1.Columns.Count; i++)//对于DataGridView的每一个列都调整
            {
                this.dataGridViewX1.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);//将每一列都调整为自动适应模式
                width += this.dataGridViewX1.Columns[i].Width;//记录整个DataGridView的宽度
            }

            if (width > this.dataGridViewX1.Size.Width)//判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，则将DataGridView的列自动调整模式设置为显示的列即可，如果是小于原来设定的宽度，将模式改为填充。
            {
                this.dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                this.dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            this.dataGridViewX1.ReadOnly = true;
            System.DateTime currentTime = System.DateTime.Now;
            this.textBoxX1.Text = currentTime.ToString("yyyyMMddhmmss");

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            //System.DateTime currentTime=new System.DateTime();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dataGridViewX1.CurrentCell.RowIndex;
            //string id = this.dataGridViewX1.Rows[a].Cells[0].Value.ToString();
            string danjia = this.dataGridViewX1.Rows[a].Cells[8].Value.ToString();
            string shangpinmingcheng = this.dataGridViewX1.Rows[a].Cells[2].Value.ToString();
            int b = this.dataGridViewX2.RowCount;
            if (b == 7 || b > 7)
            {
                MessageBox.Show("每单最多添加六件商品");
                return;
            }
           // MessageBox.Show("b="+b);
            //MessageBox.Show(id);
            //this.dataGridViewX2.Rows[b-1].Cells[0].Value = id;
            //this.dataGridViewX2.Rows[b - 1].Cells[1].Value = danjia;
            //this.dataGridViewX2.AllowUserToAddRows = true;
            this.dataGridViewX2.Rows.Add(b,shangpinmingcheng,1,danjia,danjia,"删除");

            /**
           * 
           * 以下为自动调整列宽的代码
           * 
           * */
            int width = 0;
            for (int i = 0; i < this.dataGridViewX2.Columns.Count; i++)//对于DataGridView的每一个列都调整
            {
                this.dataGridViewX2.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.AllCells);//将每一列都调整为自动适应模式
                width += this.dataGridViewX2.Columns[i].Width;//记录整个DataGridView的宽度
            }

            if (width > this.dataGridViewX2.Size.Width)//判断调整后的宽度与原来设定的宽度的关系，如果是调整后的宽度大于原来设定的宽度，则将DataGridView的列自动调整模式设置为显示的列即可，如果是小于原来设定的宽度，将模式改为填充。
            {
                this.dataGridViewX2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                this.dataGridViewX2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            int zongjia = 0;
            for (int i = 0; i < b; i++)
            {
                zongjia += Convert.ToInt32(this.dataGridViewX2.Rows[i].Cells[4].Value.ToString());
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;
            
            }
            

        }
        private void dataGridViewX2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dataGridViewX2.CurrentCell.RowIndex;
            int shuliang = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[2].Value.ToString());
            int danjia = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[3].Value.ToString());
            this.dataGridViewX2.Rows[a].Cells[4].Value = danjia * shuliang;

            int b = this.dataGridViewX2.RowCount;
            int zongjia = 0;
            for (int i = 0; i < b-1; i++)
            {
                string  z = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                int z1 = Convert.ToInt32(z);
                zongjia +=z1;
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;
            
            }
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c1 = this.dataGridViewX2.RowCount;//一共多少行
            int a = this.dataGridViewX2.CurrentCell.RowIndex;//当前行数
            int b = this.dataGridViewX2.CurrentCell.ColumnIndex;//当前列数
            if(b==5)
            {
                this.dataGridViewX2.Rows.RemoveAt(a);
            }
            int c2 = this.dataGridViewX2.RowCount;
            if (c1 != c2)
            {
                for (int i = 0; i < c2 - 1; i++)
                {
                    this.dataGridViewX2.Rows[i].Cells[0].Value = i+1;
                }
            }

            int zongjia = 0;
            for (int i = 0; i < c2-1; i++)
            {
                zongjia += Convert.ToInt32(this.dataGridViewX2.Rows[i].Cells[4].Value.ToString());
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string Document_ID = "";
            string good_id1 = "";
            string good_danjia1 = "";
            string good_number1 = "";
            string good_id2 = "";
            string good_danjia2 = "";
            string good_number2 = "";
            string good_id3 = "";
            string good_danjia3 = "";
            string good_number3 = "";
            string good_id4 = "";
            string good_danjia4 = "";
            string good_number4 = "";
            string good_id5 = "";
            string good_danjia5 = "";
            string good_number5 = "";
            string good_id6 = "";
            string good_danjia6 = "";
            string good_number6 = "";
            string due = "";
            string Real_payment = "";
            string client_ID = "";
            string worker_ID = "";
            string account = "";
            string sell_Rrmarks = "";
            
            ///**
            // * 将表中的数据赋值给以上定义的变量；
            // * */
            int b = this.dataGridViewX2.RowCount;
            Document_ID = this.textBoxX1.Text;
            for (int i = 0; i < b-1; i++)
            {
                if(i==0)
                {
                    good_id1=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia1=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number1=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
                if(i==1)
                {
                    good_id2=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia2=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number2=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
                if(i==2)
                {
                    good_id3=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia3=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number3=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
                if(i==3)
                {
                    good_id4=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia4=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number4=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
                if(i==4)
                {
                    good_id5=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia5=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number5=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
                if(i==5)
                {
                    good_id6=this.dataGridViewX2.Rows[i].Cells[1].Value.ToString();
                    good_danjia6=this.dataGridViewX2.Rows[i].Cells[3].Value.ToString();
                    good_number6=this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                }
             
            }
            textBoxX2.Text = textBoxX3.Text;
            due = textBoxX2.Text;
            Real_payment = textBoxX4.Text;
            client_ID = textBoxX5.Text;
            worker_ID = textBoxX6.Text;
            account = textBoxX7.Text;
            sell_Rrmarks = textBoxX8.Text;

            DBCL2.sell model = new DBCL2.sell();
            model.Document_ID = Document_ID;
            model.Goods_ID1 = good_id1;
            model.Goods_ID2 = good_id2;
            model.Goods_ID3 = good_id3;
            model.Goods_ID4 = good_id4;
            model.Goods_ID5 = good_id5;
            model.Goods_ID6 = good_id6;
            model.Goods_danjia1 = good_danjia1;
            model.Goods_danjia2 = good_danjia2;
            model.Goods_danjia3 = good_danjia3;
            model.Goods_danjia4 = good_danjia4;
            model.Goods_danjia5 = good_danjia5;
            model.Goods_danjia6 = good_danjia6;
            model.Goods_Number1 = good_number1;
            model.Goods_Number2 = good_number2;
            model.Goods_Number3 = good_number3;
            model.Goods_Number4 = good_number4;
            model.Goods_Number5 = good_number5;
            model.Goods_Number6 = good_number6;
            model.Due = due;
            model.Real_Payment = Real_payment;
            model.Worker_ID = worker_ID;
            model.Client_ID = client_ID;
            model.Account = account;
            model.Sell_Remarks = sell_Rrmarks;

            try
            {
                db.sell.Add(model);
                db.SaveChanges();
            }
            catch {
                MessageBox.Show("添加失败！");
                return;
            }
            MessageBox.Show("添加成功！");
            DBCL2.Goods model1 = new DBCL2.Goods();
            var model2 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id1);
            if (model2 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model2.Goods_Sum_Number);
                model2.Goods_Sum_Number = (m+Convert.ToInt32(good_number1)).ToString();
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
            var model3 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id2);
            if (model3 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model3.Goods_Sum_Number);
                model3.Goods_Sum_Number = (m + Convert.ToInt32(good_number2)).ToString();
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
            var model4 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id3);
            if (model4 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model4.Goods_Sum_Number);
                model4.Goods_Sum_Number = (m + Convert.ToInt32(good_number3)).ToString();
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
            var model5 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id4);
            if (model5 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model5.Goods_Sum_Number);
                model5.Goods_Sum_Number = (m + Convert.ToInt32(good_number4)).ToString();
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
            var model6 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id5);
            if (model6 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model6.Goods_Sum_Number);
                model6.Goods_Sum_Number = (m + Convert.ToInt32(good_number5)).ToString(); 
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
            var model7 = db.Goods.FirstOrDefault(m => m.Goods_ID == good_id6);
            if (model7 == null)
            {
                return;
            }
            else
            {
                int m = Convert.ToInt32(model7.Goods_Sum_Number);
                model7.Goods_Sum_Number = (m + Convert.ToInt32(good_number6)).ToString(); 
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
        }
    }
}
