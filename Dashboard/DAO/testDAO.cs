using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLyCLBVoThuat.GUI;

namespace QuanLyCLBVoThuat.DAO
{
    class TestDAO
    {
        private static TestDAO instance;
        private DataTable result;

        public static TestDAO Instance
        {
            get { if (instance == null) instance = new TestDAO(); return instance; }
            private set { instance = value; }
        }

        private TestDAO() { }

        public bool Login(string voSinhId, string ten)
        {
            string query = "VoSinh_Find @voSinhId , @ten";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { voSinhId, ten });
            return result.Rows.Count > 0;
        }
        public bool InsertFood(string userName, string passWord)
        {
            // string query = string.Format("INSERT dbo.VoSinh ( TenVoSinh , Truong ) VALUES  ( N'{0}', N '{1}' )", userName, passWord);
            string query = "VoSinh_Insert @voSinhId , @ten";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
