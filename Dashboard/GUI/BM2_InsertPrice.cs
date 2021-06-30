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

namespace QuanLyCLBVoThuat
{
    public partial class BM2 : Form
    {
        public BM2()
        {
            InitializeComponent();
            MaPhieuThu_load();
            XemVoSinh.DataSource = GetData();
        }
        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.VoSinh.STT, dbo.VoSinh.TenVoSinh, dbo.PhieuThu.SoTienNop , dbo.PhieuThu.NgayThu, dbo.PhieuThu.GhiChu FROM dbo.VoSinh INNER JOIN dbo.PhieuThu ON dbo.VoSinh.STT = dbo.PhieuThu.STT", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    con.Close();
                };
            }
            return dataTable;
        }

        private DataTable MaPhieuThu_load()
        {
            string query = "SELECT MAX (MaPhieuThu) FROM dbo.PhieuThu";
            DataTable MaxPhieuThu = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //MaxSTT.Load(reader);
                    //string str = reader.ToString();
                    while (reader.Read())
                    {
                        string col1Value = reader[0].ToString();
                        int max = Int32.Parse(col1Value) + 1;
                        maPhieuThu.Text = max.ToString();
                    }
                    con.Close();
                };
            }
            return MaxPhieuThu;
        }

        private void stt_TextChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                if (stt.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT TenVoSinh, SoTienNop FROM dbo.VoSinh FULL JOIN dbo.PhieuThu ON dbo.VoSinh.STT = dbo.PhieuThu.STT WHERE dbo.VoSinh.STT = @STT", con);
                    //SqlCommand cmd = new SqlCommand("SELECT TenVoSinh, SoTienNop FROM dbo.VoSinh INNER JOIN dbo.PhieuThu ON dbo.VoSinh.STT WHERE dbo.VoSinh.STT = @STT", con);
                    cmd.Parameters.AddWithValue("@STT", int.Parse(stt.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tenVoSinh.Text = reader.GetValue(0).ToString();
                        soTien.Text = reader.GetValue(1).ToString();
                    }
                }

                con.Close();
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string stt_old = stt.Text;
            string maphieuthu = maPhieuThu.Text;
            string sotiendong = soTien.Text;
            string ngaythu = ngayThu.Text;
            string ghichu = ghiChu.Text;

            if (VoSinhDAO.Instance.InsertPrice(stt_old, maphieuthu, sotiendong, ngaythu, ghichu))
            {
                MessageBox.Show("Thêm thành công");
                MaPhieuThu_load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }

            XemVoSinh.DataSource = GetData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BM2_ExportPrice bm2exp = new BM2_ExportPrice();
            bm2exp.ShowDialog();
        }

    }

}
