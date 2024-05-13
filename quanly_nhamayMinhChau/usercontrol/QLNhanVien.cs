using quanly_nhamayMinhChau.Controller;
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
    public partial class QLNhanVien : UserControl
    {
        NhanVienController controller = new NhanVienController();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        protected override void OnLoad( EventArgs e)
        {
            nhanvien_datagridview.DataSource = controller.GetAll();

            base.OnLoad(e);
        }

        private void Nhanvien_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_button_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
