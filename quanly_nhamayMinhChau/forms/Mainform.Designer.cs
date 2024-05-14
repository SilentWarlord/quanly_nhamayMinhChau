namespace quanly_nhamayMinhChau
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.Listchucnang_panel = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.head2_label = new System.Windows.Forms.Label();
            this.head1_label = new System.Windows.Forms.Label();
            this.ThongKe_button = new System.Windows.Forms.Button();
            this.QLVL_button = new System.Windows.Forms.Button();
            this.QLNV_button = new System.Windows.Forms.Button();
            this.QLKH__button = new System.Windows.Forms.Button();
            this.HoaDon__button = new System.Windows.Forms.Button();
            this.SP__button = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.tenNhanVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maintheme_usercontrol = new quanly_nhamayMinhChau.usercontrol.MainTheme();
            this.thongke_usercontrol = new quanly_nhamayMinhChau.usercontrol.ThongKe();
            this.quanlynvl__usercontrol = new quanly_nhamayMinhChau.usercontrol.QuanLyNVL();
            this.qlnhanvien_usercontrol = new quanly_nhamayMinhChau.usercontrol.QLNhanVien();
            this.qlkhachhang_usercontrol = new quanly_nhamayMinhChau.usercontrol.QLKhachHang();
            this.qlhoadon_usercontrol = new quanly_nhamayMinhChau.usercontrol.QLHoaDon();
            this.sp_usercontrol = new quanly_nhamayMinhChau.usercontrol.SP();
            this.Listchucnang_panel.SuspendLayout();
            this.logo_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Listchucnang_panel
            // 
            this.Listchucnang_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Listchucnang_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Listchucnang_panel.Controls.Add(this.tenNhanVien);
            this.Listchucnang_panel.Controls.Add(this.label2);
            this.Listchucnang_panel.Controls.Add(this.logout_button);
            this.Listchucnang_panel.Controls.Add(this.logo_panel);
            this.Listchucnang_panel.Controls.Add(this.ThongKe_button);
            this.Listchucnang_panel.Controls.Add(this.QLVL_button);
            this.Listchucnang_panel.Controls.Add(this.QLNV_button);
            this.Listchucnang_panel.Controls.Add(this.QLKH__button);
            this.Listchucnang_panel.Controls.Add(this.HoaDon__button);
            this.Listchucnang_panel.Controls.Add(this.SP__button);
            this.Listchucnang_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Listchucnang_panel.Location = new System.Drawing.Point(0, 0);
            this.Listchucnang_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Listchucnang_panel.Name = "Listchucnang_panel";
            this.Listchucnang_panel.Size = new System.Drawing.Size(399, 875);
            this.Listchucnang_panel.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.Honeydew;
            this.logout_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.Image = ((System.Drawing.Image)(resources.GetObject("logout_button.Image")));
            this.logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.Location = new System.Drawing.Point(-2, 672);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(399, 81);
            this.logout_button.TabIndex = 8;
            this.logout_button.Text = "Đăng xuất";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // logo_panel
            // 
            this.logo_panel.BackColor = System.Drawing.Color.Honeydew;
            this.logo_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo_panel.BackgroundImage")));
            this.logo_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_panel.Controls.Add(this.head2_label);
            this.logo_panel.Controls.Add(this.head1_label);
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(397, 105);
            this.logo_panel.TabIndex = 7;
            this.logo_panel.Click += new System.EventHandler(this.logo_panel_Click);
            // 
            // head2_label
            // 
            this.head2_label.AutoSize = true;
            this.head2_label.Font = new System.Drawing.Font("Freestyle Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head2_label.Location = new System.Drawing.Point(244, 22);
            this.head2_label.Name = "head2_label";
            this.head2_label.Size = new System.Drawing.Size(153, 51);
            this.head2_label.TabIndex = 15;
            this.head2_label.Text = "Minh Châu";
            // 
            // head1_label
            // 
            this.head1_label.AutoSize = true;
            this.head1_label.Font = new System.Drawing.Font("Freestyle Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head1_label.Location = new System.Drawing.Point(11, 22);
            this.head1_label.Name = "head1_label";
            this.head1_label.Size = new System.Drawing.Size(129, 51);
            this.head1_label.TabIndex = 14;
            this.head1_label.Text = "Nhà may";
            // 
            // ThongKe_button
            // 
            this.ThongKe_button.BackColor = System.Drawing.Color.Honeydew;
            this.ThongKe_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ThongKe_button.FlatAppearance.BorderSize = 0;
            this.ThongKe_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKe_button.Image = ((System.Drawing.Image)(resources.GetObject("ThongKe_button.Image")));
            this.ThongKe_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThongKe_button.Location = new System.Drawing.Point(-2, 585);
            this.ThongKe_button.Name = "ThongKe_button";
            this.ThongKe_button.Size = new System.Drawing.Size(399, 81);
            this.ThongKe_button.TabIndex = 6;
            this.ThongKe_button.Text = "Thống kê";
            this.ThongKe_button.UseVisualStyleBackColor = false;
            this.ThongKe_button.Click += new System.EventHandler(this.ThongKe_button_Click);
            // 
            // QLVL_button
            // 
            this.QLVL_button.BackColor = System.Drawing.Color.Honeydew;
            this.QLVL_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.QLVL_button.FlatAppearance.BorderSize = 0;
            this.QLVL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLVL_button.Image = ((System.Drawing.Image)(resources.GetObject("QLVL_button.Image")));
            this.QLVL_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLVL_button.Location = new System.Drawing.Point(-2, 498);
            this.QLVL_button.Name = "QLVL_button";
            this.QLVL_button.Size = new System.Drawing.Size(399, 81);
            this.QLVL_button.TabIndex = 5;
            this.QLVL_button.Text = "Quản lý nguyên/vật liệu";
            this.QLVL_button.UseVisualStyleBackColor = false;
            this.QLVL_button.Click += new System.EventHandler(this.QLVL_button_Click);
            // 
            // QLNV_button
            // 
            this.QLNV_button.BackColor = System.Drawing.Color.Honeydew;
            this.QLNV_button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.QLNV_button.FlatAppearance.BorderSize = 0;
            this.QLNV_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNV_button.Image = ((System.Drawing.Image)(resources.GetObject("QLNV_button.Image")));
            this.QLNV_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLNV_button.Location = new System.Drawing.Point(-2, 411);
            this.QLNV_button.Name = "QLNV_button";
            this.QLNV_button.Size = new System.Drawing.Size(399, 81);
            this.QLNV_button.TabIndex = 4;
            this.QLNV_button.Text = "Quản lý nhân viên";
            this.QLNV_button.UseVisualStyleBackColor = false;
            this.QLNV_button.Click += new System.EventHandler(this.QLNV_button_Click);
            // 
            // QLKH__button
            // 
            this.QLKH__button.BackColor = System.Drawing.Color.Honeydew;
            this.QLKH__button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.QLKH__button.FlatAppearance.BorderSize = 0;
            this.QLKH__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLKH__button.Image = ((System.Drawing.Image)(resources.GetObject("QLKH__button.Image")));
            this.QLKH__button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QLKH__button.Location = new System.Drawing.Point(-2, 324);
            this.QLKH__button.Name = "QLKH__button";
            this.QLKH__button.Size = new System.Drawing.Size(399, 81);
            this.QLKH__button.TabIndex = 3;
            this.QLKH__button.Text = "Quản lý khách hàng";
            this.QLKH__button.UseVisualStyleBackColor = false;
            this.QLKH__button.Click += new System.EventHandler(this.QLKH__button_Click);
            // 
            // HoaDon__button
            // 
            this.HoaDon__button.BackColor = System.Drawing.Color.Honeydew;
            this.HoaDon__button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.HoaDon__button.FlatAppearance.BorderSize = 0;
            this.HoaDon__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoaDon__button.Image = ((System.Drawing.Image)(resources.GetObject("HoaDon__button.Image")));
            this.HoaDon__button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HoaDon__button.Location = new System.Drawing.Point(-2, 237);
            this.HoaDon__button.Name = "HoaDon__button";
            this.HoaDon__button.Size = new System.Drawing.Size(399, 81);
            this.HoaDon__button.TabIndex = 2;
            this.HoaDon__button.Text = "Quản lý hóa đơn";
            this.HoaDon__button.UseVisualStyleBackColor = false;
            this.HoaDon__button.Click += new System.EventHandler(this.HoaDon__button_Click);
            // 
            // SP__button
            // 
            this.SP__button.BackColor = System.Drawing.Color.Honeydew;
            this.SP__button.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.SP__button.FlatAppearance.BorderSize = 0;
            this.SP__button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP__button.Image = ((System.Drawing.Image)(resources.GetObject("SP__button.Image")));
            this.SP__button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SP__button.Location = new System.Drawing.Point(-2, 150);
            this.SP__button.Name = "SP__button";
            this.SP__button.Size = new System.Drawing.Size(399, 81);
            this.SP__button.TabIndex = 1;
            this.SP__button.Text = "Sản phẩm";
            this.SP__button.UseVisualStyleBackColor = false;
            this.SP__button.Click += new System.EventHandler(this.SP__button_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.Honeydew;
            this.main_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_panel.Controls.Add(this.maintheme_usercontrol);
            this.main_panel.Controls.Add(this.thongke_usercontrol);
            this.main_panel.Controls.Add(this.quanlynvl__usercontrol);
            this.main_panel.Controls.Add(this.qlnhanvien_usercontrol);
            this.main_panel.Controls.Add(this.qlkhachhang_usercontrol);
            this.main_panel.Controls.Add(this.qlhoadon_usercontrol);
            this.main_panel.Controls.Add(this.sp_usercontrol);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(399, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1180, 875);
            this.main_panel.TabIndex = 1;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.AutoSize = true;
            this.tenNhanVien.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenNhanVien.Location = new System.Drawing.Point(88, 108);
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.Size = new System.Drawing.Size(95, 31);
            this.tenNhanVien.TabIndex = 9;
            this.tenNhanVien.Text = "[None]";
            this.tenNhanVien.Click += new System.EventHandler(this.tenNhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chào ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // maintheme_usercontrol
            // 
            this.maintheme_usercontrol.BackColor = System.Drawing.Color.Honeydew;
            this.maintheme_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintheme_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.maintheme_usercontrol.Name = "maintheme_usercontrol";
            this.maintheme_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.maintheme_usercontrol.TabIndex = 6;
            // 
            // thongke_usercontrol
            // 
            this.thongke_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongke_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.thongke_usercontrol.Name = "thongke_usercontrol";
            this.thongke_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.thongke_usercontrol.TabIndex = 5;
            // 
            // quanlynvl__usercontrol
            // 
            this.quanlynvl__usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quanlynvl__usercontrol.Location = new System.Drawing.Point(0, 0);
            this.quanlynvl__usercontrol.Name = "quanlynvl__usercontrol";
            this.quanlynvl__usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.quanlynvl__usercontrol.TabIndex = 4;
            // 
            // qlnhanvien_usercontrol
            // 
            this.qlnhanvien_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlnhanvien_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.qlnhanvien_usercontrol.Name = "qlnhanvien_usercontrol";
            this.qlnhanvien_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.qlnhanvien_usercontrol.TabIndex = 3;
            // 
            // qlkhachhang_usercontrol
            // 
            this.qlkhachhang_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlkhachhang_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.qlkhachhang_usercontrol.Name = "qlkhachhang_usercontrol";
            this.qlkhachhang_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.qlkhachhang_usercontrol.TabIndex = 2;
            // 
            // qlhoadon_usercontrol
            // 
            this.qlhoadon_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qlhoadon_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.qlhoadon_usercontrol.Name = "qlhoadon_usercontrol";
            this.qlhoadon_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.qlhoadon_usercontrol.TabIndex = 1;
            // 
            // sp_usercontrol
            // 
            this.sp_usercontrol.AutoSize = true;
            this.sp_usercontrol.BackColor = System.Drawing.Color.Honeydew;
            this.sp_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.sp_usercontrol.Name = "sp_usercontrol";
            this.sp_usercontrol.Size = new System.Drawing.Size(1180, 875);
            this.sp_usercontrol.TabIndex = 0;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1579, 875);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Listchucnang_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Listchucnang_panel.ResumeLayout(false);
            this.Listchucnang_panel.PerformLayout();
            this.logo_panel.ResumeLayout(false);
            this.logo_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Listchucnang_panel;
        private System.Windows.Forms.Button SP__button;
        private System.Windows.Forms.Button ThongKe_button;
        private System.Windows.Forms.Button QLVL_button;
        private System.Windows.Forms.Button QLNV_button;
        private System.Windows.Forms.Button QLKH__button;
        private System.Windows.Forms.Button HoaDon__button;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel logo_panel;
        private usercontrol.SP sp_usercontrol;
        private usercontrol.QLHoaDon qlhoadon_usercontrol;
        private usercontrol.QLKhachHang qlkhachhang_usercontrol;
        private usercontrol.QuanLyNVL quanlynvl__usercontrol;
        private usercontrol.QLNhanVien qlnhanvien_usercontrol;
        private usercontrol.ThongKe thongke_usercontrol;
        private usercontrol.MainTheme maintheme_usercontrol;
        private System.Windows.Forms.Label head2_label;
        private System.Windows.Forms.Label head1_label;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label tenNhanVien;
        private System.Windows.Forms.Label label2;
    }
}