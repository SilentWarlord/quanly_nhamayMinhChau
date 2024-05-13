namespace quanly_nhamayMinhChau.usercontrol
{
    partial class SP
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
            System.Windows.Forms.Panel mota_panel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP));
            this.motaSP_usercontrol = new quanly_nhamayMinhChau.usercontrol.motaSP();
            this.head_panel = new System.Windows.Forms.Panel();
            this.SP_label = new System.Windows.Forms.Label();
            this.SP_picturebox = new System.Windows.Forms.PictureBox();
            this.sanpham_datagridview = new System.Windows.Forms.DataGridView();
            this.data_panel = new System.Windows.Forms.Panel();
            this.save_icon = new System.Windows.Forms.PictureBox();
            this.cancel_icon = new System.Windows.Forms.PictureBox();
            this.modify_icon = new System.Windows.Forms.PictureBox();
            this.delete_icon = new System.Windows.Forms.PictureBox();
            this.huy_button = new System.Windows.Forms.Button();
            this.add_icon = new System.Windows.Forms.PictureBox();
            this.luu_button = new System.Windows.Forms.Button();
            this.sua_button = new System.Windows.Forms.Button();
            this.xoa_button = new System.Windows.Forms.Button();
            this.them_button = new System.Windows.Forms.Button();
            mota_panel = new System.Windows.Forms.Panel();
            mota_panel.SuspendLayout();
            this.head_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_datagridview)).BeginInit();
            this.data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.save_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // mota_panel
            // 
            mota_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            mota_panel.Controls.Add(this.motaSP_usercontrol);
            mota_panel.Dock = System.Windows.Forms.DockStyle.Right;
            mota_panel.Location = new System.Drawing.Point(889, 100);
            mota_panel.Name = "mota_panel";
            mota_panel.Size = new System.Drawing.Size(291, 775);
            mota_panel.TabIndex = 3;
            // 
            // motaSP_usercontrol
            // 
            this.motaSP_usercontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motaSP_usercontrol.Location = new System.Drawing.Point(0, 0);
            this.motaSP_usercontrol.Name = "motaSP_usercontrol";
            this.motaSP_usercontrol.Size = new System.Drawing.Size(289, 773);
            this.motaSP_usercontrol.TabIndex = 0;
            // 
            // head_panel
            // 
            this.head_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.head_panel.Controls.Add(this.SP_label);
            this.head_panel.Controls.Add(this.SP_picturebox);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(1180, 100);
            this.head_panel.TabIndex = 0;
            // 
            // SP_label
            // 
            this.SP_label.AutoSize = true;
            this.SP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SP_label.Location = new System.Drawing.Point(469, 27);
            this.SP_label.Name = "SP_label";
            this.SP_label.Size = new System.Drawing.Size(226, 51);
            this.SP_label.TabIndex = 2;
            this.SP_label.Text = "Sản phẩm";
            // 
            // SP_picturebox
            // 
            this.SP_picturebox.BackgroundImage = global::quanly_nhamayMinhChau.Properties.Resources.datsp_icon;
            this.SP_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SP_picturebox.Location = new System.Drawing.Point(372, 3);
            this.SP_picturebox.Name = "SP_picturebox";
            this.SP_picturebox.Size = new System.Drawing.Size(76, 97);
            this.SP_picturebox.TabIndex = 0;
            this.SP_picturebox.TabStop = false;
            // 
            // sanpham_datagridview
            // 
            this.sanpham_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanpham_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sanpham_datagridview.Location = new System.Drawing.Point(0, 100);
            this.sanpham_datagridview.Name = "sanpham_datagridview";
            this.sanpham_datagridview.RowHeadersWidth = 51;
            this.sanpham_datagridview.RowTemplate.Height = 24;
            this.sanpham_datagridview.Size = new System.Drawing.Size(889, 775);
            this.sanpham_datagridview.TabIndex = 5;
            // 
            // data_panel
            // 
            this.data_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.data_panel.Controls.Add(this.save_icon);
            this.data_panel.Controls.Add(this.cancel_icon);
            this.data_panel.Controls.Add(this.modify_icon);
            this.data_panel.Controls.Add(this.delete_icon);
            this.data_panel.Controls.Add(this.huy_button);
            this.data_panel.Controls.Add(this.add_icon);
            this.data_panel.Controls.Add(this.luu_button);
            this.data_panel.Controls.Add(this.sua_button);
            this.data_panel.Controls.Add(this.xoa_button);
            this.data_panel.Controls.Add(this.them_button);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_panel.Location = new System.Drawing.Point(0, 100);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(889, 39);
            this.data_panel.TabIndex = 6;
            // 
            // save_icon
            // 
            this.save_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save_icon.BackgroundImage")));
            this.save_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_icon.Location = new System.Drawing.Point(500, 5);
            this.save_icon.Name = "save_icon";
            this.save_icon.Size = new System.Drawing.Size(33, 31);
            this.save_icon.TabIndex = 11;
            this.save_icon.TabStop = false;
            // 
            // cancel_icon
            // 
            this.cancel_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_icon.BackgroundImage")));
            this.cancel_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancel_icon.Location = new System.Drawing.Point(658, 3);
            this.cancel_icon.Name = "cancel_icon";
            this.cancel_icon.Size = new System.Drawing.Size(33, 31);
            this.cancel_icon.TabIndex = 10;
            this.cancel_icon.TabStop = false;
            // 
            // modify_icon
            // 
            this.modify_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_icon.BackgroundImage")));
            this.modify_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.modify_icon.Location = new System.Drawing.Point(351, 3);
            this.modify_icon.Name = "modify_icon";
            this.modify_icon.Size = new System.Drawing.Size(33, 31);
            this.modify_icon.TabIndex = 9;
            this.modify_icon.TabStop = false;
            // 
            // delete_icon
            // 
            this.delete_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_icon.BackgroundImage")));
            this.delete_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_icon.Location = new System.Drawing.Point(191, 3);
            this.delete_icon.Name = "delete_icon";
            this.delete_icon.Size = new System.Drawing.Size(33, 31);
            this.delete_icon.TabIndex = 8;
            this.delete_icon.TabStop = false;
            // 
            // huy_button
            // 
            this.huy_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy_button.Location = new System.Drawing.Point(658, 3);
            this.huy_button.Name = "huy_button";
            this.huy_button.Size = new System.Drawing.Size(142, 31);
            this.huy_button.TabIndex = 4;
            this.huy_button.Text = "Hủy";
            this.huy_button.UseVisualStyleBackColor = true;
            // 
            // add_icon
            // 
            this.add_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_icon.BackgroundImage")));
            this.add_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_icon.Location = new System.Drawing.Point(31, 3);
            this.add_icon.Name = "add_icon";
            this.add_icon.Size = new System.Drawing.Size(33, 31);
            this.add_icon.TabIndex = 7;
            this.add_icon.TabStop = false;
            // 
            // luu_button
            // 
            this.luu_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luu_button.Location = new System.Drawing.Point(500, 3);
            this.luu_button.Name = "luu_button";
            this.luu_button.Size = new System.Drawing.Size(142, 31);
            this.luu_button.TabIndex = 5;
            this.luu_button.Text = "Lưu";
            this.luu_button.UseVisualStyleBackColor = true;
            // 
            // sua_button
            // 
            this.sua_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua_button.Location = new System.Drawing.Point(351, 3);
            this.sua_button.Name = "sua_button";
            this.sua_button.Size = new System.Drawing.Size(143, 31);
            this.sua_button.TabIndex = 3;
            this.sua_button.Text = "Sửa";
            this.sua_button.UseVisualStyleBackColor = true;
            // 
            // xoa_button
            // 
            this.xoa_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa_button.Location = new System.Drawing.Point(191, 3);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Size = new System.Drawing.Size(142, 31);
            this.xoa_button.TabIndex = 2;
            this.xoa_button.Text = "Xóa";
            this.xoa_button.UseVisualStyleBackColor = true;
            // 
            // them_button
            // 
            this.them_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them_button.Location = new System.Drawing.Point(31, 3);
            this.them_button.Name = "them_button";
            this.them_button.Size = new System.Drawing.Size(142, 31);
            this.them_button.TabIndex = 0;
            this.them_button.Text = "Thêm";
            this.them_button.UseVisualStyleBackColor = true;
            // 
            // SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.sanpham_datagridview);
            this.Controls.Add(mota_panel);
            this.Controls.Add(this.head_panel);
            this.Name = "SP";
            this.Size = new System.Drawing.Size(1180, 875);
            mota_panel.ResumeLayout(false);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SP_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanpham_datagridview)).EndInit();
            this.data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.save_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.PictureBox SP_picturebox;
        private System.Windows.Forms.Label SP_label;
        private motaSP motaSP_usercontrol;
        private System.Windows.Forms.DataGridView sanpham_datagridview;
        private System.Windows.Forms.Panel data_panel;
        private System.Windows.Forms.Button huy_button;
        private System.Windows.Forms.Button sua_button;
        private System.Windows.Forms.Button xoa_button;
        private System.Windows.Forms.Button them_button;
        private System.Windows.Forms.Button luu_button;
        private System.Windows.Forms.PictureBox save_icon;
        private System.Windows.Forms.PictureBox cancel_icon;
        private System.Windows.Forms.PictureBox modify_icon;
        private System.Windows.Forms.PictureBox delete_icon;
        private System.Windows.Forms.PictureBox add_icon;
    }
}
