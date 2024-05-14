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
    internal class SanPhamService
    {
        SqlConnection conn;
        List<SanPham> list;
        string lastid;

        public List<SanPham> GetAll()
        {
            list = new List<SanPham>();
            using (conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM SanPham ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.maSanPham = (string)reader["maSanPham"];
                    sanPham.tenSanPham = (string)reader["tenSanPham"];
                    list.Add(sanPham);
                    lastid = sanPham.maSanPham;
                }
            }
            conn.Close();
            return list;
        }
        public void Add(SanPham sanPham)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "INSERT INTO SanPham VALUES(@maSanPham,@tenSanPham)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maSanPham", sanPham.maSanPham);
                cmd.Parameters.AddWithValue("@tenSanPham", sanPham.tenSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Update(SanPham sanPham)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "UPDATE SanPham SET tenSanPham = @tenSanPham WHERE maSanPham = @maSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maSanPham", sanPham.maSanPham);
                cmd.Parameters.AddWithValue("@tenSanPham", sanPham.tenSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Delete(string maSanPham)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "DELETE * FROM SanPham WHERE maSanPham = @maSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maSanPham", maSanPham);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public List<SanPham> Search(string type, string key)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "SELECT * FROM NhanVien WHERE " + type + " LIKE '%" + key + "%'";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPham sanPham = new SanPham();
                    sanPham.maSanPham = (string)reader["maSanPham"];
                    sanPham.tenSanPham = (string)reader["tenSanPham"];
                    list.Add(sanPham);
                }
            }
            conn.Close();
            return list;
        }
    
        public string GetID()
        {
            return lastid;
        }
    }
}
