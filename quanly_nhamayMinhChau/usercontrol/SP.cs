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

        public void FormLoad()
        {
            sanpham_datagridview.DataSource = controller.GetAll();
            //txt_ma.Text = controller.GetNextId();
        }
        protected override void OnLoad(EventArgs e)
        {
            FormLoad();
            base.OnLoad(e);
        }

        private void motaSP_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void sanpham_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
