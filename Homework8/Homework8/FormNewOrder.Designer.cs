
namespace Homework8
{
    partial class FormNewOrder
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
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNewCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNewOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.Controls.Add(this.button3);
            this.panelNewOrder.Controls.Add(this.button1);
            this.panelNewOrder.Controls.Add(this.textBoxNewCustomer);
            this.panelNewOrder.Controls.Add(this.label2);
            this.panelNewOrder.Controls.Add(this.textBoxNewCustomerID);
            this.panelNewOrder.Controls.Add(this.label1);
            this.panelNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewOrder.Location = new System.Drawing.Point(0, 0);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(990, 202);
            this.panelNewOrder.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(317, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "确定新建";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNewCustomer
            // 
            this.textBoxNewCustomer.Location = new System.Drawing.Point(100, 45);
            this.textBoxNewCustomer.Name = "textBoxNewCustomer";
            this.textBoxNewCustomer.Size = new System.Drawing.Size(298, 35);
            this.textBoxNewCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户名";
            // 
            // textBoxNewCustomerID
            // 
            this.textBoxNewCustomerID.Location = new System.Drawing.Point(100, 3);
            this.textBoxNewCustomerID.Name = "textBoxNewCustomerID";
            this.textBoxNewCustomerID.Size = new System.Drawing.Size(298, 35);
            this.textBoxNewCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 202);
            this.Controls.Add(this.panelNewOrder);
            this.Name = "FormNewOrder";
            this.Text = "新建订单";
            this.panelNewOrder.ResumeLayout(false);
            this.panelNewOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewCustomerID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}