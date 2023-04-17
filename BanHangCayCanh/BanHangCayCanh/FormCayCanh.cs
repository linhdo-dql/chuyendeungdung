using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormCayCanh : Form
    {
        private DataTable dtCayCanh;
        private const string IMAGE_PATH = @"C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\";
        private const string REPORT_PATH = @"C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Reports\";
        private string currentFilePath = "";
        private string defaultFilePath = @"C:\Users\linhl\source\repos\BanHangCayCanh\BanHangCayCanh\Resources\anh_cay_canh\default.png";
        private string saveFilePath = "";
        private string currentId;
        public static List<string> ListIdSelecteds;
        private DataTable dtCayCanhTimKiem;
        private bool isImageSelected;

        public FormCayCanh()
        {
            InitializeComponent();
        }

        private void FormCayCanh_Load(object sender, EventArgs e)
        {
            ListIdSelecteds = new List<string>();
            LoadDataGridView();
            LoadCombobox();
            ofd.InitialDirectory = IMAGE_PATH;
            ofd.FileName = "";
            btnChangeImage.BringToFront();

        }

        private void LoadCombobox()
        {
            string sql = "Select * from LoaiCay";
            Data.FillCombo(sql, cbbLoaiCay, "idLoaiCay", "tenLoaiCay");
            cbbLoaiCay.Text = "";
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM CayCanh";
            titleTable.Text = "Danh sách cây cảnh";
            btnHuyTimKiem.Visible = false;
            dgvCayCanh.AutoGenerateColumns = false;
            dtCayCanh = Data.GetDataToTable(sql).AsEnumerable().Reverse().CopyToDataTable(); //Đọc dữ liệu từ bảng
            dgvCayCanh.DataSource = dtCayCanh; //Nguồn dữ liệu
            BindingDataGridViewUI();
            LoadImage(dtCayCanh);
            ResetValue();
        }

        private void ResetValue()
        {
            txtTenCay.Text = "";
            txtSoLuong.Text = "";
            txtMauSac.Text = "";
            txtKichThuoc.Text = "";
            txtTuoi.Text = "";
            txtGiaBan.Text = "";
            rtxtMota.Text = "";
            txtTimkiem.Text = "";
            cbbLoaiCay.Text = "";
            picCayCanh.BackgroundImage = Image.FromFile(defaultFilePath);
            currentFilePath = defaultFilePath;
            dgvCayCanh.ClearSelection();
        }

        private void BindingDataGridViewUI()
        {
            btnXoa.Visible = false;
            txtSoLuongDaChon.Text = "Đã chọn: " + ListIdSelecteds.Count;
            dgvCayCanh.Columns["pathAnh"].DataPropertyName = "anh";
            dgvCayCanh.Columns["idCayCanh"].DataPropertyName = "idCayCanh";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["tenCayCanh"].DataPropertyName = "tenCay";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["moTa"].DataPropertyName = "moTa";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["tuoi"].DataPropertyName = "tuoi";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["mauSac"].DataPropertyName = "mauSac";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["soLuong"].DataPropertyName = "soLuong";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["gia"].DataPropertyName = "gia";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["idLoaiCay"].DataPropertyName = "idLoaiCay";//Binding dữ liệu vào các cột
            dgvCayCanh.Columns["kichThuoc"].DataPropertyName = "kichThuoc";//Binding dữ liệu vào các cột
            dgvCayCanh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvCayCanh.ClearSelection();
        }

        private void LoadImage(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgvCayCanh.Rows[i].Cells["tenLoaiCay"].Value = GetTenCay(dtCayCanh.Rows[i]["idLoaiCay"].ToString());//Binding dữ liệu vào các cột
                ((DataGridViewImageCell)dgvCayCanh.Rows[i].Cells[0]).Value = Image.FromFile(dt.Rows[i][7].ToString());
                if (ListIdSelecteds.Count > 0)
                {
                    if (ListIdSelecteds.Contains(dt.Rows[i]["idCayCanh"].ToString()))
                    {
                        btnXoa.Visible = true;
                        ((DataGridViewCheckBoxCell)dgvCayCanh.Rows[i].Cells["selected"]).Value = true;
                    }
                }
            }
        }

        private string GetTenCay(string value)
        {
            return Data.GetPropertiesById("LoaiCay", "idLoaiCay", value).Rows[0]["tenLoaiCay"].ToString();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                string trailFile = ofd.FileName.Substring(ofd.FileName.Length - 3, 3);
                if (trailFile == "jpg" || trailFile == "png" || trailFile == "jpeg")
                {
                    currentFilePath = ofd.FileName;
                    picCayCanh.BackgroundImageLayout = ImageLayout.Zoom;
                    picCayCanh.BackgroundImage = Image.FromFile(currentFilePath);
                    isImageSelected = true;
                }
                else
                {
                    MessageBox.Show("Định dạng file ảnh chưa đúng. (Phải bao gồm: .png, .jpg, .jpeg) ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh!");
            }
        }

        private void FormCayCanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void dgvCayCanh_Click(object sender, EventArgs e)
        {
            if (dtCayCanh.Rows.Count == 0) //Nếu không có dữ liệu
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
            currentId = dgvCayCanh.CurrentRow.Cells["idCayCanh"].Value.ToString();
            saveFilePath = dgvCayCanh.CurrentRow.Cells["pathAnh"].Value.ToString();
            picCayCanh.BackgroundImage = Image.FromFile(saveFilePath);
            txtTenCay.Text = dgvCayCanh.CurrentRow.Cells["tenCayCanh"].Value.ToString();
            rtxtMota.Text = dgvCayCanh.CurrentRow.Cells["moTa"].Value.ToString();
            txtMauSac.Text = dgvCayCanh.CurrentRow.Cells["mauSac"].Value.ToString();
            txtTuoi.Text = dgvCayCanh.CurrentRow.Cells["tuoi"].Value.ToString();
            cbbLoaiCay.Text = dgvCayCanh.CurrentRow.Cells["tenLoaiCay"].Value.ToString();
            txtGiaBan.Text = dgvCayCanh.CurrentRow.Cells["gia"].Value.ToString();
            txtSoLuong.Text = dgvCayCanh.CurrentRow.Cells["soLuong"].Value.ToString();
            txtKichThuoc.Text = dgvCayCanh.CurrentRow.Cells["kichThuoc"].Value.ToString();
            // }

            btnSua.Enabled = true;
            btnReset.Enabled = true;
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int value = Common.GetMaxId(dtCayCanh, "idCayCanh") + 1;
            string idNumber = value < 10 ? "0" + value : value + "";
            string id = "cc_" + idNumber;
            InsertData(id);
        }

        private void InsertData(string id)
        {
            string sql; //Lưu lệnh sql
            if (txtTenCay.Text.Trim().Length == 0) //Nếu chưa nhập tên cây
            {
                MessageBox.Show("Bạn phải nhập tên cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCay.Focus();
                return;
            }
            if (cbbLoaiCay.Text.Trim().Length == 0) //Nếu chưa loại cây
            {
                MessageBox.Show("Bạn phải nhập tên loại cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbbLoaiCay.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim().Length == 0) //Nếu chưa loại cây
            {
                MessageBox.Show("Bạn phải nhập số lượng cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtGiaBan.Text.Trim().Length == 0) //Nếu chưa loại cây
            {
                MessageBox.Show("Bạn phải nhập giá bán cho cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return;
            }
            if (txtKichThuoc.Text.Trim().Length == 0) //Nếu chưa loại cây
            {
                MessageBox.Show("Bạn phải nhập giá bán cho cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return;
            }
            string idLoaiCay = GetIdLoaiCay(cbbLoaiCay.Text);
            /*if( CheckContainsName(txtTenLoaiCay.Text) )
            {
                MessageBox.Show("Tên loại cây đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiCay.Focus();
                return;
            }*/
            sql = "INSERT INTO CayCanh VALUES(N'" + id + "',N'" + txtTenCay.Text + "',N'" + idLoaiCay + "'," + txtSoLuong.Text + "," + txtGiaBan.Text + "," + txtTuoi.Text + ",N'" + txtMauSac.Text + "', N'" + currentFilePath + "',N'" + rtxtMota.Text + "',N'" + txtKichThuoc.Text + "')";
            Data.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnReset.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }

        private string GetIdLoaiCay(string tenLoaiCay)
        {
            string sql = "Select * from LoaiCay where tenLoaiCay like N'" + tenLoaiCay + "'";
            return Data.GetIdByProperties(sql, "idLoaiCay");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void UpdateData()
        {
            string sql; //Lưu câu lệnh sql
            if (dtCayCanh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCay.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE CayCanh SET tenCay=N'" + txtTenCay.Text.ToString() +
                  "', moTa = N'" + rtxtMota.Text +
                  "', idLoaiCay=N'" + GetIdLoaiCay(cbbLoaiCay.Text) +
                  "', gia = " + txtGiaBan.Text +
                  ", soLuong = " + txtSoLuong.Text +
                  ", tuoi = " + txtTuoi.Text +
                  ", mauSac = N'" + txtMauSac.Text +
                  "', kichThuoc = N'" + txtKichThuoc.Text +
                  "', anh = N'" + (isImageSelected ? currentFilePath : saveFilePath) +
                  "' Where idCayCanh = N'" + currentId + "'";
            Data.RunSQL(sql);
            isImageSelected = false;
            LoadDataGridView();
            ResetValue();
        }

        private void dgvCayCanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCayCanh.CurrentCell.ColumnIndex.Equals(11))
            {
                DeleteData();
            }

            if (dgvCayCanh.CurrentCell.ColumnIndex.Equals(12))
            {
                btnXoa.Visible = true;
                if (Convert.ToBoolean(dgvCayCanh.CurrentCell.EditedFormattedValue))
                {
                    ListIdSelecteds.Add(currentId);
                    txtSoLuongDaChon.Text = "Đã chọn: " + ListIdSelecteds.Count;
                }
                else
                {
                    ListIdSelecteds.Remove(currentId);
                    if (ListIdSelecteds.Count < 1)
                    {
                        btnXoa.Visible = false;
                    }
                    txtSoLuongDaChon.Text = "Đã chọn: " + ListIdSelecteds.Count;
                }
            }
        }

        private void DeleteData()
        {
            string sql;
            if (dtCayCanh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCay.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn xóa cây cảnh này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                sql = "DELETE CayCanh WHERE idCayCanh=N'" + currentId + "'";
                Data.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void DeleteMoreData()
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn xóa các cây cảnh này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                foreach (var id in ListIdSelecteds)
                {
                    string sql = "DELETE CayCanh WHERE idCayCanh=N'" + id + "'";
                    Data.RunSqlDel(sql);
                    ResetValue();
                }
                LoadDataGridView();
                btnXoa.Visible = false;
                ListIdSelecteds.Clear();
                txtSoLuongDaChon.Text = "Đã chọn: " + ListIdSelecteds.Count;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteMoreData();
        }

        private void FindObjectByIdOrName()
        {
            titleTable.Text = "Kết quả tìm kiếm: ";
            btnHuyTimKiem.Visible = true;
            string sql = "Select * from CayCanh where idCayCanh LIKE N'%" + txtTimkiem.Text + "%' or tenCay  LIKE N'%" + txtTimkiem.Text + "%'";
            dtCayCanhTimKiem = Data.GetDataToTable(sql);
            dgvCayCanh.DataSource = dtCayCanhTimKiem;
            BindingDataGridViewUI();
        }

        private void FindObjectByName()
        {
            titleTable.Text = "Kết quả tìm kiếm: ";
            btnHuyTimKiem.Visible = true;
            string sql = "Select * from CayCanh where CHARINDEX( N'" + txtTimkiem.Text + "', tenCay) > 0";
            dtCayCanhTimKiem = Data.GetDataToTable(sql);
            dgvCayCanh.DataSource = dtCayCanhTimKiem;
            LoadImage(dtCayCanhTimKiem);
            BindingDataGridViewUI();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FindObjectByName();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyTimKiem.Visible = false;
            LoadDataGridView();
            ResetValue();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           /* using (SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "BaoCao|*.xlsx",
                FileName = "CayCanh"
            })
            {
                saveFileDialog.InitialDirectory = REPORT_PATH;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dtCayCanh, "Danh sách cây cảnh");
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Tạo file excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }*/
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void dgvCayCanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            if (ListIdSelecteds.Count > 0)
            {
                DialogAddBill dialog = new DialogAddBill();
                this.Hide();
                dialog.IsFromFormCayCanh = true;
                dialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn cây cảnh nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXuatDSCayCanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBaoCao(0).Show();
        }
    }
}
