namespace quanly_nhamayMinhChau.usercontrol
{
    partial class QLNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLNhanVien));
            this.nhanvien_datagridview = new System.Windows.Forms.DataGridView();
            this.head_panel = new System.Windows.Forms.Panel();
            this.QLNhanVien_label = new System.Windows.Forms.Label();
            this.QLNhanVien_picturebox = new System.Windows.Forms.PictureBox();
            this.chucnang_panel = new System.Windows.Forms.Panel();
            this.txt_SearchType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchKey = new System.Windows.Forms.TextBox();
            this.cancel_icon = new System.Windows.Forms.PictureBox();
            this.delete_icon = new System.Windows.Forms.PictureBox();
            this.add_icon = new System.Windows.Forms.PictureBox();
            this.huy_button = new System.Windows.Forms.Button();
            this.xoa_button = new System.Windows.Forms.Button();
            this.them_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_datagridview)).BeginInit();
            this.head_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhanVien_picturebox)).BeginInit();
            this.chucnang_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvien_datagridview
            // 
            this.nhanvien_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanvien_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvien_datagridview.Location = new System.Drawing.Point(0, 159);
            this.nhanvien_datagridview.Name = "nhanvien_datagridview";
            this.nhanvien_datagridview.RowHeadersWidth = 51;
            this.nhanvien_datagridview.RowTemplate.Height = 24;
            this.nhanvien_datagridview.Size = new System.Drawing.Size(1180, 716);
            this.nhanvien_datagridview.TabIndex = 10;
            this.nhanvien_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Nhanvien_datagridview_CellContentClick);
            this.nhanvien_datagridview.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nhanvien_datagridview_CellContentDoubleClick);
            // 
            // head_panel
            // 
            this.head_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head_panel.Controls.Add(this.QLNhanVien_label);
            this.head_panel.Controls.Add(this.QLNhanVien_picturebox);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1180, 100);
            this.head_panel.TabIndex = 8;
            // 
            // QLNhanVien_label
            // 
            this.QLNhanVien_label.AutoSize = true;
            this.QLNhanVien_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLNhanVien_label.Location = new System.Drawing.Point(398, 29);
            this.QLNhanVien_label.Name = "QLNhanVien_label";
            this.QLNhanVien_label.Size = new System.Drawing.Size(385, 51);
            this.QLNhanVien_label.TabIndex = 4;
            this.QLNhanVien_label.Text = "Quản lý nhân viên";
            // 
            // QLNhanVien_picturebox
            // 
            this.QLNhanVien_picturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QLNhanVien_picturebox.BackgroundImage")));
            this.QLNhanVien_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QLNhanVien_picturebox.Location = new System.Drawing.Point(297, -2);
            this.QLNhanVien_picturebox.Name = "QLNhanVien_picturebox";
            this.QLNhanVien_picturebox.Size = new System.Drawing.Size(76, 97);
            this.QLNhanVien_picturebox.TabIndex = 3;
            this.QLNhanVien_picturebox.TabStop = false;
            // 
            // chucnang_panel
            // 
            this.chucnang_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chucnang_panel.Controls.Add(this.txt_SearchType);
            this.chucnang_panel.Controls.Add(this.label1);
            this.chucnang_panel.Controls.Add(this.txt_SearchKey);
            this.chucnang_panel.Controls.Add(this.cancel_icon);
            this.chucnang_panel.Controls.Add(this.delete_icon);
            this.chucnang_panel.Controls.Add(this.add_icon);
            this.chucnang_panel.Controls.Add(this.huy_button);
            this.chucnang_panel.Controls.Add(this.xoa_button);
            this.chucnang_panel.Controls.Add(this.them_button);
            this.chucnang_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chucnang_panel.Location = new System.Drawing.Point(0, 100);
            this.chucnang_panel.Name = "chucnang_panel";
            this.chucnang_panel.Size = new System.Drawing.Size(1180, 59);
            this.chucnang_panel.TabIndex = 11;
            // 
            // txt_SearchType
            // 
            this.txt_SearchType.FormattingEnabled = true;
            this.txt_SearchType.Location = new System.Drawing.Point(899, 17);
            this.txt_SearchType.Name = "txt_SearchType";
            this.txt_SearchType.Size = new System.Drawing.Size(121, 24);
            this.txt_SearchType.TabIndex = 23;
            this.txt_SearchType.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_SearchKey
            // 
            this.txt_SearchKey.Location = new System.Drawing.Point(707, 17);
            this.txt_SearchKey.Name = "txt_SearchKey";
            this.txt_SearchKey.Size = new System.Drawing.Size(186, 22);
            this.txt_SearchKey.TabIndex = 21;
            this.txt_SearchKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cancel_icon
            // 
            this.cancel_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_icon.BackgroundImage")));
            this.cancel_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_icon.Location = new System.Drawing.Point(473, 5);
            this.cancel_icon.Name = "cancel_icon";
            this.cancel_icon.Size = new System.Drawing.Size(42, 36);
            this.cancel_icon.TabIndex = 20;
            this.cancel_icon.TabStop = false;
            // 
            // delete_icon
            // 
            this.delete_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_icon.BackgroundImage")));
            this.delete_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_icon.Location = new System.Drawing.Point(273, 5);
            this.delete_icon.Name = "delete_icon";
            this.delete_icon.Size = new System.Drawing.Size(42, 36);
            this.delete_icon.TabIndex = 18;
            this.delete_icon.TabStop = false;
            // 
            // add_icon
            // 
            this.add_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_icon.BackgroundImage")));
            this.add_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_icon.Location = new System.Drawing.Point(93, 5);
            this.add_icon.Name = "add_icon";
            this.add_icon.Size = new System.Drawing.Size(42, 36);
            this.add_icon.TabIndex = 17;
            this.add_icon.TabStop = false;
            // 
            // huy_button
            // 
            this.huy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy_button.Location = new System.Drawing.Point(464, 1);
            this.huy_button.Name = "huy_button";
            this.huy_button.Size = new System.Drawing.Size(143, 53);
            this.huy_button.TabIndex = 8;
            this.huy_button.Text = "Hủy";
            this.huy_button.UseVisualStyleBackColor = true;
            this.huy_button.Click += new System.EventHandler(this.huy_button_Click);
            // 
            // xoa_button
            // 
            this.xoa_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.Location = new System.Drawing.Point(273, 1);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Size = new System.Drawing.Size(142, 53);
            this.xoa_button.TabIndex = 6;
            this.xoa_button.Text = "Xóa";
            this.xoa_button.UseVisualStyleBackColor = true;
            this.xoa_button.Click += new System.EventHandler(this.xoa_button_Click);
            // 
            // them_button
            // 
            this.them_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_button.Location = new System.Drawing.Point(93, -2);
            this.them_button.Name = "them_button";
            this.them_button.Size = new System.Drawing.Size(142, 53);
            this.them_button.TabIndex = 5;
            this.them_button.Text = "Thêm";
            this.them_button.UseVisualStyleBackColor = true;
            this.them_button.Click += new System.EventHandler(this.them_button_Click);
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nhanvien_datagridview);
            this.Controls.Add(this.chucnang_panel);
            this.Controls.Add(this.head_panel);
            this.Name = "QLNhanVien";
            this.Size = new System.Drawing.Size(1180, 875);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_datagridview)).EndInit();
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhanVien_picturebox)).EndInit();
            this.chucnang_panel.ResumeLayout(false);
            this.chucnang_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView nhanvien_datagridview;
        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label QLNhanVien_label;
        private System.Windows.Forms.PictureBox QLNhanVien_picturebox;
        private System.Windows.Forms.Panel chucnang_panel;
        private System.Windows.Forms.PictureBox cancel_icon;
        private System.Windows.Forms.PictureBox delete_icon;
        private System.Windows.Forms.PictureBox add_icon;
        private System.Windows.Forms.Button huy_button;
        private System.Windows.Forms.Button xoa_button;
        private System.Windows.Forms.Button them_button;
        private System.Windows.Forms.TextBox txt_SearchKey;
        private System.Windows.Forms.ComboBox txt_SearchType;
        private System.Windows.Forms.Label label1;
    }
}
