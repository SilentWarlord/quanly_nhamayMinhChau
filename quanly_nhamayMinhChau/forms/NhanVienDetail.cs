using quanly_nhamayMinhChau.Controller;
using quanly_nhamayMinhChau.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_nhamayMinhChau.forms
{
    public partial class NhanVienDetail : Form
    {
        string maNhanVien;
        string type;
        NhanVienController controller = new NhanVienController();

        public NhanVienDetail()
        {
            InitializeComponent();
        }

        public NhanVienDetail(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
            txt_ma.Text = maNhanVien;
            this.type = "add";
        }
        public void UpdateTable(NhanVien nhanVien)
        {
            txt_ma.Text = nhanVien.maNhanVien;
            txt_ten.Text = nhanVien.tenNhanVien;
            txt_ChucVu.Text = nhanVien.chucVu;
            txt_SDT.Text = nhanVien.SDT;
            txt_Email.Text = nhanVien.email;
            txt_Password.Text = nhanVien.password;
            txt_QueQuan.Text = nhanVien.queQuan;
            //txt_NgaySinh.Value = nhanVien.ngaySinh;
            //txt_NgayLam.Value = nhanVien.ngayLam;
            txt_Luong.Text = nhanVien.luong.ToString();
            this.type = "update";
        }
        public NhanVien ConfirmData()
        {
            NhanVien nhanVien = new NhanVien();

            return nhanVien;
        }
        protected void btn_XacNhan_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "add":
                    controller.Add(txt_ma.Text, txt_ten.Text, txt_ChucVu.Text,txt_SDT.Text, txt_Email.Text, txt_Password.Text, txt_QueQuan.Text, (DateTime)txt_NgaySinh.Value, (DateTime)txt_NgayLam.Value,int.Parse(txt_Luong.Text));
                    this.Close();
                    break;
                case "update":
                    controller.Update(txt_ma.Text, txt_ten.Text, txt_ChucVu.Text, txt_SDT.Text, txt_Email.Text, txt_Password.Text, txt_QueQuan.Text,(DateTime)txt_NgaySinh.Value, (DateTime)txt_NgayLam.Value, int.Parse(txt_Luong.Text));
                    this.Close();
                    break;
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
