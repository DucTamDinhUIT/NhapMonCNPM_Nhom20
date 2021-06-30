namespace QuanLyCLBVoThuat
{
    partial class BM5_FindInfor
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
            this.button1 = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bShowAll = new System.Windows.Forms.Button();
            this.dataVoSinh = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_NgayThamGia = new System.Windows.Forms.DateTimePicker();
            this.tb_SinhNhat = new System.Windows.Forms.DateTimePicker();
            this.tb_Truong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_CapBac = new System.Windows.Forms.TextBox();
            this.tb_TenVoSinh = new System.Windows.Forms.TextBox();
            this.tb_STT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TimKiem);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(49, 60);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(277, 20);
            this.searchText.TabIndex = 2;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ký tự";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(547, 43);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(175, 53);
            this.bShowAll.TabIndex = 6;
            this.bShowAll.Text = "Xem tất cả";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.BShowAll_Click);
            // 
            // dataVoSinh
            // 
            this.dataVoSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoSinh.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataVoSinh.Location = new System.Drawing.Point(49, 118);
            this.dataVoSinh.Name = "dataVoSinh";
            this.dataVoSinh.Size = new System.Drawing.Size(721, 156);
            this.dataVoSinh.TabIndex = 7;
            this.dataVoSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataVoSinh_CellContentClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tb_NgayThamGia);
            this.groupBox1.Controls.Add(this.tb_SinhNhat);
            this.groupBox1.Controls.Add(this.tb_Truong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_CapBac);
            this.groupBox1.Controls.Add(this.tb_TenVoSinh);
            this.groupBox1.Controls.Add(this.tb_STT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 249);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa trực tiếp";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 80);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_NgayThamGia
            // 
            this.tb_NgayThamGia.Location = new System.Drawing.Point(149, 198);
            this.tb_NgayThamGia.Name = "tb_NgayThamGia";
            this.tb_NgayThamGia.Size = new System.Drawing.Size(238, 20);
            this.tb_NgayThamGia.TabIndex = 13;
            // 
            // tb_SinhNhat
            // 
            this.tb_SinhNhat.Location = new System.Drawing.Point(149, 126);
            this.tb_SinhNhat.Name = "tb_SinhNhat";
            this.tb_SinhNhat.Size = new System.Drawing.Size(238, 20);
            this.tb_SinhNhat.TabIndex = 12;
            // 
            // tb_Truong
            // 
            this.tb_Truong.Location = new System.Drawing.Point(149, 93);
            this.tb_Truong.Name = "tb_Truong";
            this.tb_Truong.Size = new System.Drawing.Size(238, 20);
            this.tb_Truong.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cấp bậc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ngày Tham Gia";
            // 
            // tb_CapBac
            // 
            this.tb_CapBac.Location = new System.Drawing.Point(149, 165);
            this.tb_CapBac.Name = "tb_CapBac";
            this.tb_CapBac.Size = new System.Drawing.Size(238, 20);
            this.tb_CapBac.TabIndex = 6;
            // 
            // tb_TenVoSinh
            // 
            this.tb_TenVoSinh.Location = new System.Drawing.Point(149, 57);
            this.tb_TenVoSinh.Name = "tb_TenVoSinh";
            this.tb_TenVoSinh.Size = new System.Drawing.Size(238, 20);
            this.tb_TenVoSinh.TabIndex = 5;
            // 
            // tb_STT
            // 
            this.tb_STT.Location = new System.Drawing.Point(149, 23);
            this.tb_STT.Name = "tb_STT";
            this.tb_STT.Size = new System.Drawing.Size(238, 20);
            this.tb_STT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sinh Nhật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trường";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Võ Sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "STT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 80);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BM5_FindInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataVoSinh);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.button1);
            this.Name = "BM5_FindInfor";
            this.Text = "Tìm kiếm danh sách võ sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataVoSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bShowAll;
        private System.Windows.Forms.DataGridView dataVoSinh;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CapBac;
        private System.Windows.Forms.TextBox tb_TenVoSinh;
        private System.Windows.Forms.TextBox tb_STT;
        private System.Windows.Forms.TextBox tb_Truong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tb_NgayThamGia;
        private System.Windows.Forms.DateTimePicker tb_SinhNhat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}