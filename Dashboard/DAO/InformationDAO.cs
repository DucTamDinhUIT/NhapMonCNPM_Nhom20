using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCLBVoThuat.DAO
{
    public class InformationDAO
    {
        private static InformationDAO instance;

        public static InformationDAO Instance
        {
            get { if (instance == null) instance = new InformationDAO(); return instance; }
            private set { instance = value; }
        }
        public bool InsertInfo(string stt, string tenvosinh, string truong)
        {
            string query = string.Format("INSERT dbo.Information ( STT, TenVoSinh, Truong) VALUES  ( N'{0}', {1}, {2})", stt, tenvosinh, truong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateInfo(string stt, string tenvosinh, string truong)
        {
            string query = string.Format("UPDATE dbo.Information SET TenVoSinh = N'{0}', Truong = {1}, WHERE STT = {3}", stt, tenvosinh, truong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        /*
        public bool DeleteInfo(int idInfo)
        {
            BillInfoDAO.Instance.DeleteBillInfoByInfoID(idInfo);

            string query = string.Format("Delete Info where id = {0}", idInfo);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        */
    }
}
