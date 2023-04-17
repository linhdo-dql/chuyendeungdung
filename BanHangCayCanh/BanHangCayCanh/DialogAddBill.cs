using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class DialogAddBill : Form
    {
        public bool IsFromFormCayCanh { get; set; }
        public DataTable dtKH;
        private bool isOldCustomer;
        private string currentId;
        public string currentIdHoaDon;
        public bool IsDatLaiHoaDon { get; set; }

        private string currentIdKhachHang;
        private DataTable dtCurrentHD;

        public DialogAddBill()
        {
            InitializeComponent();
        }
        private void DialogAddBill_Load(object sender, EventArgs e)
        {
            LoadCBBCustormer();
            LoadCBBStaff();
            LoadCBBItems();
            cbbTrangThai.SelectedIndex = 0;
            if (IsFromFormCayCanh)
            {
                LoadDataGridView(FormCayCanh.ListIdSelecteds);
            }
            else
            {
                if (IsDatLaiHoaDon)
                {
                    currentIdHoaDon = FormBanHang.currentIdHD;
                    LoadDataGridViewByIdHoaDon(currentIdHoaDon);
                }
                else
                {
                    int maxId = (Common.GetMaxId(Data.GetDataToTable("Select * from HoaDon"), "idHoaDon") + 1);
                    currentIdHoaDon = "hd_" + (maxId < 10 ? "0" + maxId : maxId.ToString());
                }
            }
        }

        private void LoadDataGridViewByIdHoaDon(string currentIdHoaDon)
        {
            dtCurrentHD = Data.GetPropertiesById("HoaDon", "idHoaDon", currentIdHoaDon);
            LoadDGVCTHDDatLai(Data.GetDataToTable("Select * from ChiTietHoaDon where idHoaDon like N'" + currentIdHoaDon + "'"));
        }

        private void LoadDGVCTHDDatLai(DataTable dataTable)
        {
            int idCTHD = Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", dataTable.Rows[0]["idCayCanh"].ToString());
                var index = dgvCTHD.Rows.Add();
                DataGridViewRow dr = dgvCTHD.Rows[index];
                dr.Cells["idCTHD"].Value = "cthd_" + (idCTHD < 10 ? "0" + idCTHD : idCTHD.ToString());
                dr.Cells["idHoaDon"].Value = dataTable.Rows[i]["idHoaDon"];
                dr.Cells["idCay"].Value = dataTable.Rows[i]["idCayCanh"];
                dr.Cells["soLuong"].Value = dataTable.Rows[i]["soLuong"];
                dr.Cells["donGia"].Value = dataTable.Rows[i]["donGia"];
                dr.Cells["tenCay"].Value = dt.Rows[0]["tenCay"];
                dr.Cells["thanhTien"].Value = (float.Parse(dataTable.Rows[i]["soLuong"].ToString()) * float.Parse(dataTable.Rows[i]["donGia"].ToString())) + "";
                idCTHD += 1;
            }
            txtGiamGia.Text = "0";
            ResetTongTien();
            int maxId = (Common.GetMaxId(Data.GetDataToTable("Select * from HoaDon"), "idHoaDon") + 1);
            currentIdHoaDon = "hd_" + (maxId < 10 ? "0" + maxId : maxId.ToString());
        }

        private void LoadDataGridView(List<string> listIdSelecteds)
        {
            int maxId = (Common.GetMaxId(Data.GetDataToTable("Select * from HoaDon"), "idHoaDon") + 1);
            currentIdHoaDon = "hd_" + (maxId < 10 ? "0" + maxId : maxId.ToString());
            int startId = Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
            float tong = 0;
            if (listIdSelecteds != null)
            {
                for (int i = 0; i < listIdSelecteds.Count; i++)
                {
                    DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", listIdSelecteds[i]);
                    tong += float.Parse(dt.Rows[0]["gia"].ToString());
                    int newID = startId + i;
                    string newIdCTHD = "cthd_" + (newID < 10 ? "0" + newID : newID.ToString());
                    AddRowToDataGridView(dt, newIdCTHD, currentIdHoaDon);
                }
            }
            txtTongTien.Text = tong + "";
            dgvCTHD.ClearSelection();

        }

        private void AddRowToDataGridView(DataTable dt, string idCTHD, string idHoaDon)
        {
            var index = dgvCTHD.Rows.Add();
            DataGridViewRow dr = dgvCTHD.Rows[index];
            dr.Cells["idCTHD"].Value = idCTHD;
            dr.Cells["idHoaDon"].Value = idHoaDon;
            dr.Cells["idCay"].Value = dt.Rows[0]["idCayCanh"];
            dr.Cells["soLuong"].Value = 1;
            dr.Cells["donGia"].Value = dt.Rows[0]["gia"];
            dr.Cells["tenCay"].Value = dt.Rows[0]["tenCay"];
            dr.Cells["thanhTien"].Value = float.Parse(dt.Rows[0]["gia"].ToString());
            //
            dr.Cells["anhCay"].Value = dt.Rows[0]["anh"];
            //
        }

        private void LoadCBBItems()
        {
            string sql = "Select * from CayCanh";
            Data.FillCombo(sql, cbbTenCay, "idCayCanh", "tenCay");
            cbbTenCay.SelectedIndex = 0;
        }

        private void LoadCBBStaff()
        {
            /*string sql = "Select * from NhanVien";
            Data.FillCombo(sql, cbbNhanVien, "idNhanVien", "idNhanVien");*/
            txtIdNhanVien.Text = ConfigurationManager.AppSettings.Get("AccountSaved");
        }

        private void LoadCBBCustormer()
        {
            string sql = "Select * from KhachHang";
            dtKH = Data.GetDataToTable(sql);
            Data.FillCombo(sql, cbbKhachHang, "idKH", "tenKH");
            cbbKhachHang.Text = "";
            cbbKhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbKhachHang.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadInfoCustormer(string id)
        {
            DataTable dt = Data.GetPropertiesById("KhachHang", "idKH", id);
            if (dt.Rows.Count > 0)
            {
                txtSDT.Text = dt.Rows[0]["sdtKH"].ToString();
                txtDiaChiKH.Text = dt.Rows[0]["diaChiKH"].ToString();
                txtTuoiKH.Text = dt.Rows[0]["tuoiKH"].ToString();
            }
            currentIdKhachHang = cbbKhachHang.SelectedValue.ToString();
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            LoadInfoCustormer(combo.SelectedValue.ToString());
        }

        private void DialogAddBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsFromFormCayCanh)
            {
                new FormCayCanh().Show();
            }
            else
            {
                new FormBanHang().Show();
            }

        }

        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            currentId = dgvCTHD.CurrentRow.Cells["idCTHD"].Value.ToString();
            cbbTenCay.Text = dgvCTHD.CurrentRow.Cells["tenCay"].Value.ToString();
            nudSoLuong.Value = int.Parse(dgvCTHD.CurrentRow.Cells["soLuong"].Value.ToString());
            txtGiaBan.Text = dgvCTHD.CurrentRow.Cells["donGia"].Value.ToString();
            txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            //
            picAnhCayCanh.BackgroundImageLayout = ImageLayout.Zoom;
            picAnhCayCanh.BackgroundImage = Image.FromFile(dgvCTHD.CurrentRow.Cells["anhCay"].Value.ToString());
            //
            btnXoaSP.Visible = true;
            btnSuaSP.Visible = true;
            btnThemSP.Visible = false;
            panelSanPham.Visible = true;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentId))
                {
                    dgvCTHD.Rows[i].Cells["idCay"].Value = cbbTenCay.SelectedValue;
                    dgvCTHD.Rows[i].Cells["tenCay"].Value = cbbTenCay.Text;
                    dgvCTHD.Rows[i].Cells["soLuong"].Value = nudSoLuong.Value;
                    dgvCTHD.Rows[i].Cells["donGia"].Value = txtGiaBan.Text;
                    dgvCTHD.Rows[i].Cells["thanhTien"].Value = txtThanhTien.Text;
                    //
                    dgvCTHD.Rows[i].Cells["anhCay"].Value = Data.GetPropertiesById("CayCanh", "idCayCanh", cbbTenCay.SelectedValue.ToString()).Rows[0]["anh"];
                    break;
                }
            }
            ResetTongTien();
            panelSanPham.Visible = false;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (IsHavedItems())
            {
                DialogResult r = MessageBox.Show("Đã có cây cảnh này trong danh sách! Bạn có muốn tăng số lượng của cây trong danh sách hiện có?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    float newTotal = float.Parse(txtGiaBan.Text) * int.Parse(nudSoLuong.Value.ToString());
                    for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                    {
                        if (dgvCTHD.Rows[i].Cells["idCay"].Value.ToString().Equals(cbbTenCay.SelectedValue))
                        {
                            int newAmount = (int)(int.Parse(dgvCTHD.Rows[i].Cells["soLuong"].Value.ToString()) + nudSoLuong.Value);
                            dgvCTHD.Rows[i].Cells["soLuong"].Value = newAmount;
                            dgvCTHD.Rows[i].Cells["thanhTien"].Value = float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString()) + newTotal;
                            break;
                        }
                    }
                }
                else if (r == DialogResult.No)
                {

                    int idCTHD = dgvCTHD.Rows.Count > 0 ?
                           Common.GetNumberOfId(dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Cells["idCTHD"].Value.ToString()) + 1 :
                           Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
                    var index = dgvCTHD.Rows.Add();
                    DataGridViewRow dr = dgvCTHD.Rows[index];
                    dr.Cells["idCTHD"].Value = "cthd_" + (idCTHD < 10 ? "0" + idCTHD : idCTHD.ToString());
                    dr.Cells["idHoaDon"].Value = idHoaDon;
                    dr.Cells["idCay"].Value = cbbTenCay.SelectedValue;
                    dr.Cells["soLuong"].Value = nudSoLuong.Value;
                    dr.Cells["donGia"].Value = txtGiaBan.Text;
                    dr.Cells["tenCay"].Value = cbbTenCay.Text;
                    dr.Cells["thanhTien"].Value = txtThanhTien.Text;
                }
                else
                {
                    return;
                }
            }
            else
            {

                int idCTHD = dgvCTHD.Rows.Count > 0 ?
                       Common.GetNumberOfId(dgvCTHD.Rows[dgvCTHD.Rows.Count - 1].Cells["idCTHD"].Value.ToString()) + 1 :
                       Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
                var index = dgvCTHD.Rows.Add();
                DataGridViewRow dr = dgvCTHD.Rows[index];
                dr.Cells["idCTHD"].Value = "cthd_" + (idCTHD < 10 ? "0" + idCTHD : idCTHD.ToString());
                dr.Cells["idHoaDon"].Value = idHoaDon;
                dr.Cells["idCay"].Value = cbbTenCay.SelectedValue;
                dr.Cells["soLuong"].Value = nudSoLuong.Value;
                dr.Cells["donGia"].Value = txtGiaBan.Text;
                dr.Cells["tenCay"].Value = cbbTenCay.Text;
                dr.Cells["thanhTien"].Value = txtThanhTien.Text;
            }
            ResetTongTien();
            panelSanPham.Visible = false;

        }

        private void ResetFormSP()
        {
            cbbTenCay.SelectedIndex = 0;
            nudSoLuong.Value = 1;
        }

        private bool IsHavedItems()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCay"].Value.ToString().Equals(cbbTenCay.SelectedValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnClosePanelSP_Click(object sender, EventArgs e)
        {
            panelSanPham.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbbTenCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelSanPham.Visible)
            {
                DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", (sender as ComboBox).SelectedValue.ToString());
                txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
                txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
                picAnhCayCanh.BackgroundImage = Image.FromFile(dt.Rows[0]["anh"].ToString());
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (panelSanPham.Visible)
            {
                txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelSanPham.Visible = true;
            btnXoaSP.Visible = false;
            btnSuaSP.Visible = false;
            btnThemSP.Visible = true;
            DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", cbbTenCay.SelectedValue.ToString());
            txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
            txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            ResetFormSP();
        }

        private void ResetTongTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                tong += float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            txtTongTien.Text = (tong - float.Parse(txtGiamGia.Text)) + "";
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex("^[0-9]+$");
            if (float.Parse(txtTongTien.Text) < 0 || !regex.IsMatch(txtGiamGia.Text))
            {
                MessageBox.Show("Chiết khấu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiamGia.Text = "0";
                ResetTongTien();
                return;
            }
            ResetTongTien();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cây cảnh này khỏi hóa đơn? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                DeleteItem();
                ResetTongTien();
            }
        }

        private void DeleteItem()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentId))
                {
                    dgvCTHD.Rows.Remove(dgvCTHD.Rows[i]);
                }
            }
            int startId = Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                startId += i;
                dgvCTHD.Rows[i].Cells["idCTHD"].Value = "cthd_" + (startId < 10 ? "0" + startId : startId.ToString());
            }
            ResetFormSP();
            panelSanPham.Visible = false;
        }

        private void btnResetFormHoaDon_Click(object sender, EventArgs e)
        {
            ResetDialog();
        }

        private void ResetDialog()
        {
            dgvCTHD.ClearSelection();
            cbbKhachHang.Text = "";
            txtDiaChiKH.Text = "";
            txtTuoiKH.Text = "";
            txtSDT.Text = "";
            ResetFormSP();
            panelSanPham.Visible = false;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            InsertHoaDon();
        }

        private void InsertCTHD()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                string sql = "Insert into ChiTietHoaDon VALUES (N'" + dgvCTHD.Rows[i].Cells["idCTHD"].Value +
                  "',N'" + dgvCTHD.Rows[i].Cells["idCay"].Value +
                  "',N'" + currentIdHoaDon +
                  "'," + dgvCTHD.Rows[i].Cells["soLuong"].Value +
                  "," + dgvCTHD.Rows[i].Cells["donGia"].Value + ")";
                Data.RunSQL(sql);
            }
            MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InsertHoaDon()
        {
            string sql; //Lưu câu lệnh sql
            if (dgvCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn cây cảnh nào trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!isOldCustomer)
            {
                if (txtTenKhachHang.Text == "" || txtDiaChiKH.Text == "" || txtSDT.Text == "" || txtTuoiKH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                    return;
                }
                Regex regex = new Regex(@"(\+?84|0)\d{9,10}");
                if (!regex.Match(txtSDT.Text).Success)
                {
                    MessageBox.Show("Vui lòng nhập đúng số điện thoại!", "Thông báo");
                    return;
                }
                regex = new Regex("^[0-9]+$");
                if (!regex.Match(txtTuoiKH.Text).Success)
                {
                    MessageBox.Show("Tuổi khách hàng không hợp lệ!", "Thông báo");
                    return;
                }
                int value = Common.GetMaxId(dtKH, "idKH") + 1;
                string idKH = "kh_" + (value < 10 ? "0" + value : value.ToString());
                string sqlKH = "Insert into KhachHang VALUES (N'" + idKH +
                               "',N'" + txtTenKhachHang.Text +
                               "',N'" + txtTuoiKH.Text +
                               "',N'" + txtDiaChiKH.Text +
                               "',N'" + txtSDT.Text +
                               "')";
                Data.RunSQL(sqlKH);
                currentIdKhachHang = idKH;
            }

            bool validTenKhachHang = isOldCustomer ? cbbKhachHang.Text.Trim() == "" : txtTenKhachHang.Text.Trim() == "";
            if (validTenKhachHang) //nếu chưa chọn khách hàng
            {
                MessageBox.Show("Bạn chưa nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Insert into HoaDon VALUES (N'" + currentIdHoaDon +
                  "',N'" + txtIdNhanVien.Text +
                  "',N'" + dtpNgayLap.Text +
                  "',N'" + currentIdKhachHang +
                  "'," + txtGiamGia.Text +
                  "," + txtTongTien.Text +
                  ",N'" + cbbTrangThai.Text +
                  "')";
            Data.RunSQL(sql);
            InsertCTHD();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbKhachHangMoi_CheckedChanged(object sender, EventArgs e)
        {
            isOldCustomer = false;
            panelKhachHang.Visible = true;
            txtTenKhachHang.Visible = true;
            cbbKhachHang.Visible = false;
            ResetDialog();
        }

        private void rbKhachHangCu_CheckedChanged(object sender, EventArgs e)
        {
            isOldCustomer = true;
            panelKhachHang.Visible = true;
            cbbKhachHang.Visible = true;
            txtTenKhachHang.Visible = false;
            ResetDialog();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (isOldCustomer)
            {
                FillComboBoxKH();
            }
        }

        private void FillComboBoxKH()
        {
            foreach (DataRow r in dtKH.Rows)
            {
                if (r["sdtKH"].ToString().Equals(txtSDT.Text))
                {
                    cbbKhachHang.Text = r["tenKH"].ToString();
                    break;
                }
            }
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }

}
