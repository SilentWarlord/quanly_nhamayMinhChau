using quanly_nhamayMinhChau.usercontrol;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Models;

namespace quanly_nhamayMinhChau.Service
{
    internal class KhachHangService
    {
        List<KhachHang> list;
        string lastid;
        SqlConnection conn;

        public List<KhachHang> GetAll()
        {
            list = new List<KhachHang>();
            using(conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM KhachHang ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang();
                    kh.maKhachHang = (string)reader["maKhachHang"];
                    kh.tenKhachHang = (string)reader["tenKhachHang"];
                    kh.SDT = (string)reader["SDT"];
                    kh.diaChi = (string)reader["diaChi"];
                    kh.ngaySinh = (DateTime)reader["ngaySinh"];
                    list.Add(kh);
                    lastid = kh.maKhachHang;
                }
            }
            conn.Close();
            return list;
        }

        public void Add(KhachHang khachHang)
        {
            using(conn = Connection.GetConnection())
            {
                string query = "INSERT INTO KhachHang VALUES(@maKhachHang,@tenKhachHang,@SDT,@diaChi,@ngaySinh) ";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maKhachHang",khachHang.maKhachHang);
                cmd.Parameters.AddWithValue("@tenKhachHang", khachHang.tenKhachHang);
                cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                cmd.Parameters.AddWithValue("@diaChi", khachHang.diaChi);
                cmd.Parameters.AddWithValue("@ngaySinh", khachHang.ngaySinh);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();

            }
        }

        public void Update(KhachHang khachHang)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "UPDATE KhachHang SET tenKhachHang = @tenKhachHang,SDT = @SDT,diaChi = @diaChi,ngaySinh = @ngaySinh WHERE maKhachHang = @maKhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maKhachHang", khachHang.maKhachHang);
                cmd.Parameters.AddWithValue("@tenKhachHang", khachHang.tenKhachHang);
                cmd.Parameters.AddWithValue("@SDT", khachHang.SDT);
                cmd.Parameters.AddWithValue("@diaChi", khachHang.diaChi);
                cmd.Parameters.AddWithValue("@ngaySinh", khachHang.ngaySinh);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }

        }
        public void Delete(string maKhachHang)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "DELETE * FROM KhachHang WHERE maKhachHang = @maKhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maKhachHang",maKhachHang);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public List<KhachHang> Search(string type, string key)
        {
            using (conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM KhachHang WHERE " + type + " LIKE '%" + key + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang();
                    kh.maKhachHang = (string)reader["maKhachHang"];
                    kh.tenKhachHang = (string)reader["tenKhachHang"];
                    kh.SDT = (string)reader["SDT"];
                    kh.diaChi = (string)reader["diaChi"];
                    kh.ngaySinh = (DateTime)reader["ngaySinh"];
                    list.Add(kh);
                }
            }
            conn.Close();
            return list;
        }
    }
}
