using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanly_nhamayMinhChau.forms
{
    public partial class print_form : Form
    {
        public print_form()
        {
            InitializeComponent();
        }

        private void print_buttton_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            // Thiết lập PrintDocument để vẽ nội dung từ mainpanel
            printDocument.PrintPage += (s, args) =>
            {
                Bitmap bmp = new Bitmap(main_panel.Width, main_panel.Height);
                main_panel.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, main_panel.Width, main_panel.Height));
                args.Graphics.DrawImage(bmp, 0, 0);
            };

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
