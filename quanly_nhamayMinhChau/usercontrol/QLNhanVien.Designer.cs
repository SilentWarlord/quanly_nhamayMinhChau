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
            this.save_icon = new System.Windows.Forms.PictureBox();
            this.cancel_icon = new System.Windows.Forms.PictureBox();
            this.modify_icon = new System.Windows.Forms.PictureBox();
            this.delete_icon = new System.Windows.Forms.PictureBox();
            this.add_icon = new System.Windows.Forms.PictureBox();
            this.luu_button = new System.Windows.Forms.Button();
            this.huy_button = new System.Windows.Forms.Button();
            this.sua_button = new System.Windows.Forms.Button();
            this.xoa_button = new System.Windows.Forms.Button();
            this.them_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_datagridview)).BeginInit();
            this.head_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhanVien_picturebox)).BeginInit();
            this.chucnang_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanvien_datagridview
            // 
            this.nhanvien_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanvien_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhanvien_datagridview.Location = new System.Drawing.Point(0, 100);
            this.nhanvien_datagridview.Name = "nhanvien_datagridview";
            this.nhanvien_datagridview.RowHeadersWidth = 51;
            this.nhanvien_datagridview.RowTemplate.Height = 24;
            this.nhanvien_datagridview.Size = new System.Drawing.Size(1180, 775);
            this.nhanvien_datagridview.TabIndex = 10;
            this.nhanvien_datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Nhanvien_datagridview_CellContentClick);
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
            this.chucnang_panel.Controls.Add(this.save_icon);
            this.chucnang_panel.Controls.Add(this.cancel_icon);
            this.chucnang_panel.Controls.Add(this.modify_icon);
            this.chucnang_panel.Controls.Add(this.delete_icon);
            this.chucnang_panel.Controls.Add(this.add_icon);
            this.chucnang_panel.Controls.Add(this.luu_button);
            this.chucnang_panel.Controls.Add(this.huy_button);
            this.chucnang_panel.Controls.Add(this.sua_button);
            this.chucnang_panel.Controls.Add(this.xoa_button);
            this.chucnang_panel.Controls.Add(this.them_button);
            this.chucnang_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.chucnang_panel.Location = new System.Drawing.Point(0, 100);
            this.chucnang_panel.Name = "chucnang_panel";
            this.chucnang_panel.Size = new System.Drawing.Size(1180, 59);
            this.chucnang_panel.TabIndex = 11;
            // 
            // save_icon
            // 
            this.save_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_icon.BackgroundImage")));
            this.save_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_icon.Location = new System.Drawing.Point(730, 5);
            this.save_icon.Name = "save_icon";
            this.save_icon.Size = new System.Drawing.Size(42, 36);
            this.save_icon.TabIndex = 21;
            this.save_icon.TabStop = false;
            // 
            // cancel_icon
            // 
            this.cancel_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_icon.BackgroundImage")));
            this.cancel_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_icon.Location = new System.Drawing.Point(936, 5);
            this.cancel_icon.Name = "cancel_icon";
            this.cancel_icon.Size = new System.Drawing.Size(42, 36);
            this.cancel_icon.TabIndex = 20;
            this.cancel_icon.TabStop = false;
            // 
            // modify_icon
            // 
            this.modify_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_icon.BackgroundImage")));
            this.modify_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modify_icon.Location = new System.Drawing.Point(523, 5);
            this.modify_icon.Name = "modify_icon";
            this.modify_icon.Size = new System.Drawing.Size(42, 36);
            this.modify_icon.TabIndex = 19;
            this.modify_icon.TabStop = false;
            // 
            // delete_icon
            // 
            this.delete_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_icon.BackgroundImage")));
            this.delete_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_icon.Location = new System.Drawing.Point(307, 5);
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
            // luu_button
            // 
            this.luu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu_button.Location = new System.Drawing.Point(721, 1);
            this.luu_button.Name = "luu_button";
            this.luu_button.Size = new System.Drawing.Size(142, 53);
            this.luu_button.TabIndex = 10;
            this.luu_button.Text = "Lưu";
            this.luu_button.UseVisualStyleBackColor = true;
            // 
            // huy_button
            // 
            this.huy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy_button.Location = new System.Drawing.Point(927, 1);
            this.huy_button.Name = "huy_button";
            this.huy_button.Size = new System.Drawing.Size(143, 53);
            this.huy_button.TabIndex = 8;
            this.huy_button.Text = "Hủy";
            this.huy_button.UseVisualStyleBackColor = true;
            // 
            // sua_button
            // 
            this.sua_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_button.Location = new System.Drawing.Point(513, 1);
            this.sua_button.Name = "sua_button";
            this.sua_button.Size = new System.Drawing.Size(143, 53);
            this.sua_button.TabIndex = 7;
            this.sua_button.Text = "Sửa";
            this.sua_button.UseVisualStyleBackColor = true;
            // 
            // xoa_button
            // 
            this.xoa_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.Location = new System.Drawing.Point(297, 1);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Size = new System.Drawing.Size(142, 53);
            this.xoa_button.TabIndex = 6;
            this.xoa_button.Text = "Xóa";
            this.xoa_button.UseVisualStyleBackColor = true;
            // 
            // them_button
            // 
            this.them_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_button.Location = new System.Drawing.Point(85, 1);
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
            this.Controls.Add(this.chucnang_panel);
            this.Controls.Add(this.nhanvien_datagridview);
            this.Controls.Add(this.head_panel);
            this.Name = "QLNhanVien";
            this.Size = new System.Drawing.Size(1180, 875);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvien_datagridview)).EndInit();
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLNhanVien_picturebox)).EndInit();
            this.chucnang_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.save_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_icon)).EndInit();
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
        private System.Windows.Forms.PictureBox save_icon;
        private System.Windows.Forms.PictureBox cancel_icon;
        private System.Windows.Forms.PictureBox modify_icon;
        private System.Windows.Forms.PictureBox delete_icon;
        private System.Windows.Forms.PictureBox add_icon;
        private System.Windows.Forms.Button luu_button;
        private System.Windows.Forms.Button huy_button;
        private System.Windows.Forms.Button sua_button;
        private System.Windows.Forms.Button xoa_button;
        private System.Windows.Forms.Button them_button;
    }
}
