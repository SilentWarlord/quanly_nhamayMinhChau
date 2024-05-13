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
    
    public partial class QuanLyNVL : UserControl
    {
        NguyenLieuController controller = new NguyenLieuController();
        public QuanLyNVL()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            nvl_datagridview.DataSource = controller.GetAll();

            base.OnLoad(e);
        }
    }
}
