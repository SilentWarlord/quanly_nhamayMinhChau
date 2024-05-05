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
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void print_buttton_Click(object sender, EventArgs e)
        {
            Form form = new print_form();
            form.Show();
        }
    }
}
