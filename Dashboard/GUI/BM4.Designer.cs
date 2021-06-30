namespace QuanLyCLBVoThuat
{
    partial class BM4
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DiemThi = new System.Windows.Forms.Label();
            this.KetQua = new System.Windows.Forms.Label();
            this.CapHienTai = new System.Windows.Forms.Label();
            this.CapKeTiep = new System.Windows.Forms.Label();
            this.diemthi_tb = new System.Windows.Forms.TextBox();
            this.NguoiKiemTra = new System.Windows.Forms.Label();
            this.GhiChu = new System.Windows.Forms.Label();
            this.NgayKiemTra = new System.Windows.Forms.Label();
            this.ketqua_tb = new System.Windows.Forms.TextBox();
            this.caphientai_tb = new System.Windows.Forms.TextBox();
            this.capketiep_tb = new System.Windows.Forms.TextBox();
            this.nguoikiemtra_tb = new System.Windows.Forms.TextBox();
            this.ghichu_tb = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.stt_tb = new System.Windows.Forms.TextBox();
            this.STT = new System.Windows.Forms.Label();
            this.MaDiemThi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.TenVoSinh = new System.Windows.Forms.TextBox();
            this.ngaykiemtra_tb = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(329, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(693, 450);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(678, 411);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DiemThi
            // 
            this.DiemThi.AutoSize = true;
            this.DiemThi.Location = new System.Drawing.Point(22, 114);
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Size = new System.Drawing.Size(49, 13);
            this.DiemThi.TabIndex = 7;
            this.DiemThi.Text = "Điểm Thi";
            // 
            // KetQua
            // 
            this.KetQua.AutoSize = true;
            this.KetQua.Location = new System.Drawing.Point(22, 155);
            this.KetQua.Name = "KetQua";
            this.KetQua.Size = new System.Drawing.Size(44, 13);
            this.KetQua.TabIndex = 8;
            this.KetQua.Text = "Kết quả";
            this.KetQua.Click += new System.EventHandler(this.label2_Click);
            // 
            // CapHienTai
            // 
            this.CapHienTai.AutoSize = true;
            this.CapHienTai.Location = new System.Drawing.Point(22, 197);
            this.CapHienTai.Name = "CapHienTai";
            this.CapHienTai.Size = new System.Drawing.Size(63, 13);
            this.CapHienTai.TabIndex = 10;
            this.CapHienTai.Text = "Cấp hiện tại";
            // 
            // CapKeTiep
            // 
            this.CapKeTiep.AutoSize = true;
            this.CapKeTiep.Location = new System.Drawing.Point(22, 233);
            this.CapKeTiep.Name = "CapKeTiep";
            this.CapKeTiep.Size = new System.Drawing.Size(61, 13);
            this.CapKeTiep.TabIndex = 9;
            this.CapKeTiep.Text = "Cấp kế tiếp";
            // 
            // diemthi_tb
            // 
            this.diemthi_tb.Location = new System.Drawing.Point(109, 111);
            this.diemthi_tb.Name = "diemthi_tb";
            this.diemthi_tb.Size = new System.Drawing.Size(201, 20);
            this.diemthi_tb.TabIndex = 11;
            // 
            // NguoiKiemTra
            // 
            this.NguoiKiemTra.AutoSize = true;
            this.NguoiKiemTra.Location = new System.Drawing.Point(22, 307);
            this.NguoiKiemTra.Name = "NguoiKiemTra";
            this.NguoiKiemTra.Size = new System.Drawing.Size(76, 13);
            this.NguoiKiemTra.TabIndex = 14;
            this.NguoiKiemTra.Text = "Người Kiểm tra";
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSize = true;
            this.GhiChu.Location = new System.Drawing.Point(22, 342);
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(45, 13);
            this.GhiChu.TabIndex = 13;
            this.GhiChu.Text = "Ghi Chú";
            // 
            // NgayKiemTra
            // 
            this.NgayKiemTra.AutoSize = true;
            this.NgayKiemTra.Location = new System.Drawing.Point(22, 272);
            this.NgayKiemTra.Name = "NgayKiemTra";
            this.NgayKiemTra.Size = new System.Drawing.Size(72, 13);
            this.NgayKiemTra.TabIndex = 12;
            this.NgayKiemTra.Text = "Ngày kiểm tra";
            // 
            // ketqua_tb
            // 
            this.ketqua_tb.Location = new System.Drawing.Point(109, 152);
            this.ketqua_tb.Name = "ketqua_tb";
            this.ketqua_tb.Size = new System.Drawing.Size(201, 20);
            this.ketqua_tb.TabIndex = 15;
            // 
            // caphientai_tb
            // 
            this.caphientai_tb.Location = new System.Drawing.Point(109, 194);
            this.caphientai_tb.Name = "caphientai_tb";
            this.caphientai_tb.Size = new System.Drawing.Size(201, 20);
            this.caphientai_tb.TabIndex = 16;
            // 
            // capketiep_tb
            // 
            this.capketiep_tb.Location = new System.Drawing.Point(109, 230);
            this.capketiep_tb.Name = "capketiep_tb";
            this.capketiep_tb.Size = new System.Drawing.Size(201, 20);
            this.capketiep_tb.TabIndex = 17;
            // 
            // nguoikiemtra_tb
            // 
            this.nguoikiemtra_tb.Location = new System.Drawing.Point(109, 304);
            this.nguoikiemtra_tb.Name = "nguoikiemtra_tb";
            this.nguoikiemtra_tb.Size = new System.Drawing.Size(201, 20);
            this.nguoikiemtra_tb.TabIndex = 19;
            // 
            // ghichu_tb
            // 
            this.ghichu_tb.Location = new System.Drawing.Point(109, 339);
            this.ghichu_tb.Name = "ghichu_tb";
            this.ghichu_tb.Size = new System.Drawing.Size(201, 20);
            this.ghichu_tb.TabIndex = 20;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(25, 382);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(138, 56);
            this.Submit.TabIndex = 21;
            this.Submit.Text = "Chỉnh sửa";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // stt_tb
            // 
            this.stt_tb.Location = new System.Drawing.Point(109, 27);
            this.stt_tb.Name = "stt_tb";
            this.stt_tb.Size = new System.Drawing.Size(54, 20);
            this.stt_tb.TabIndex = 22;
            this.stt_tb.TextChanged += new System.EventHandler(this.stt_tb_TextChanged);
            // 
            // STT
            // 
            this.STT.AutoSize = true;
            this.STT.Location = new System.Drawing.Point(22, 30);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(28, 13);
            this.STT.TabIndex = 23;
            this.STT.Text = "STT";
            // 
            // MaDiemThi
            // 
            this.MaDiemThi.AutoSize = true;
            this.MaDiemThi.Location = new System.Drawing.Point(196, 30);
            this.MaDiemThi.Name = "MaDiemThi";
            this.MaDiemThi.Size = new System.Drawing.Size(18, 13);
            this.MaDiemThi.TabIndex = 25;
            this.MaDiemThi.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(54, 20);
            this.textBox1.TabIndex = 24;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(172, 382);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(138, 56);
            this.Insert.TabIndex = 26;
            this.Insert.Text = "Ghi điểm";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // TenVoSinh
            // 
            this.TenVoSinh.Location = new System.Drawing.Point(40, 67);
            this.TenVoSinh.Name = "TenVoSinh";
            this.TenVoSinh.ReadOnly = true;
            this.TenVoSinh.Size = new System.Drawing.Size(249, 20);
            this.TenVoSinh.TabIndex = 27;
            // 
            // ngaykiemtra_tb
            // 
            this.ngaykiemtra_tb.Location = new System.Drawing.Point(110, 266);
            this.ngaykiemtra_tb.Name = "ngaykiemtra_tb";
            this.ngaykiemtra_tb.Size = new System.Drawing.Size(200, 20);
            this.ngaykiemtra_tb.TabIndex = 28;
            // 
            // BM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.ngaykiemtra_tb);
            this.Controls.Add(this.TenVoSinh);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.MaDiemThi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.stt_tb);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ghichu_tb);
            this.Controls.Add(this.nguoikiemtra_tb);
            this.Controls.Add(this.capketiep_tb);
            this.Controls.Add(this.caphientai_tb);
            this.Controls.Add(this.ketqua_tb);
            this.Controls.Add(this.NguoiKiemTra);
            this.Controls.Add(this.GhiChu);
            this.Controls.Add(this.NgayKiemTra);
            this.Controls.Add(this.diemthi_tb);
            this.Controls.Add(this.CapHienTai);
            this.Controls.Add(this.CapKeTiep);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.DiemThi);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "BM4";
            this.Text = "Nhập điểm thi ";
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DiemThi;
        private System.Windows.Forms.Label KetQua;
        private System.Windows.Forms.Label CapHienTai;
        private System.Windows.Forms.Label CapKeTiep;
        private System.Windows.Forms.TextBox diemthi_tb;
        private System.Windows.Forms.Label NguoiKiemTra;
        private System.Windows.Forms.Label GhiChu;
        private System.Windows.Forms.Label NgayKiemTra;
        private System.Windows.Forms.TextBox ketqua_tb;
        private System.Windows.Forms.TextBox caphientai_tb;
        private System.Windows.Forms.TextBox capketiep_tb;
        private System.Windows.Forms.TextBox nguoikiemtra_tb;
        private System.Windows.Forms.TextBox ghichu_tb;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox stt_tb;
        private System.Windows.Forms.Label STT;
        private System.Windows.Forms.Label MaDiemThi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TextBox TenVoSinh;
        private System.Windows.Forms.DateTimePicker ngaykiemtra_tb;
    }
}