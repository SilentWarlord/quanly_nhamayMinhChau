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
        public Mainform()
        {
            InitializeComponent();
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
    }
}
