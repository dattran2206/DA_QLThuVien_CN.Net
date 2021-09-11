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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {          
            FrmQLSach sach = new FrmQLSach();
            this.Hide();
            sach.ShowDialog();
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FrmTimKiem tk = new FrmTimKiem();
            this.Hide();
            tk.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Close();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {

        }
    }
}
