using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCLBVoThuat.DAO;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyCLBVoThuat.DTO;


namespace QuanLyCLBVoThuat
{
    public partial class BM4 : Form
    {
        public BM4()
        {
            InitializeComponent();
            dataGridView1.DataSource = ShowData();
            ID_load();
        }

        private object ShowData()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string command = "SELECT dbo.VoSinh.STT, dbo.DiemThi.DiemThi, dbo.DiemThi.KetQua, dbo.DiemThi.CapBacHienTai, dbo.DiemThi.CapBacKeTiep, dbo.DiemThi.NgayKiemTra, dbo.DiemThi.NguoiKiemTra, dbo.DiemThi.GhiChu  FROM dbo.VoSinh INNER JOIN dbo.DiemThi ON dbo.VoSinh.STT = dbo.DiemThi.STT";
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                //using (SqlCommand cmd = new SqlCommand("SELECT dbo.VoSinh.STT, dbo.VoSinh.TenVoSinh, dbo.DiemThi.DiemThi, dbo.DiemThi.CapBacHienTai, dbo.DiemThi.CapBacKeTiep FROM dbo.VoSinh INNER JOIN dbo.DiemThi ON dbo.VoSinh.STT = 0", con))
                using (SqlCommand cmd = new SqlCommand(command, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                };
            }
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            stt_tb.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            diemthi_tb.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            ketqua_tb.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            caphientai_tb.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            capketiep_tb.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            ngaykiemtra_tb.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            nguoikiemtra_tb.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            ghichu_tb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                string stt = stt_tb.Text;
                string diemthi = diemthi_tb.Text;
                string ketqua = ketqua_tb.Text;
                string caphientai = caphientai_tb.Text;
                string capketiep = caphientai_tb.Text;
                string ngaykiemtra = ngaykiemtra_tb.Text;
                string nguoikiemtra = nguoikiemtra_tb.Text;
                string ghichu = ghichu_tb.Text;

                if (VoSinhDAO.Instance.UpdateMatch(stt, diemthi, ketqua, caphientai, capketiep, ngaykiemtra, nguoikiemtra, ghichu))
                {
                    ShowData();
                    MessageBox.Show("Sửa thành công");
                    ID_load();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }

            }
            //return data;
            dataGridView1.DataSource = ShowData();
        }

        private DataTable ID_load()
        {
            string query = "SELECT MAX (MaDiemThi) FROM dbo.DiemThi";
            DataTable MaxSTT = new DataTable();
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
                        textBox1.Text = max.ToString();
                    }
                    con.Close();
                };
            }
            return MaxSTT;
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                string stt = stt_tb.Text;
                string madiemthi = textBox1.Text;
                string diemthi = diemthi_tb.Text;
                string ketqua = ketqua_tb.Text;
                string caphientai = caphientai_tb.Text;
                string capketiep = caphientai_tb.Text;
                string ngaykiemtra = ngaykiemtra_tb.Text;
                string nguoikiemtra = nguoikiemtra_tb.Text;
                string ghichu = ghichu_tb.Text;

                if (VoSinhDAO.Instance.InsertMatch(madiemthi, stt, diemthi, ketqua, caphientai, capketiep, ngaykiemtra, nguoikiemtra, ghichu))
                {
                    ShowData();
                    MessageBox.Show("Thêm thành công");
                    ID_load();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Thêm");
                }

            }
            //return data;
            dataGridView1.DataSource = ShowData();
        }

        private void stt_tb_TextChanged(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                con.Open();

                if (stt_tb.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("SELECT TenVoSinh FROM dbo.VoSinh FULL JOIN dbo.DiemThi ON dbo.VoSinh.STT = dbo.DiemThi.STT WHERE dbo.VoSinh.STT = @STT", con);
                    cmd.Parameters.AddWithValue("@STT", int.Parse(stt_tb.Text));
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        TenVoSinh.Text = reader.GetValue(0).ToString();
                    }
                }

                con.Close();
            }
        }
    }
}
