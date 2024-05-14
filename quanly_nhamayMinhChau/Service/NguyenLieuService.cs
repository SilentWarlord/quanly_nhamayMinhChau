using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.usercontrol;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanly_nhamayMinhChau.Service
{
    internal class NguyenLieuService
    {
        SqlConnection conn;
        List<NguyenLieu> list;
        string lastid;

        public List<NguyenLieu> GetAll()
        {
            list = new List<NguyenLieu>();
            using (conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM NguyenLieu ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NguyenLieu nguyenLieu = new NguyenLieu();
                    nguyenLieu.maNL = (string)reader["maNL"];
                    nguyenLieu.tenNL = (string)reader["tenNL"];
                    nguyenLieu.soLuong = (int)reader["soLuong"];
                    nguyenLieu.DVD = (string)reader["DVD"];
                    nguyenLieu.giaThanh = (int)reader["giaThanh"];
                    nguyenLieu.ngayNhap = (DateTime)reader["ngayNhap"];
                    list.Add(nguyenLieu);
                    lastid = nguyenLieu.maNL;
                }
            }
            conn.Close();
            return list;
        }

        public void Add(NguyenLieu nguyenLieu)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "INSERT INTO NguyenLieu VALUES(@maNL,@tenNL,@soLuong,@DVD,@giaThanh,@ngayNhap)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNL", nguyenLieu.maNL);
                cmd.Parameters.AddWithValue("@tenNL", nguyenLieu.tenNL);
                cmd.Parameters.AddWithValue("@soLuong", nguyenLieu.soLuong);
                cmd.Parameters.AddWithValue("@DVD", nguyenLieu.DVD);
                cmd.Parameters.AddWithValue("@giaThanh", nguyenLieu.giaThanh);
                cmd.Parameters.AddWithValue("@ngayNhap", nguyenLieu.ngayNhap);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Update(NguyenLieu nguyenLieu)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "UPDATE NguyenLieu SET tenNL = @tenNL,soLuong = @soLuong,DVD = @DVD,giaThanh = @giaThanh,ngayNhap = @ngayNhap WHERE maNL = @maNL";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNL", nguyenLieu.maNL);
                cmd.Parameters.AddWithValue("@tenNL", nguyenLieu.tenNL);
                cmd.Parameters.AddWithValue("@soLuong", nguyenLieu.soLuong);
                cmd.Parameters.AddWithValue("@DVD", nguyenLieu.DVD);
                cmd.Parameters.AddWithValue("@giaThanh", nguyenLieu.giaThanh);
                cmd.Parameters.AddWithValue("@ngayNhap", nguyenLieu.ngayNhap);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Delete(string maNL)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "DELETE * FROM NguyenLieu WHERE maNL = @maNL";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNL", maNL);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Search()
        {
            using (conn = Connection.GetConnection()) { }
        }

    }
}
