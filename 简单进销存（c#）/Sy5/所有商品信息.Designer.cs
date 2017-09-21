namespace Sy5
{
    partial class 所有商品信息
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(所有商品信息));
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsColourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsCleanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsSeasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsMadeByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsramarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notemanagementDataSet = new Sy5.notemanagementDataSet();
            this.goodsTableAdapter = new Sy5.notemanagementDataSetTableAdapters.GoodsTableAdapter();
            this.bindingNavigatorEx1 = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorAddNewItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorDeleteItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notemanagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "夏天";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "春夏";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "春天";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "夏秋";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsColourDataGridViewTextBoxColumn,
            this.goodsSizeDataGridViewTextBoxColumn,
            this.goodsMaterialDataGridViewTextBoxColumn,
            this.goodsCleanDataGridViewTextBoxColumn,
            this.goodsSeasonDataGridViewTextBoxColumn,
            this.goodsMadeByDataGridViewTextBoxColumn,
            this.goodsramarksDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.goodsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(873, 274);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "Goods_ID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "Goods_ID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "Brand_Name";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "Goods_Name";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "Goods_Name";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // goodsColourDataGridViewTextBoxColumn
            // 
            this.goodsColourDataGridViewTextBoxColumn.DataPropertyName = "Goods_Colour";
            this.goodsColourDataGridViewTextBoxColumn.HeaderText = "Goods_Colour";
            this.goodsColourDataGridViewTextBoxColumn.Name = "goodsColourDataGridViewTextBoxColumn";
            // 
            // goodsSizeDataGridViewTextBoxColumn
            // 
            this.goodsSizeDataGridViewTextBoxColumn.DataPropertyName = "Goods_Size";
            this.goodsSizeDataGridViewTextBoxColumn.HeaderText = "Goods_Size";
            this.goodsSizeDataGridViewTextBoxColumn.Name = "goodsSizeDataGridViewTextBoxColumn";
            // 
            // goodsMaterialDataGridViewTextBoxColumn
            // 
            this.goodsMaterialDataGridViewTextBoxColumn.DataPropertyName = "Goods_Material";
            this.goodsMaterialDataGridViewTextBoxColumn.HeaderText = "Goods_Material";
            this.goodsMaterialDataGridViewTextBoxColumn.Name = "goodsMaterialDataGridViewTextBoxColumn";
            // 
            // goodsCleanDataGridViewTextBoxColumn
            // 
            this.goodsCleanDataGridViewTextBoxColumn.DataPropertyName = "Goods_Clean";
            this.goodsCleanDataGridViewTextBoxColumn.HeaderText = "Goods_Clean";
            this.goodsCleanDataGridViewTextBoxColumn.Name = "goodsCleanDataGridViewTextBoxColumn";
            // 
            // goodsSeasonDataGridViewTextBoxColumn
            // 
            this.goodsSeasonDataGridViewTextBoxColumn.DataPropertyName = "Goods_Season";
            this.goodsSeasonDataGridViewTextBoxColumn.HeaderText = "Goods_Season";
            this.goodsSeasonDataGridViewTextBoxColumn.Name = "goodsSeasonDataGridViewTextBoxColumn";
            // 
            // goodsMadeByDataGridViewTextBoxColumn
            // 
            this.goodsMadeByDataGridViewTextBoxColumn.DataPropertyName = "Goods_MadeBy";
            this.goodsMadeByDataGridViewTextBoxColumn.HeaderText = "Goods_MadeBy";
            this.goodsMadeByDataGridViewTextBoxColumn.Name = "goodsMadeByDataGridViewTextBoxColumn";
            // 
            // goodsramarksDataGridViewTextBoxColumn
            // 
            this.goodsramarksDataGridViewTextBoxColumn.DataPropertyName = "Goods_ramarks";
            this.goodsramarksDataGridViewTextBoxColumn.HeaderText = "Goods_ramarks";
            this.goodsramarksDataGridViewTextBoxColumn.Name = "goodsramarksDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.notemanagementDataSet;
            // 
            // notemanagementDataSet
            // 
            this.notemanagementDataSet.DataSetName = "notemanagementDataSet";
            this.notemanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorEx1
            // 
            this.bindingNavigatorEx1.AddNewRecordButton = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorEx1.AntiAlias = true;
            this.bindingNavigatorEx1.BindingSource = this.goodsBindingSource;
            this.bindingNavigatorEx1.CountLabel = this.bindingNavigatorCountItem;
            this.bindingNavigatorEx1.CountLabelFormat = "of {0}";
            this.bindingNavigatorEx1.DeleteButton = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bindingNavigatorEx1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorEx1.IsMaximized = false;
            this.bindingNavigatorEx1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3});
            this.bindingNavigatorEx1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigatorEx1.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEx1.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEx1.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEx1.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEx1.Name = "bindingNavigatorEx1";
            this.bindingNavigatorEx1.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEx1.Size = new System.Drawing.Size(873, 26);
            this.bindingNavigatorEx1.Stretch = true;
            this.bindingNavigatorEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bindingNavigatorEx1.TabIndex = 67;
            this.bindingNavigatorEx1.TabStop = false;
            this.bindingNavigatorEx1.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.BeginGroup = true;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Text = "-1";
            this.bindingNavigatorPositionItem.TextBoxWidth = 54;
            this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BeginGroup = true;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "update";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Edit";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "刷新";
            this.buttonItem3.Click += new System.EventHandler(this.buttonItem3_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(334, 92);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(71, 23);
            this.labelX1.TabIndex = 68;
            this.labelX1.Text = "品牌名称：";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.goodsBindingSource;
            this.comboBox1.DisplayMember = "Brand_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 20);
            this.comboBox1.TabIndex = 69;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(600, 89);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 70;
            this.labelX2.Text = "适用季节：";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.goodsBindingSource;
            this.comboBox2.DisplayMember = "Goods_Season";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(700, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 71;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.goodsBindingSource;
            this.comboBox4.DisplayMember = "Goods_ID";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(93, 89);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 73;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(12, 89);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 77;
            this.labelX4.Text = "商品编号：";
            // 
            // 所有商品信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 447);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.bindingNavigatorEx1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "所有商品信息";
            this.Text = "所有商品信息";
            this.Load += new System.EventHandler(this.所有商品信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notemanagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevComponents.Editors.ComboItem comboItem4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private notemanagementDataSet notemanagementDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private notemanagementDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bindingNavigatorEx1;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorAddNewItem;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorDeleteItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsColourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsCleanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsMadeByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsramarksDataGridViewTextBoxColumn;
    }
}