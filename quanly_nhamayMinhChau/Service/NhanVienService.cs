using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using quanly_nhamayMinhChau.Service;
using quanly_nhamayMinhChau.Models;
using System.Net.NetworkInformation;
using quanly_nhamayMinhChau.usercontrol;

namespace quanly_nhamayMinhChau.Service
{
    internal class NhanVienService
    {
        SqlConnection conn;
        List<NhanVien> list;
        string lastid;

        public List<NhanVien> GetAll()
        {
            list = new List<NhanVien>();
            using (conn = Connection.GetConnection())
            {
                string query = "SELECT * FROM NhanVien ";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    NhanVien nhanVien = new NhanVien();
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
                    list.Add(nhanVien);
                    lastid = nhanVien.maNhanVien;
                }
            }
            conn.Close();
            return list;
        }


        public void Add(NhanVien nhanvien)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "INSERT INTO NhanVien VALUES(@maNhanVien,@tenNhanVien,@chucVu,@SDT,@email,@password,@queQuan,@ngaySinh,@ngayLam,@luong) ";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNhanVien", nhanvien.maNhanVien);
                cmd.Parameters.AddWithValue("@tenNhanVien", nhanvien.tenNhanVien);
                cmd.Parameters.AddWithValue("@chucVu", nhanvien.chucVu);
                cmd.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                cmd.Parameters.AddWithValue("@email", nhanvien.email);
                cmd.Parameters.AddWithValue("@password", nhanvien.password);
                cmd.Parameters.AddWithValue("@queQuan", nhanvien.queQuan);
                cmd.Parameters.AddWithValue("@ngaySinh", nhanvien.ngaySinh);
                cmd.Parameters.AddWithValue("@ngayLam", nhanvien.ngayLam);
                cmd.Parameters.AddWithValue("@luong", nhanvien.luong);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Update(NhanVien nhanvien)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "UPDATE NhanVien SET tenNhanVien = @tenNhanVien,chucVu = @chucVu,SDT = @SDT,email = @email,password = @password,queQuan = @queQuan,ngaySinh = @ngaySinh,ngayLam = @ngayLam,luong = @luong WHERE maNhanVien = @maNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNhanVien", nhanvien.maNhanVien);
                cmd.Parameters.AddWithValue("@tenNhanVien", nhanvien.tenNhanVien);
                cmd.Parameters.AddWithValue("@chucVu", nhanvien.chucVu);
                cmd.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                cmd.Parameters.AddWithValue("@email", nhanvien.email);
                cmd.Parameters.AddWithValue("@password", nhanvien.password);
                cmd.Parameters.AddWithValue("@queQuan", nhanvien.queQuan);
                cmd.Parameters.AddWithValue("@ngaySinh", nhanvien.ngaySinh);
                cmd.Parameters.AddWithValue("@ngayLam", nhanvien.ngayLam);
                cmd.Parameters.AddWithValue("@luong", nhanvien.luong);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public void Delete(string maNhanVien)
        {
            using (conn = Connection.GetConnection()) 
            {
                string query = "DELETE * FROM NhanVien WHERE maNhanVien = @maNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@maNhanVien", maNhanVien);

                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
        public List<NhanVien> Search(string type,string key)
        {
            using (conn = Connection.GetConnection()) 
            {
                list = new List<NhanVien>();
                try{
                    using (conn = Connection.GetConnection())
                    {
                        string query = "SELECT * FROM NhanVien WHERE " + type + " LIKE '%"+ key+"%'";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        
                        conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            NhanVien nhanVien = new NhanVien();
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
                            list.Add(nhanVien);
                            lastid = nhanVien.maNhanVien;
                        }
                    }
                    conn.Close();
                    return list;
                }
                catch
                {
                    return list;
                }
            }
        }

        public void SendEmail(string toEmail,string subject,string body)
        {

            var fromAddress = new MailAddress("anbum7733@gmail.com", "From Name");
            var toAddress = new MailAddress(toEmail, "To Name");
            const string fromPassword = "dbyc hqzw iiwm ywsx";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public string GetID()
        {
            return lastid;
        }
    }
}
