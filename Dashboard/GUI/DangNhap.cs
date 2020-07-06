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

namespace QuanLyCLBVoThuat
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }
        private void Dang_Nhap(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string passWord = textBox2.Text;
            if (Login(userName, passWord))
            {
                DashboardControl f = new DashboardControl();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Exit?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

    }
}
