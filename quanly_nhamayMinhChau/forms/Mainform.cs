using quanly_nhamayMinhChau.Models;
using quanly_nhamayMinhChau.Service;
using quanly_nhamayMinhChau.usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_nhamayMinhChau
{
    public partial class Mainform : Form
    {
        NhanVien nhanVien;
        public Mainform()
        {
            InitializeComponent();
        }

        public Mainform(NhanVien nhanVien)
        {
            InitializeComponent();
            this.nhanVien = nhanVien;
            tenNhanVien.Text = nhanVien.tenNhanVien;
            Role();
        }
        public void Role()
        {
            SP__button.Enabled = false;
            HoaDon__button.Enabled=false;
            QLKH__button.Enabled = false;
            QLNV_button.Enabled = false;
            QLVL_button.Enabled=false;
            ThongKe_button.Enabled = false;
            switch (nhanVien.chucVu) 
            {
                case "HoaDon":
                    HoaDon__button.Enabled = true;
                    break;
                case "SanPham":
                    SP__button.Enabled = true;
                    break ;
                case "NhanSu":
                    QLNV_button.Enabled = true;
                    break;
                case "VatDung":
                    QLVL_button.Enabled = true;
                    break ;
                case "KhachHang":
                    QLKH__button.Enabled = true;
                    break ;
                case "KeToan":
                    ThongKe_button.Enabled = true;
                    break ;
                case "admin":
                    SP__button.Enabled = true;
                    HoaDon__button.Enabled = true;
                    QLKH__button.Enabled = true;
                    QLNV_button.Enabled = true;
                    QLVL_button.Enabled = true;
                    ThongKe_button.Enabled = true;
                    break ;
            }
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void logo_panel_Click(object sender, EventArgs e)
        {
            maintheme_usercontrol.BringToFront();
        }

        private void SP__button_Click(object sender, EventArgs e)
        {
            sp_usercontrol.BringToFront();
        }

        private void HoaDon__button_Click(object sender, EventArgs e)
        {
            qlhoadon_usercontrol.BringToFront();
        }

        private void QLKH__button_Click(object sender, EventArgs e)
        {
            qlkhachhang_usercontrol.BringToFront();
        }

        private void QLNV_button_Click(object sender, EventArgs e)
        {
            qlnhanvien_usercontrol.BringToFront();
        }

        private void QLVL_button_Click(object sender, EventArgs e)
        {
            quanlynvl__usercontrol.BringToFront();
        }

        private void ThongKe_button_Click(object sender, EventArgs e)
        {
            thongke_usercontrol.BringToFront();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Form startForm = new Startform();
            startForm.Show();
            this.Close();
        }

        private void tenNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
