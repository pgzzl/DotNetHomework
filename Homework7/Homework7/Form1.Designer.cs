
namespace Homework7
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
            this.panel_Draw = new System.Windows.Forms.Panel();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_leng = new System.Windows.Forms.TextBox();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel_Setting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Draw
            // 
            this.panel_Draw.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Draw.Location = new System.Drawing.Point(0, 0);
            this.panel_Draw.Name = "panel_Draw";
            this.panel_Draw.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Draw.Size = new System.Drawing.Size(820, 981);
            this.panel_Draw.TabIndex = 0;
            // 
            // panel_Setting
            // 
            this.panel_Setting.Controls.Add(this.tableLayoutPanel1);
            this.panel_Setting.Controls.Add(this.btnDraw);
            this.panel_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Setting.Location = new System.Drawing.Point(820, 0);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Padding = new System.Windows.Forms.Padding(10);
            this.panel_Setting.Size = new System.Drawing.Size(682, 981);
            this.panel_Setting.TabIndex = 1;
            this.panel_Setting.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Setting_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox_leng, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_per1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_n, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_th2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_per2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_color, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_th1, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 906);
            this.tableLayoutPanel1.TabIndex = 15;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 697);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "主干长度（leng）100左右";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "右分支长度比（per1）0.6左右";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 828);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "画笔颜色（pen）";
            // 
            // textBox_leng
            // 
            this.textBox_leng.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_leng.Location = new System.Drawing.Point(404, 692);
            this.textBox_leng.Name = "textBox_leng";
            this.textBox_leng.Size = new System.Drawing.Size(184, 35);
            this.textBox_leng.TabIndex = 11;
            // 
            // textBox_per1
            // 
            this.textBox_per1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_per1.Location = new System.Drawing.Point(392, 176);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(208, 35);
            this.textBox_per1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "递归深度（n）建议：10左右";
            // 
            // textBox_n
            // 
            this.textBox_n.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_n.Location = new System.Drawing.Point(396, 47);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(200, 35);
            this.textBox_n.TabIndex = 7;
            this.textBox_n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_th2
            // 
            this.textBox_th2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_th2.Location = new System.Drawing.Point(397, 563);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(198, 35);
            this.textBox_th2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "左分支长度比（per2）同上";
            // 
            // textBox_per2
            // 
            this.textBox_per2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_per2.Location = new System.Drawing.Point(400, 305);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(192, 35);
            this.textBox_per2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "左分支角度（th2）建议同上";
            // 
            // comboBox_color
            // 
            this.comboBox_color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "黑色"});
            this.comboBox_color.Location = new System.Drawing.Point(436, 824);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(121, 32);
            this.comboBox_color.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 48);
            this.label7.TabIndex = 13;
            this.label7.Text = "右分支角度（th1*pi/180）25左右";
            // 
            // textBox_th1
            // 
            this.textBox_th1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_th1.Location = new System.Drawing.Point(400, 434);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(192, 35);
            this.textBox_th1.TabIndex = 14;
            // 
            // btnDraw
            // 
            this.btnDraw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDraw.Location = new System.Drawing.Point(10, 916);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(662, 55);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "绘制";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1502, 981);
            this.Controls.Add(this.panel_Setting);
            this.Controls.Add(this.panel_Draw);
            this.Name = "Form1";
            this.panel_Setting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Draw;
        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_leng;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_th1;
    }
}

