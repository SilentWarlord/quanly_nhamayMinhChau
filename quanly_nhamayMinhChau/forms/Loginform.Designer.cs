namespace quanly_nhamayMinhChau
{
    partial class Loginform
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
            this.username_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.dangnhap_button = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.hienthi_checkbox = new System.Windows.Forms.CheckBox();
            this.doimk_label = new System.Windows.Forms.Label();
            this.doimk_click = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.username_label.Location = new System.Drawing.Point(23, 13);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(107, 33);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.pass_label.Location = new System.Drawing.Point(28, 64);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(102, 33);
            this.pass_label.TabIndex = 1;
            this.pass_label.Text = "Password";
            this.pass_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // dangnhap_button
            // 
            this.dangnhap_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dangnhap_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_button.ForeColor = System.Drawing.Color.Moccasin;
            this.dangnhap_button.Location = new System.Drawing.Point(201, 261);
            this.dangnhap_button.Margin = new System.Windows.Forms.Padding(4);
            this.dangnhap_button.Name = "dangnhap_button";
            this.dangnhap_button.Size = new System.Drawing.Size(157, 41);
            this.dangnhap_button.TabIndex = 3;
            this.dangnhap_button.Text = "Đăng nhập";
            this.dangnhap_button.UseVisualStyleBackColor = false;
            this.dangnhap_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.username_textBox.Location = new System.Drawing.Point(135, 13);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(333, 39);
            this.username_textBox.TabIndex = 4;
            this.username_textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.pass_textBox.Location = new System.Drawing.Point(135, 68);
            this.pass_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(333, 39);
            this.pass_textBox.TabIndex = 5;
            this.pass_textBox.UseSystemPasswordChar = true;
            this.pass_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hienthi_checkbox
            // 
            this.hienthi_checkbox.AutoSize = true;
            this.hienthi_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthi_checkbox.ForeColor = System.Drawing.Color.GhostWhite;
            this.hienthi_checkbox.Location = new System.Drawing.Point(28, 140);
            this.hienthi_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.hienthi_checkbox.Name = "hienthi_checkbox";
            this.hienthi_checkbox.Size = new System.Drawing.Size(201, 29);
            this.hienthi_checkbox.TabIndex = 6;
            this.hienthi_checkbox.Text = "Hiển thị mật khẩu";
            this.hienthi_checkbox.UseVisualStyleBackColor = true;
            this.hienthi_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // doimk_label
            // 
            this.doimk_label.AutoSize = true;
            this.doimk_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doimk_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.doimk_label.Location = new System.Drawing.Point(274, 139);
            this.doimk_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doimk_label.Name = "doimk_label";
            this.doimk_label.Size = new System.Drawing.Size(179, 33);
            this.doimk_label.TabIndex = 7;
            this.doimk_label.Text = "Đổi mật khẩu click";
            this.doimk_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // doimk_click
            // 
            this.doimk_click.AutoSize = true;
            this.doimk_click.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doimk_click.ForeColor = System.Drawing.Color.Moccasin;
            this.doimk_click.Location = new System.Drawing.Point(429, 139);
            this.doimk_click.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doimk_click.Name = "doimk_click";
            this.doimk_click.Size = new System.Drawing.Size(84, 33);
            this.doimk_click.TabIndex = 2;
            this.doimk_click.Text = "vào đây";
            this.doimk_click.Click += new System.EventHandler(this.label3_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(537, 334);
            this.Controls.Add(this.doimk_label);
            this.Controls.Add(this.hienthi_checkbox);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.dangnhap_button);
            this.Controls.Add(this.doimk_click);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.username_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loginform";
            this.Text = "Loginform";
            this.Load += new System.EventHandler(this.Loginform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Button dangnhap_button;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.CheckBox hienthi_checkbox;
        private System.Windows.Forms.Label doimk_label;
        private System.Windows.Forms.Label doimk_click;
    }
}