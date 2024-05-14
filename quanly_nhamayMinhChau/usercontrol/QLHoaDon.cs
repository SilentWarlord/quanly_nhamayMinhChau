using quanly_nhamayMinhChau.Controller;
using quanly_nhamayMinhChau.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_nhamayMinhChau.usercontrol
{
    public partial class QLHoaDon : UserControl
    {
        DonHangController controller = new DonHangController();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        public void FormLoad()
        {
            hoadon_datagridview.DataSource = controller.GetAll();
            MaHDvalue_label.Text = controller.GetNextId();
            sua_button.Enabled = false;
            xoa_button.Enabled = false;
            them_button.Enabled = true;
            maKhachHang.Text = "";
            maSanPham.Text = "";
            mota_textbox.Text = "";
            TongTien_value.Text = "";
            TongCong_value.Text = "[None]";
        }

        private void print_buttton_Click(object sender, EventArgs e)
        {
            Form form = new print_form();
            form.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            FormLoad();
            base.OnLoad(e);
        }

        private void hoadon_datagridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            hoadon_datagridview.CurrentCell.Selected = true;
            MaHDvalue_label.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            maKhachHang.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            maSanPham.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            mota_textbox.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            TongTien_value.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            sua_button.Enabled = true;
            xoa_button.Enabled = true;
            them_button.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void them_button_Click(object sender, EventArgs e)
        {
            controller.Add(MaHDvalue_label.Text, maKhachHang.Text, maSanPham.Text, mota_textbox.Text, int.Parse(TongTien_value.Text));
        }

        private void xoa_button_Click(object sender, EventArgs e)
        {
            controller.Delete(MaHDvalue_label.Text);
        }

        private void sua_button_Click(object sender, EventArgs e)
        {
            controller.Update(MaHDvalue_label.Text, maKhachHang.Text, maSanPham.Text, mota_textbox.Text, int.Parse(TongTien_value.Text));
        }

        private void huy_button_Click(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
