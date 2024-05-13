using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.usercontrol;

namespace quanly_nhamayMinhChau.Service
{
    internal class LoginService
    {
        NhanVien nhanVien;
        SqlConnection conn;

        public Boolean Login(string SDT, string password)
        {
            using(conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM NhanVien WHERE SDT = @SDT AND password =@password";
                SqlCommand cmd = new SqlCommand(query,conn);

                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                }

                if (reader != null)
                {
                    nhanVien = new NhanVien();
                    //nhan vien
                    nhanVien.maNhanVien = (string)reader["maNhanVien"];
                    nhanVien.tenNhanVien = (string)reader["tenNhanVien"];
                    nhanVien.chucVu = (string)reader["chucVu"];
                    nhanVien.SDT = (string)reader["SDT"];
                    nhanVien.email = (string)reader["email"];
                    nhanVien.password = (string)reader["password"];
                    nhanVien.queQuan = (string)reader["queQuan"];
                    nhanVien.ngaySinh = (DateTime)reader["ngaySinh"];
                    nhanVien.ngayLam = (DateTime)reader["NgayLam"];
                    nhanVien.luong = (int)reader["luong"];


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
        public NhanVien Detail()
        {
            return nhanVien;
        }
    }
}
