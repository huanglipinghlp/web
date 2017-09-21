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
    public partial class 库存 : Form
    {
        public 库存()
        {
            InitializeComponent();
        }

        private void 库存_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet17.Goods”中。您可以根据需要移动或删除它。
            this.goodsTableAdapter.Fill(this.notemanagementDataSet17.Goods);
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

        }
    }
}
