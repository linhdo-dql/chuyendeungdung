using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormBanHang : Form
    {
        private DataTable dtHoaDon;
        public static string currentIdHD { get; set; }
        private DataTable dtCTHD;
        private string currentIdCTHD;
        private bool isFirstAdd;
        private int iniDgvCTHDRowCount;
        private bool isOldCustomer;
        private bool isChanged;
        private string currentIdKhachHang;
        private DataTable dtKH;
        private DataTable dtTimKiemHoaDon;

        public FormBanHang()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvCTHD.AutoGenerateColumns = false;
            LoadDataGridViewBill();
            LoadCBBItems();
            LoadCBBCustomer();
            LoadCBBStaff();
            isFirstAdd = true;
            cbbTrangThai.SelectedIndex = 0;
        }

        private void LoadCBBStaff()
        {
            string sql = "Select * from NhanVien";
            Data.FillCombo(sql, cbbIdNhanVien, "idNhanVien", "idNhanVien");
        }

        private void LoadCBBCustomer()
        {
            string sql = "Select * from KhachHang";
            Data.FillCombo(sql, cbbKhachHang, "idKH", "tenKH");
            dtKH = Data.GetDataToTable(sql);
        }

        private void LoadDataGridViewBill()
        {
            dtHoaDon = Data.GetDataToTable("Select * from HoaDon");
            dgvHoaDon.DataSource = dtHoaDon.AsEnumerable().Reverse().CopyToDataTable();
            BindingDataGridViewUI();
        }
        private void LoadCBBItems()
        {
            string sql = "Select * from CayCanh";
            Data.FillCombo(sql, cbbTenCay, "idCayCanh", "tenCay");
            cbbTenCay.SelectedIndex = 0;
        }
        private void BindingDataGridViewUI()
        {
            dgvHoaDon.Columns["idHoaDonAll"].DataPropertyName = "idHoaDon";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["idNhanVien"].DataPropertyName = "idNhanVien";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["ngayLap"].DataPropertyName = "ngayLap";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["idKhachHang"].DataPropertyName = "idKH";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["chietKhau"].DataPropertyName = "chietKhau";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["tongTien"].DataPropertyName = "tongTien";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["trangThai"].DataPropertyName = "trangThai";
            dgvHoaDon.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvHoaDon.ClearSelection();
        }


        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            if (isChanged)
            {
                DialogResult result = MessageBox.Show("Bạn đang update hóa đơn trước! Bạn có muốn lưu lại thông tin cập nhật?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    UpdateInfoBill();
                }
            }
            panelThongTinHoaDon.Visible = true;
            isChanged = false;
            if (dtHoaDon.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /* if (txtTenCay.Text != "")
             {
                 DialogResult r = MessageBox.Show("Bạn đang ở chế độ thêm mới hoặc chỉnh sửa. Bạn có muốn hủy dữ liệu vừa nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (r.Equals(DialogResult.Yes))
                 {
                   
                     txtTenCay.Text = dgvCayCanh.CurrentRow.Cells["tenCay"].Value.ToString();
                     rtxtMota.Text = dgvCayCanh.CurrentRow.Cells["moTa"].Value.ToString();
                 }
                 return;
             }
             else
             {*/
            
            panelSanPham.Visible = false;
            currentIdHD = dgvHoaDon.CurrentRow.Cells["idHoaDonAll"].Value.ToString();
            lbIDHoaDon.Text = "Thông tin hóa đơn : "+ currentIdHD;
            cbbIdNhanVien.Text = dgvHoaDon.CurrentRow.Cells["idNhanVien"].Value.ToString();
            DataRow dr = Data.GetPropertiesById("KhachHang", "idKH", dgvHoaDon.CurrentRow.Cells["idKhachHang"].Value.ToString()).Rows[0];
            cbbKhachHang.Text = dr["tenKH"].ToString();
            txtDiaChiKH.Text = dr["diaChiKH"].ToString();
            txtSDT.Text = dr["sdtKH"].ToString();
            txtTuoiKH.Text = dr["tuoiKH"].ToString();
            rbKhachHangCu.Checked = true;
            cbbTrangThai.Text = dgvHoaDon.CurrentRow.Cells["trangThai"].Value.ToString();
            dtpNgayLap.Value = DateTime.Parse(dgvHoaDon.CurrentRow.Cells["ngayLap"].Value.ToString());
            txtGiamGia.Text = dgvHoaDon.CurrentRow.Cells["chietKhau"].Value.ToString();
            txtTongTien.Text = dgvHoaDon.CurrentRow.Cells["tongTien"].Value.ToString();
            LoadDataGridViewBillDetail();
            ResetTongTien();
            // }
        }

        private void LoadDataGridViewBillDetail()
        {
            btnHuyTimKiem.Visible = false;
            titleTable.Text = "Danh sách hóa đơn";
            dtCTHD = Data.GetDataToTable("Select * from ChiTietHoaDon where idHoaDon like N'" + currentIdHD + "'");
            dgvCTHD.Rows.Clear();
            for (int i = 0; i < dtCTHD.Rows.Count; i++)
            {
                var index = dgvCTHD.Rows.Add();
                DataGridViewRow dr = dgvCTHD.Rows[index];
                dr.Cells["idCTHD"].Value = dtCTHD.Rows[i]["idCTHD"].ToString();
                dr.Cells["idHoaDon"].Value = dtCTHD.Rows[i]["idHoaDon"].ToString(); ;
                dr.Cells["idCay"].Value = dtCTHD.Rows[i]["idCayCanh"].ToString();
                dr.Cells["soLuong"].Value = dtCTHD.Rows[i]["soLuong"].ToString();
                dr.Cells["donGia"].Value = dtCTHD.Rows[i]["donGia"].ToString();
            }
            iniDgvCTHDRowCount = dgvCTHD.Rows.Count;
            BindingDataGridViewUIBillDetails();
        }

        private void BindingDataGridViewUIBillDetails()
        {
            dgvCTHD.Columns["idHoaDon"].DataPropertyName = "idHoaDon";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["idCTHD"].DataPropertyName = "idCTHD";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["idCay"].DataPropertyName = "idCayCanh";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["soLuong"].DataPropertyName = "soLuong";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["donGia"].DataPropertyName = "donGia";
            LoadTenCay();
        }

        private void LoadTenCay()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                //
                DataRow dr = Data.GetPropertiesById("CayCanh", "idCayCanh", dtCTHD.Rows[i]["idCayCanh"].ToString()).Rows[0];
                dgvCTHD.Rows[i].Cells["anhCay"].Value = dr["anh"];
                dgvCTHD.Rows[i].Cells["tenCay"].Value = dr["tenCay"];
                //
                dgvCTHD.Rows[i].Cells["thanhTien"].Value = (float.Parse(dgvCTHD.Rows[i].Cells["soLuong"].Value.ToString()) * float.Parse(dgvCTHD.Rows[i].Cells["donGia"].Value.ToString())) + "";
            }
            dgvCTHD.ClearSelection();
        }

        private void ResetTongTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                tong += float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            txtGiaCay.Text = tong + "";
            txtTongTien.Text = (tong - float.Parse(txtGiamGia.Text)) + "";
        }
        private void cbbTenCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelSanPham.Visible)
            {
                DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", (sender as ComboBox).SelectedValue.ToString());
                txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
                txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
                //
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
            isChanged = true;
            panelSanPham.Visible = true;
            btnXoaSP.Visible = false;
            btnSuaSP.Visible = false;
            btnThemSP.Visible = true;
            DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", cbbTenCay.SelectedValue.ToString());
            txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
            txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            ResetFormSP();
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            isChanged = true;
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
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentIdCTHD))
                {
                    dgvCTHD.Rows.Remove(dgvCTHD.Rows[i]);
                    if (i < iniDgvCTHDRowCount)
                    {
                        iniDgvCTHDRowCount -= 1;
                    }
                    break;
                }
            }
            int startId = Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
            for (int i = iniDgvCTHDRowCount; i < dgvCTHD.Rows.Count; i++)
            {
                dgvCTHD.Rows[i].Cells["idCTHD"].Value = "cthd_" + (startId < 10 ? "0" + startId : startId.ToString());
                startId += 1;
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
            ResetFormSP();
            panelSanPham.Visible = false;
            txtTenKhachHang.Text = "";
            cbbKhachHang.Text = "";
            txtDiaChiKH.Text = "";
            txtTuoiKH.Text = "";
            txtSDT.Text = "";
        }
        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            currentIdCTHD = dgvCTHD.CurrentRow.Cells["idCTHD"].Value.ToString();
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
            isChanged = true;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentIdCTHD))
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
                            float newValue = float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString()) + newTotal;
                            dgvCTHD.Rows[i].Cells["thanhTien"].Value = newValue;
                            UpdateAmount(dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString(), newAmount);
                            break;
                        }

                    }
                }
                else if (r == DialogResult.No)
                {

                    int idCTHD = dgvCTHD.Rows.Count > iniDgvCTHDRowCount ?
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
                int idCTHD = dgvCTHD.Rows.Count > iniDgvCTHDRowCount ?
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
            isChanged = true;
            ResetTongTien();
            panelSanPham.Visible = false;

        }
        private void UpdateAmount(string idCTHD, int newAmount)
        {
            string sql = "UPDATE ChiTietHoaDon SET soLuong=" + newAmount +
                   " Where idCTHD = N'" + idCTHD + "'";
            Data.RunSQL(sql);

        }
        private void UpdateDatabase()
        {
            string sql = "UPDATE ChiTietHoaDon SET soLuong=" + nudSoLuong.Value +
                   ", idCayCanh = N'" + cbbTenCay.SelectedValue.ToString() +
                   "', donGia=" + txtGiaBan.Text +
                   " Where idCTHD = N'" + currentIdCTHD + "'";
            Data.RunSQL(sql);
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

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogAddBill dialog = new DialogAddBill();
            dialog.IsFromFormCayCanh = false;
            dialog.IsDatLaiHoaDon = false;
            dialog.ShowDialog();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvHoaDon.Columns[e.ColumnIndex].Name == "trangThai" && e.Value != null)
            {
                e.CellStyle.Font = new System.Drawing.Font("ubuntu", 9, FontStyle.Bold);
                switch (e.Value)
                {
                    case "Chờ xử lý":
                        e.CellStyle.ForeColor = System.Drawing.Color.Orange; break;
                    case "Đang giao":
                        e.CellStyle.ForeColor = System.Drawing.Color.Blue; break;
                    case "Chưa thanh toán":
                        e.CellStyle.ForeColor = System.Drawing.Color.Red; break;
                    case "Đã thanh toán":
                        e.CellStyle.ForeColor = System.Drawing.Color.Green; break;
                    case "Đã hủy":
                        e.CellStyle.ForeColor = System.Drawing.Color.Black; break;
                }
            }
        }

        private void btnClosePanelSP_Click(object sender, EventArgs e)
        {
            panelSanPham.Visible = false;
        }

        private void btnDatLaiDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            DialogAddBill dialog = new DialogAddBill();
            dialog.IsFromFormCayCanh = false;
            dialog.IsDatLaiHoaDon = true;
            dialog.ShowDialog();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            isChanged = false;
            UpdateInfoBill();
        }

        private void UpdateInfoBill()
        {
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
            string sql = "Update HoaDon Set idNhanVien = N'" + cbbIdNhanVien.SelectedValue +
                "',ngayLap = N'" + dtpNgayLap.Text +
                "',idKH = N'" + currentIdKhachHang +
                "',chietKhau =" + txtGiamGia.Text +
                ",tongTien =" + txtTongTien.Text +
                ",trangThai = N'" + cbbTrangThai.Text + "' where idHoaDon like N'" + currentIdHD + "'";
            Data.RunSQL(sql);
            UpdateCTHD();
            LoadDataGridViewBill();

        }

        private void UpdateCTHD()
        {
            string sql = "Select * from ChiTietHoaDon where idHoaDon like N'" + currentIdHD + "'";
            foreach (DataGridViewRow dr in dgvCTHD.Rows)
            {
                foreach (DataRow dataRow in dtCTHD.Rows)
                {
                    //Nếu có trên cả dgv và dt thì update
                    if (dr.Cells["idCTHD"].Value.Equals(dataRow["idCTHD"]))
                    {
                        string sqlUpdate = "Update ChiTietHoaDon set idCayCanh = N'" + dr.Cells["idCay"].Value +
                                           "',soLuong =" + dr.Cells["soLuong"].Value + " where idCTHD like N'" + dr.Cells["idCTHD"].Value + "'";
                        Data.RunSQL(sqlUpdate);
                        break;
                    }
                }
            }
            dtCTHD = Data.GetDataToTable(sql);
            foreach (DataGridViewRow dr in dgvCTHD.Rows)
            {

                //Nếu có trên dgv nhưng không có trên dt thì thêm
                if (!IsContainDataTable(dtCTHD, dr.Cells["idCTHD"].Value.ToString()))
                {
                    string sqlInsert = "Insert into ChiTietHoaDon values (N'" + dr.Cells["idCTHD"].Value +
                                                                      "', N'" + dr.Cells["idCay"].Value +
                                                                      "', N'" + currentIdHD +
                                                                      "'," + dr.Cells["soLuong"].Value +
                                                                      "," + dr.Cells["donGia"].Value + ")";
                    Data.RunSQL(sqlInsert);
                }
            }
            dtCTHD = Data.GetDataToTable(sql);
            foreach (DataRow dr in dtCTHD.Rows)
            {
                //Nếu có trên dt nhưng không có trên dgv thì xóa
                if (!IsContainDGV(dgvCTHD, dr["idCTHD"].ToString()))
                {
                    string sqlDelete = "Delete from ChiTietHoaDon where idCTHD like N'" + dr["idCTHD"] + "'";
                    Data.RunSQL(sqlDelete);
                }
            }


        }

        private bool IsContainDataTable(DataTable dt, string id)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["idCTHD"].Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsContainDGV(DataGridView dgv, string id)
        {
            foreach (DataGridViewRow dr in dgv.Rows)
            {
                if (dr.Cells["idCTHD"].Value.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        private void rbKhachHangMoi_CheckedChanged(object sender, EventArgs e)
        {
            isOldCustomer = false;
            panelKhachHang.Visible = true;
            txtTenKhachHang.Visible = true;
            cbbKhachHang.Visible = false;
            ResetDialog();
            txtDiaChiKH.Enabled = txtSDT.Enabled = txtTuoiKH.Enabled = true;
        }

        private void rbKhachHangCu_CheckedChanged(object sender, EventArgs e)
        {
            isOldCustomer = true;
            panelKhachHang.Visible = true;
            cbbKhachHang.Visible = true;
            txtTenKhachHang.Visible = false;
            ResetDialog();
            DataRow dr = Data.GetPropertiesById("KhachHang", "idKH", dgvHoaDon.CurrentRow.Cells["idKhachHang"].Value.ToString()).Rows[0];
            cbbKhachHang.Text = dr["tenKH"].ToString();
            txtDiaChiKH.Text = dr["diaChiKH"].ToString();
            txtSDT.Text = dr["sdtKH"].ToString();
            txtTuoiKH.Text = dr["tuoiKH"].ToString();
            txtDiaChiKH.Enabled = txtSDT.Enabled = txtTuoiKH.Enabled = false;
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            LoadInfoCustormer(combo.SelectedValue.ToString());
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyTimKiem.Visible = true;
            titleTable.Text = "Kết quả tìm kiếm";

            dtTimKiemHoaDon = Data.GetDataToTable("Select * from HoaDon where idKH = N'" + txtTimkiem.Text + "' or idNhanVien = N'" + txtTimkiem.Text + "' or idHoaDon = N'" + txtTimkiem.Text + "'");
            dgvHoaDon.DataSource = dtTimKiemHoaDon;
            BindingDataGridViewUI();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGridViewBill();
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

        private void btnInHD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrint formPrint = new FormPrint(currentIdHD);
            formPrint.ShowDialog();
        }
    }
}
