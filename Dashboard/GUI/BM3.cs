using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLBVoThuat
{
    public partial class BM3 : Form
    {
        public BM3()
        {
            InitializeComponent();
        }

        private void BM3_Load(object sender, EventArgs e)
        {
            phieuThuChi.DataSource = ShowThuChi();
        }

        private object ShowThuChi()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PhieuThu", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                };
            }
            return dataTable;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chức năng chưa được hoàn thiện", "Exit Please", MessageBoxButtons.OK);
            phieuThuChi.DataSource = ShowThuChi();
        }
    }
}
