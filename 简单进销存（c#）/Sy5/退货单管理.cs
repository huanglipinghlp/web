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
    public partial class 退货单管理 : Form
    {
        private DBCL2.notemanagementEntities db = new DBCL2.notemanagementEntities();
        public 退货单管理()
        {
            InitializeComponent();
        }

        private void 退货单管理_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet12.sell”中。您可以根据需要移动或删除它。
            this.sellTableAdapter.Fill(this.notemanagementDataSet12.sell);
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

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = this.dataGridViewX1.CurrentCell.RowIndex;
            //string id = this.dataGridViewX1.Rows[a].Cells[0].Value.ToString();
            string jinhuodanhao = this.dataGridViewX1.Rows[a].Cells[0].Value.ToString();
            string s1 = this.dataGridViewX1.Rows[a].Cells[1].Value.ToString();
            string d1 = this.dataGridViewX1.Rows[a].Cells[2].Value.ToString();
            string l1 = this.dataGridViewX1.Rows[a].Cells[3].Value.ToString();
            string s2 = this.dataGridViewX1.Rows[a].Cells[4].Value.ToString();
            string d2 = this.dataGridViewX1.Rows[a].Cells[5].Value.ToString();
            string l2 = this.dataGridViewX1.Rows[a].Cells[6].Value.ToString();
            string s3 = this.dataGridViewX1.Rows[a].Cells[7].Value.ToString();
            string d3 = this.dataGridViewX1.Rows[a].Cells[8].Value.ToString();
            string l3 = this.dataGridViewX1.Rows[a].Cells[9].Value.ToString();
            string s4 = this.dataGridViewX1.Rows[a].Cells[10].Value.ToString();
            string d4 = this.dataGridViewX1.Rows[a].Cells[11].Value.ToString();
            string l4 = this.dataGridViewX1.Rows[a].Cells[12].Value.ToString();
            string s5 = this.dataGridViewX1.Rows[a].Cells[13].Value.ToString();
            string d5 = this.dataGridViewX1.Rows[a].Cells[14].Value.ToString();
            string l5 = this.dataGridViewX1.Rows[a].Cells[15].Value.ToString();
            string s6 = this.dataGridViewX1.Rows[a].Cells[16].Value.ToString();
            string d6 = this.dataGridViewX1.Rows[a].Cells[17].Value.ToString();
            string l6 = this.dataGridViewX1.Rows[a].Cells[18].Value.ToString();
            int b = this.dataGridViewX2.RowCount;
            if (b == 7 || b > 7)
            {
                MessageBox.Show("每单最多添加六件商品");
                return;
            }
            int z1 = Convert.ToInt32(d1.Trim()) * Convert.ToInt32(l1.Trim()) + Convert.ToInt32(d2.Trim()) * Convert.ToInt32(l2.Trim()) + Convert.ToInt32(d3.Trim()) * Convert.ToInt32(l3.Trim()) + Convert.ToInt32(d4.Trim()) * Convert.ToInt32(l4.Trim()) + Convert.ToInt32(d5.Trim()) * Convert.ToInt32(l5.Trim()) + Convert.ToInt32(d6.Trim())*Convert.ToInt32(l6.Trim());
            //this.dataGridViewX2.AllowUserToAddRows = true;
            this.dataGridViewX2.Rows.Add(b, jinhuodanhao, s1,d1,l1,s2,d2,l2,s3,d3,l3,s4,d4,l4,s5,d5,l5,s6,d6,l6,z1, "删除");

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
                string a1 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();
                int a2 = Convert.ToInt32(a1.Trim());
                zongjia += a2;
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;

            }
        }

        private void dataGridViewX2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int shuliang = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[2].Value.ToString());
            //int danjia = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[3].Value.ToString());
            //this.dataGridViewX2.Rows[a].Cells[4].Value = danjia * shuliang;

             int a = this.dataGridViewX2.CurrentCell.RowIndex;
             int d1 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[3].Value.ToString().Trim());
             int l1 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[4].Value.ToString().Trim());
             int d2 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[6].Value.ToString().Trim());
             int l2 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[7].Value.ToString().Trim());
             int d3 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[9].Value.ToString().Trim());
             int l3 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[10].Value.ToString().Trim());
             int d4 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[12].Value.ToString().Trim());
             int l4 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[13].Value.ToString().Trim());
             int d5 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[15].Value.ToString().Trim());
             int  l5 = Convert.ToInt32( this.dataGridViewX2.Rows[a].Cells[16].Value.ToString().Trim());
             int  d6 = Convert.ToInt32( this.dataGridViewX2.Rows[a].Cells[18].Value.ToString().Trim());
             int l6 = Convert.ToInt32(this.dataGridViewX2.Rows[a].Cells[19].Value.ToString().Trim());
             //int z1 = 0;
            //z1 = Convert.ToInt32(d1) * Convert.ToInt32(l1) + Convert.ToInt32(d2) * Convert.ToInt32(l2) + Convert.ToInt32(d3) * Convert.ToInt32(l3) + Convert.ToInt32(d4) * Convert.ToInt32(l4) + Convert.ToInt32(d5) * Convert.ToInt32(l5) + Convert.ToInt32(d6) * Convert.ToInt32(l6);
             this.dataGridViewX2.Rows[a].Cells[20].Value = d1*l1+d2*l2+d3*l3+d4*l4+d5*l5+d6*l6;

            int b = this.dataGridViewX2.RowCount;
            int zongjia = 0;
            for (int i = 0; i < b - 2; i++)
            {
                string z = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();
                int z11 = Convert.ToInt32(z);
                zongjia += z11;
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;

            }
        }

        private void dataGridViewX2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int c1 = this.dataGridViewX2.RowCount;//一共多少行
            int a = this.dataGridViewX2.CurrentCell.RowIndex;//当前行数
            int b = this.dataGridViewX2.CurrentCell.ColumnIndex;//当前列数
            if (b == 21)
            {
                this.dataGridViewX2.Rows.RemoveAt(a);
            }
            int c2 = this.dataGridViewX2.RowCount;
            if (c1 != c2)
            {
                for (int i = 0; i < c2 - 1; i++)
                {
                    this.dataGridViewX2.Rows[i].Cells[0].Value = i + 1;
                }
            }

            int zongjia = 0;
            for (int i = 0; i < c2 - 1; i++)
            {
                zongjia += Convert.ToInt32(this.dataGridViewX2.Rows[i].Cells[20].Value.ToString());
                textBoxX3.Text = Convert.ToString(zongjia);
                textBoxX2.Text = textBoxX3.Text;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string Document_ID = "";
            string Document_ID_old1 = "";
            string good_id1 = "";
            string good_number1 = "";
            string good_id2 = "";
            string good_number2 = "";
            string good_id3 = "";
            string good_number3 = "";
            string good_id4 = "";
            string good_number4 = "";
            string good_id5 = "";
            string good_number5 = "";
            string good_id6 = "";
            string good_number6 = "";
            string sum1 = "";

            string Document_ID_old2 = "";
            string good_id21 = "";
            string good_number21 = "";
            string good_id22 = "";
            string good_number22 = "";
            string good_id23 = "";
            string good_number23 = "";
            string good_id24 = "";
            string good_number24 = "";
            string good_id25 = "";
            string good_number25 = "";
            string good_id26 = "";
            string good_number26 = "";
            string sum2 = "";

            string Document_ID_old3 = "";
            string good_id31 = "";
            string good_number31 = "";
            string good_id32 = "";
            string good_number32 = "";
            string good_id33 = "";
            string good_number33 = "";
            string good_id34 = "";
            string good_number34 = "";
            string good_id35 = "";
            string good_number35 = "";
            string good_id36 = "";
            string good_number36 = "";
            string sum3 = "";

            string Document_ID_old4 = "";
            string good_id41 = "";
            string good_number41 = "";
            string good_id42 = "";
            string good_number42 = "";
            string good_id43 = "";
            string good_number43 = "";
            string good_id44 = "";
            string good_number44 = "";
            string good_id45 = "";
            string good_number45 = "";
            string good_id46 = "";
            string good_number46 = "";
            string sum4 = "";

            string Document_ID_old5 = "";
            string good_id51 = "";
            string good_number51 = "";
            string good_id52 = "";
            string good_number52 = "";
            string good_id53 = "";
            string good_number53 = "";
            string good_id54 = "";
            string good_number54 = "";
            string good_id55 = "";
            string good_number55 = "";
            string good_id56 = "";
            string good_number56 = "";
            string sum5 = "";

            string Document_ID_old6 = "";
            string good_id61 = "";
            string good_number61 = "";
            string good_id62 = "";
            string good_number62 = "";
            string good_id63 = "";
            string good_number63 = "";
            string good_id64 = "";
            string good_number64 = "";
            string good_id65 = "";
            string good_number65 = "";
            string good_id66 = "";
            string good_number66 = "";
            string sum6 = "";


            string due = "";
            string Real_payment = "";
            string client_ID = "";
            string worker_ID = "";
            string account = "";
            string sell_Rrmarks = "";

            int b = this.dataGridViewX2.RowCount;
            Document_ID = this.textBoxX1.Text;
            for (int i = 0; i < b - 1; i++)
            {
               if (i == 0)
                {
                    Document_ID_old1 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id1 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number1 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id2 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number2 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id3 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number3 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id4 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number4 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id5 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number5 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id6 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number6 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum1 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();
                }
                if (i == 1)
                {
                    Document_ID_old2 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id21 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number21 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id22 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number22 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id23 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number23 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id24 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number24 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id25 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number25 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id26 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number26 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum2 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();
                }
                if (i == 2)
                {
                    Document_ID_old3 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id31 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number31 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id32 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number32 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id33 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number33 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id34 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number34 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id35 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number35 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id36 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number36 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum3 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();
                }
                if (i == 3)
                {
                    Document_ID_old4 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id41 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number41 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id42 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number42 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id43 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number43 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id44 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number44 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id45 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number45 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id46 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number46 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum4 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();

                }
                if (i == 4)
                {
                    Document_ID_old5 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id51 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number51 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id52 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number52 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id53 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number53 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id54 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number54 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id55 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number55 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id56 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number56 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum5 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();

                }
                if (i == 5)
                {
                    Document_ID_old6 = this.dataGridViewX2.Rows[i].Cells[0].Value.ToString();
                    good_id61 = this.dataGridViewX2.Rows[i].Cells[2].Value.ToString();
                    good_number61 = this.dataGridViewX2.Rows[i].Cells[4].Value.ToString();
                    good_id62 = this.dataGridViewX2.Rows[i].Cells[5].Value.ToString();
                    good_number62 = this.dataGridViewX2.Rows[i].Cells[7].Value.ToString();
                    good_id63 = this.dataGridViewX2.Rows[i].Cells[8].Value.ToString();
                    good_number63 = this.dataGridViewX2.Rows[i].Cells[10].Value.ToString();
                    good_id64 = this.dataGridViewX2.Rows[i].Cells[11].Value.ToString();
                    good_number64 = this.dataGridViewX2.Rows[i].Cells[13].Value.ToString();
                    good_id65 = this.dataGridViewX2.Rows[i].Cells[14].Value.ToString();
                    good_number65 = this.dataGridViewX2.Rows[i].Cells[16].Value.ToString();
                    good_id66 = this.dataGridViewX2.Rows[i].Cells[17].Value.ToString();
                    good_number66 = this.dataGridViewX2.Rows[i].Cells[19].Value.ToString();
                    sum6 = this.dataGridViewX2.Rows[i].Cells[20].Value.ToString();

                }
            }
            textBoxX2.Text = textBoxX3.Text;
            due = textBoxX2.Text;
            Real_payment = textBoxX4.Text;
            client_ID = textBoxX5.Text;
            worker_ID = textBoxX6.Text;
            account = textBoxX7.Text;
            sell_Rrmarks = textBoxX8.Text;

            DBCL2.Sales_Return model = new DBCL2.Sales_Return();
            model.Document_ID = Document_ID;
            model.Document_ID_old1 = Document_ID_old1;
            model.docu_old_2 = Document_ID_old2;
            model.docu_old_3 = Document_ID_old3;
            model.docu_old_4 = Document_ID_old4;
            model.docu_old_5 = Document_ID_old5;
            model.docu_old_6 = Document_ID_old6;
            model.Goods_ID11 = good_id1;
            model.Goods_ID12 = good_id2;
            model.Goods_ID13 = good_id3;
            model.Goods_ID14 = good_id4;
            model.Goods_ID15 = good_id5;
            model.Goods_ID16 = good_id6;
            model.Gid21 = good_id21;
            model.gid22 = good_id22;
            model.gid23 = good_id23;
            model.gid24 = good_id24;
            model.gid25 = good_id25;
            model.gid26 = good_id26;
            model.gid31 = good_id31;
            model.gid32 = good_id32;
            model.gid33 = good_id33;
            model.gid34 = good_id34;
            model.gid35 = good_id35;
            model.gid36 = good_id36;
            model.gid41 = good_id41;
            model.gid42 = good_id42;
            model.gid43 = good_id43;
            model.gid44 = good_id44;
            model.gid45 = good_id45;
            model.gid46 = good_id46;
            model.gid51 = good_id51;
            model.gid52 = good_id52;
            model.gid53 = good_id53;
            model.gid54 = good_id54;
            model.gid55 = good_id55;
            model.gid56 = good_id56;
            model.gid61 = good_id61;
            model.gid62 = good_id62;
            model.gid63 = good_id63;
            model.gid64 = good_id64;
            model.gid65 = good_id65;
            model.gid66 = good_id66;

            model.Goods_Number11 = good_number1;
            model.Goods_Number12 = good_number2;
            model.Goods_Number13 = good_number3;
            model.Goods_Number14 = good_number4;
            model.Goods_Number15 = good_number5;
            model.Goods_Number16 = good_number6;
            model.gn21 = good_number21;
            model.dm22 = good_number22;
            model.gn23 = good_number23;
            model.gn24 = good_number24;
            model.gn25 = good_number25;
            model.gn26 = good_number26;
            model.gn31 = good_number31;
            model.gn32 = good_number32;
            model.gn33 = good_number33;
            model.gn34 = good_number34;
            model.gn35 = good_number35;
            model.gn36 = good_number36;
            model.gn41 = good_number41;
            model.gn42 = good_number42;
            model.gn43 = good_number43;
            model.gn44 = good_number44;
            model.gn45 = good_number45;
            model.gn46 = good_number46;
            model.gn51 = good_number51;
            model.gn52 = good_number52;
            model.gn53 = good_number53;
            model.gn54 = good_number54;
            model.gn55 = good_number55;
            model.gn56 = good_number56;
            model.gn61 = good_number61;
            model.gn62 = good_number62;
            model.gn63 = good_number63;
            model.gn64 = good_number64;
            model.gn65 = good_number65;
            model.gn66 = good_number66;
            model.Goods_sum1 = sum1;
            model.gs2 = sum1;
            model.gs3 = sum3;
            model.gs4 = sum4;
            model.gs5 = sum5;
            model.gs6 = sum6;
            try
            {
                db.Sales_Return.Add(model);
                db.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("加入失败！");
                return;
            }
            MessageBox.Show("成功！");
        }
    }
}
