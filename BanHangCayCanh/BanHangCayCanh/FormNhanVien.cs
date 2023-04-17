using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormNhanVien : Form
    {
        private DataTable dtKH;
        private string currentIdNhanVien;
        private DataTable dtKHTimKiem;

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = false;
            LoadDGV();
        }
       

        private void rtxtMota_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

            
        }

        private void LoadDGV()
        {
            dtKH = Data.GetDataToTable("Select * from NhanVien");
            dgvNhanVien.DataSource = dtKH;
            LoadUI();
            ResetForm();
        }

        private void LoadUI()
        {
            dgvNhanVien.Columns["idNhanVien"].DataPropertyName = "idNhanVien";//Binding dữ liệu vào các cột
            dgvNhanVien.Columns["tenNV"].DataPropertyName = "tenNV";//Binding dữ liệu vào các cột
            dgvNhanVien.Columns["namSinh"].DataPropertyName = "namSinh";//Binding dữ liệu vào các cột
            dgvNhanVien.Columns["gioiTinh"].DataPropertyName = "gioiTinh";//Binding dữ liệu vào các cột
            dgvNhanVien.Columns["diaChi"].DataPropertyName = "diaChi";//Binding dữ liệu vào các cột
            dgvNhanVien.Columns["sdtNV"].DataPropertyName = "sdtNV";//Binding dữ liệu vào các cột\
        }

        private void ResetForm()
        {
            txtTen.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
            rtxtDiaChi.Text = "";
            btnHuyTimKiem.Visible = false;
            titleTable.Text = "Danh sách nhân viên";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (IsValidateForm())
            {
                int value = Common.GetMaxId(dtKH, "idNhanVien") + 1;
                string idNV = "nv_" + (value < 10 ? "0" + value : value.ToString());
                string sql = "Insert into NhanVien VALUES (N'" + idNV +
                               "',N'" + txtTen.Text +
                               "',N'" + cbbGioiTinh.Text +
                               "',N'" + rtxtDiaChi.Text +
                               "',N'" + txtSDT.Text +
                               "',N'" + txtTuoi.Text +
                               "')";
                Data.RunSQL(sql);
                LoadDGV();
                MessageBox.Show("Thêm thành công!");
            }

        }

        private bool IsValidateForm()
        {
            if (txtSDT.Text == "" || txtTen.Text == "" || txtTuoi.Text == "" || rtxtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return false;
            }
            Regex regex = new Regex(@"(\+?84|0)\d{9,10}");
            if (!regex.Match(txtSDT.Text).Success)
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại!", "Thông báo");
                return false;
            }
            if (!CheckAge(txtTuoi.Value))
            {
                MessageBox.Show("Tuổi nhân viên không hợp lệ!", "Thông báo");
                return false;
            }

            return true;
        }
        public static bool CheckAge(DateTime dob)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;

            if (dob > today.AddYears(-age))
                age--;

            return age >= 18;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (IsValidateForm())
            {
                string sqlKH = "Update NhanVien set tenNV = N'" + txtTen.Text +
                              "', namSinh = N'" + txtTuoi.Text +
                              "', diaChi = N'" + rtxtDiaChi.Text +
                              "',sdtNV = N'" + txtSDT.Text +
                              "',gioiTinh = N'" + cbbGioiTinh.Text +
                              "' where idNhanVien like N'" + currentIdNhanVien + "'";
                Data.RunSQL(sqlKH);
                LoadDGV();
                MessageBox.Show("Sửa thành công!");
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                string sql = "Delete from NhanVien where idNhanVien like N'" + currentIdNhanVien + "'";
                string sqlAccount = "Delete from TaiKhoan where idNhanVien like N'" + currentIdNhanVien + "'";
                Data.RunSQL(sqlAccount);
                Data.RunSQL(sql);
                LoadDGV();
                MessageBox.Show("Xóa thành công!");
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyTimKiem.Visible = true;
            titleTable.Text = "Kết quả tìm kiếm";
            dtKHTimKiem = Data.GetDataToTable("Select * from NhanVien where idNhanVien = N'" + txtTimkiem.Text + "' or tenNV = N'" + txtTimkiem.Text + "' or sdtNV = N'" + txtTimkiem.Text + "'");
            dgvNhanVien.DataSource = dtKHTimKiem;
            LoadUI();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            LoadDGV();
            ResetForm();
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            txtTen.Text = dgvNhanVien.CurrentRow.Cells["tenNV"].Value.ToString();
            txtTuoi.Text = dgvNhanVien.CurrentRow.Cells["namSinh"].Value.ToString();
            txtSDT.Text = dgvNhanVien.CurrentRow.Cells["sdtNV"].Value.ToString();
            rtxtDiaChi.Text = dgvNhanVien.CurrentRow.Cells["diaChi"].Value.ToString();
            cbbGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["gioiTinh"].Value.ToString();
            currentIdNhanVien = dgvNhanVien.CurrentRow.Cells["idNhanVien"].Value.ToString();
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }
    }
}
