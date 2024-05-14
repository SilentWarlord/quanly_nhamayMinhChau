using quanly_nhamayMinhChau.Controller;
using quanly_nhamayMinhChau.forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace quanly_nhamayMinhChau.usercontrol
{
    public partial class QLNhanVien : UserControl
    {
        NhanVienController controller = new NhanVienController();
        string maNhanVien;
        public QLNhanVien()
        {
            InitializeComponent();
        }
        public void FormLoad()
        {
            nhanvien_datagridview.DataSource = controller.GetAll();

        }

        protected override void OnLoad( EventArgs e)
        {

            FormLoad();
            txt_SearchType.Items.Add("maNhanVien");
            txt_SearchType.Items.Add("tenNhanVien");
            txt_SearchType.Items.Add("chucVu");
            txt_SearchType.Items.Add("SDT");
            txt_SearchType.Items.Add("email");
            txt_SearchType.Items.Add("queQuan");
            txt_SearchType.Items.Add("ngaySinh");
            txt_SearchType.Items.Add("ngayLam");
            txt_SearchType.Items.Add("luong");

            base.OnLoad(e);
        }

        private void Nhanvien_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nhanvien_datagridview.CurrentCell.Selected = true;

            this.maNhanVien = nhanvien_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void them_button_Click(object sender, EventArgs e)
        {
            Form nhanvien = new NhanVienDetail(controller.GetNextId());
            nhanvien.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nhanvien_datagridview.DataSource = controller.Search(txt_SearchType.Text,txt_SearchKey.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhanvien_datagridview_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanvien_datagridview.CurrentCell.Selected = true;

            nhanVien.maNhanVien = nhanvien_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            nhanVien.tenNhanVien = nhanvien_datagridview.Rows[e.RowIndex].Cells[1].Value.ToString();
            nhanVien.chucVu = nhanvien_datagridview.Rows[e.RowIndex].Cells[2].Value.ToString();
            nhanVien.SDT = nhanvien_datagridview.Rows[e.RowIndex].Cells[3].Value.ToString();
            nhanVien.email = nhanvien_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
            nhanVien.password = nhanvien_datagridview.Rows[e.RowIndex].Cells[5].Value.ToString();
            nhanVien.queQuan = nhanvien_datagridview.Rows[e.RowIndex].Cells[6].Value.ToString();
            //nhanVien.ngaySinh = DateTime.ParseExact(nhanvien_datagridview.Rows[e.RowIndex].Cells[7].Value.ToString(), "yyyy-MM-dd",null);
            //nhanVien.ngayLam = DateTime.ParseExact(nhanvien_datagridview.Rows[e.RowIndex].Cells[8].Value.ToString(), "yyyy-MM-dd",System.Globalization.CultureInfo.InvariantCulture);
            nhanVien.luong = Int32.Parse(nhanvien_datagridview.Rows[e.RowIndex].Cells[9].Value.ToString());

            NhanVienDetail nhanvienD = new NhanVienDetail();
            nhanvienD.UpdateTable(nhanVien);
            nhanvienD.Show();
        }

        private void huy_button_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void xoa_button_Click(object sender, EventArgs e)
        {
            controller.Delete(maNhanVien);
        }
    }
}
