using System.Drawing;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    partial class FormBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.panelThongTinHoaDon = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSupport5 = new System.Windows.Forms.Panel();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.idCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSanPham = new System.Windows.Forms.Panel();
            this.picAnhCayCanh = new System.Windows.Forms.PictureBox();
            this.btnClosePanelSP = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbbTenCay = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panelSupport4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelSupport3 = new System.Windows.Forms.Panel();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTuoiKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panelSupport2 = new System.Windows.Forms.Panel();
            this.rbKhachHangCu = new System.Windows.Forms.RadioButton();
            this.rbKhachHangMoi = new System.Windows.Forms.RadioButton();
            this.panelSupport1 = new System.Windows.Forms.Panel();
            this.cbbIdNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbIDHoaDon = new System.Windows.Forms.Label();
            this.panelSupport = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtGiaCay = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDatLaiDon = new System.Windows.Forms.Button();
            this.btnResetFormHoaDon = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.idHoaDonAll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chietKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnXuatDSHoaDon = new System.Windows.Forms.Button();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.titleTable = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThongTinHoaDon.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelSupport5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCayCanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.panelSupport4.SuspendLayout();
            this.panelSupport3.SuspendLayout();
            this.panelSupport2.SuspendLayout();
            this.panelSupport1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelSupport.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelThongTinHoaDon
            // 
            this.panelThongTinHoaDon.Controls.Add(this.panel4);
            this.panelThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelThongTinHoaDon.Location = new System.Drawing.Point(877, 0);
            this.panelThongTinHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongTinHoaDon.Name = "panelThongTinHoaDon";
            this.panelThongTinHoaDon.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelThongTinHoaDon.Size = new System.Drawing.Size(703, 1003);
            this.panelThongTinHoaDon.TabIndex = 1;
            this.panelThongTinHoaDon.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(683, 987);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panelSupport5);
            this.panel3.Controls.Add(this.panelSupport4);
            this.panel3.Controls.Add(this.panelSupport3);
            this.panel3.Controls.Add(this.panelSupport2);
            this.panel3.Controls.Add(this.panelSupport1);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panelSupport);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 987);
            this.panel3.TabIndex = 0;
            // 
            // panelSupport5
            // 
            this.panelSupport5.Controls.Add(this.dgvCTHD);
            this.panelSupport5.Controls.Add(this.panelSanPham);
            this.panelSupport5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupport5.Location = new System.Drawing.Point(0, 203);
            this.panelSupport5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupport5.Name = "panelSupport5";
            this.panelSupport5.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panelSupport5.Size = new System.Drawing.Size(681, 630);
            this.panelSupport5.TabIndex = 35;
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
            this.idHoaDon,
            this.anhCay});
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
            this.dgvCTHD.Size = new System.Drawing.Size(661, 456);
            this.dgvCTHD.TabIndex = 8;
            this.dgvCTHD.Click += new System.EventHandler(this.dgvCTHD_Click);
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
            // anhCay
            // 
            this.anhCay.HeaderText = "Ảnh";
            this.anhCay.MinimumWidth = 6;
            this.anhCay.Name = "anhCay";
            this.anhCay.Visible = false;
            this.anhCay.Width = 125;
            // 
            // panelSanPham
            // 
            this.panelSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSanPham.Controls.Add(this.picAnhCayCanh);
            this.panelSanPham.Controls.Add(this.btnClosePanelSP);
            this.panelSanPham.Controls.Add(this.txtThanhTien);
            this.panelSanPham.Controls.Add(this.label18);
            this.panelSanPham.Controls.Add(this.btnSuaSP);
            this.panelSanPham.Controls.Add(this.btnXoaSP);
            this.panelSanPham.Controls.Add(this.nudSoLuong);
            this.panelSanPham.Controls.Add(this.btnThemSP);
            this.panelSanPham.Controls.Add(this.txtGiaBan);
            this.panelSanPham.Controls.Add(this.label4);
            this.panelSanPham.Controls.Add(this.label5);
            this.panelSanPham.Controls.Add(this.label21);
            this.panelSanPham.Controls.Add(this.cbbTenCay);
            this.panelSanPham.Controls.Add(this.label22);
            this.panelSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSanPham.Location = new System.Drawing.Point(10, 464);
            this.panelSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Size = new System.Drawing.Size(661, 158);
            this.panelSanPham.TabIndex = 7;
            this.panelSanPham.Visible = false;
            // 
            // picAnhCayCanh
            // 
            this.picAnhCayCanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnhCayCanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhCayCanh.Location = new System.Drawing.Point(17, 33);
            this.picAnhCayCanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAnhCayCanh.Name = "picAnhCayCanh";
            this.picAnhCayCanh.Size = new System.Drawing.Size(130, 115);
            this.picAnhCayCanh.TabIndex = 24;
            this.picAnhCayCanh.TabStop = false;
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
            this.btnClosePanelSP.Click += new System.EventHandler(this.btnClosePanelSP_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(537, 73);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(115, 22);
            this.txtThanhTien.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(454, 74);
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
            this.btnSuaSP.Click += new System.EventHandler(this.btnSuaSP_Click);
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
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(252, 73);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(185, 22);
            this.nudSoLuong.TabIndex = 18;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
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
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Enabled = false;
            this.txtGiaBan.Location = new System.Drawing.Point(537, 35);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(115, 22);
            this.txtGiaBan.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thông tin sản phẩm:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(169, 75);
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
            this.cbbTenCay.Location = new System.Drawing.Point(252, 35);
            this.cbbTenCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenCay.Name = "cbbTenCay";
            this.cbbTenCay.Size = new System.Drawing.Size(183, 24);
            this.cbbTenCay.TabIndex = 12;
            this.cbbTenCay.SelectedIndexChanged += new System.EventHandler(this.cbbTenCay_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(169, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(59, 16);
            this.label22.TabIndex = 11;
            this.label22.Text = "Tên cây:";
            // 
            // panelSupport4
            // 
            this.panelSupport4.Controls.Add(this.label7);
            this.panelSupport4.Controls.Add(this.label17);
            this.panelSupport4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupport4.Location = new System.Drawing.Point(0, 175);
            this.panelSupport4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupport4.Name = "panelSupport4";
            this.panelSupport4.Size = new System.Drawing.Size(681, 28);
            this.panelSupport4.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Image = global::BanHangCayCanh.Properties.Resources.bin;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(526, 6);
            this.label7.MinimumSize = new System.Drawing.Size(153, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Xóa mục đã chọn";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.UseMnemonic = false;
            this.label7.Visible = false;
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
            // panelSupport3
            // 
            this.panelSupport3.Controls.Add(this.txtTenKhachHang);
            this.panelSupport3.Controls.Add(this.cbbKhachHang);
            this.panelSupport3.Controls.Add(this.txtTuoiKH);
            this.panelSupport3.Controls.Add(this.txtDiaChiKH);
            this.panelSupport3.Controls.Add(this.label11);
            this.panelSupport3.Controls.Add(this.txtSDT);
            this.panelSupport3.Controls.Add(this.label9);
            this.panelSupport3.Controls.Add(this.label10);
            this.panelSupport3.Controls.Add(this.label12);
            this.panelSupport3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupport3.Location = new System.Drawing.Point(0, 99);
            this.panelSupport3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupport3.Name = "panelSupport3";
            this.panelSupport3.Size = new System.Drawing.Size(681, 76);
            this.panelSupport3.TabIndex = 33;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(132, 9);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(230, 22);
            this.txtTenKhachHang.TabIndex = 19;
            this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbKhachHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(132, 8);
            this.cbbKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(230, 24);
            this.cbbKhachHang.TabIndex = 18;
            this.cbbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbbKhachHang_SelectedIndexChanged);
            // 
            // txtTuoiKH
            // 
            this.txtTuoiKH.Location = new System.Drawing.Point(455, 7);
            this.txtTuoiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuoiKH.Name = "txtTuoiKH";
            this.txtTuoiKH.Size = new System.Drawing.Size(214, 22);
            this.txtTuoiKH.TabIndex = 17;
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
            this.txtSDT.Size = new System.Drawing.Size(216, 22);
            this.txtSDT.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "SĐT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tuổi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tên khách hàng:";
            // 
            // panelSupport2
            // 
            this.panelSupport2.Controls.Add(this.rbKhachHangCu);
            this.panelSupport2.Controls.Add(this.rbKhachHangMoi);
            this.panelSupport2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupport2.Location = new System.Drawing.Point(0, 71);
            this.panelSupport2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupport2.Name = "panelSupport2";
            this.panelSupport2.Size = new System.Drawing.Size(681, 28);
            this.panelSupport2.TabIndex = 24;
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
            this.rbKhachHangCu.CheckedChanged += new System.EventHandler(this.rbKhachHangCu_CheckedChanged);
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
            this.rbKhachHangMoi.CheckedChanged += new System.EventHandler(this.rbKhachHangMoi_CheckedChanged);
            // 
            // panelSupport1
            // 
            this.panelSupport1.Controls.Add(this.cbbIdNhanVien);
            this.panelSupport1.Controls.Add(this.dtpNgayLap);
            this.panelSupport1.Controls.Add(this.label3);
            this.panelSupport1.Controls.Add(this.label15);
            this.panelSupport1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSupport1.Location = new System.Drawing.Point(0, 34);
            this.panelSupport1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSupport1.Name = "panelSupport1";
            this.panelSupport1.Size = new System.Drawing.Size(681, 37);
            this.panelSupport1.TabIndex = 23;
            // 
            // cbbIdNhanVien
            // 
            this.cbbIdNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbIdNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbIdNhanVien.FormattingEnabled = true;
            this.cbbIdNhanVien.Location = new System.Drawing.Point(132, 5);
            this.cbbIdNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbIdNhanVien.Name = "cbbIdNhanVien";
            this.cbbIdNhanVien.Size = new System.Drawing.Size(230, 24);
            this.cbbIdNhanVien.TabIndex = 19;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(455, 6);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(214, 22);
            this.dtpNgayLap.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày lập:";
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
            // panel7
            // 
            this.panel7.Controls.Add(this.lbIDHoaDon);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(5);
            this.panel7.Size = new System.Drawing.Size(681, 34);
            this.panel7.TabIndex = 6;
            // 
            // lbIDHoaDon
            // 
            this.lbIDHoaDon.AutoSize = true;
            this.lbIDHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbIDHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbIDHoaDon.Location = new System.Drawing.Point(5, 5);
            this.lbIDHoaDon.Name = "lbIDHoaDon";
            this.lbIDHoaDon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbIDHoaDon.Size = new System.Drawing.Size(143, 20);
            this.lbIDHoaDon.TabIndex = 0;
            this.lbIDHoaDon.Text = "Thông tin hóa đơn";
            // 
            // panelSupport
            // 
            this.panelSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupport.Controls.Add(this.panel15);
            this.panelSupport.Controls.Add(this.label16);
            this.panelSupport.Controls.Add(this.btnThem);
            this.panelSupport.Controls.Add(this.label20);
            this.panelSupport.Controls.Add(this.txtGiamGia);
            this.panelSupport.Controls.Add(this.panel12);
            this.panelSupport.Controls.Add(this.txtGiaCay);
            this.panelSupport.Controls.Add(this.label19);
            this.panelSupport.Controls.Add(this.txtTongTien);
            this.panelSupport.Controls.Add(this.label13);
            this.panelSupport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSupport.Location = new System.Drawing.Point(0, 833);
            this.panelSupport.Margin = new System.Windows.Forms.Padding(0);
            this.panelSupport.Name = "panelSupport";
            this.panelSupport.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelSupport.Size = new System.Drawing.Size(681, 96);
            this.panelSupport.TabIndex = 5;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.cbbTrangThai);
            this.panel15.Controls.Add(this.label6);
            this.panel15.Location = new System.Drawing.Point(175, 11);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(270, 28);
            this.panel15.TabIndex = 36;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đang giao",
            "Đã thanh toán",
            "Đã hủy"});
            this.cbbTrangThai.Location = new System.Drawing.Point(87, 3);
            this.cbbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(183, 24);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(632, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "(VND)";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::BanHangCayCanh.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(10, 10);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.MaximumSize = new System.Drawing.Size(159, 42);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThem.Size = new System.Drawing.Size(159, 42);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm sản phẩm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(455, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 16);
            this.label20.TabIndex = 31;
            this.label20.Text = "Chiết khấu:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(543, 34);
            this.txtGiamGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(125, 22);
            this.txtGiamGia.TabIndex = 32;
            this.txtGiamGia.Text = "0";
            this.txtGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel12.Location = new System.Drawing.Point(459, 61);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 1);
            this.panel12.TabIndex = 30;
            // 
            // txtGiaCay
            // 
            this.txtGiaCay.AutoSize = true;
            this.txtGiaCay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.txtGiaCay.Location = new System.Drawing.Point(587, 11);
            this.txtGiaCay.MaximumSize = new System.Drawing.Size(81, 16);
            this.txtGiaCay.MinimumSize = new System.Drawing.Size(81, 16);
            this.txtGiaCay.Name = "txtGiaCay";
            this.txtGiaCay.Size = new System.Drawing.Size(81, 16);
            this.txtGiaCay.TabIndex = 29;
            this.txtGiaCay.Text = "0";
            this.txtGiaCay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(455, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 20);
            this.label19.TabIndex = 28;
            this.label19.Text = "Giá cây:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTongTien.Location = new System.Drawing.Point(543, 67);
            this.txtTongTien.MaximumSize = new System.Drawing.Size(90, 16);
            this.txtTongTien.MinimumSize = new System.Drawing.Size(90, 16);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(90, 16);
            this.txtTongTien.TabIndex = 20;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(455, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Tổng tiền:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnDatLaiDon);
            this.panel5.Controls.Add(this.btnResetFormHoaDon);
            this.panel5.Controls.Add(this.btnInHD);
            this.panel5.Controls.Add(this.btnCapNhat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 929);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(681, 56);
            this.panel5.TabIndex = 0;
            // 
            // btnDatLaiDon
            // 
            this.btnDatLaiDon.Image = global::BanHangCayCanh.Properties.Resources.rotating_arrow;
            this.btnDatLaiDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLaiDon.Location = new System.Drawing.Point(10, 6);
            this.btnDatLaiDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDatLaiDon.MaximumSize = new System.Drawing.Size(159, 42);
            this.btnDatLaiDon.Name = "btnDatLaiDon";
            this.btnDatLaiDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDatLaiDon.Size = new System.Drawing.Size(159, 42);
            this.btnDatLaiDon.TabIndex = 26;
            this.btnDatLaiDon.Text = "Tạo đơn đặt lại";
            this.btnDatLaiDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatLaiDon.UseVisualStyleBackColor = true;
            this.btnDatLaiDon.Click += new System.EventHandler(this.btnDatLaiDon_Click);
            // 
            // btnResetFormHoaDon
            // 
            this.btnResetFormHoaDon.Image = global::BanHangCayCanh.Properties.Resources.refresh;
            this.btnResetFormHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetFormHoaDon.Location = new System.Drawing.Point(354, 6);
            this.btnResetFormHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetFormHoaDon.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnResetFormHoaDon.Name = "btnResetFormHoaDon";
            this.btnResetFormHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnResetFormHoaDon.Size = new System.Drawing.Size(149, 42);
            this.btnResetFormHoaDon.TabIndex = 25;
            this.btnResetFormHoaDon.Text = "Reset";
            this.btnResetFormHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetFormHoaDon.UseVisualStyleBackColor = true;
            this.btnResetFormHoaDon.Click += new System.EventHandler(this.btnResetFormHoaDon_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Image = global::BanHangCayCanh.Properties.Resources.bill;
            this.btnInHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHD.Location = new System.Drawing.Point(521, 6);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHD.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnInHD.Size = new System.Drawing.Size(149, 42);
            this.btnInHD.TabIndex = 24;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::BanHangCayCanh.Properties.Resources.write;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(187, 6);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(149, 42);
            this.btnCapNhat.TabIndex = 23;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.panel1.Size = new System.Drawing.Size(877, 1003);
            this.panel1.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvHoaDon);
            this.panel8.Controls.Add(this.panel14);
            this.panel8.Controls.Add(this.panel13);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 88);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(857, 907);
            this.panel8.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeColumns = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.ColumnHeadersHeight = 29;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHoaDonAll,
            this.idNhanVien,
            this.idKhachHang,
            this.ngayLap,
            this.chietKhau,
            this.tongTien,
            this.trangThai});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 52);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 29;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.ShowCellErrors = false;
            this.dgvHoaDon.ShowCellToolTips = false;
            this.dgvHoaDon.ShowEditingIcon = false;
            this.dgvHoaDon.ShowRowErrors = false;
            this.dgvHoaDon.Size = new System.Drawing.Size(857, 799);
            this.dgvHoaDon.TabIndex = 21;
            this.dgvHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvHoaDon_CellFormatting);
            this.dgvHoaDon.Click += new System.EventHandler(this.dgvHoaDon_Click);
            // 
            // idHoaDonAll
            // 
            this.idHoaDonAll.HeaderText = "Mã hóa đơn";
            this.idHoaDonAll.MinimumWidth = 6;
            this.idHoaDonAll.Name = "idHoaDonAll";
            this.idHoaDonAll.ReadOnly = true;
            this.idHoaDonAll.Width = 125;
            // 
            // idNhanVien
            // 
            this.idNhanVien.HeaderText = "Mã nhân viên";
            this.idNhanVien.MinimumWidth = 6;
            this.idNhanVien.Name = "idNhanVien";
            this.idNhanVien.ReadOnly = true;
            this.idNhanVien.Width = 125;
            // 
            // idKhachHang
            // 
            this.idKhachHang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idKhachHang.HeaderText = "Mã khách hàng";
            this.idKhachHang.MinimumWidth = 6;
            this.idKhachHang.Name = "idKhachHang";
            this.idKhachHang.ReadOnly = true;
            this.idKhachHang.Width = 138;
            // 
            // ngayLap
            // 
            this.ngayLap.HeaderText = "Ngày lập";
            this.ngayLap.MinimumWidth = 6;
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.ReadOnly = true;
            this.ngayLap.Width = 125;
            // 
            // chietKhau
            // 
            this.chietKhau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chietKhau.HeaderText = "Chiết khấu";
            this.chietKhau.MinimumWidth = 6;
            this.chietKhau.Name = "chietKhau";
            this.chietKhau.ReadOnly = true;
            // 
            // tongTien
            // 
            this.tongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.MinimumWidth = 6;
            this.trangThai.Name = "trangThai";
            // 
            // panel14
            // 
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel14.Controls.Add(this.btnXuatDSHoaDon);
            this.panel14.Controls.Add(this.btnTaoHoaDon);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 851);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.panel14.Size = new System.Drawing.Size(857, 56);
            this.panel14.TabIndex = 19;
            // 
            // btnXuatDSHoaDon
            // 
            this.btnXuatDSHoaDon.Image = global::BanHangCayCanh.Properties.Resources.print;
            this.btnXuatDSHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatDSHoaDon.Location = new System.Drawing.Point(14, 7);
            this.btnXuatDSHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatDSHoaDon.Name = "btnXuatDSHoaDon";
            this.btnXuatDSHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXuatDSHoaDon.Size = new System.Drawing.Size(160, 41);
            this.btnXuatDSHoaDon.TabIndex = 12;
            this.btnXuatDSHoaDon.Text = "Xuất danh sách";
            this.btnXuatDSHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatDSHoaDon.UseVisualStyleBackColor = true;
            this.btnXuatDSHoaDon.Click += new System.EventHandler(this.btnXuatDSHoaDon_Click);
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTaoHoaDon.Image = global::BanHangCayCanh.Properties.Resources.add;
            this.btnTaoHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoHoaDon.Location = new System.Drawing.Point(693, 6);
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaoHoaDon.MaximumSize = new System.Drawing.Size(149, 42);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTaoHoaDon.Size = new System.Drawing.Size(149, 42);
            this.btnTaoHoaDon.TabIndex = 22;
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.titleTable);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 16, 6, 0);
            this.panel13.Size = new System.Drawing.Size(857, 52);
            this.panel13.TabIndex = 18;
            // 
            // titleTable
            // 
            this.titleTable.AutoSize = true;
            this.titleTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleTable.Location = new System.Drawing.Point(0, 16);
            this.titleTable.Name = "titleTable";
            this.titleTable.Size = new System.Drawing.Size(195, 28);
            this.titleTable.TabIndex = 14;
            this.titleTable.Text = "Danh sách hóa đơn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.btnHuyTimKiem);
            this.panel6.Controls.Add(this.btnTimKiem);
            this.panel6.Controls.Add(this.txtTimkiem);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel6.Size = new System.Drawing.Size(857, 80);
            this.panel6.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.comboBox1);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 52);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(714, 28);
            this.panel10.TabIndex = 37;
            this.panel10.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mã hóa đơn",
            "Mã nhân viên",
            "Mã khách hàng",
            "Tên khách hàng"});
            this.comboBox1.Location = new System.Drawing.Point(160, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tìm theo:";
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
            this.btnHuyTimKiem.Location = new System.Drawing.Point(714, 20);
            this.btnHuyTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyTimKiem.MaximumSize = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.MinimumSize = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHuyTimKiem.Size = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.TabIndex = 11;
            this.btnHuyTimKiem.Text = "Hủy tìm kiếm";
            this.btnHuyTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyTimKiem.UseVisualStyleBackColor = false;
            this.btnHuyTimKiem.Visible = false;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(520, 18);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(117, 28);
            this.btnTimKiem.TabIndex = 10;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.Location = new System.Drawing.Point(160, 19);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.MaximumSize = new System.Drawing.Size(331, 50);
            this.txtTimkiem.MinimumSize = new System.Drawing.Size(331, 33);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(331, 27);
            this.txtTimkiem.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nội dung tìm kiếm:";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 1003);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelThongTinHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBanHang_FormClosed);
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panelThongTinHoaDon.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelSupport5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.panelSanPham.ResumeLayout(false);
            this.panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCayCanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.panelSupport4.ResumeLayout(false);
            this.panelSupport4.PerformLayout();
            this.panelSupport3.ResumeLayout(false);
            this.panelSupport3.PerformLayout();
            this.panelSupport2.ResumeLayout(false);
            this.panelSupport2.PerformLayout();
            this.panelSupport1.ResumeLayout(false);
            this.panelSupport1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelSupport.ResumeLayout(false);
            this.panelSupport.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelThongTinHoaDon;
        private Panel panel4;
        private Panel panel3;
        private Panel panelSupport;
        private Label txtTongTien;
        private Label label13;
        private Panel panel5;
        private Button btnInHD;
        private Button btnCapNhat;
        private Button btnTaoHoaDon;
        private Label txtGiaCay;
        private Label label19;
        private Panel panel12;
        private Button btnResetFormHoaDon;
        private Button btnThem;
        private Label label20;
        private TextBox txtGiamGia;
        private Panel panel1;
        private Panel panel6;
        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private Panel panel13;
        private Label titleTable;
        private DataGridView dgvHoaDon;
        private Panel panel14;
        private Button btnXuatDSHoaDon;
        private Label label16;
        private Panel panelSupport1;
        private DateTimePicker dtpNgayLap;
        private Label label3;
        private Label label15;
        private Panel panel15;
        private ComboBox cbbTrangThai;
        private Label label6;
        private Panel panel10;
        private ComboBox comboBox1;
        private Label label8;
        private Button btnDatLaiDon;
        private DataGridViewTextBoxColumn idHoaDonAll;
        private DataGridViewTextBoxColumn idNhanVien;
        private DataGridViewTextBoxColumn idKhachHang;
        private DataGridViewTextBoxColumn ngayLap;
        private DataGridViewTextBoxColumn chietKhau;
        private DataGridViewTextBoxColumn tongTien;
        private DataGridViewTextBoxColumn trangThai;
        private Panel panelSupport5;
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
        private Label label4;
        private Label label5;
        private Label label21;
        private ComboBox cbbTenCay;
        private Label label22;
        private Panel panelSupport4;
        private Label label7;
        private Label label17;
        private Panel panelSupport3;
        private ComboBox cbbKhachHang;
        private TextBox txtTuoiKH;
        private TextBox txtDiaChiKH;
        private Label label11;
        private TextBox txtSDT;
        private Label label9;
        private Label label10;
        private Label label12;
        private Panel panelSupport2;
        private RadioButton rbKhachHangCu;
        private RadioButton rbKhachHangMoi;
        private ComboBox cbbIdNhanVien;
        private TextBox txtTenKhachHang;
        private PictureBox picAnhCayCanh;
        private DataGridViewTextBoxColumn idCTHD;
        private DataGridViewTextBoxColumn idCay;
        private DataGridViewTextBoxColumn tenCay;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewTextBoxColumn idHoaDon;
        private DataGridViewTextBoxColumn anhCay;
        private Panel panel7;
        private Label lbIDHoaDon;
    }
}