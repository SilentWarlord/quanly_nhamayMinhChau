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

        private void print_buttton_Click(object sender, EventArgs e)
        {
            Form form = new print_form();
            form.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            hoadon_datagridview.DataSource = controller.GetAll();

            base.OnLoad(e);
        }

        private void hoadon_datagridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            hoadon_datagridview.CurrentCell.Selected = true;
            MaHDvalue_label.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[0].Value.ToString();
            TongTien_value.Text = hoadon_datagridview.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
