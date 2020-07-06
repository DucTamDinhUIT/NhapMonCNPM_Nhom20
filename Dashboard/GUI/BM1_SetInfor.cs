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

namespace QuanLyCLBVoThuat
{
    public partial class BM1_SetInfor : Form
    {
        public BM1_SetInfor()
        {
            InitializeComponent();
            SoThuTu_load();
        }
        private void Button_Add(object sender, EventArgs e)
        {        
            string stt = soThuTu.Text;
            string tenvosinh = tenVoSinh.Text;
            string truong = truongTh.Text;
            string sinhnhat = sinhNhat.Text;
            string capbac = capBac.Text;
            string ngaythamgia = ngayThamGia.Text;
            /*
            string query = "INSERT INTO dbo.VoSinh (STT, TenVoSinh, Truong, SinhNhat, CapBac, NgayThamGia)  VALUES(' " + stt + " ', ' " + tenvosinh + " ', '  " + truong + " ', '" + sinhnhat + "', '" + capbac + "', '" + ngaythamgia + "')";
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //string query = "INSERT INTO dbo.VoSinh (STT, TenVoSinh, Truong, SinhNhat, CapBac, NgayThamGia)  VALUES(' " + stt + " ', ' " + tenvosinh + " ', '  " + truong + " ', '" + sinhnhat + "', '" + capbac + "', '" + ngaythamgia + "')";
                
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                };
            }
            */
            
            if (VoSinhDAO.Instance.InsertInfo( stt , tenvosinh , truong , sinhnhat , capbac , ngaythamgia ))
            {
                MessageBox.Show("Thêm thành công");
                SoThuTu_load();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }
            
            dataShow.DataSource = GetData();
            
        } 
            private DataTable GetData()
            {
                DataTable dataTable = new DataTable();
                string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString))
                {
                //INSERT INTO dbo.VoSinh(STT, TenVoSinh, Truong, SinhNhat, CapBac, NgayThamGia)  VALUES('3', 'Thanh', 'UIT', 'Haiphong', 'trắng', '26/8');
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh", con))
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dataTable.Load(reader);
                        con.Close();
                    };
                }
                return dataTable;
            }
        private void ExitClick_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Exit?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private DataTable SoThuTu_load()
        {
            string query = "SELECT MAX (STT) FROM dbo.VoSinh";
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
                        soThuTu.Text = max.ToString() ;
                    }
                    con.Close();
                };
            }
            return MaxSTT;
        }
    }
}
