using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormLoaiCayCanh : Form
    {
        public DataTable dtLoaiCayCanh;
        private string currentId;
        private List<string> listIdSelecteds = new List<string>();
        private DataTable dtLoaiCayCanhTimKiem;

        public FormLoaiCayCanh()
        {
            InitializeComponent();
        }

        private void FormLoaiCayCanh_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM LoaiCay";
            titleTable.Text = "Danh sách loại cây cảnh";
            btnHuyTimKiem.Visible = false;
            ResetValue();
            dgvLoaiCayCanh.AutoGenerateColumns = false;
            dtLoaiCayCanh = Data.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvLoaiCayCanh.DataSource = dtLoaiCayCanh; //Nguồn dữ liệu
            BindingDataGridViewUI();
        }

        private void BindingDataGridViewUI()
        {
            dgvLoaiCayCanh.Columns["idLoaiCay"].DataPropertyName = "idLoaiCay";//Binding dữ liệu vào các cột
            dgvLoaiCayCanh.Columns["tenLoaiCay"].DataPropertyName = "tenLoaiCay";//Binding dữ liệu vào các cột
            dgvLoaiCayCanh.Columns["moTa"].DataPropertyName = "moTa";//Binding dữ liệu vào các cột
            dgvLoaiCayCanh.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvLoaiCayCanh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLoaiCayCanh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLoaiCayCanh.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoaiCayCanh.Columns[0].ReadOnly = true;
            dgvLoaiCayCanh.Columns[1].ReadOnly = true;
            dgvLoaiCayCanh.Columns[2].ReadOnly = true;
        }

        private void dgvLoaiCayCanh_Click(object sender, EventArgs e)
        {
            if (dtLoaiCayCanh.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /* if (txtTenLoaiCay.Text != "")
             {
                 DialogResult r = MessageBox.Show("Bạn đang ở chế độ thêm mới hoặc chỉnh sửa. Bạn có muốn hủy dữ liệu vừa nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (r.Equals(DialogResult.Yes))
                 {
                   
                     txtTenLoaiCay.Text = dgvLoaiCayCanh.CurrentRow.Cells["tenLoaiCay"].Value.ToString();
                     rtxtMota.Text = dgvLoaiCayCanh.CurrentRow.Cells["moTa"].Value.ToString();
                 }
                 return;
             }
             else
             {*/
            currentId = dgvLoaiCayCanh.CurrentRow.Cells["idLoaiCay"].Value.ToString();
            txtTenLoaiCay.Text = dgvLoaiCayCanh.CurrentRow.Cells["tenLoaiCay"].Value.ToString();
            rtxtMota.Text = dgvLoaiCayCanh.CurrentRow.Cells["moTa"].Value.ToString();
            // }
            btnSua.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int value = GetMaxId() + 1; //CheckEmptyId();
            string idNumber = value < 10 ? "0" + value : value + "";
            string id = "lc_" + idNumber;
            InsertData(id);
        }

        private void InsertData(string id)
        {
            string sql; //Lưu lệnh sql
            if (txtTenLoaiCay.Text.Trim().Length == 0) //Nếu chưa nhập tên loại cây
            {
                MessageBox.Show("Bạn phải nhập tên loại cây", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiCay.Focus();
                return;
            }
            /*if( CheckContainsName(txtTenLoaiCay.Text) )
            {
                MessageBox.Show("Tên loại cây đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiCay.Focus();
                return;
            }*/
            sql = "INSERT INTO LoaiCay VALUES(N'" + id + "',N'" + txtTenLoaiCay.Text + "',N'" + rtxtMota.Text + "')";
            Data.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnReset.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }

        private bool CheckContainsName(string text)
        {
            bool r = false;
            for (int i = 0; i < dgvLoaiCayCanh.Rows.Count; i++)
            {
                if (text.Equals(dtLoaiCayCanh.Rows[i][1].ToString()))
                {
                    r = true;
                    break;
                }
            }
            return r;
        }

        private void UpdateData()
        {
            string sql; //Lưu câu lệnh sql
            if (dtLoaiCayCanh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiCay.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE LoaiCay SET tenLoaiCay=N'" +
                txtTenLoaiCay.Text.ToString() +
                "', moTa = N'" + rtxtMota.Text + "' WHERE idLoaiCay=N'" + currentId + "'";
            Data.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
        }

        private void ResetValue()
        {
            txtTenLoaiCay.Text = "";
            txtTimkiem.Text = "";
            rtxtMota.Text = "";
        }

        private int GetMaxId()
        {
            int maxId = GetNumberOfId(dtLoaiCayCanh.Rows[0][0].ToString());
            for (int i = 1; i < dtLoaiCayCanh.Rows.Count; i++)
            {
                int value = GetNumberOfId(dtLoaiCayCanh.Rows[i][0].ToString());
                if (value > maxId)
                {
                    maxId = value;
                }
            }
            return maxId;
        }

        int GetNumberOfId(string strId)
        {
            return int.Parse(strId.Split('_')[1]);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteMoreData();
        }

        private void DeleteMoreData()
        {
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn xóa các loại cây cảnh này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                foreach (var id in listIdSelecteds)
                {
                    string sql = "DELETE LoaiCay WHERE idLoaiCay=N'" + id + "'";
                    Data.RunSqlDel(sql);
                    ResetValue();
                }
                LoadDataGridView();
                btnXoa.Visible = false;
                listIdSelecteds.Clear();
            }
        }

        private void dgvLoaiCayCanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLoaiCayCanh.CurrentCell.ColumnIndex.Equals(4))
            {
                DeleteData();
            }

            if (dgvLoaiCayCanh.CurrentCell.ColumnIndex.Equals(3))
            {
                btnXoa.Visible = true;
                if (Convert.ToBoolean(dgvLoaiCayCanh.CurrentCell.EditedFormattedValue))
                {
                    listIdSelecteds.Add(currentId);
                }
                else
                {
                    listIdSelecteds.Remove(currentId);
                    if (listIdSelecteds.Count < 1)
                    {
                        btnXoa.Visible = false;
                    }
                }
            }
        }

        private void DeleteData()
        {
            string sql;
            if (dtLoaiCayCanh.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenLoaiCay.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult r = MessageBox.Show("Bạn có thật sự muốn xóa loại cây cảnh này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.OK)
            {
                sql = "DELETE LoaiCay WHERE idLoaiCay=N'" + currentId + "'";
                Data.RunSqlDel(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private int CheckEmptyId()
        {
            int number = 0;
            for (int i = 0; i < dtLoaiCayCanh.Rows.Count; i++)
            {
                if (i != GetNumberOfId(dtLoaiCayCanh.Rows[i][0].ToString()))
                {
                    number = i; break;
                }
            }
            return number == 0 ? GetMaxId() + 1 : number;
        }

        private void FindObjectByIdOrName()
        {
            titleTable.Text = "Kết quả tìm kiếm: ";
            btnHuyTimKiem.Visible = true;
            string sql = "Select * from LoaiCay where idLoaiCay LIKE N'%" + txtTimkiem.Text + "%' or tenLoaiCay  LIKE N'%" + txtTimkiem.Text + "%'";
            dtLoaiCayCanhTimKiem = Data.GetDataToTable(sql);
            dgvLoaiCayCanh.DataSource = dtLoaiCayCanhTimKiem;
            BindingDataGridViewUI();
        }

        private void FindObjectByName()
        {
            titleTable.Text = "Kết quả tìm kiếm: ";
            btnHuyTimKiem.Visible = true;
            string sql = "Select * from LoaiCay where CHARINDEX( N'" + txtTimkiem.Text + "', tenLoaiCay) > 0";
            dtLoaiCayCanhTimKiem = Data.GetDataToTable(sql);
            dgvLoaiCayCanh.DataSource = dtLoaiCayCanhTimKiem;
            BindingDataGridViewUI();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimkiem.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //FindObjectByIdOrName();
            FindObjectByName();
        }

        private void btnHuyTimKiem_Click(object sender, EventArgs e)
        {
            btnHuyTimKiem.Visible = false;
            LoadDataGridView();
            ResetValue();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            /*  string sql = "Select * from LoaiCay where idLoaiCay LIKE N'%" + txtTimkiem.Text + "%' or tenLoaiCay  LIKE N'%" + txtTimkiem.Text + "%'";
              dtLoaiCayCanhTimKiem = Data.GetDataToTable(sql);
              dgvLoaiCayCanh.DataSource = dtLoaiCayCanhTimKiem;
              BindingDataGridViewUI();*/
        }

        private void FormLoaiCayCanh_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void btnXuatDSLoaiCayCanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBaoCao(4).Show();
        }
    }
}
