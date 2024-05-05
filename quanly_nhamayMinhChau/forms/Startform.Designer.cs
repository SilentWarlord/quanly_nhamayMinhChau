namespace quanly_nhamayMinhChau
{
    partial class Startform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startform));
            this.main_panel = new System.Windows.Forms.Panel();
            this.big_panel = new System.Windows.Forms.Panel();
            this.head_panel = new System.Windows.Forms.Panel();
            this.dangnhap_button = new System.Windows.Forms.Button();
            this.dangky_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.big_panel.SuspendLayout();
            this.head_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Location = new System.Drawing.Point(1, 206);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(739, 368);
            this.main_panel.TabIndex = 1;
            // 
            // big_panel
            // 
            this.big_panel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.big_panel.Controls.Add(this.head_panel);
            this.big_panel.Controls.Add(this.main_panel);
            this.big_panel.Controls.Add(this.dangnhap_button);
            this.big_panel.Controls.Add(this.dangky_button);
            this.big_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.big_panel.Location = new System.Drawing.Point(0, 0);
            this.big_panel.Margin = new System.Windows.Forms.Padding(4);
            this.big_panel.Name = "big_panel";
            this.big_panel.Size = new System.Drawing.Size(739, 653);
            this.big_panel.TabIndex = 2;
            // 
            // head_panel
            // 
            this.head_panel.BackColor = System.Drawing.Color.GhostWhite;
            this.head_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("head_panel.BackgroundImage")));
            this.head_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.head_panel.Controls.Add(this.label2);
            this.head_panel.Controls.Add(this.label1);
            this.head_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.head_panel.Location = new System.Drawing.Point(0, 0);
            this.head_panel.Name = "head_panel";
            this.head_panel.Size = new System.Drawing.Size(739, 102);
            this.head_panel.TabIndex = 6;
            // 
            // dangnhap_button
            // 
            this.dangnhap_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dangnhap_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dangnhap_button.FlatAppearance.BorderSize = 0;
            this.dangnhap_button.Font = new System.Drawing.Font("Open Sans Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap_button.ForeColor = System.Drawing.Color.Moccasin;
            this.dangnhap_button.Location = new System.Drawing.Point(0, 149);
            this.dangnhap_button.Margin = new System.Windows.Forms.Padding(4);
            this.dangnhap_button.Name = "dangnhap_button";
            this.dangnhap_button.Size = new System.Drawing.Size(370, 60);
            this.dangnhap_button.TabIndex = 4;
            this.dangnhap_button.Text = "Đăng nhập";
            this.dangnhap_button.UseVisualStyleBackColor = false;
            this.dangnhap_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dangky_button
            // 
            this.dangky_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dangky_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dangky_button.FlatAppearance.BorderSize = 0;
            this.dangky_button.Font = new System.Drawing.Font("Open Sans Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangky_button.ForeColor = System.Drawing.Color.Moccasin;
            this.dangky_button.Location = new System.Drawing.Point(368, 149);
            this.dangky_button.Margin = new System.Windows.Forms.Padding(4);
            this.dangky_button.Name = "dangky_button";
            this.dangky_button.Size = new System.Drawing.Size(371, 60);
            this.dangky_button.TabIndex = 5;
            this.dangky_button.Text = "Đăng ký";
            this.dangky_button.UseVisualStyleBackColor = false;
            this.dangky_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minh Châu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Freestyle Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà may";
            // 
            // Startform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.big_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Startform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Startform_Load);
            this.big_panel.ResumeLayout(false);
            this.head_panel.ResumeLayout(false);
            this.head_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel big_panel;
        private System.Windows.Forms.Button dangky_button;
        private System.Windows.Forms.Button dangnhap_button;
        private System.Windows.Forms.Panel head_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}