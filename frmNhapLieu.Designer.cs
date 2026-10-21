namespace Lab06
{
    partial class frmNhapLieu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSoDong = new System.Windows.Forms.Label();
            this.lblSoCot = new System.Windows.Forms.Label();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.txtSoCot = new System.Windows.Forms.TextBox();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblSoDong
            //
            this.lblSoDong.AutoSize = true;
            this.lblSoDong.Location = new System.Drawing.Point(20, 22);
            this.lblSoDong.Name = "lblSoDong";
            this.lblSoDong.Size = new System.Drawing.Size(51, 15);
            this.lblSoDong.TabIndex = 0;
            this.lblSoDong.Text = "Số dòng";
            //
            // lblSoCot
            //
            this.lblSoCot.AutoSize = true;
            this.lblSoCot.Location = new System.Drawing.Point(20, 58);
            this.lblSoCot.Name = "lblSoCot";
            this.lblSoCot.Size = new System.Drawing.Size(42, 15);
            this.lblSoCot.TabIndex = 1;
            this.lblSoCot.Text = "Số cột";
            //
            // txtSoDong
            //
            this.txtSoDong.Location = new System.Drawing.Point(90, 19);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(110, 23);
            this.txtSoDong.TabIndex = 2;
            //
            // txtSoCot
            //
            this.txtSoCot.Location = new System.Drawing.Point(90, 55);
            this.txtSoCot.Name = "txtSoCot";
            this.txtSoCot.Size = new System.Drawing.Size(110, 23);
            this.txtSoCot.TabIndex = 3;
            //
            // btnKhoiTao
            //
            this.btnKhoiTao.Location = new System.Drawing.Point(225, 15);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(130, 65);
            this.btnKhoiTao.TabIndex = 4;
            this.btnKhoiTao.Text = "Khởi tạo form";
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            //
            // frmNhapLieu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 98);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.txtSoCot);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.lblSoCot);
            this.Controls.Add(this.lblSoDong);
            this.Name = "frmNhapLieu";
            this.Text = "Nhập liệu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblSoDong;
        private System.Windows.Forms.Label lblSoCot;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox txtSoCot;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}
