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


namespace QuanLyCLBVoThuat
{
    public partial class BM1_SetInfor : Form
    {
        public BM1_SetInfor()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
                string stt = textBox6.Text;
                string tenvosinh = textBox2.Text;
                string truong = textBox3.Text;
            if (VoSinhDAO.Instance.InsertInfo(stt, tenvosinh, truong))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm");
            }

        }
    }
}
