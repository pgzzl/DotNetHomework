
namespace Homework8
{
    partial class FormDelOrder
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
            this.labelDelByID = new System.Windows.Forms.Label();
            this.textBoxDelByID = new System.Windows.Forms.TextBox();
            this.buttonDelByID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDelByID
            // 
            this.labelDelByID.AutoSize = true;
            this.labelDelByID.Location = new System.Drawing.Point(12, 9);
            this.labelDelByID.Name = "labelDelByID";
            this.labelDelByID.Size = new System.Drawing.Size(226, 24);
            this.labelDelByID.TabIndex = 0;
            this.labelDelByID.Text = "输入订单号进行删除";
            // 
            // textBoxDelByID
            // 
            this.textBoxDelByID.Location = new System.Drawing.Point(13, 37);
            this.textBoxDelByID.Name = "textBoxDelByID";
            this.textBoxDelByID.Size = new System.Drawing.Size(100, 35);
            this.textBoxDelByID.TabIndex = 1;
            this.textBoxDelByID.TextChanged += new System.EventHandler(this.textBoxDelByID_TextChanged);
            // 
            // buttonDelByID
            // 
            this.buttonDelByID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDelByID.Location = new System.Drawing.Point(259, 387);
            this.buttonDelByID.Name = "buttonDelByID";
            this.buttonDelByID.Size = new System.Drawing.Size(253, 51);
            this.buttonDelByID.TabIndex = 2;
            this.buttonDelByID.Text = "确定删除";
            this.buttonDelByID.UseVisualStyleBackColor = true;
            this.buttonDelByID.Click += new System.EventHandler(this.buttonDelByID_Click);
            // 
            // FormDelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelByID);
            this.Controls.Add(this.textBoxDelByID);
            this.Controls.Add(this.labelDelByID);
            this.Name = "FormDelOrder";
            this.Text = "FormDelOrder";
            this.Load += new System.EventHandler(this.FormDelOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelByID;
        private System.Windows.Forms.TextBox textBoxDelByID;
        private System.Windows.Forms.Button buttonDelByID;
    }
}