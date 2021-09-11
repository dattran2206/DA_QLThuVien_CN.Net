namespace QL_ThuVien2
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.txt_Matkhau = new System.Windows.Forms.TextBox();
            this.txt_Taikhoan = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txt_MatKhau2DK = new System.Windows.Forms.TextBox();
            this.txt_MatKhau1DK = new System.Windows.Forms.TextBox();
            this.txt_EmailDK = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoanDK = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(344, 358);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage1.Controls.Add(this.btn_DangNhap);
            this.tabPage1.Controls.Add(this.txt_Matkhau);
            this.tabPage1.Controls.Add(this.txt_Taikhoan);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đăng Nhập";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BackColor = System.Drawing.Color.Blue;
            this.btn_DangNhap.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_DangNhap.Location = new System.Drawing.Point(33, 248);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(257, 53);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = false;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Matkhau.Location = new System.Drawing.Point(33, 132);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Size = new System.Drawing.Size(257, 29);
            this.txt_Matkhau.TabIndex = 1;
            this.txt_Matkhau.Text = "Mật Khẩu";
            this.txt_Matkhau.UseSystemPasswordChar = true;
            this.txt_Matkhau.Enter += new System.EventHandler(this.txt_Matkhau_Enter);
            this.txt_Matkhau.Leave += new System.EventHandler(this.txt_Matkhau_Leave);
            // 
            // txt_Taikhoan
            // 
            this.txt_Taikhoan.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_Taikhoan.Location = new System.Drawing.Point(33, 64);
            this.txt_Taikhoan.Name = "txt_Taikhoan";
            this.txt_Taikhoan.Size = new System.Drawing.Size(257, 29);
            this.txt_Taikhoan.TabIndex = 0;
            this.txt_Taikhoan.Text = "Tài Khoản";
            this.txt_Taikhoan.Enter += new System.EventHandler(this.txt_Taikhoan_Enter);
            this.txt_Taikhoan.Leave += new System.EventHandler(this.txt_Taikhoan_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SlateGray;
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.btnDangKy);
            this.tabPage2.Controls.Add(this.txt_MatKhau2DK);
            this.tabPage2.Controls.Add(this.txt_MatKhau1DK);
            this.tabPage2.Controls.Add(this.txt_EmailDK);
            this.tabPage2.Controls.Add(this.txt_TaiKhoanDK);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đăng Ký";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(39, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(265, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tôi đồng ý với thỏa thuận sử dụng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.Blue;
            this.btnDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(39, 261);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(257, 53);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txt_MatKhau2DK
            // 
            this.txt_MatKhau2DK.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_MatKhau2DK.Location = new System.Drawing.Point(39, 182);
            this.txt_MatKhau2DK.Name = "txt_MatKhau2DK";
            this.txt_MatKhau2DK.Size = new System.Drawing.Size(257, 29);
            this.txt_MatKhau2DK.TabIndex = 4;
            this.txt_MatKhau2DK.Text = "Mật Khẩu";
            this.txt_MatKhau2DK.UseSystemPasswordChar = true;
            this.txt_MatKhau2DK.Enter += new System.EventHandler(this.txt_MatKhau2DK_Enter);
            this.txt_MatKhau2DK.Leave += new System.EventHandler(this.txt_MatKhau2DK_Leave);
            // 
            // txt_MatKhau1DK
            // 
            this.txt_MatKhau1DK.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_MatKhau1DK.Location = new System.Drawing.Point(39, 127);
            this.txt_MatKhau1DK.Name = "txt_MatKhau1DK";
            this.txt_MatKhau1DK.Size = new System.Drawing.Size(257, 29);
            this.txt_MatKhau1DK.TabIndex = 3;
            this.txt_MatKhau1DK.Text = "Mật Khẩu";
            this.txt_MatKhau1DK.UseSystemPasswordChar = true;
            this.txt_MatKhau1DK.Enter += new System.EventHandler(this.txt_MatKhau1DK_Enter);
            this.txt_MatKhau1DK.Leave += new System.EventHandler(this.txt_MatKhau1DK_Leave);
            // 
            // txt_EmailDK
            // 
            this.txt_EmailDK.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_EmailDK.Location = new System.Drawing.Point(39, 76);
            this.txt_EmailDK.Name = "txt_EmailDK";
            this.txt_EmailDK.Size = new System.Drawing.Size(257, 29);
            this.txt_EmailDK.TabIndex = 2;
            this.txt_EmailDK.Text = "Email";
            this.txt_EmailDK.Enter += new System.EventHandler(this.txt_EmailDK_Enter);
            this.txt_EmailDK.Leave += new System.EventHandler(this.txt_EmailDK_Leave);
            // 
            // txt_TaiKhoanDK
            // 
            this.txt_TaiKhoanDK.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_TaiKhoanDK.Location = new System.Drawing.Point(39, 27);
            this.txt_TaiKhoanDK.Name = "txt_TaiKhoanDK";
            this.txt_TaiKhoanDK.Size = new System.Drawing.Size(257, 29);
            this.txt_TaiKhoanDK.TabIndex = 1;
            this.txt_TaiKhoanDK.Text = "Tài Khoản";
            this.txt_TaiKhoanDK.Enter += new System.EventHandler(this.txt_TaiKhoanDK_Enter);
            this.txt_TaiKhoanDK.Leave += new System.EventHandler(this.txt_TaiKhoanDK_Leave);
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDangNhap";
            this.Load += new System.EventHandler(this.FrmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_Matkhau;
        private System.Windows.Forms.TextBox txt_Taikhoan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txt_MatKhau2DK;
        private System.Windows.Forms.TextBox txt_MatKhau1DK;
        private System.Windows.Forms.TextBox txt_EmailDK;
        private System.Windows.Forms.TextBox txt_TaiKhoanDK;

    }
}