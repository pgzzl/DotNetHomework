namespace 计算器窗体应用
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.equalButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "第一个数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作符";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "第二个数";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(57, 77);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(64, 25);
            this.num1.TabIndex = 3;
            // 
            // operation
            // 
            this.operation.Location = new System.Drawing.Point(164, 77);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(49, 25);
            this.operation.TabIndex = 4;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(258, 76);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(64, 25);
            this.num2.TabIndex = 5;
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(355, 76);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 23);
            this.equalButton.TabIndex = 6;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(472, 76);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(65, 25);
            this.result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "计算器窗体应用";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.TextBox result;
    }
}

