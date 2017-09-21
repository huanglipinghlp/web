namespace Sy5
{
    partial class 员工信息
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(员工信息));
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBumenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notemanagementDataSet2 = new Sy5.notemanagementDataSet2();
            this.workerTableAdapter = new Sy5.notemanagementDataSet2TableAdapters.WorkerTableAdapter();
            this.bindingNavigatorEx1 = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorAddNewItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorDeleteItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notemanagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoGenerateColumns = false;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIDDataGridViewTextBoxColumn,
            this.workerNameDataGridViewTextBoxColumn,
            this.workerPhoneDataGridViewTextBoxColumn,
            this.workerEmailDataGridViewTextBoxColumn,
            this.workerBumenDataGridViewTextBoxColumn});
            this.dataGridViewX1.DataSource = this.workerBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(628, 278);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "Worker_ID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "Worker_ID";
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            // 
            // workerNameDataGridViewTextBoxColumn
            // 
            this.workerNameDataGridViewTextBoxColumn.DataPropertyName = "Worker_Name";
            this.workerNameDataGridViewTextBoxColumn.HeaderText = "Worker_Name";
            this.workerNameDataGridViewTextBoxColumn.Name = "workerNameDataGridViewTextBoxColumn";
            // 
            // workerPhoneDataGridViewTextBoxColumn
            // 
            this.workerPhoneDataGridViewTextBoxColumn.DataPropertyName = "Worker_Phone";
            this.workerPhoneDataGridViewTextBoxColumn.HeaderText = "Worker_Phone";
            this.workerPhoneDataGridViewTextBoxColumn.Name = "workerPhoneDataGridViewTextBoxColumn";
            // 
            // workerEmailDataGridViewTextBoxColumn
            // 
            this.workerEmailDataGridViewTextBoxColumn.DataPropertyName = "Worker_Email";
            this.workerEmailDataGridViewTextBoxColumn.HeaderText = "Worker_Email";
            this.workerEmailDataGridViewTextBoxColumn.Name = "workerEmailDataGridViewTextBoxColumn";
            // 
            // workerBumenDataGridViewTextBoxColumn
            // 
            this.workerBumenDataGridViewTextBoxColumn.DataPropertyName = "Worker_Bumen";
            this.workerBumenDataGridViewTextBoxColumn.HeaderText = "Worker_Bumen";
            this.workerBumenDataGridViewTextBoxColumn.Name = "workerBumenDataGridViewTextBoxColumn";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.notemanagementDataSet2;
            // 
            // notemanagementDataSet2
            // 
            this.notemanagementDataSet2.DataSetName = "notemanagementDataSet2";
            this.notemanagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorEx1
            // 
            this.bindingNavigatorEx1.AddNewRecordButton = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorEx1.AntiAlias = true;
            this.bindingNavigatorEx1.BindingSource = this.workerBindingSource;
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorEx1.Location = new System.Drawing.Point(0, 278);
            this.bindingNavigatorEx1.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorEx1.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorEx1.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorEx1.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorEx1.Name = "bindingNavigatorEx1";
            this.bindingNavigatorEx1.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bindingNavigatorEx1.Size = new System.Drawing.Size(628, 25);
            this.bindingNavigatorEx1.Stretch = true;
            this.bindingNavigatorEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bindingNavigatorEx1.TabIndex = 1;
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
            // 员工信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 375);
            this.Controls.Add(this.bindingNavigatorEx1);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "员工信息";
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.员工信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notemanagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private notemanagementDataSet2 notemanagementDataSet2;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private notemanagementDataSet2TableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBumenDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bindingNavigatorEx1;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorAddNewItem;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorDeleteItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
    }
}