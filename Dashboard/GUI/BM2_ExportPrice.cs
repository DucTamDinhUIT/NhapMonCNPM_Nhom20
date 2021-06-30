using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyCLBVoThuat.DAO;
using QuanLyCLBVoThuat.DTO;
using System.Configuration;
using QuanLyCLBVoThuat.GUI;

namespace QuanLyCLBVoThuat.GUI
{
    public partial class BM2_ExportPrice : Form
    {
        public BM2_ExportPrice()
        {
            InitializeComponent();
            MaPhieuChi_load();
            CacKhoanChi.DataSource = GetData();
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.PhieuChi", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    con.Close();
                };
            }
            return dataTable;
        }

        private DataTable MaPhieuChi_load()
        {
            string query = "SELECT MAX (MaPhieuChi) FROM dbo.PhieuChi";
            DataTable MaxPhieuChi = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string col1Value = reader[0].ToString();
                        int max = Int32.Parse(col1Value) + 1;
                        maPhieuChi.Text = max.ToString();
                    }
                    con.Close();
                };
            }
            return MaxPhieuChi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maphieuchi = maPhieuChi.Text;
            string sotienchi = SoTienChi.Text;
            string ngaychi = NgayChi.Text;
            string noidung = NoiDung.Text;

            if (VoSinhDAO.Instance.ExportPrice(maphieuchi, sotienchi, ngaychi, noidung))
            {
                MessageBox.Show("Thêm thành công");
                MaPhieuChi_load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
            CacKhoanChi.DataSource = GetData();
        }
    }
}
