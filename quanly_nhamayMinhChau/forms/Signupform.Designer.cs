namespace quanly_nhamayMinhChau
{
    partial class Signupform
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.dangky_button = new System.Windows.Forms.Button();
            this.hienthimk_checkbox = new System.Windows.Forms.CheckBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.pass_label = new System.Windows.Forms.Label();
            this.confirmpass_textBox = new System.Windows.Forms.TextBox();
            this.confirmpass_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.username_label.Location = new System.Drawing.Point(19, 13);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(107, 33);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.username_textBox.Location = new System.Drawing.Point(160, 13);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(454, 39);
            this.username_textBox.TabIndex = 1;
            // 
            // dangky_button
            // 
            this.dangky_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dangky_button.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_button.ForeColor = System.Drawing.Color.Moccasin;
            this.dangky_button.Location = new System.Drawing.Point(473, 258);
            this.dangky_button.Margin = new System.Windows.Forms.Padding(4);
            this.dangky_button.Name = "dangky_button";
            this.dangky_button.Size = new System.Drawing.Size(141, 46);
            this.dangky_button.TabIndex = 2;
            this.dangky_button.Text = "Đăng ký";
            this.dangky_button.UseVisualStyleBackColor = false;
            // 
            // hienthimk_checkbox
            // 
            this.hienthimk_checkbox.AutoSize = true;
            this.hienthimk_checkbox.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthimk_checkbox.ForeColor = System.Drawing.Color.GhostWhite;
            this.hienthimk_checkbox.Location = new System.Drawing.Point(25, 224);
            this.hienthimk_checkbox.Margin = new System.Windows.Forms.Padding(4);
            this.hienthimk_checkbox.Name = "hienthimk_checkbox";
            this.hienthimk_checkbox.Size = new System.Drawing.Size(197, 37);
            this.hienthimk_checkbox.TabIndex = 3;
            this.hienthimk_checkbox.Text = "Hiển thị mật khẩu";
            this.hienthimk_checkbox.UseVisualStyleBackColor = true;
            this.hienthimk_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.hienthimk_checkbox.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // email_textBox
            // 
            this.email_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.email_textBox.Location = new System.Drawing.Point(160, 66);
            this.email_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(454, 39);
            this.email_textBox.TabIndex = 5;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.email_label.Location = new System.Drawing.Point(19, 66);
            this.email_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(65, 33);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "Email";
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textBox.Location = new System.Drawing.Point(160, 119);
            this.pass_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.Size = new System.Drawing.Size(454, 39);
            this.pass_textBox.TabIndex = 7;
            this.pass_textBox.UseSystemPasswordChar = true;
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.pass_label.Location = new System.Drawing.Point(19, 119);
            this.pass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(102, 33);
            this.pass_label.TabIndex = 6;
            this.pass_label.Text = "Password";
            // 
            // confirmpass_textBox
            // 
            this.confirmpass_textBox.Font = new System.Drawing.Font("Open Sans", 13.8F);
            this.confirmpass_textBox.Location = new System.Drawing.Point(160, 172);
            this.confirmpass_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpass_textBox.Name = "confirmpass_textBox";
            this.confirmpass_textBox.Size = new System.Drawing.Size(454, 39);
            this.confirmpass_textBox.TabIndex = 9;
            this.confirmpass_textBox.UseSystemPasswordChar = true;
            // 
            // confirmpass_label
            // 
            this.confirmpass_label.AutoSize = true;
            this.confirmpass_label.Font = new System.Drawing.Font("Open Sans Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass_label.ForeColor = System.Drawing.Color.GhostWhite;
            this.confirmpass_label.Location = new System.Drawing.Point(19, 172);
            this.confirmpass_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmpass_label.Name = "confirmpass_label";
            this.confirmpass_label.Size = new System.Drawing.Size(131, 33);
            this.confirmpass_label.TabIndex = 8;
            this.confirmpass_label.Text = "Confirm pass";
            // 
            // Signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(651, 333);
            this.Controls.Add(this.confirmpass_textBox);
            this.Controls.Add(this.confirmpass_label);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.hienthimk_checkbox);
            this.Controls.Add(this.dangky_button);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.username_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Signupform";
            this.Text = "Signupform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.Button dangky_button;
        private System.Windows.Forms.CheckBox hienthimk_checkbox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox confirmpass_textBox;
        private System.Windows.Forms.Label confirmpass_label;
    }
}