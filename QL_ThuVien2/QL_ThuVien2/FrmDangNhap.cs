using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_ThuVien2
{
    public partial class FrmDangNhap : Form
    {

        XuLy dt = new XuLy();

        public FrmDangNhap()
        {
            InitializeComponent();
        }
        
        //TextBox
        //Đăng Nhập

        private void txt_Taikhoan_Enter(object sender, EventArgs e)
        {
            if (txt_Taikhoan.Text == "Tài Khoản")
            {
                txt_Taikhoan.Text = string.Empty;
                txt_Taikhoan.ForeColor = Color.Black;
            }
        }

        private void txt_Taikhoan_Leave(object sender, EventArgs e)
        {
            if (txt_Taikhoan.Text == string.Empty)
            {
                txt_Taikhoan.Text = "Tài Khoản";
                txt_Taikhoan.ForeColor = Color.Silver;
            }
        }

        private void txt_Matkhau_Enter(object sender, EventArgs e)
        {
            if (txt_Matkhau.Text == "Mật Khẩu")
            {
                txt_Matkhau.Text = string.Empty;
                txt_Matkhau.ForeColor = Color.Black;
            }
        }

        private void txt_Matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_Matkhau.Text == string.Empty)
            {
                txt_Matkhau.Text = "Mật Khẩu";
                txt_Matkhau.ForeColor = Color.Silver;
            }
        }

        //Đăng Ký

        private void txt_TaiKhoanDK_Enter(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDK.Text == "Tài Khoản")
            {
                txt_TaiKhoanDK.Text = string.Empty;
                txt_TaiKhoanDK.ForeColor = Color.Black;
            }
        }

        private void txt_TaiKhoanDK_Leave(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDK.Text == string.Empty)
            {
                txt_TaiKhoanDK.Text = "Tài Khoản";
                txt_TaiKhoanDK.ForeColor = Color.Silver;
            }
        }

        private void txt_EmailDK_Enter(object sender, EventArgs e)
        {
            if (txt_EmailDK.Text == "Email")
            {
                txt_EmailDK.Text = string.Empty;
                txt_EmailDK.ForeColor = Color.Black;
            }
        }

        private void txt_EmailDK_Leave(object sender, EventArgs e)
        {
            if (txt_EmailDK.Text == string.Empty)
            {
                txt_EmailDK.Text = "Email";
                txt_EmailDK.ForeColor = Color.Silver;
            }
        }

        private void txt_MatKhau1DK_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhau1DK.Text == "Mật Khẩu")
            {
                txt_MatKhau1DK.Text = string.Empty;
                txt_MatKhau1DK.ForeColor = Color.Black;
            }
        }

        private void txt_MatKhau1DK_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau1DK.Text == string.Empty)
            {
                txt_MatKhau1DK.Text = "Mật Khẩu";
                txt_MatKhau1DK.ForeColor = Color.Silver;
            }
        }

        private void txt_MatKhau2DK_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhau2DK.Text == "Mật Khẩu")
            {
                txt_MatKhau2DK.Text = string.Empty;
                txt_MatKhau2DK.ForeColor = Color.Black;
            }
        }

        private void txt_MatKhau2DK_Leave(object sender, EventArgs e)
        {
            if (txt_MatKhau2DK.Text == string.Empty)
            {
                txt_MatKhau2DK.Text = "Mật Khẩu";
                txt_MatKhau2DK.ForeColor = Color.Silver;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_Taikhoan.Text == "Tài Khoản" || txt_Matkhau.Text == "Mật Khẩu")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                if (dt.DangNhap(txt_Taikhoan.Text, txt_Matkhau.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormMain main = new FormMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    return;
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoanDK.Text == "Tài Khoản" || txt_MatKhau1DK.Text == "Mật Khẩu" || txt_MatKhau2DK.Text == "Mật Khẩu" || txt_EmailDK.Text == "Email")
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                if (checkBox1.Checked)
                {
                    if (txt_MatKhau1DK.Text != txt_MatKhau2DK.Text)
                    {
                        MessageBox.Show("Mật khẩu không khớp");
                    }
                    else
                    {
                        if (dt.DangKy(txt_TaiKhoanDK.Text, txt_MatKhau1DK.Text, txt_EmailDK.Text))
                        {
                            MessageBox.Show("Đăng ký thành công");
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản đã tồn tại");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn có đồng ý với thỏa thuận không?");
                }
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        
    }
}
