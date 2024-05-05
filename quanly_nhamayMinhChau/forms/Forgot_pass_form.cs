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
    public partial class Forgot_pass_form : Form
    {
        public Forgot_pass_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm_change;
            confirm_change = MessageBox.Show("Xác nhận đổi mật khẩu?", "Warning!",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Information);
            if (confirm_change == DialogResult.OK)
            {
                //cap nhat co so du lieu
                MessageBox.Show("Đổi mật khẩu thành công!", "warning!");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (hienthi_checkbox.Checked)
            {
                pass_textbox.UseSystemPasswordChar = false;
                confirmpass_textbox.UseSystemPasswordChar = false;
            }
            else
            {
                pass_textbox.UseSystemPasswordChar = true;
                confirmpass_textbox.UseSystemPasswordChar = true;
            }
        }
    }
}
