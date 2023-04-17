using System.Drawing;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLCC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBC = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.panelDangNhap = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowHidePass = new System.Windows.Forms.Label();
            this.lkTaoTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.rbSaveLogined = new System.Windows.Forms.RadioButton();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhauDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaNVDangNhap = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTaiKhoan = new System.Windows.Forms.Panel();
            this.panelTaoTaiKhoan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatKhauNhapLai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnShowHidePassDangKy = new System.Windows.Forms.Label();
            this.lkQuayLaiDangNhap = new System.Windows.Forms.LinkLabel();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.txtMatKhauDangKy = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbbMaNVDangKy = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panelDangNhap.SuspendLayout();
            this.panelTaiKhoan.SuspendLayout();
            this.panelTaoTaiKhoan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDM,
            this.menuBH,
            this.menuBC,
            this.menuTK});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // menuDM
            // 
            this.menuDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCC,
            this.menuLCC,
            this.menuNV,
            this.menuKH});
            this.menuDM.Name = "menuDM";
            this.menuDM.Size = new System.Drawing.Size(90, 25);
            this.menuDM.Text = "Danh mục";
            // 
            // menuCC
            // 
            this.menuCC.Name = "menuCC";
            this.menuCC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.menuCC.Size = new System.Drawing.Size(245, 26);
            this.menuCC.Text = "Cây cảnh";
            this.menuCC.Click += new System.EventHandler(this.menuCC_Click);
            // 
            // menuLCC
            // 
            this.menuLCC.Name = "menuLCC";
            this.menuLCC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.menuLCC.Size = new System.Drawing.Size(245, 26);
            this.menuLCC.Text = "Loại cây cảnh";
            this.menuLCC.Click += new System.EventHandler(this.menuLCC_Click);
            // 
            // menuNV
            // 
            this.menuNV.Name = "menuNV";
            this.menuNV.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.menuNV.Size = new System.Drawing.Size(245, 26);
            this.menuNV.Text = "Nhân viên";
            this.menuNV.Click += new System.EventHandler(this.menuNV_Click);
            // 
            // menuKH
            // 
            this.menuKH.Name = "menuKH";
            this.menuKH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.menuKH.Size = new System.Drawing.Size(245, 26);
            this.menuKH.Text = "Khách hàng";
            this.menuKH.Click += new System.EventHandler(this.menuKH_Click);
            // 
            // menuBH
            // 
            this.menuBH.Name = "menuBH";
            this.menuBH.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.menuBH.Size = new System.Drawing.Size(85, 25);
            this.menuBH.Text = "Bán hàng";
            this.menuBH.Click += new System.EventHandler(this.menuBH_Click);
            // 
            // menuBC
            // 
            this.menuBC.Name = "menuBC";
            this.menuBC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.menuBC.Size = new System.Drawing.Size(77, 25);
            this.menuBC.Text = "Báo cáo";
            this.menuBC.Click += new System.EventHandler(this.menuBC_Click);
            // 
            // menuTK
            // 
            this.menuTK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDX});
            this.menuTK.Name = "menuTK";
            this.menuTK.Size = new System.Drawing.Size(129, 25);
            this.menuTK.Text = "Tài khoản: nv_00";
            // 
            // menuDX
            // 
            this.menuDX.AutoSize = false;
            this.menuDX.AutoToolTip = true;
            this.menuDX.Name = "menuDX";
            this.menuDX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuDX.RightToLeftAutoMirrorImage = true;
            this.menuDX.Size = new System.Drawing.Size(223, 26);
            this.menuDX.Text = "Đăng xuất";
            this.menuDX.Click += new System.EventHandler(this.menuDX_Click);
            // 
            // panel
            // 
            this.panel.CausesValidation = false;
            this.panel.Controls.Add(this.panelDangNhap);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(90, 40);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(430, 244);
            this.panel.TabIndex = 0;
            // 
            // panelDangNhap
            // 
            this.panelDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.panelDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDangNhap.Controls.Add(this.label5);
            this.panelDangNhap.Controls.Add(this.label4);
            this.panelDangNhap.Controls.Add(this.btnShowHidePass);
            this.panelDangNhap.Controls.Add(this.lkTaoTaiKhoan);
            this.panelDangNhap.Controls.Add(this.rbSaveLogined);
            this.panelDangNhap.Controls.Add(this.btnDangNhap);
            this.panelDangNhap.Controls.Add(this.txtMatKhauDangNhap);
            this.panelDangNhap.Controls.Add(this.label3);
            this.panelDangNhap.Controls.Add(this.cbbMaNVDangNhap);
            this.panelDangNhap.Controls.Add(this.label2);
            this.panelDangNhap.Controls.Add(this.label1);
            this.panelDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDangNhap.Location = new System.Drawing.Point(0, 0);
            this.panelDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDangNhap.Name = "panelDangNhap";
            this.panelDangNhap.Size = new System.Drawing.Size(430, 244);
            this.panelDangNhap.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(118, 95);
            this.label5.MaximumSize = new System.Drawing.Size(10, 8);
            this.label5.MinimumSize = new System.Drawing.Size(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 8);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(145, 55);
            this.label4.MaximumSize = new System.Drawing.Size(10, 8);
            this.label4.MinimumSize = new System.Drawing.Size(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 8);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // btnShowHidePass
            // 
            this.btnShowHidePass.AutoSize = true;
            this.btnShowHidePass.ForeColor = System.Drawing.Color.Lime;
            this.btnShowHidePass.Location = new System.Drawing.Point(373, 99);
            this.btnShowHidePass.MaximumSize = new System.Drawing.Size(40, 16);
            this.btnShowHidePass.MinimumSize = new System.Drawing.Size(40, 16);
            this.btnShowHidePass.Name = "btnShowHidePass";
            this.btnShowHidePass.Size = new System.Drawing.Size(40, 16);
            this.btnShowHidePass.TabIndex = 9;
            this.btnShowHidePass.Text = "Hiện";
            this.btnShowHidePass.Click += new System.EventHandler(this.btnShowHidePass_Click);
            // 
            // lkTaoTaiKhoan
            // 
            this.lkTaoTaiKhoan.AutoSize = true;
            this.lkTaoTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lkTaoTaiKhoan.LinkColor = System.Drawing.Color.Black;
            this.lkTaoTaiKhoan.Location = new System.Drawing.Point(135, 180);
            this.lkTaoTaiKhoan.Name = "lkTaoTaiKhoan";
            this.lkTaoTaiKhoan.Size = new System.Drawing.Size(124, 16);
            this.lkTaoTaiKhoan.TabIndex = 8;
            this.lkTaoTaiKhoan.TabStop = true;
            this.lkTaoTaiKhoan.Text = "Thêm tài khoản mới";
            this.lkTaoTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkTaoTaiKhoan_LinkClicked_1);
            // 
            // rbSaveLogined
            // 
            this.rbSaveLogined.AutoSize = true;
            this.rbSaveLogined.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSaveLogined.Location = new System.Drawing.Point(56, 137);
            this.rbSaveLogined.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSaveLogined.Name = "rbSaveLogined";
            this.rbSaveLogined.Size = new System.Drawing.Size(66, 20);
            this.rbSaveLogined.TabIndex = 7;
            this.rbSaveLogined.TabStop = true;
            this.rbSaveLogined.Text = "Lưu lại";
            this.rbSaveLogined.UseVisualStyleBackColor = true;
            this.rbSaveLogined.CheckedChanged += new System.EventHandler(this.rbSaveLogined_CheckedChanged);
            this.rbSaveLogined.Click += new System.EventHandler(this.rbSaveLogined_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(164, 133);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(207, 28);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhauDangNhap
            // 
            this.txtMatKhauDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauDangNhap.Location = new System.Drawing.Point(164, 97);
            this.txtMatKhauDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauDangNhap.MaximumSize = new System.Drawing.Size(205, 30);
            this.txtMatKhauDangNhap.MinimumSize = new System.Drawing.Size(205, 30);
            this.txtMatKhauDangNhap.Name = "txtMatKhauDangNhap";
            this.txtMatKhauDangNhap.PasswordChar = '*';
            this.txtMatKhauDangNhap.Size = new System.Drawing.Size(205, 30);
            this.txtMatKhauDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbMaNVDangNhap
            // 
            this.cbbMaNVDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaNVDangNhap.FormattingEnabled = true;
            this.cbbMaNVDangNhap.Location = new System.Drawing.Point(164, 57);
            this.cbbMaNVDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaNVDangNhap.Name = "cbbMaNVDangNhap";
            this.cbbMaNVDangNhap.Size = new System.Drawing.Size(205, 31);
            this.cbbMaNVDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã nhân viên:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(135, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTaiKhoan
            // 
            this.panelTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.panelTaiKhoan.Controls.Add(this.panelTaoTaiKhoan);
            this.panelTaiKhoan.Controls.Add(this.panel);
            this.panelTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.panelTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTaiKhoan.Name = "panelTaiKhoan";
            this.panelTaiKhoan.Padding = new System.Windows.Forms.Padding(90, 40, 90, 40);
            this.panelTaiKhoan.Size = new System.Drawing.Size(610, 324);
            this.panelTaiKhoan.TabIndex = 1;
            // 
            // panelTaoTaiKhoan
            // 
            this.panelTaoTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.panelTaoTaiKhoan.Controls.Add(this.panel1);
            this.panelTaoTaiKhoan.Controls.Add(this.label11);
            this.panelTaoTaiKhoan.Controls.Add(this.label12);
            this.panelTaoTaiKhoan.Controls.Add(this.label13);
            this.panelTaoTaiKhoan.Controls.Add(this.textBox2);
            this.panelTaoTaiKhoan.Controls.Add(this.label14);
            this.panelTaoTaiKhoan.Controls.Add(this.label15);
            this.panelTaoTaiKhoan.Controls.Add(this.linkLabel1);
            this.panelTaoTaiKhoan.Controls.Add(this.button2);
            this.panelTaoTaiKhoan.Controls.Add(this.textBox1);
            this.panelTaoTaiKhoan.Controls.Add(this.label16);
            this.panelTaoTaiKhoan.Controls.Add(this.comboBox1);
            this.panelTaoTaiKhoan.Controls.Add(this.label17);
            this.panelTaoTaiKhoan.Controls.Add(this.label18);
            this.panelTaoTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTaoTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTaoTaiKhoan.Location = new System.Drawing.Point(90, 40);
            this.panelTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTaoTaiKhoan.Name = "panelTaoTaiKhoan";
            this.panelTaoTaiKhoan.Size = new System.Drawing.Size(430, 244);
            this.panelTaoTaiKhoan.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtMatKhauNhapLai);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnShowHidePassDangKy);
            this.panel1.Controls.Add(this.lkQuayLaiDangNhap);
            this.panel1.Controls.Add(this.btnTaoTaiKhoan);
            this.panel1.Controls.Add(this.txtMatKhauDangKy);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.cbbMaNVDangKy);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 244);
            this.panel1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(176, 118);
            this.label6.MaximumSize = new System.Drawing.Size(10, 8);
            this.label6.MinimumSize = new System.Drawing.Size(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 8);
            this.label6.TabIndex = 14;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(118, 85);
            this.label7.MaximumSize = new System.Drawing.Size(10, 8);
            this.label7.MinimumSize = new System.Drawing.Size(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 8);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(143, 50);
            this.label8.MaximumSize = new System.Drawing.Size(10, 8);
            this.label8.MinimumSize = new System.Drawing.Size(10, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 8);
            this.label8.TabIndex = 12;
            this.label8.Text = "*";
            // 
            // txtMatKhauNhapLai
            // 
            this.txtMatKhauNhapLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauNhapLai.Location = new System.Drawing.Point(189, 118);
            this.txtMatKhauNhapLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauNhapLai.Name = "txtMatKhauNhapLai";
            this.txtMatKhauNhapLai.Size = new System.Drawing.Size(180, 30);
            this.txtMatKhauNhapLai.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(54, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nhập lại mật khẩu:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnShowHidePassDangKy
            // 
            this.btnShowHidePassDangKy.AutoSize = true;
            this.btnShowHidePassDangKy.ForeColor = System.Drawing.Color.Lime;
            this.btnShowHidePassDangKy.Location = new System.Drawing.Point(375, 89);
            this.btnShowHidePassDangKy.MaximumSize = new System.Drawing.Size(40, 16);
            this.btnShowHidePassDangKy.MinimumSize = new System.Drawing.Size(40, 16);
            this.btnShowHidePassDangKy.Name = "btnShowHidePassDangKy";
            this.btnShowHidePassDangKy.Size = new System.Drawing.Size(40, 16);
            this.btnShowHidePassDangKy.TabIndex = 9;
            this.btnShowHidePassDangKy.Text = "Hiện";
            this.btnShowHidePassDangKy.Click += new System.EventHandler(this.btnShowHidePass_Click);
            // 
            // lkQuayLaiDangNhap
            // 
            this.lkQuayLaiDangNhap.AutoSize = true;
            this.lkQuayLaiDangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lkQuayLaiDangNhap.LinkColor = System.Drawing.Color.Black;
            this.lkQuayLaiDangNhap.Location = new System.Drawing.Point(146, 212);
            this.lkQuayLaiDangNhap.Name = "lkQuayLaiDangNhap";
            this.lkQuayLaiDangNhap.Size = new System.Drawing.Size(123, 16);
            this.lkQuayLaiDangNhap.TabIndex = 8;
            this.lkQuayLaiDangNhap.TabStop = true;
            this.lkQuayLaiDangNhap.Text = "Quay lại đăng nhập";
            this.lkQuayLaiDangNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkQuayLaiDangNhap_LinkClicked);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(56, 156);
            this.btnTaoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(315, 41);
            this.btnTaoTaiKhoan.TabIndex = 6;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // txtMatKhauDangKy
            // 
            this.txtMatKhauDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatKhauDangKy.Location = new System.Drawing.Point(189, 85);
            this.txtMatKhauDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauDangKy.Name = "txtMatKhauDangKy";
            this.txtMatKhauDangKy.Size = new System.Drawing.Size(180, 30);
            this.txtMatKhauDangKy.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(54, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Mật khẩu:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbMaNVDangKy
            // 
            this.cbbMaNVDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbMaNVDangKy.FormattingEnabled = true;
            this.cbbMaNVDangKy.Location = new System.Drawing.Point(189, 50);
            this.cbbMaNVDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaNVDangKy.Name = "cbbMaNVDangKy";
            this.cbbMaNVDangKy.Size = new System.Drawing.Size(180, 31);
            this.cbbMaNVDangKy.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(54, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "Mã nhân viên:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(117, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 38);
            this.label21.TabIndex = 0;
            this.label21.Text = "Tạo tài khoản";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(176, 111);
            this.label11.MaximumSize = new System.Drawing.Size(10, 8);
            this.label11.MinimumSize = new System.Drawing.Size(10, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 8);
            this.label11.TabIndex = 14;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(118, 78);
            this.label12.MaximumSize = new System.Drawing.Size(10, 8);
            this.label12.MinimumSize = new System.Drawing.Size(10, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 8);
            this.label12.TabIndex = 13;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(143, 43);
            this.label13.MaximumSize = new System.Drawing.Size(10, 8);
            this.label13.MinimumSize = new System.Drawing.Size(10, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 8);
            this.label13.TabIndex = 12;
            this.label13.Text = "*";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(189, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 30);
            this.textBox2.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(54, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Nhập lại mật khẩu:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(375, 82);
            this.label15.MaximumSize = new System.Drawing.Size(40, 16);
            this.label15.MinimumSize = new System.Drawing.Size(40, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Hiện";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(146, 196);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quay lại đăng nhập";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 150);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(315, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tạo tài khoản";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(189, 78);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(54, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Mật khẩu:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 31);
            this.comboBox1.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(54, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã nhân viên:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(117, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 38);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tạo tài khoản";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::BanHangCayCanh.Properties.Resources.LinhBonsai;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 324);
            this.Controls.Add(this.panelTaiKhoan);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng cây cảnh LinhBonsai";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panelDangNhap.ResumeLayout(false);
            this.panelDangNhap.PerformLayout();
            this.panelTaiKhoan.ResumeLayout(false);
            this.panelTaoTaiKhoan.ResumeLayout(false);
            this.panelTaoTaiKhoan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDM;
        private ToolStripMenuItem menuCC;
        private ToolStripMenuItem menuLCC;
        private ToolStripMenuItem menuNV;
        private ToolStripMenuItem menuKH;
        private ToolStripMenuItem menuBH;
        private ToolStripMenuItem menuBC;
        private Panel panel;
        private Panel panelDangNhap;
        private Label btnShowHidePass;
        private LinkLabel lkTaoTaiKhoan;
        private RadioButton rbSaveLogined;
        private Button btnDangNhap;
        private TextBox txtMatKhauDangNhap;
        private Label label3;
        private ComboBox cbbMaNVDangNhap;
        private Label label2;
        private Label label1;
        private Panel panelTaiKhoan;
        private Label label5;
        private Label label4;
        private Panel panelTaoTaiKhoan;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMatKhauNhapLai;
        private Label label9;
        private Label btnShowHidePassDangKy;
        private LinkLabel lkQuayLaiDangNhap;
        private Button btnTaoTaiKhoan;
        private TextBox txtMatKhauDangKy;
        private Label label19;
        private ComboBox cbbMaNVDangKy;
        private Label label20;
        private Label label21;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
        private Label label14;
        private Label label15;
        private LinkLabel linkLabel1;
        private Button button2;
        private TextBox textBox1;
        private Label label16;
        private ComboBox comboBox1;
        private Label label17;
        private Label label18;
        private ToolStripMenuItem menuTK;
        private ToolStripMenuItem menuDX;
    }
}