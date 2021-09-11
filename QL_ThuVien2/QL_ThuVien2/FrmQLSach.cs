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
    public partial class FrmQLSach : Form
    {

        XuLy dt = new XuLy();

        public FrmQLSach()
        {
            InitializeComponent();
            
        }

        private void FrmQLSach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.loadSach();
            dt.Databingding(txtMaSach, cbxMaLoai, txtTenSach, txtTacGia, txtNhaXB, txtSoLuong);
            cbxMaLoai.DataSource = dt.loadLoai();
            cbxMaLoai.DisplayMember = "TenLoai";
            cbxMaLoai.ValueMember = "MaLoai";
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormMain main = new FormMain();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == null || cbxMaLoai.Text == null || txtTenSach.Text == null || txtTacGia.Text == null || txtNhaXB.Text == null || txtSoLuong.Text == null)
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                if (dt.themSach(txtMaSach.Text, cbxMaLoai.SelectedValue.ToString(), txtTenSach.Text, txtTacGia.Text, txtNhaXB.Text, txtSoLuong.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dt.Luu())
            {
                MessageBox.Show("Lưu thành công");
                btnLuu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lưu thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == null)
            {
                MessageBox.Show("Phải nhập mã sách");
            }
            else
            {
                if (dt.xoaSach(txtMaSach.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Mã sách không tồn tại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == null || cbxMaLoai.Text == null || txtTenSach.Text == null || txtTacGia.Text == null || txtNhaXB.Text == null || txtSoLuong.Text == null)
            {
                MessageBox.Show("Không được để trống");
            }
            else
            {
                if (dt.suaSach(txtMaSach.Text, cbxMaLoai.SelectedValue.ToString(), txtTenSach.Text, txtTacGia.Text, txtNhaXB.Text, txtSoLuong.Text))
                {
                    MessageBox.Show("Sửa thành công");
                    btnLuu.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
        }
    }
}
