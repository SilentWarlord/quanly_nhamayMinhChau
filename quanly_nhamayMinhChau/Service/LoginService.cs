using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Models;

namespace quanly_nhamayMinhChau.Service
{
    internal class LoginService
    {
        NhanVien nv;
        SqlConnection conn;

        public Boolean Login(string phone, string password)
        {
            using(conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM NhanVien WHERE ";
                SqlCommand cmd = new SqlCommand(query,conn);
                
                conn.Open();
                SqlDataReader dt = cmd.ExecuteReader();

                if (dt.Read())
                {
                    nv = new NhanVien();
                    //nhan vien

                    conn.Close();
                    return true;
                }

                conn.Close();
                return false;
            }
        }
        public void ForgotPass()
        {
            
        }
        public NhanVien SetNhanVien()
        {
            return nv;
        }
    }
}
