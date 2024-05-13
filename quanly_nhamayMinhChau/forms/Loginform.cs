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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanly_nhamayMinhChau
{
    public partial class Loginform : Form
    {
        LoginControler controler = new LoginControler();
        public Loginform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thuc hein cac buoc xac minh tai khoan..
            if (controler.Login(username_textBox.Text, pass_textBox.Text))
            {
                Form mainForm = new Mainform();
                
                mainForm.Show();
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Mainform")
                        Application.OpenForms[i].Hide();
                }

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form fp_form = new Forgot_pass_form();
            fp_form.Show();
        }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (hienthi_checkbox.Checked)
            {
                pass_textBox.UseSystemPasswordChar = false;
            }
            else
            {
                pass_textBox.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
