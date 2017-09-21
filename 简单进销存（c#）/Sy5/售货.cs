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
    public partial class 售货 : Form
    {
        public 售货()
        {
            InitializeComponent();
        }

        private void 售货_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet14.Goods”中。您可以根据需要移动或删除它。
            this.goodsTableAdapter1.Fill(this.notemanagementDataSet14.Goods);

        }

    }
}
