namespace QuanLyCLBVoThuat
{
    partial class BM1_SetInfor
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
            this.tenVoSinh = new System.Windows.Forms.TextBox();
            this.truongTh = new System.Windows.Forms.TextBox();
            this.sinhNhat = new System.Windows.Forms.TextBox();
            this.soThuTu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.capBac = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.dataShow = new System.Windows.Forms.DataGridView();
            this.ExitClick = new System.Windows.Forms.Button();
            this.ngayThamGia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // tenVoSinh
            // 
            this.tenVoSinh.Location = new System.Drawing.Point(43, 134);
            this.tenVoSinh.Name = "tenVoSinh";
            this.tenVoSinh.Size = new System.Drawing.Size(100, 20);
            this.tenVoSinh.TabIndex = 0;
            // 
            // truongTh
            // 
            this.truongTh.Location = new System.Drawing.Point(188, 134);
            this.truongTh.Name = "truongTh";
            this.truongTh.Size = new System.Drawing.Size(100, 20);
            this.truongTh.TabIndex = 1;
            // 
            // sinhNhat
            // 
            this.sinhNhat.Location = new System.Drawing.Point(337, 134);
            this.sinhNhat.Name = "sinhNhat";
            this.sinhNhat.Size = new System.Drawing.Size(100, 20);
            this.sinhNhat.TabIndex = 2;
            // 
            // soThuTu
            // 
            this.soThuTu.Location = new System.Drawing.Point(356, 39);
            this.soThuTu.Name = "soThuTu";
            this.soThuTu.ReadOnly = true;
            this.soThuTu.Size = new System.Drawing.Size(132, 20);
            this.soThuTu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "STT Võ sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sinh nhật";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cấp bậc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày tham gia";
            // 
            // capBac
            // 
            this.capBac.FormattingEnabled = true;
            this.capBac.Items.AddRange(new object[] {
            "Trắng",
            "Vàng",
            "Cam",
            "Lục",
            "Lam",
            "Đỏ",
            "Nâu",
            "Đen"});
            this.capBac.Location = new System.Drawing.Point(481, 134);
            this.capBac.Name = "capBac";
            this.capBac.Size = new System.Drawing.Size(121, 21);
            this.capBac.TabIndex = 12;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(208, 176);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(329, 42);
            this.bAdd.TabIndex = 13;
            this.bAdd.Text = "Thêm";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.Button_Add);
            // 
            // dataShow
            // 
            this.dataShow.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.dataShow.AllowUserToAddRows = false;
            this.dataShow.AllowUserToDeleteRows = false;
            this.dataShow.AllowUserToOrderColumns = true;
            this.dataShow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShow.Location = new System.Drawing.Point(34, 239);
            this.dataShow.Name = "dataShow";
            this.dataShow.ReadOnly = true;
            this.dataShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataShow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataShow.Size = new System.Drawing.Size(803, 260);
            this.dataShow.TabIndex = 14;
            // 
            // ExitClick
            // 
            this.ExitClick.Location = new System.Drawing.Point(562, 176);
            this.ExitClick.Name = "ExitClick";
            this.ExitClick.Size = new System.Drawing.Size(137, 42);
            this.ExitClick.TabIndex = 15;
            this.ExitClick.Text = "Thoát";
            this.ExitClick.UseVisualStyleBackColor = true;
            this.ExitClick.Click += new System.EventHandler(this.ExitClick_Click);
            // 
            // ngayThamGia
            // 
            this.ngayThamGia.Location = new System.Drawing.Point(637, 135);
            this.ngayThamGia.Name = "ngayThamGia";
            this.ngayThamGia.Size = new System.Drawing.Size(200, 20);
            this.ngayThamGia.TabIndex = 16;
            // 
            // BM1_SetInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 527);
            this.Controls.Add(this.ngayThamGia);
            this.Controls.Add(this.ExitClick);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.capBac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soThuTu);
            this.Controls.Add(this.sinhNhat);
            this.Controls.Add(this.truongTh);
            this.Controls.Add(this.tenVoSinh);
            this.Name = "BM1_SetInfor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Nhập thông tin võ sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenVoSinh;
        private System.Windows.Forms.TextBox truongTh;
        private System.Windows.Forms.TextBox sinhNhat;
        private System.Windows.Forms.TextBox soThuTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox capBac;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.DataGridView dataShow;
        private System.Windows.Forms.Button ExitClick;
        private System.Windows.Forms.DateTimePicker ngayThamGia;
    }
}