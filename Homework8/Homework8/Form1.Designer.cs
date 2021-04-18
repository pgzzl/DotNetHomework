
namespace Homework8
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.创建订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrder = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxQueryByCustomerName = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxQueryByCustomerName = new System.Windows.Forms.TextBox();
            this.groupBoxQueryByID = new System.Windows.Forms.GroupBox();
            this.buttonQueryByID = new System.Windows.Forms.Button();
            this.textBoxQueryByID = new System.Windows.Forms.TextBox();
            this.groupBox_QueryAll = new System.Windows.Forms.GroupBox();
            this.buttonQueryAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxQueryByCustomerName.SuspendLayout();
            this.groupBoxQueryByID.SuspendLayout();
            this.groupBox_QueryAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建订单ToolStripMenuItem,
            this.删除订单ToolStripMenuItem,
            this.修改订单ToolStripMenuItem,
            this.导出订单ToolStripMenuItem,
            this.导入订单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1464, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 创建订单ToolStripMenuItem
            // 
            this.创建订单ToolStripMenuItem.Name = "创建订单ToolStripMenuItem";
            this.创建订单ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.创建订单ToolStripMenuItem.Text = "创建订单";
            this.创建订单ToolStripMenuItem.Click += new System.EventHandler(this.创建订单ToolStripMenuItem_Click);
            // 
            // 删除订单ToolStripMenuItem
            // 
            this.删除订单ToolStripMenuItem.Name = "删除订单ToolStripMenuItem";
            this.删除订单ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.删除订单ToolStripMenuItem.Text = "删除订单";
            this.删除订单ToolStripMenuItem.Click += new System.EventHandler(this.删除订单ToolStripMenuItem_Click);
            // 
            // 修改订单ToolStripMenuItem
            // 
            this.修改订单ToolStripMenuItem.Name = "修改订单ToolStripMenuItem";
            this.修改订单ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.修改订单ToolStripMenuItem.Text = "修改订单";
            this.修改订单ToolStripMenuItem.Click += new System.EventHandler(this.修改订单ToolStripMenuItem_Click);
            // 
            // 导出订单ToolStripMenuItem
            // 
            this.导出订单ToolStripMenuItem.Name = "导出订单ToolStripMenuItem";
            this.导出订单ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.导出订单ToolStripMenuItem.Text = "导出订单";
            this.导出订单ToolStripMenuItem.Click += new System.EventHandler(this.导出订单ToolStripMenuItem_Click);
            // 
            // 导入订单ToolStripMenuItem
            // 
            this.导入订单ToolStripMenuItem.Name = "导入订单ToolStripMenuItem";
            this.导入订单ToolStripMenuItem.Size = new System.Drawing.Size(130, 38);
            this.导入订单ToolStripMenuItem.Text = "导入订单";
            this.导入订单ToolStripMenuItem.Click += new System.EventHandler(this.导入订单ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 854);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceOrder;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1190, 854);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSourceOrder
            // 
            this.bindingSourceOrder.DataSource = typeof(Homework8.Order);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBoxQueryByCustomerName);
            this.panel2.Controls.Add(this.groupBoxQueryByID);
            this.panel2.Controls.Add(this.groupBox_QueryAll);
            this.panel2.Location = new System.Drawing.Point(1190, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 854);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxQueryByCustomerName
            // 
            this.groupBoxQueryByCustomerName.Controls.Add(this.button1);
            this.groupBoxQueryByCustomerName.Controls.Add(this.textBoxQueryByCustomerName);
            this.groupBoxQueryByCustomerName.Location = new System.Drawing.Point(7, 382);
            this.groupBoxQueryByCustomerName.Name = "groupBoxQueryByCustomerName";
            this.groupBoxQueryByCustomerName.Size = new System.Drawing.Size(200, 132);
            this.groupBoxQueryByCustomerName.TabIndex = 3;
            this.groupBoxQueryByCustomerName.TabStop = false;
            this.groupBoxQueryByCustomerName.Text = "按顾客名查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "点击查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxQueryByCustomerName
            // 
            this.textBoxQueryByCustomerName.Location = new System.Drawing.Point(6, 35);
            this.textBoxQueryByCustomerName.Name = "textBoxQueryByCustomerName";
            this.textBoxQueryByCustomerName.Size = new System.Drawing.Size(176, 35);
            this.textBoxQueryByCustomerName.TabIndex = 0;
            // 
            // groupBoxQueryByID
            // 
            this.groupBoxQueryByID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxQueryByID.Controls.Add(this.buttonQueryByID);
            this.groupBoxQueryByID.Controls.Add(this.textBoxQueryByID);
            this.groupBoxQueryByID.Location = new System.Drawing.Point(6, 216);
            this.groupBoxQueryByID.Name = "groupBoxQueryByID";
            this.groupBoxQueryByID.Size = new System.Drawing.Size(200, 148);
            this.groupBoxQueryByID.TabIndex = 2;
            this.groupBoxQueryByID.TabStop = false;
            this.groupBoxQueryByID.Text = "按订单号查询";
            // 
            // buttonQueryByID
            // 
            this.buttonQueryByID.Location = new System.Drawing.Point(7, 88);
            this.buttonQueryByID.Name = "buttonQueryByID";
            this.buttonQueryByID.Size = new System.Drawing.Size(176, 42);
            this.buttonQueryByID.TabIndex = 1;
            this.buttonQueryByID.Text = "点击查询";
            this.buttonQueryByID.UseVisualStyleBackColor = true;
            this.buttonQueryByID.Click += new System.EventHandler(this.buttonQueryByID_Click);
            // 
            // textBoxQueryByID
            // 
            this.textBoxQueryByID.Location = new System.Drawing.Point(6, 46);
            this.textBoxQueryByID.Name = "textBoxQueryByID";
            this.textBoxQueryByID.Size = new System.Drawing.Size(177, 35);
            this.textBoxQueryByID.TabIndex = 0;
            this.textBoxQueryByID.TextChanged += new System.EventHandler(this.textBoxQueryByID_TextChanged);
            // 
            // groupBox_QueryAll
            // 
            this.groupBox_QueryAll.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox_QueryAll.Controls.Add(this.buttonQueryAll);
            this.groupBox_QueryAll.Location = new System.Drawing.Point(6, 66);
            this.groupBox_QueryAll.Name = "groupBox_QueryAll";
            this.groupBox_QueryAll.Size = new System.Drawing.Size(200, 102);
            this.groupBox_QueryAll.TabIndex = 1;
            this.groupBox_QueryAll.TabStop = false;
            this.groupBox_QueryAll.Text = "查询全部";
            // 
            // buttonQueryAll
            // 
            this.buttonQueryAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryAll.Location = new System.Drawing.Point(6, 34);
            this.buttonQueryAll.Name = "buttonQueryAll";
            this.buttonQueryAll.Size = new System.Drawing.Size(188, 48);
            this.buttonQueryAll.TabIndex = 0;
            this.buttonQueryAll.Text = "点击查询";
            this.buttonQueryAll.UseVisualStyleBackColor = true;
            this.buttonQueryAll.Click += new System.EventHandler(this.buttonQueryAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 902);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "订单管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxQueryByCustomerName.ResumeLayout(false);
            this.groupBoxQueryByCustomerName.PerformLayout();
            this.groupBoxQueryByID.ResumeLayout(false);
            this.groupBoxQueryByID.PerformLayout();
            this.groupBox_QueryAll.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 创建订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入订单ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxQueryByCustomerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxQueryByCustomerName;
        private System.Windows.Forms.GroupBox groupBoxQueryByID;
        private System.Windows.Forms.Button buttonQueryByID;
        private System.Windows.Forms.TextBox textBoxQueryByID;
        private System.Windows.Forms.GroupBox groupBox_QueryAll;
        private System.Windows.Forms.Button buttonQueryAll;
        private System.Windows.Forms.BindingSource bindingSourceOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
    }
}

