using QuanLyCLBVoThuat.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLBVoThuat.DTO
{
    public class VoSinh
    {
        public VoSinh(string stt, string tenvosinh, string truong)
        {
            this.STT = stt;
            this.TenVoSinh = tenvosinh;
            this.Truong = truong;

        }
        DataTable TimKiem(string hoTen, string capBac)
        {
            return VoSinhDAO.Instance.TimKiem(hoTen, capBac);
        }
        private string truong;

        public string Truong
        {
            get { return truong; }
            set { truong = value; }
        }

        private string tenvosinh;

        public string TenVoSinh
        {
            get { return tenvosinh; }
            set { tenvosinh = value; }
        }

        public string STT { get; set; }
    }
}
