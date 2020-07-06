namespace QuanLyCLBVoThuat
{
    partial class BM2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stt = new System.Windows.Forms.TextBox();
            this.tenVoSinh = new System.Windows.Forms.TextBox();
            this.soTien = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.XemVoSinh = new System.Windows.Forms.DataGridView();
            this.lable1 = new System.Windows.Forms.Label();
            this.maPhieuThu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ghiChu = new System.Windows.Forms.TextBox();
            this.ngayThu = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.XemVoSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên võ sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Thu";
            // 
            // stt
            // 
            this.stt.Location = new System.Drawing.Point(24, 100);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(70, 20);
            this.stt.TabIndex = 4;
            this.stt.TextChanged += new System.EventHandler(this.stt_TextChanged);
            // 
            // tenVoSinh
            // 
            this.tenVoSinh.Location = new System.Drawing.Point(131, 100);
            this.tenVoSinh.Name = "tenVoSinh";
            this.tenVoSinh.Size = new System.Drawing.Size(195, 20);
            this.tenVoSinh.TabIndex = 5;
            // 
            // soTien
            // 
            this.soTien.Location = new System.Drawing.Point(382, 100);
            this.soTien.Name = "soTien";
            this.soTien.Size = new System.Drawing.Size(178, 20);
            this.soTien.TabIndex = 6;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(533, 425);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(180, 52);
            this.Send.TabIndex = 8;
            this.Send.Text = "Gửi";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // XemVoSinh
            // 
            this.XemVoSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.XemVoSinh.Location = new System.Drawing.Point(23, 171);
            this.XemVoSinh.Name = "XemVoSinh";
            this.XemVoSinh.Size = new System.Drawing.Size(738, 235);
            this.XemVoSinh.TabIndex = 9;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(296, 33);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(70, 13);
            this.lable1.TabIndex = 10;
            this.lable1.Text = "Mã Phiếu thu";
            // 
            // maPhieuThu
            // 
            this.maPhieuThu.Location = new System.Drawing.Point(380, 30);
            this.maPhieuThu.Name = "maPhieuThu";
            this.maPhieuThu.ReadOnly = true;
            this.maPhieuThu.Size = new System.Drawing.Size(107, 20);
            this.maPhieuThu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ghi chú";
            // 
            // ghiChu
            // 
            this.ghiChu.Location = new System.Drawing.Point(201, 134);
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(461, 20);
            this.ghiChu.TabIndex = 13;
            // 
            // ngayThu
            // 
            this.ngayThu.Location = new System.Drawing.Point(588, 100);
            this.ngayThu.Name = "ngayThu";
            this.ngayThu.Size = new System.Drawing.Size(200, 20);
            this.ngayThu.TabIndex = 14;
            // 
            // BM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.ngayThu);
            this.Controls.Add(this.ghiChu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maPhieuThu);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.XemVoSinh);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.soTien);
            this.Controls.Add(this.tenVoSinh);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BM2";
            this.Text = "Nhập phiếu thu lệ phí";
            ((System.ComponentModel.ISupportInitialize)(this.XemVoSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stt;
        private System.Windows.Forms.TextBox tenVoSinh;
        private System.Windows.Forms.TextBox soTien;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.DataGridView XemVoSinh;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox maPhieuThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ghiChu;
        private System.Windows.Forms.DateTimePicker ngayThu;
    }
}