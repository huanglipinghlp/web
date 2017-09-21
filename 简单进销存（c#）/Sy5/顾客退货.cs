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
    public partial class 顾客退货 : Form
    {
        public 顾客退货()
        {
            InitializeComponent();
        }

        private void 顾客退货_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“notemanagementDataSet15.sell”中。您可以根据需要移动或删除它。
            this.sellTableAdapter1.Fill(this.notemanagementDataSet15.sell);

        }
    }
}
