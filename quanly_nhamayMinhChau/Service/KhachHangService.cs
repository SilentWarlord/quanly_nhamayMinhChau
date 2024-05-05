using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Service
{
    internal class KhachHangService
    {
        List<KhachHang> list;
        string lastid;
        SqlConnection conn;

        public List<KhachHang> GetKhachHang()
        {
            list = new List<KhachHang>();
            using(conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KhachHang kh = new KhachHang();
                    kh.maKhachHang = (string)reader["id"];
                    kh.tenKhachHang = (string)reader["ho_ten"];
                    kh.SDT = (string)reader["dia_chi"];
                    kh.diaChi = (string)reader["email"];
                    kh.ngaySinh = (DateTime)reader["so_dien_thoai"];
                    list.Add(kh);
                    lastid = kh.maKhachHang;
                }
            }
            conn.Close();
            return list;
        }

        public void AddKhachHang(string maKhachHang, string tenKhachHang, string SDT, string diaChi, DateTime ngaySinh )
        {
            using(conn = Connection.GetConnection())
            {
                string query = "";
            }
        }

        public void UpdateKhachHang()
        {

        }
        public void DeleteKhachHang()
        {

        }
    }
}
