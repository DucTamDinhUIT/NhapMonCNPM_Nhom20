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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.capbac1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bShowAll = new System.Windows.Forms.Button();
            this.dataVoSinh = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TimKiem);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 2;
            // 
            // capbac1
            // 
            this.capbac1.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên võ sinh",
            "Mã võ sinh",
            "Trường học",
            "Ngày sinh",
            "Cấp bậc",
            "Ngày tham gia"});
            this.capbac1.FormattingEnabled = true;
            this.capbac1.Location = new System.Drawing.Point(356, 29);
            this.capbac1.Name = "capbac1";
            this.capbac1.Size = new System.Drawing.Size(121, 21);
            this.capbac1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ký tự";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại";
            // 
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(690, 25);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(98, 26);
            this.bShowAll.TabIndex = 6;
            this.bShowAll.Text = "Xem tất cả";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.BShowAll_Click);
            // 
            // dataGridView1
            // 
            this.dataVoSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoSinh.Location = new System.Drawing.Point(49, 74);
            this.dataVoSinh.Name = "dataGridView1";
            this.dataVoSinh.Size = new System.Drawing.Size(721, 335);
            this.dataVoSinh.TabIndex = 7;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // BM5_FindInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataVoSinh);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.capbac1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "BM5_FindInfor";
            this.Text = "Tìm kiếm danh sách võ sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataVoSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox capbac1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bShowAll;
        private System.Windows.Forms.DataGridView dataVoSinh;
        private System.Data.DataSet dataSet1;
    }
}