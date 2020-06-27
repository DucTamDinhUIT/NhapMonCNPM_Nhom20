namespace QuanLyCLBVoThuat
{
    partial class BM6
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.MaVoSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenVoSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CapBac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KetQua = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TrungBinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CapBacMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaVoSinh,
            this.TenVoSinh,
            this.CapBac,
            this.Diem,
            this.TrungBinh,
            this.KetQua,
            this.CapBacMoi});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(798, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // MaVoSinh
            // 
            this.MaVoSinh.Text = "Mã Võ sinh";
            this.MaVoSinh.Width = 96;
            // 
            // TenVoSinh
            // 
            this.TenVoSinh.Text = "Tên võ sinh";
            this.TenVoSinh.Width = 203;
            // 
            // CapBac
            // 
            this.CapBac.Text = "Cấp bậc";
            this.CapBac.Width = 69;
            // 
            // Diem
            // 
            this.Diem.Text = "Điểm chấm";
            this.Diem.Width = 100;
            // 
            // KetQua
            // 
            this.KetQua.DisplayIndex = 4;
            this.KetQua.Text = "Kết quả chấm";
            this.KetQua.Width = 86;
            // 
            // TrungBinh
            // 
            this.TrungBinh.DisplayIndex = 5;
            this.TrungBinh.Text = "Trung bình";
            this.TrungBinh.Width = 82;
            // 
            // CapBacMoi
            // 
            this.CapBacMoi.Text = "Cấp bậc mới";
            this.CapBacMoi.Width = 147;
            // 
            // BM6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "BM6";
            this.Text = "Xuất kết quả thi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MaVoSinh;
        private System.Windows.Forms.ColumnHeader TenVoSinh;
        private System.Windows.Forms.ColumnHeader CapBac;
        private System.Windows.Forms.ColumnHeader Diem;
        private System.Windows.Forms.ColumnHeader TrungBinh;
        private System.Windows.Forms.ColumnHeader KetQua;
        private System.Windows.Forms.ColumnHeader CapBacMoi;
    }
}