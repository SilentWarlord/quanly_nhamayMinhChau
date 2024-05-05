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
    public partial class Signupform : Form
    {
        public Signupform()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienthimk_checkbox.Checked)
            {
                pass_textBox.UseSystemPasswordChar = false;
                confirmpass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                pass_textBox.UseSystemPasswordChar = true;
                confirmpass_textBox.UseSystemPasswordChar = true;
            }
        }
    }
}
