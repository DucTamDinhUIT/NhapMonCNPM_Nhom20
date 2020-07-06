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
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVoSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TimKiem);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(40, 29);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(277, 20);
            this.searchText.TabIndex = 2;
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
            // bShowAll
            // 
            this.bShowAll.Location = new System.Drawing.Point(539, 25);
            this.bShowAll.Name = "bShowAll";
            this.bShowAll.Size = new System.Drawing.Size(131, 26);
            this.bShowAll.TabIndex = 6;
            this.bShowAll.Text = "Xem tất cả";
            this.bShowAll.UseVisualStyleBackColor = true;
            this.bShowAll.Click += new System.EventHandler(this.BShowAll_Click);
            // 
            // dataVoSinh
            // 
            this.dataVoSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVoSinh.Location = new System.Drawing.Point(49, 118);
            this.dataVoSinh.Name = "dataVoSinh";
            this.dataVoSinh.Size = new System.Drawing.Size(721, 291);
            this.dataVoSinh.TabIndex = 7;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(346, 73);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(175, 26);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Xoá";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(539, 73);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(131, 26);
            this.Edit.TabIndex = 9;
            this.Edit.Text = "Sửa";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // BM5_FindInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataVoSinh);
            this.Controls.Add(this.bShowAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
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
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bShowAll;
        private System.Windows.Forms.DataGridView dataVoSinh;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
    }
}