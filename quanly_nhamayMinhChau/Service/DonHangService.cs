using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Models;

namespace quanly_nhamayMinhChau.Service
{
    internal class DonHangService
    {
        SqlConnection conn;
        List<DonHang> list;
        string lastid;

        public List<DonHang> GetAll()
        {
            list = new List<DonHang>();
            using (conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM DonHang ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DonHang donHang = new DonHang();
                    donHang.maDonHang = (string)reader["maDonHang"];
                    donHang.maKhachHang = (string)reader["maKhachHang"];
                    donHang.maSanPham = (string)reader["maSanPham"];
                    donHang.moTa = (string)reader["moTa"];
                    donHang.thanhTien = (int)reader["thanhTien"];
                    list.Add(donHang);
                    lastid = donHang.maDonHang;
                }
            }
            conn.Close();
            return list;
        }
        public void Add(DonHang donHang)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "INSERT INTO DonHang VALUE(@maDonHang,@maKhachHang,@maSanPham,@moTa,@thanhTien) ";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maDonHang", donHang.maDonHang);
                cmd.Parameters.AddWithValue("@maKhachHang", donHang.maKhachHang);
                cmd.Parameters.AddWithValue("@maSanPham", donHang.maSanPham);
                cmd.Parameters.AddWithValue("@moTa", donHang.moTa);
                cmd.Parameters.AddWithValue("@thanhTien", donHang.thanhTien);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Update(DonHang donHang) 
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "UPDATE DonHang SET maKhachHang = @maKhachHang,maSanPham = @maSanPham,moTa = @moTa,trangThai = @trangThai WHERE maDonHang = @maDonHang";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maDonHang", donHang.maDonHang);
                cmd.Parameters.AddWithValue("@maKhachHang", donHang.maKhachHang);
                cmd.Parameters.AddWithValue("@maSanPham", donHang.maSanPham);
                cmd.Parameters.AddWithValue("@moTa)", donHang.moTa);
                cmd.Parameters.AddWithValue("@thanhTien", donHang.thanhTien);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Delete(string maDonHang) 
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "DELETE FROM DonHang WHERE maDonHang = @maDonHang";
                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@maDonHang", maDonHang);

                conn.Open();
                command.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Search() 
        {
            using (conn = Connection.GetConnection()) { }
        }
    }
}
