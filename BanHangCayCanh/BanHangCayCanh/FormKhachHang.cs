using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class FormKhachHang : Form
    {
        private DataTable dtKH;
        private string currentIdKhachHang;
        private DataTable dtKHTimKiem;

        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void rtxtMota_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {

            dgvKhachHang.AutoGenerateColumns = false;
            LoadDGV();
        }

        private void LoadDGV()
        {
            dtKH = Data.GetDataToTable("Select * from KhachHang");
            dgvKhachHang.DataSource = dtKH;
            LoadUI();
            ResetForm();
        }

        private void LoadUI()
        {
            dgvKhachHang.Columns["idKH"].DataPropertyName = "idKH";//Binding dữ liệu vào các cột
            dgvKhachHang.Columns["tenKH"].DataPropertyName = "tenKH";//Binding dữ liệu vào các cột
            dgvKhachHang.Columns["tuoiKH"].DataPropertyName = "tuoiKH";//Binding dữ liệu vào các cột
            dgvKhachHang.Columns["diaChiKH"].DataPropertyName = "diaChiKH";//Binding dữ liệu vào các cột
            dgvKhachHang.Columns["sdtKH"].DataPropertyName = "sdtKH";//Binding dữ liệu vào các cột\
        }

        private void ResetForm()
        {
            txtTen.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
            rtxtDiaChi.Text = "";
            btnHuyTimKiem.Visible = false;
            currentIdKhachHang = "";
            titleTable.Text = "Danh sách khách hàng";
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            txtTen.Text = dgvKhachHang.CurrentRow.Cells["tenKH"].Value.ToString();
            txtTuoi.Text = dgvKhachHang.CurrentRow.Cells["tuoiKH"].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells["sdtKH"].Value.ToString();
            rtxtDiaChi.Text = dgvKhachHang.CurrentRow.Cells["diaChiKH"].Value.ToString();
            currentIdKhachHang = dgvKhachHang.CurrentRow.Cells["idKH"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(IsValidateForm())
            {
                int value = Common.GetMaxId(dtKH, "idKH") + 1;
                string idKH = "kh_" + (value < 10 ? "0" + value : value.ToString());
                string sqlKH = "Insert into KhachHang VALUES (N'" + idKH +
                               "',N'" + txtTen.Text +
                               "',N'" + txtTuoi.Text +
                               "',N'" + rtxtDiaChi.Text +
                               "',N'" + txtSDT.Text +
                               "')";
                Data.RunSQL(sqlKH);
                LoadDGV();
                MessageBox.Show("Thêm thành công!");
            }
            
        }

        private bool IsValidateForm()
        {
            if (txtSDT.Text == ""|| txtTen.Text == "" || txtTuoi.Text == "" || rtxtDiaChi.Text == "" )
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
            regex = new Regex("^[0-9]+$");
            if (!regex.Match(txtTuoi.Text).Success)
            {
                MessageBox.Show("Tuổi khách hàng không hợp lệ!", "Thông báo");
                return false;
            }
            
            return true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(IsValidateForm())
            {
                string sqlKH = "Update KhachHang set tenKH = N'" + txtTen.Text +
                              "', tuoiKH = " + txtTuoi.Text +
                              ", diaChiKH = N'" + rtxtDiaChi.Text +
                              "',sdtKH = N'" + txtSDT.Text +
                              "' where idKH like N'" + currentIdKhachHang +"'";
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
            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                string sql = "Delete from KhachHang where idKH like N'" + currentIdKhachHang + "'";
                Data.RunSQL(sql);
                LoadDGV();
                MessageBox.Show("Xóa thành công!");
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyTimKiem.Visible = true;
            titleTable.Text = "Kết quả tìm kiếm";
            dtKHTimKiem = Data.GetDataToTable("Select * from KhachHang where idKH = N'" + txtTimkiem.Text + "' or tenKH = N'" + txtTimkiem.Text + "' or sdtKH = N'" + txtTimkiem.Text  + "'");
            dgvKhachHang.DataSource = dtKHTimKiem;
            LoadUI();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            LoadDGV();
            ResetForm();
        }

        private void titleTable_Click(object sender, EventArgs e)
        {

        }

        private void FormKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void btnXuatDSKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBaoCao(2).Show();
        }
    }
}
