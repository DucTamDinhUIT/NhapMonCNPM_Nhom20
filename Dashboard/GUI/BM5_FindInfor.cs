﻿using System;
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
    public partial class BM5_FindInfor : Form
    {
        public BM5_FindInfor()
        {
            InitializeComponent();
            //FindInfor_Load();
        }
        //string connecSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyCLB;Integrated Security=True";

        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7GALQ9H\SQLEXPRESS;Initial Catalog=QuanLyCLB;User ID=sa;Context Connection=True");
        BindingSource voSinhList = new BindingSource();
        //private SqlCommand cmd;

        /*
List<VoSinh> SearchVoSinhByName(string name)
{
List<VoSinh> listVoSinh = VoSinhDAO.Instance.SearchVoSinhByName(name);

return listVoSinh;
}
*/
        void FindInfor_Load()
        {
            //SqlConnection conn = new SqlConnection(conn);
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7GALQ9H\SQLEXPRESS;Initial Catalog=QuanLyCLB;User ID=sa;Context Connection=True");
            try
            {
                //Mo ket noi
                //SqlConnection conn = new SqlConnection(@"Data Source =.\\sqlexpress; Initial Catalog = QuanLyCLB; Integrated Security = True");
                conn.Open();
                //Chuan bi cau lenh query viet bang SQL
                string query = "SELECT * FROM dbo.VoSinh ";
                //Tao mot Sqlcommand de thuc hien cau lenh truy van da chuan bi voi ket noi hien tai
                SqlCommand command = new SqlCommand(query, conn);
                //Thuc hien cau truy van va nhan ve mot doi tuong reader ho tro do du lieu
                SqlDataReader reader = command.ExecuteReader();
                //Su dung reader de doc tung dong du lieu
                //va thuc hien thao tac xu ly mong muon voi du lieu doc len
                while (reader.HasRows)//con dong du lieu thi doc tiep
                {
                    if (reader.Read() == false) return;//doc ko duoc thi return
                    //xu ly khi da doc du lieu len
                    dataVoSinh.Rows.Add(reader.GetString(0), reader.GetBoolean(1),
                                            reader.GetInt32(2), reader.GetInt32(3),
                                            reader.GetInt32(4), reader.GetInt32(5));
                }
            }
            catch (InvalidOperationException ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception ex)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
        }
        private void TimKiem(object sender, EventArgs e)
        {
            dataVoSinh.DataSource = SearchVoSinhByName(searchText.Text);

        }

        private object SearchVoSinhByName(string text)
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh WHERE TenVoSinh LIKE '%" + text + "%'", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                };
            }
            return dataTable;
        }

        private void BShowAll_Click(object sender, EventArgs e)
        {
            dataVoSinh.DataSource = ShowData();
        }

        private object ShowData()
        {
            DataTable dataTable = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                //using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh INNER JOIN dbo.BienLai ON dbo.VoSinh.STT = dbo.BienLai.STT", con))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.VoSinh", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                };
            }
            return dataTable;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Chức năng chưa được hoàn thiện", "Exit Please", MessageBoxButtons.OK);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chức năng chưa được hoàn thiện", "Exit Please", MessageBoxButtons.OK);
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataVoSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataVoSinh.CurrentRow.Index;
            tb_STT.Text = dataVoSinh.Rows[i].Cells[0].Value.ToString();
            tb_TenVoSinh.Text = dataVoSinh.Rows[i].Cells[1].Value.ToString();
            tb_Truong.Text = dataVoSinh.Rows[i].Cells[2].Value.ToString();
            tb_SinhNhat.Text = dataVoSinh.Rows[i].Cells[3].Value.ToString();
            tb_CapBac.Text = dataVoSinh.Rows[i].Cells[4].Value.ToString();
            tb_NgayThamGia.Text = dataVoSinh.Rows[i].Cells[5].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                string stt = tb_STT.Text;
                string tenvosinh = tb_TenVoSinh.Text;
                string truong = tb_Truong.Text;
                string sinhnhat = tb_SinhNhat.Text;
                string capbac = tb_CapBac.Text;
                string ngaythamgia = tb_NgayThamGia.Text;

                if (VoSinhDAO.Instance.UpdateInfo(stt, tenvosinh, truong, sinhnhat, capbac, ngaythamgia))
                {
                    ShowData();
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Sửa");
                }
                
            }
            //return data;
            dataVoSinh.DataSource = ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connString))
            {
                string stt = tb_STT.Text;

                if (VoSinhDAO.Instance.DeleteInfo(stt))
                {
                    ShowData();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi Xóa");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}