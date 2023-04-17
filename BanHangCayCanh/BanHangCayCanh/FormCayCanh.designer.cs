using System.Drawing;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    partial class FormCayCanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCayCanh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCayCanh = new System.Windows.Forms.DataGridView();
            this.anh = new System.Windows.Forms.DataGridViewImageColumn();
            this.idCayCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCayCanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaicay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLoaiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kichThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pathAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSoLuongDaChon = new System.Windows.Forms.Label();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnXuatDSCayCanh = new System.Windows.Forms.Button();
            this.titleTable = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtKichThuoc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLoaiCay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtxtMota = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picCayCanh = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCayCanh)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCayCanh)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvCayCanh);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 6);
            this.panel1.Size = new System.Drawing.Size(1157, 913);
            this.panel1.TabIndex = 9;
            // 
            // dgvCayCanh
            // 
            this.dgvCayCanh.AllowUserToResizeColumns = false;
            this.dgvCayCanh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCayCanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCayCanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCayCanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCayCanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anh,
            this.idCayCanh,
            this.tenCayCanh,
            this.tenLoaicay,
            this.idLoaiCay,
            this.moTa,
            this.tuoi,
            this.mauSac,
            this.soLuong,
            this.gia,
            this.kichThuoc,
            this.delete,
            this.selected,
            this.pathAnh});
            this.dgvCayCanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCayCanh.EnableHeadersVisualStyles = false;
            this.dgvCayCanh.Location = new System.Drawing.Point(11, 10);
            this.dgvCayCanh.MultiSelect = false;
            this.dgvCayCanh.Name = "dgvCayCanh";
            this.dgvCayCanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCayCanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCayCanh.RowHeadersVisible = false;
            this.dgvCayCanh.RowHeadersWidth = 51;
            this.dgvCayCanh.RowTemplate.Height = 150;
            this.dgvCayCanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCayCanh.Size = new System.Drawing.Size(1135, 832);
            this.dgvCayCanh.TabIndex = 15;
            this.dgvCayCanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCayCanh_CellClick);
            this.dgvCayCanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCayCanh_CellContentClick);
            this.dgvCayCanh.Click += new System.EventHandler(this.dgvCayCanh_Click);
            // 
            // anh
            // 
            this.anh.HeaderText = "Ảnh";
            this.anh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.anh.MinimumWidth = 6;
            this.anh.Name = "anh";
            this.anh.Width = 125;
            // 
            // idCayCanh
            // 
            this.idCayCanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idCayCanh.DefaultCellStyle = dataGridViewCellStyle2;
            this.idCayCanh.HeaderText = "Mã cây cảnh";
            this.idCayCanh.MinimumWidth = 6;
            this.idCayCanh.Name = "idCayCanh";
            this.idCayCanh.ReadOnly = true;
            this.idCayCanh.Visible = false;
            this.idCayCanh.Width = 125;
            // 
            // tenCayCanh
            // 
            this.tenCayCanh.HeaderText = "Tên cây";
            this.tenCayCanh.MinimumWidth = 6;
            this.tenCayCanh.Name = "tenCayCanh";
            this.tenCayCanh.ReadOnly = true;
            this.tenCayCanh.Width = 125;
            // 
            // tenLoaicay
            // 
            this.tenLoaicay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaicay.HeaderText = "Loại Cây";
            this.tenLoaicay.MinimumWidth = 6;
            this.tenLoaicay.Name = "tenLoaicay";
            this.tenLoaicay.ReadOnly = true;
            // 
            // idLoaiCay
            // 
            this.idLoaiCay.HeaderText = "Mã Loại Cây";
            this.idLoaiCay.MinimumWidth = 6;
            this.idLoaiCay.Name = "idLoaiCay";
            this.idLoaiCay.Visible = false;
            this.idLoaiCay.Width = 125;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.moTa.DefaultCellStyle = dataGridViewCellStyle3;
            this.moTa.HeaderText = "Mô tả";
            this.moTa.MinimumWidth = 200;
            this.moTa.Name = "moTa";
            this.moTa.ReadOnly = true;
            // 
            // tuoi
            // 
            this.tuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.ReadOnly = true;
            this.tuoi.Width = 67;
            // 
            // mauSac
            // 
            this.mauSac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mauSac.HeaderText = "Màu sắc";
            this.mauSac.MinimumWidth = 6;
            this.mauSac.Name = "mauSac";
            this.mauSac.ReadOnly = true;
            this.mauSac.Width = 85;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 91;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gia.HeaderText = "Giá bán";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.ReadOnly = true;
            this.gia.Width = 83;
            // 
            // kichThuoc
            // 
            this.kichThuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.kichThuoc.HeaderText = "Kích thước";
            this.kichThuoc.MinimumWidth = 6;
            this.kichThuoc.Name = "kichThuoc";
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::BanHangCayCanh.Properties.Resources.remove;
            this.delete.MinimumWidth = 50;
            this.delete.Name = "delete";
            this.delete.Width = 50;
            // 
            // selected
            // 
            this.selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.selected.HeaderText = "";
            this.selected.MinimumWidth = 6;
            this.selected.Name = "selected";
            // 
            // pathAnh
            // 
            this.pathAnh.HeaderText = "";
            this.pathAnh.MinimumWidth = 6;
            this.pathAnh.Name = "pathAnh";
            this.pathAnh.Visible = false;
            this.pathAnh.Width = 125;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txtSoLuongDaChon);
            this.panel9.Controls.Add(this.btnTaoHoaDon);
            this.panel9.Controls.Add(this.btnXuatDSCayCanh);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(11, 842);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.panel9.Size = new System.Drawing.Size(1135, 65);
            this.panel9.TabIndex = 14;
            // 
            // txtSoLuongDaChon
            // 
            this.txtSoLuongDaChon.AutoSize = true;
            this.txtSoLuongDaChon.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSoLuongDaChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoLuongDaChon.Location = new System.Drawing.Point(868, 10);
            this.txtSoLuongDaChon.Margin = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.txtSoLuongDaChon.Name = "txtSoLuongDaChon";
            this.txtSoLuongDaChon.Padding = new System.Windows.Forms.Padding(0, 12, 20, 0);
            this.txtSoLuongDaChon.Size = new System.Drawing.Size(103, 32);
            this.txtSoLuongDaChon.TabIndex = 14;
            this.txtSoLuongDaChon.Text = "Đã chọn: 2";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaoHoaDon.Image = global::BanHangCayCanh.Properties.Resources.bill;
            this.btnTaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(971, 10);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHoaDon.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTaoHoaDon.Size = new System.Drawing.Size(149, 42);
            this.btnTaoHoaDon.TabIndex = 13;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnXuatDSCayCanh
            // 
            this.btnXuatDSCayCanh.Image = global::BanHangCayCanh.Properties.Resources.print;
            this.btnXuatDSCayCanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatDSCayCanh.Location = new System.Drawing.Point(14, 13);
            this.btnXuatDSCayCanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatDSCayCanh.Name = "btnXuatDSCayCanh";
            this.btnXuatDSCayCanh.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXuatDSCayCanh.Size = new System.Drawing.Size(160, 41);
            this.btnXuatDSCayCanh.TabIndex = 12;
            this.btnXuatDSCayCanh.Text = "Xuất danh sách";
            this.btnXuatDSCayCanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatDSCayCanh.UseVisualStyleBackColor = true;
            this.btnXuatDSCayCanh.Click += new System.EventHandler(this.btnXuatDSCayCanh_Click);
            // 
            // titleTable
            // 
            this.titleTable.AutoSize = true;
            this.titleTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleTable.Location = new System.Drawing.Point(11, 6);
            this.titleTable.Name = "titleTable";
            this.titleTable.Size = new System.Drawing.Size(199, 28);
            this.titleTable.TabIndex = 14;
            this.titleTable.Text = "Danh sách cây cảnh";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.titleTable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 49);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.panel6.Size = new System.Drawing.Size(1157, 41);
            this.panel6.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::BanHangCayCanh.Properties.Resources.bin;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(998, 6);
            this.btnXoa.MinimumSize = new System.Drawing.Size(153, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(153, 22);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa mục đã chọn";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseMnemonic = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 90);
            this.panel2.TabIndex = 7;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnHuyTimKiem);
            this.panel8.Controls.Add(this.btnTimKiem);
            this.panel8.Controls.Add(this.txtTimkiem);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 16, 6, 0);
            this.panel8.Size = new System.Drawing.Size(1157, 49);
            this.panel8.TabIndex = 17;
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyTimKiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHuyTimKiem.FlatAppearance.BorderSize = 0;
            this.btnHuyTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTimKiem.Image = global::BanHangCayCanh.Properties.Resources.clear2;
            this.btnHuyTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTimKiem.Location = new System.Drawing.Point(1008, 16);
            this.btnHuyTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyTimKiem.MaximumSize = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.MinimumSize = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHuyTimKiem.Size = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.TabIndex = 7;
            this.btnHuyTimKiem.Text = "Hủy tìm kiếm";
            this.btnHuyTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyTimKiem.UseVisualStyleBackColor = false;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(527, 17);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(117, 28);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.Location = new System.Drawing.Point(167, 18);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.MaximumSize = new System.Drawing.Size(331, 50);
            this.txtTimkiem.MinimumSize = new System.Drawing.Size(331, 33);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(331, 27);
            this.txtTimkiem.TabIndex = 5;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nội dung tìm kiếm:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtKichThuoc);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnChangeImage);
            this.panel4.Controls.Add(this.txtSoLuong);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtGiaBan);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtTuoi);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtMauSac);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cbbLoaiCay);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTenCay);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.picCayCanh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 991);
            this.panel4.TabIndex = 0;
            // 
            // txtKichThuoc
            // 
            this.txtKichThuoc.Location = new System.Drawing.Point(342, 512);
            this.txtKichThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKichThuoc.Name = "txtKichThuoc";
            this.txtKichThuoc.Size = new System.Drawing.Size(60, 22);
            this.txtKichThuoc.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 514);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Size:";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.Image = global::BanHangCayCanh.Properties.Resources.circular;
            this.btnChangeImage.Location = new System.Drawing.Point(350, 214);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(23, 22, 23, 22);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnChangeImage.Size = new System.Drawing.Size(43, 34);
            this.btnChangeImage.TabIndex = 26;
            this.btnChangeImage.UseVisualStyleBackColor = true;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(305, 340);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(97, 22);
            this.txtSoLuong.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "SL:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(112, 558);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(289, 22);
            this.txtGiaBan.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Giá bán:";
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(247, 512);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(33, 22);
            this.txtTuoi.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 514);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tuổi:";
            // 
            // txtMauSac
            // 
            this.txtMauSac.Location = new System.Drawing.Point(112, 512);
            this.txtMauSac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(61, 22);
            this.txtMauSac.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Màu sắc:";
            // 
            // cbbLoaiCay
            // 
            this.cbbLoaiCay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiCay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiCay.FormattingEnabled = true;
            this.cbbLoaiCay.Location = new System.Drawing.Point(112, 340);
            this.cbbLoaiCay.Name = "cbbLoaiCay";
            this.cbbLoaiCay.Size = new System.Drawing.Size(154, 24);
            this.cbbLoaiCay.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Loại cây:";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.rtxtMota);
            this.panel7.Location = new System.Drawing.Point(112, 385);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(290, 102);
            this.panel7.TabIndex = 13;
            // 
            // rtxtMota
            // 
            this.rtxtMota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMota.Location = new System.Drawing.Point(-1, 1);
            this.rtxtMota.Name = "rtxtMota";
            this.rtxtMota.Size = new System.Drawing.Size(290, 100);
            this.rtxtMota.TabIndex = 8;
            this.rtxtMota.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thông tin cây cảnh:";
            // 
            // txtTenCay
            // 
            this.txtTenCay.Location = new System.Drawing.Point(112, 297);
            this.txtTenCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCay.Name = "txtTenCay";
            this.txtTenCay.Size = new System.Drawing.Size(290, 22);
            this.txtTenCay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên cây cảnh:";
            // 
            // picCayCanh
            // 
            this.picCayCanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCayCanh.BackgroundImage = global::BanHangCayCanh.Properties.Resources._default;
            this.picCayCanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCayCanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCayCanh.Location = new System.Drawing.Point(10, 55);
            this.picCayCanh.MaximumSize = new System.Drawing.Size(392, 202);
            this.picCayCanh.MinimumSize = new System.Drawing.Size(392, 202);
            this.picCayCanh.Name = "picCayCanh";
            this.picCayCanh.Size = new System.Drawing.Size(392, 202);
            this.picCayCanh.TabIndex = 14;
            this.picCayCanh.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1157, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(423, 1003);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(6, 932);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(411, 65);
            this.panel5.TabIndex = 13;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BanHangCayCanh.Properties.Resources.write;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(161, 13);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSua.Size = new System.Drawing.Size(101, 41);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::BanHangCayCanh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 13);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Size = new System.Drawing.Size(101, 41);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::BanHangCayCanh.Properties.Resources.circular;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(304, 13);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnReset.Size = new System.Drawing.Size(101, 41);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BanHangCayCanh.Properties.Resources.remove;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // FormCayCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1003);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCayCanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cây cảnh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCayCanh_FormClosed);
            this.Load += new System.EventHandler(this.FormCayCanh_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCayCanh)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCayCanh)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label btnXoa;
        private Label titleTable;
        private Panel panel6;
        private Panel panel2;
        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox picCayCanh;
        private Label label9;
        private TextBox txtGiaBan;
        private Label label8;
        private Label label7;
        private TextBox txtMauSac;
        private Label label6;
        private ComboBox cbbLoaiCay;
        private Label label5;
        private Panel panel7;
        private RichTextBox rtxtMota;
        private Label label2;
        private TextBox txtTenCay;
        private Label label4;
        private Label label3;
        private Button btnChangeImage;
        private OpenFileDialog ofd;
        private TextBox txtKichThuoc;
        private Label label10;
        private DataGridView dgvCayCanh;
        private Panel panel9;
        private Button btnTaoHoaDon;
        private Button btnXuatDSCayCanh;
        private Panel panel5;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
        private Label txtSoLuongDaChon;
        private DataGridViewImageColumn anh;
        private DataGridViewTextBoxColumn idCayCanh;
        private DataGridViewTextBoxColumn tenCayCanh;
        private DataGridViewTextBoxColumn tenLoaicay;
        private DataGridViewTextBoxColumn idLoaiCay;
        private DataGridViewTextBoxColumn moTa;
        private DataGridViewTextBoxColumn tuoi;
        private DataGridViewTextBoxColumn mauSac;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn kichThuoc;
        private DataGridViewImageColumn delete;
        private DataGridViewCheckBoxColumn selected;
        private DataGridViewTextBoxColumn pathAnh;
        private TextBox txtSoLuong;
        private TextBox txtTuoi;
        private DataGridViewImageColumn dataGridViewImageColumn1;
    }
}