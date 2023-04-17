
using System.Drawing;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    partial class DialogAddBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnResetFormHoaDon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.idCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.btnClosePanelSP = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbTenCay = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelKhachHang = new System.Windows.Forms.Panel();
            this.txtTuoiKH = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbKhachHangCu = new System.Windows.Forms.RadioButton();
            this.rbKhachHangMoi = new System.Windows.Forms.RadioButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtIdNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panel12.SuspendLayout();
            this.panelKhachHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btnResetFormHoaDon);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnTaoHoaDon);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtGiamGia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 597);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(702, 61);
            this.panel3.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(473, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "(VND)";
            // 
            // btnResetFormHoaDon
            // 
            this.btnResetFormHoaDon.Image = global::BanHangCayCanh.Properties.Resources.refresh;
            this.btnResetFormHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFormHoaDon.Location = new System.Drawing.Point(172, 8);
            this.btnResetFormHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetFormHoaDon.MaximumSize = new System.Drawing.Size(89, 42);
            this.btnResetFormHoaDon.Name = "btnResetFormHoaDon";
            this.btnResetFormHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnResetFormHoaDon.Size = new System.Drawing.Size(89, 42);
            this.btnResetFormHoaDon.TabIndex = 27;
            this.btnResetFormHoaDon.Text = "Reset";
            this.btnResetFormHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetFormHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::BanHangCayCanh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.MaximumSize = new System.Drawing.Size(159, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Size = new System.Drawing.Size(159, 42);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Image = global::BanHangCayCanh.Properties.Resources.bill;
            this.btnTaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(529, 8);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHoaDon.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTaoHoaDon.Size = new System.Drawing.Size(145, 42);
            this.btnTaoHoaDon.TabIndex = 21;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTongTien.Location = new System.Drawing.Point(387, 34);
            this.txtTongTien.MinimumSize = new System.Drawing.Size(90, 16);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(90, 20);
            this.txtTongTien.TabIndex = 20;
            this.txtTongTien.Text = "1";
            this.txtTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(306, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tổng tiền:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Chiết khấu:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(387, 8);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(136, 22);
            this.txtGiamGia.TabIndex = 16;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panelKhachHang);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(702, 563);
            this.panel4.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dgvCTHD);
            this.panel13.Controls.Add(this.panelSanPham);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 169);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel13.Size = new System.Drawing.Size(702, 394);
            this.panel13.TabIndex = 26;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.AllowUserToResizeColumns = false;
            this.dgvCTHD.AllowUserToResizeRows = false;
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.ColumnHeadersHeight = 29;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCTHD,
            this.idCay,
            this.tenCay,
            this.soLuong,
            this.donGia,
            this.thanhTien,
            this.idHoaDon});
            this.dgvCTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCTHD.Location = new System.Drawing.Point(10, 8);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.ShowCellErrors = false;
            this.dgvCTHD.ShowCellToolTips = false;
            this.dgvCTHD.ShowEditingIcon = false;
            this.dgvCTHD.ShowRowErrors = false;
            this.dgvCTHD.Size = new System.Drawing.Size(682, 220);
            this.dgvCTHD.TabIndex = 8;
            // 
            // idCTHD
            // 
            this.idCTHD.HeaderText = "Mã CTHD";
            this.idCTHD.MinimumWidth = 6;
            this.idCTHD.Name = "idCTHD";
            this.idCTHD.ReadOnly = true;
            this.idCTHD.Width = 75;
            // 
            // idCay
            // 
            this.idCay.HeaderText = "Mã cây";
            this.idCay.MinimumWidth = 6;
            this.idCay.Name = "idCay";
            this.idCay.ReadOnly = true;
            this.idCay.Visible = false;
            this.idCay.Width = 125;
            // 
            // tenCay
            // 
            this.tenCay.HeaderText = "Tên cây";
            this.tenCay.MinimumWidth = 6;
            this.tenCay.Name = "tenCay";
            this.tenCay.ReadOnly = true;
            this.tenCay.Width = 125;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 105;
            // 
            // donGia
            // 
            this.donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // idHoaDon
            // 
            this.idHoaDon.HeaderText = "Mã Hóa Đơn";
            this.idHoaDon.MinimumWidth = 6;
            this.idHoaDon.Name = "idHoaDon";
            this.idHoaDon.ReadOnly = true;
            this.idHoaDon.Visible = false;
            this.idHoaDon.Width = 125;
            // 
            // panelSanPham
            // 
            this.panelSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSanPham.Controls.Add(this.btnClosePanelSP);
            this.panelSanPham.Controls.Add(this.txtThanhTien);
            this.panelSanPham.Controls.Add(this.label18);
            this.panelSanPham.Controls.Add(this.btnSuaSP);
            this.panelSanPham.Controls.Add(this.btnXoaSP);
            this.panelSanPham.Controls.Add(this.nudSoLuong);
            this.panelSanPham.Controls.Add(this.btnThemSP);
            this.panelSanPham.Controls.Add(this.txtGiaBan);
            this.panelSanPham.Controls.Add(this.label19);
            this.panelSanPham.Controls.Add(this.label20);
            this.panelSanPham.Controls.Add(this.label21);
            this.panelSanPham.Controls.Add(this.cbbTenCay);
            this.panelSanPham.Controls.Add(this.label22);
            this.panelSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSanPham.Location = new System.Drawing.Point(10, 228);
            this.panelSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(682, 158);
            this.panelSanPham.TabIndex = 7;
            this.panelSanPham.Visible = false;
            // 
            // btnClosePanelSP
            // 
            this.btnClosePanelSP.FlatAppearance.BorderSize = 0;
            this.btnClosePanelSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePanelSP.Image = global::BanHangCayCanh.Properties.Resources.clear2;
            this.btnClosePanelSP.Location = new System.Drawing.Point(632, 5);
            this.btnClosePanelSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClosePanelSP.Name = "btnClosePanelSP";
            this.btnClosePanelSP.Size = new System.Drawing.Size(20, 16);
            this.btnClosePanelSP.TabIndex = 23;
            this.btnClosePanelSP.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(458, 73);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(194, 22);
            this.txtThanhTien.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(348, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "Thành tiền:";
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Image = global::BanHangCayCanh.Properties.Resources.write;
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(458, 110);
            this.btnSuaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSuaSP.Size = new System.Drawing.Size(94, 37);
            this.btnSuaSP.TabIndex = 20;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Image = global::BanHangCayCanh.Properties.Resources.remove;
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(558, 110);
            this.btnXoaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoaSP.Size = new System.Drawing.Size(94, 37);
            this.btnXoaSP.TabIndex = 19;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(118, 73);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(199, 22);
            this.nudSoLuong.TabIndex = 18;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemSP
            // 
            this.btnThemSP.Image = global::BanHangCayCanh.Properties.Resources.add;
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(558, 110);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThemSP.Size = new System.Drawing.Size(94, 37);
            this.btnThemSP.TabIndex = 17;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(458, 35);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(194, 22);
            this.txtGiaBan.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(348, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "Giá bán:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(6, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(153, 20);
            this.label20.TabIndex = 0;
            this.label20.Text = "Thông tin sản phẩm:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "Số lượng:";
            // 
            // cbbTenCay
            // 
            this.cbbTenCay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenCay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenCay.FormattingEnabled = true;
            this.cbbTenCay.Location = new System.Drawing.Point(118, 35);
            this.cbbTenCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenCay.Name = "cbbTenCay";
            this.cbbTenCay.Size = new System.Drawing.Size(199, 24);
            this.cbbTenCay.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Tên cây:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label16);
            this.panel12.Controls.Add(this.label17);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 141);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(702, 28);
            this.panel12.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Image = global::BanHangCayCanh.Properties.Resources.bin;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(526, 6);
            this.label16.MinimumSize = new System.Drawing.Size(153, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 22);
            this.label16.TabIndex = 17;
            this.label16.Text = "Xóa mục đã chọn";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.UseMnemonic = false;
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(0, 6);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label17.Size = new System.Drawing.Size(158, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Danh sách sản phẩm";
            // 
            // panelKhachHang
            // 
            this.panelKhachHang.Controls.Add(this.txtTuoiKH);
            this.panelKhachHang.Controls.Add(this.txtTenKhachHang);
            this.panelKhachHang.Controls.Add(this.txtDiaChiKH);
            this.panelKhachHang.Controls.Add(this.label11);
            this.panelKhachHang.Controls.Add(this.txtSDT);
            this.panelKhachHang.Controls.Add(this.label5);
            this.panelKhachHang.Controls.Add(this.label3);
            this.panelKhachHang.Controls.Add(this.cbbKhachHang);
            this.panelKhachHang.Controls.Add(this.label4);
            this.panelKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKhachHang.Location = new System.Drawing.Point(0, 65);
            this.panelKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKhachHang.Name = "panelKhachHang";
            this.panelKhachHang.Size = new System.Drawing.Size(702, 76);
            this.panelKhachHang.TabIndex = 24;
            this.panelKhachHang.Visible = false;
            // 
            // txtTuoiKH
            // 
            this.txtTuoiKH.Location = new System.Drawing.Point(455, 7);
            this.txtTuoiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuoiKH.Name = "txtTuoiKH";
            this.txtTuoiKH.Size = new System.Drawing.Size(225, 22);
            this.txtTuoiKH.TabIndex = 17;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(131, 8);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(230, 22);
            this.txtTenKhachHang.TabIndex = 16;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(132, 42);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(230, 22);
            this.txtDiaChiKH.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 45);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(455, 42);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(225, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tuổi:";
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(132, 7);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(230, 24);
            this.cbbKhachHang.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 10);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.rbKhachHangCu);
            this.panel2.Controls.Add(this.rbKhachHangMoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(702, 28);
            this.panel2.TabIndex = 23;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbTrangThai);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(368, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(334, 28);
            this.panel5.TabIndex = 2;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đang giao",
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbTrangThai.Location = new System.Drawing.Point(87, 3);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(225, 24);
            this.cbbTrangThai.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Trạng thái:";
            // 
            // rbKhachHangCu
            // 
            this.rbKhachHangCu.AutoSize = true;
            this.rbKhachHangCu.Location = new System.Drawing.Point(175, 5);
            this.rbKhachHangCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbKhachHangCu.Name = "rbKhachHangCu";
            this.rbKhachHangCu.Size = new System.Drawing.Size(115, 20);
            this.rbKhachHangCu.TabIndex = 1;
            this.rbKhachHangCu.Text = "Khách hàng cũ";
            this.rbKhachHangCu.UseVisualStyleBackColor = true;
            // 
            // rbKhachHangMoi
            // 
            this.rbKhachHangMoi.AutoSize = true;
            this.rbKhachHangMoi.Location = new System.Drawing.Point(17, 4);
            this.rbKhachHangMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbKhachHangMoi.Name = "rbKhachHangMoi";
            this.rbKhachHangMoi.Size = new System.Drawing.Size(123, 20);
            this.rbKhachHangMoi.TabIndex = 0;
            this.rbKhachHangMoi.Text = "Khách hàng mới";
            this.rbKhachHangMoi.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtIdNhanVien);
            this.panel11.Controls.Add(this.dtpNgayLap);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(702, 37);
            this.panel11.TabIndex = 22;
            // 
            // txtIdNhanVien
            // 
            this.txtIdNhanVien.Enabled = false;
            this.txtIdNhanVien.Location = new System.Drawing.Point(132, 6);
            this.txtIdNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdNhanVien.Name = "txtIdNhanVien";
            this.txtIdNhanVien.Size = new System.Drawing.Size(230, 22);
            this.txtIdNhanVien.TabIndex = 16;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(455, 6);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(225, 22);
            this.dtpNgayLap.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ngày lập:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "Nhân viên:";
            // 
            // DialogAddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogAddBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo hóa đơn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panelSanPham.ResumeLayout(false);
            this.panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panelKhachHang.ResumeLayout(false);
            this.panelKhachHang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label txtTongTien;
        private Label label13;
        private Button btnTaoHoaDon;
        private Button btnThem;
        private Button btnResetFormHoaDon;
        private Label label14;
        private Label label12;
        private TextBox txtGiamGia;
        private Panel panel11;
        private DateTimePicker dtpNgayLap;
        private Label label2;
        private Label label15;
        private Panel panelKhachHang;
        private TextBox txtDiaChiKH;
        private Label label11;
        private TextBox txtSDT;
        private Label label3;
        private ComboBox cbbKhachHang;
        private Label label4;
        private Panel panel2;
        private Panel panel12;
        private Label label16;
        private Label label17;
        private Panel panel13;
        private DataGridView dgvCTHD;
        private Panel panelSanPham;
        private Button btnClosePanelSP;
        private TextBox txtThanhTien;
        private Label label18;
        private Button btnSuaSP;
        private Button btnXoaSP;
        private NumericUpDown nudSoLuong;
        private Button btnThemSP;
        private TextBox txtGiaBan;
        private Label label19;
        private Label label20;
        private Label label21;
        private ComboBox cbbTenCay;
        private Label label22;
        private RadioButton rbKhachHangCu;
        private RadioButton rbKhachHangMoi;
        private DataGridViewTextBoxColumn idCTHD;
        private DataGridViewTextBoxColumn idCay;
        private DataGridViewTextBoxColumn tenCay;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewTextBoxColumn idHoaDon;
        private TextBox txtTenKhachHang;
        private TextBox txtIdNhanVien;
        private TextBox txtTuoiKH;
        private Label label5;
        private Panel panel5;
        private ComboBox cbbTrangThai;
        private Label label6;
    }
}