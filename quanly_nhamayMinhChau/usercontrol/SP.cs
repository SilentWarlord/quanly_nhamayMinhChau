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
    public partial class SP : UserControl
    {
        SanPhamController controller = new SanPhamController();
        public SP()
        {
            InitializeComponent();


        }
        protected override void OnLoad(EventArgs e)
        {
            sanpham_datagridview.DataSource = controller.GetAll();

            base.OnLoad(e);
        }
    }
}
