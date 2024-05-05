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
    public partial class Startform : Form
    {
        public Startform()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.main_panel.Controls.Count > 0)
            {
                this.main_panel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(f);
            this.main_panel.Tag = f;
            f.Show();


        }

        private void Startform_Load(object sender, EventArgs e)
        {
             loadform(new Loginform());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Signupform());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new Loginform());

        }

    }
}
