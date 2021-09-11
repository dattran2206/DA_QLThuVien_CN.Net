using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QL_ThuVien2
{
    public class XuLy
    {
        SqlConnection cnn = new SqlConnection("Data Source=DATTRAN\\SQLEXPRESS;Initial Catalog=QLTHUVIEN;User ID=sa;Password=123");
        DataSet QL_ThuVien = new DataSet();
        SqlDataAdapter da_Sach = null;
        SqlDataAdapter da_TaiKhoan = null;

        public XuLy()
        {
            //Sach
            da_Sach = new SqlDataAdapter("Select* from tbl_Sach", cnn);
            da_Sach.Fill(QL_ThuVien, "Sach");
            //Khoa Chinh Sach
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QL_ThuVien.Tables["Sach"].Columns[0];
            QL_ThuVien.Tables["Sach"].PrimaryKey = khoachinh;


            //TaiKhoan
            da_TaiKhoan = new SqlDataAdapter("Select * from tbl_TaiKhoan", cnn);
            da_TaiKhoan.Fill(QL_ThuVien, "TaiKhoan");
            //KhoaChinhTK
            DataColumn[] khoachinh_TK = new DataColumn[1];
            khoachinh_TK[0] = QL_ThuVien.Tables["TaiKhoan"].Columns[0];
            QL_ThuVien.Tables["TaiKhoan"].PrimaryKey = khoachinh_TK;
        }

        public DataTable loadLoai()
        {
            SqlDataAdapter da_Loai = new SqlDataAdapter("Select * from tbl_LoaiSach", cnn);
            da_Loai.Fill(QL_ThuVien, "LoaiSach");
            
            DataColumn[] khoachinh = new DataColumn[1];
            khoachinh[0] = QL_ThuVien.Tables["LoaiSach"].Columns[0];
            QL_ThuVien.Tables["LoaiSach"].PrimaryKey = khoachinh;
            return QL_ThuVien.Tables["LoaiSach"];
        }

        public DataTable loadSach()
        {
            return QL_ThuVien.Tables["Sach"];
        }

        public DataTable loadTaiKhoan()
        {
            
            return QL_ThuVien.Tables["TaiKhoan"];
        }

        public bool DangKy(string pTaiKhoan, string pMatKhau, string pEmail)
        {
            try
            {
                DataRow dr_DangKy = QL_ThuVien.Tables["TaiKhoan"].NewRow();
                dr_DangKy["User"] = pTaiKhoan;
                dr_DangKy["Password"] = pMatKhau;
                dr_DangKy["email"] = pEmail;
                QL_ThuVien.Tables["TaiKhoan"].Rows.Add(dr_DangKy);
                SqlCommandBuilder build = new SqlCommandBuilder(da_TaiKhoan);
                da_TaiKhoan.Update(QL_ThuVien, "TaiKhoan");
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool DangNhap(string pTaiKhoan, string pMatKhau)
        {
            try
            {
                DataRow dr_DN = QL_ThuVien.Tables["TaiKhoan"].Rows.Find(pTaiKhoan);
                if (dr_DN == null)
                {
                    return false;
                }
                else
                {
                    if (dr_DN[1].ToString().Trim() != pMatKhau)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch 
            {
                return false;
            }
        }

        public bool Luu()
        {
            try
            {
                SqlCommandBuilder build = new SqlCommandBuilder(da_Sach);
                da_Sach.Update(QL_ThuVien, "Sach");
                return true;
            }
            catch
            {
                return false;

            }
        }

        public bool themSach(string pMaSach, string pMaLoai, string pTenSach, string pTacGia, string pNhaXB, string pSoLuong)
        {
            try
            {
                DataRow dr_ThemSach = QL_ThuVien.Tables["Sach"].NewRow();
                dr_ThemSach["MaSach"] = pMaSach;
                dr_ThemSach["MaLoai"] = pMaLoai;
                dr_ThemSach["TenSach"] = pTenSach;
                dr_ThemSach["TacGia"] = pTacGia;
                dr_ThemSach["NhaXuatBan"] = pNhaXB;
                dr_ThemSach["SoLuong"] = pSoLuong;
                QL_ThuVien.Tables["Sach"].Rows.Add(dr_ThemSach);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool xoaSach(string pMaSach)
        {
            try
            {
                DataRow dr_Xoa = QL_ThuVien.Tables["Sach"].Rows.Find(pMaSach);
                if (dr_Xoa != null)
                {
                    dr_Xoa.Delete();
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public bool suaSach(string pMaSach, string pMaLoai, string pTenSach, string pTacGia, string pNhaXB, string pSoLuong)
        {
            try
            {
                DataRow dr_Sua = QL_ThuVien.Tables["Sach"].Rows.Find(pMaLoai);
                if (dr_Sua != null)
                {
                    dr_Sua.Delete();
                }
                dr_Sua["MaSach"] = pMaSach;
                dr_Sua["MaLoai"] = pMaLoai;
                dr_Sua["TenSach"] = pTenSach;
                dr_Sua["TacGia"] = pTacGia;
                dr_Sua["NhaXuatBan"] = pNhaXB;
                dr_Sua["SoLuong"] = pSoLuong;
                QL_ThuVien.Tables["Sach"].Rows.Add(dr_Sua);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Databingding(TextBox txtMaSach, ComboBox cbxMaLoai, TextBox txtTenSach, TextBox txtTG, TextBox txtNhaXB, TextBox txtSoLuong)
        {
            DataTable DT = QL_ThuVien.Tables["Sach"];
            txtMaSach.DataBindings.Clear();
            cbxMaLoai.DataBindings.Clear();
            txtTenSach.DataBindings.Clear();
            txtTG.DataBindings.Clear();
            txtNhaXB.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();

            txtMaSach.DataBindings.Add("Text", DT, "MaSach");
            cbxMaLoai.DataBindings.Add("Text", DT, "MaLoai");
            txtTenSach.DataBindings.Add("Text", DT, "TenSach");
            txtTG.DataBindings.Add("Text", DT, "TacGia");
            txtNhaXB.DataBindings.Add("Text", DT, "NhaXuatBan");
            txtSoLuong.DataBindings.Add("Text", DT, "SoLuong");
        }
    }
}
