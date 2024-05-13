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
    public partial class QLKhachHang : UserControl
    {
        KhachHangController controller = new KhachHangController();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            khachhang_datagridview.DataSource = controller.GetAll();

            base.OnLoad(e);
        }

        private void khachhang_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
