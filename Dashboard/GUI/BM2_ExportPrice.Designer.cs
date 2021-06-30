
namespace QuanLyCLBVoThuat.GUI
{
    partial class BM2_ExportPrice
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
            this.SoTienChi = new System.Windows.Forms.TextBox();
            this.NoiDung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CacKhoanChi = new System.Windows.Forms.DataGridView();
            this.maPhieuChi = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.NgayChi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.CacKhoanChi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội Dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày tháng";
            // 
            // SoTienChi
            // 
            this.SoTienChi.Location = new System.Drawing.Point(177, 111);
            this.SoTienChi.Name = "SoTienChi";
            this.SoTienChi.Size = new System.Drawing.Size(289, 20);
            this.SoTienChi.TabIndex = 4;
            // 
            // NoiDung
            // 
            this.NoiDung.Location = new System.Drawing.Point(177, 203);
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(289, 20);
            this.NoiDung.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 93);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CacKhoanChi
            // 
            this.CacKhoanChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CacKhoanChi.Location = new System.Drawing.Point(28, 246);
            this.CacKhoanChi.Name = "CacKhoanChi";
            this.CacKhoanChi.Size = new System.Drawing.Size(738, 180);
            this.CacKhoanChi.TabIndex = 10;
            // 
            // maPhieuChi
            // 
            this.maPhieuChi.Location = new System.Drawing.Point(245, 25);
            this.maPhieuChi.Name = "maPhieuChi";
            this.maPhieuChi.ReadOnly = true;
            this.maPhieuChi.Size = new System.Drawing.Size(107, 20);
            this.maPhieuChi.TabIndex = 13;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(161, 28);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(69, 13);
            this.lable1.TabIndex = 12;
            this.lable1.Text = "Mã Phiếu chi";
            // 
            // NgayChi
            // 
            this.NgayChi.Location = new System.Drawing.Point(177, 161);
            this.NgayChi.Name = "NgayChi";
            this.NgayChi.Size = new System.Drawing.Size(289, 20);
            this.NgayChi.TabIndex = 15;
            // 
            // BM2_ExportPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NgayChi);
            this.Controls.Add(this.maPhieuChi);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.CacKhoanChi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NoiDung);
            this.Controls.Add(this.SoTienChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BM2_ExportPrice";
            this.Text = "Nhập phiếu Chi";
            ((System.ComponentModel.ISupportInitialize)(this.CacKhoanChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoTienChi;
        private System.Windows.Forms.TextBox NoiDung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView CacKhoanChi;
        private System.Windows.Forms.TextBox maPhieuChi;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.DateTimePicker NgayChi;
    }
}