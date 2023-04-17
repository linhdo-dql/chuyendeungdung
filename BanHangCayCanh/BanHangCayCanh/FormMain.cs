using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormMain : Form
    {

        DataTable dtNhanVien;
        public FormMain()
        {
            InitializeComponent();

            Data.Connect();
        }

        private void menuLCC_Click(object sender, EventArgs e)
        {
            FormLoaiCayCanh formLoaiCayCanh = new FormLoaiCayCanh();
            this.Hide();
            formLoaiCayCanh.ShowDialog();
        }


        private void menuCC_Click(object sender, EventArgs e)
        {
            FormCayCanh formCayCanh = new FormCayCanh();
            this.Hide();
            formCayCanh.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuBH_Click(object sender, EventArgs e)
        {
            FormBanHang formBanHang = new FormBanHang();
            this.Hide();
            formBanHang.ShowDialog();
        }
        private DataTable dtTaiKhoan;
        private bool isHidePass = true;

        private void LoadComboboxMaNV()
        {

            string sql = "Select * from NhanVien";
            /* string sql1 = "Select * from NhanVien inner join TaiKhoan on NhanVien.idNhanVien = TaiKhoan.idNhanVien";
             string sql2 = "Select * from NhanVien inner join TaiKhoan on NhanVien.idNhanVien != TaiKhoan.idNhanVien";*/
            Data.FillCombo(sql, cbbMaNVDangNhap, "idNhanVien", "idNhanVien");
            Data.FillCombo(sql, cbbMaNVDangKy, "idNhanVien", "idNhanVien");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                dtTaiKhoan = Data.GetDataToTable("Select * from TaiKhoan where idNhanVien like N'" + cbbMaNVDangNhap.Text + "'");
                if (dtTaiKhoan.Rows.Count > 0)
                {
                    if (dtTaiKhoan.Rows[0]["matKhau"].ToString() != txtMatKhauDangNhap.Text)
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        Common.AddUpdateAppSettings("SaveLogined", rbSaveLogined.Checked ? "1" : "0");
                        Common.AddUpdateAppSettings("AccountSaved", cbbMaNVDangNhap.Text);
                        panelTaiKhoan.Visible = false;
                        menuStrip1.Visible = true;
                        menuTK.Text = "Tài khoản: " + cbbMaNVDangNhap.Text;
                        ResetFormTaiKhoan();
                    }
                }
                else
                {
                    DialogResult r = MessageBox.Show("Tài khoản chưa có trong hệ thống! Đăng ký ngay?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (r == DialogResult.Yes)
                    {
                        panelDangNhap.SendToBack();
                        panelTaoTaiKhoan.BringToFront();
                    }
                }

            }
        }

        private bool IsValidated()
        {
            if (cbbMaNVDangNhap.Text == "" || txtMatKhauDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }
            return true;
        }

        private void btnShowHidePass_Click(object sender, EventArgs e)
        {
            isHidePass = !isHidePass;
            txtMatKhauDangNhap.PasswordChar = isHidePass ? '*' : '\0';
            btnShowHidePass.Text = !isHidePass ? "Ẩn" : "Hiện";
        }

        bool isChecked = false;
        private void rbSaveLogined_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rbSaveLogined.Checked;
        }

        private void rbSaveLogined_Click(object sender, EventArgs e)
        {
            if (rbSaveLogined.Checked && !isChecked)
                rbSaveLogined.Checked = false;
            else
            {
                rbSaveLogined.Checked = true;
                isChecked = false;
            }
        }


        private void lkTaoTaiKhoan_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelDangNhap.SendToBack();
            panelTaoTaiKhoan.BringToFront();
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {

            if (!IsFormDangKyValidate()) return;
            string sql = "Insert into TaiKhoan values(N'" + cbbMaNVDangKy.Text + "',N'" + txtMatKhauDangKy.Text + "')";
            Data.RunSQL(sql);
            DialogResult r = MessageBox.Show("Tạo tài khoản thành công! Đăng nhập ngay?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
            {
                panelTaiKhoan.Visible = false;
                menuStrip1.Visible = true;
                Common.AddUpdateAppSettings("AccountSaved", cbbMaNVDangKy.Text);
                menuTK.Text = "Tài khoản: " + cbbMaNVDangKy.Text;
            }
            else
            {
                panelTaoTaiKhoan.SendToBack();
                panelDangNhap.BringToFront();
                LoadFormDangNhap();
            }
            ResetFormTaiKhoan();
        }

        private void ResetFormTaiKhoan()
        {
            txtMatKhauDangKy.Text = "";
            txtMatKhauNhapLai.Text = "";
            txtMatKhauDangNhap.Text = "";
            panelDangNhap.BringToFront();
            panelTaoTaiKhoan.SendToBack();
        }

        private void LoadFormDangNhap()
        {
            cbbMaNVDangNhap.Text = cbbMaNVDangKy.Text;
            txtMatKhauDangNhap.Text = txtMatKhauDangKy.Text;
        }

        private bool IsFormDangKyValidate()
        {
            if (cbbMaNVDangKy.Text == "" || txtMatKhauDangKy.Text == "" || txtMatKhauNhapLai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                return false;
            }
            if (Data.GetPropertiesById("TaiKhoan", "idNhanVien", cbbMaNVDangKy.Text).Rows.Count != 0)
            {
                MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng liên hệ chủ cửa hàng để lấy lại mật khẩu.");
                return false;
            }
            if (txtMatKhauDangKy.Text != txtMatKhauNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu đăng ký và mật khẩu nhập lại phải giống nhau!");
                return false;
            }
            return true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("SaveLogined") == "1")
            {
                panelTaoTaiKhoan.Visible = false;
                panelDangNhap.Visible = false;
                menuStrip1.Visible = true;
                menuTK.Text = "Tài khoản: " + ConfigurationManager.AppSettings.Get("AccountSaved");
            }
            else
            {
                panelTaoTaiKhoan.SendToBack();
                panelDangNhap.BringToFront();
                LoadComboboxMaNV();
            }
        }

        private void menuDX_Click(object sender, EventArgs e)
        {
            Common.AddUpdateAppSettings("SaveLogined", "0");
            Common.AddUpdateAppSettings("AccountSaved", "");
            panelTaiKhoan.Visible = true;
            menuStrip1.Visible = false;
            ResetFormTaiKhoan();
        }

        private void lkQuayLaiDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetFormTaiKhoan();
            panelTaoTaiKhoan.SendToBack();
            panelDangNhap.BringToFront();
            LoadComboboxMaNV();
        }

        private void lkQuayLaiDangNhap_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void menuBC_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBaoCao().ShowDialog();
        }

        private void menuKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormKhachHang().ShowDialog();
        }

        private void menuNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormNhanVien().ShowDialog();
        }
    }
}
