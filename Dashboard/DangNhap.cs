using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace QuanLyCLBVoThuat
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Dang_Nhap(object sender, EventArgs e)
        {
            //xac dinh duong dan den database

            //ket noi csdl bang Sqlconnection

            MySqlConnection conn = DBUtils.GetDBConnection();

            try
            {
                //Mo ket noi
                conn.Open();
            }
            catch (InvalidOperationException)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Khong the mo ket noi hoac ket noi da mo truoc do");
            }
            catch (Exception)
            {
                //xu ly khi ket noi co van de
                MessageBox.Show("Ket noi xay ra loi hoac doc du lieu bi loi");
            }
            finally
            {
                //Dong ket noi sau khi thao tac ket thuc
                conn.Close();
            }
            DashboardControl dashboard = new DashboardControl();
                dashboard.ShowDialog();
        }
    }
}
