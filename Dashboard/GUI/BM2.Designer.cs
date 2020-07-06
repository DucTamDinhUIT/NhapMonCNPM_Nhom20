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
            this.thang = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "STT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên võ sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền đóng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tháng";
            // 
            // stt
            // 
            this.stt.Location = new System.Drawing.Point(12, 136);
            this.stt.Name = "stt";
            this.stt.Size = new System.Drawing.Size(70, 20);
            this.stt.TabIndex = 4;
            // 
            // tenVoSinh
            // 
            this.tenVoSinh.Location = new System.Drawing.Point(119, 136);
            this.tenVoSinh.Name = "tenVoSinh";
            this.tenVoSinh.Size = new System.Drawing.Size(195, 20);
            this.tenVoSinh.TabIndex = 5;
            // 
            // soTien
            // 
            this.soTien.Location = new System.Drawing.Point(370, 136);
            this.soTien.Name = "soTien";
            this.soTien.Size = new System.Drawing.Size(178, 20);
            this.soTien.TabIndex = 6;
            // 
            // thang
            // 
            this.thang.FormattingEnabled = true;
            this.thang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.thang.Location = new System.Drawing.Point(575, 136);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(158, 21);
            this.thang.TabIndex = 7;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(480, 324);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(180, 52);
            this.Send.TabIndex = 8;
            this.Send.Text = "Gửi";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.soTien);
            this.Controls.Add(this.tenVoSinh);
            this.Controls.Add(this.stt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BM2";
            this.Text = "Nhập phiếu thu lệ phí";
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
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.Button Send;
    }
}