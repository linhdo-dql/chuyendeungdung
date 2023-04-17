
using DocumentFormat.OpenXml.ExtendedProperties;
using System.Drawing;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    partial class FormLoaiCayCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiCayCanh));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rtxtMota = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLoaiCay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Label();
            this.titleTable = new System.Windows.Forms.Label();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLoaiCayCanh = new System.Windows.Forms.DataGridView();
            this.idLoaiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiCay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnXuatDSLoaiCayCanh = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCayCanh)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(875, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(6);
            this.panel3.Size = new System.Drawing.Size(423, 871);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSua);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Controls.Add(this.btnReset);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(6, 800);
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
            this.btnThem.Location = new System.Drawing.Point(18, 13);
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
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTenLoaiCay);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 859);
            this.panel4.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.rtxtMota);
            this.panel7.Location = new System.Drawing.Point(110, 109);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(292, 102);
            this.panel7.TabIndex = 13;
            // 
            // rtxtMota
            // 
            this.rtxtMota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtMota.Location = new System.Drawing.Point(-1, 0);
            this.rtxtMota.Name = "rtxtMota";
            this.rtxtMota.Size = new System.Drawing.Size(299, 100);
            this.rtxtMota.TabIndex = 8;
            this.rtxtMota.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thông tin loại cây cảnh:";
            // 
            // txtTenLoaiCay
            // 
            this.txtTenLoaiCay.Location = new System.Drawing.Point(110, 65);
            this.txtTenLoaiCay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenLoaiCay.Name = "txtTenLoaiCay";
            this.txtTenLoaiCay.Size = new System.Drawing.Size(292, 22);
            this.txtTenLoaiCay.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên loại cây:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnHuyTimKiem);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtTimkiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 90);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnXoa);
            this.panel6.Controls.Add(this.titleTable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 58);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(875, 32);
            this.panel6.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSize = true;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::BanHangCayCanh.Properties.Resources.bin;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(721, 6);
            this.btnXoa.MinimumSize = new System.Drawing.Size(143, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 22);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa mục đã chọn";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseMnemonic = false;
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // titleTable
            // 
            this.titleTable.AutoSize = true;
            this.titleTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.titleTable.Location = new System.Drawing.Point(11, 6);
            this.titleTable.Name = "titleTable";
            this.titleTable.Size = new System.Drawing.Size(240, 28);
            this.titleTable.TabIndex = 14;
            this.titleTable.Text = "Danh sách loại cây cảnh";
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHuyTimKiem.FlatAppearance.BorderSize = 0;
            this.btnHuyTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyTimKiem.Image = global::BanHangCayCanh.Properties.Resources.clear2;
            this.btnHuyTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyTimKiem.Location = new System.Drawing.Point(721, 18);
            this.btnHuyTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnHuyTimKiem.Size = new System.Drawing.Size(143, 28);
            this.btnHuyTimKiem.TabIndex = 3;
            this.btnHuyTimKiem.Text = "Hủy tìm kiếm";
            this.btnHuyTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyTimKiem.UseVisualStyleBackColor = false;
            this.btnHuyTimKiem.Visible = false;
            this.btnHuyTimKiem.Click += new System.EventHandler(this.btnHuyTimKiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(494, 15);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.MaximumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.MinimumSize = new System.Drawing.Size(117, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnTimKiem.Size = new System.Drawing.Size(117, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimkiem.Location = new System.Drawing.Point(156, 16);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.MaximumSize = new System.Drawing.Size(331, 40);
            this.txtTimkiem.MinimumSize = new System.Drawing.Size(331, 33);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(331, 27);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung tìm kiếm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.dgvLoaiCayCanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel1.Size = new System.Drawing.Size(875, 781);
            this.panel1.TabIndex = 6;
            // 
            // dgvLoaiCayCanh
            // 
            this.dgvLoaiCayCanh.AllowUserToResizeColumns = false;
            this.dgvLoaiCayCanh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiCayCanh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiCayCanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiCayCanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiCayCanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoaiCay,
            this.tenLoaiCay,
            this.moTa,
            this.selected,
            this.delete});
            this.dgvLoaiCayCanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiCayCanh.EnableHeadersVisualStyles = false;
            this.dgvLoaiCayCanh.Location = new System.Drawing.Point(11, 10);
            this.dgvLoaiCayCanh.MultiSelect = false;
            this.dgvLoaiCayCanh.Name = "dgvLoaiCayCanh";
            this.dgvLoaiCayCanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiCayCanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiCayCanh.RowHeadersVisible = false;
            this.dgvLoaiCayCanh.RowHeadersWidth = 51;
            this.dgvLoaiCayCanh.RowTemplate.Height = 25;
            this.dgvLoaiCayCanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiCayCanh.Size = new System.Drawing.Size(853, 761);
            this.dgvLoaiCayCanh.TabIndex = 0;
            this.dgvLoaiCayCanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiCayCanh_CellContentClick);
            this.dgvLoaiCayCanh.Click += new System.EventHandler(this.dgvLoaiCayCanh_Click);
            // 
            // idLoaiCay
            // 
            this.idLoaiCay.HeaderText = "Mã loại cây";
            this.idLoaiCay.MinimumWidth = 6;
            this.idLoaiCay.Name = "idLoaiCay";
            this.idLoaiCay.Width = 165;
            // 
            // tenLoaiCay
            // 
            this.tenLoaiCay.HeaderText = "Tên loại cây";
            this.tenLoaiCay.MinimumWidth = 6;
            this.tenLoaiCay.Name = "tenLoaiCay";
            this.tenLoaiCay.Width = 165;
            // 
            // moTa
            // 
            this.moTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTa.HeaderText = "Mô tả";
            this.moTa.MinimumWidth = 6;
            this.moTa.Name = "moTa";
            // 
            // selected
            // 
            this.selected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selected.HeaderText = "";
            this.selected.MinimumWidth = 6;
            this.selected.Name = "selected";
            this.selected.Visible = false;
            this.selected.Width = 125;
            // 
            // delete
            // 
            this.delete.HeaderText = "";
            this.delete.Image = global::BanHangCayCanh.Properties.Resources.remove;
            this.delete.MinimumWidth = 20;
            this.delete.Name = "delete";
            this.delete.Width = 125;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnXuatDSLoaiCayCanh);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(11, 706);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.panel9.Size = new System.Drawing.Size(853, 65);
            this.panel9.TabIndex = 15;
            // 
            // btnXuatDSLoaiCayCanh
            // 
            this.btnXuatDSLoaiCayCanh.Image = global::BanHangCayCanh.Properties.Resources.print;
            this.btnXuatDSLoaiCayCanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatDSLoaiCayCanh.Location = new System.Drawing.Point(14, 13);
            this.btnXuatDSLoaiCayCanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatDSLoaiCayCanh.Name = "btnXuatDSLoaiCayCanh";
            this.btnXuatDSLoaiCayCanh.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXuatDSLoaiCayCanh.Size = new System.Drawing.Size(160, 41);
            this.btnXuatDSLoaiCayCanh.TabIndex = 12;
            this.btnXuatDSLoaiCayCanh.Text = "Xuất danh sách";
            this.btnXuatDSLoaiCayCanh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatDSLoaiCayCanh.UseVisualStyleBackColor = true;
            this.btnXuatDSLoaiCayCanh.Click += new System.EventHandler(this.btnXuatDSLoaiCayCanh_Click);
            // 
            // FormLoaiCayCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1298, 871);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLoaiCayCanh";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại cây cảnh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLoaiCayCanh_FormClosed);
            this.Load += new System.EventHandler(this.FormLoaiCayCanh_Load);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiCayCanh)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private DataGridView dgvLoaiCayCanh;
        private Panel panel5;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
        private RichTextBox rtxtMota;
        private Label label4;
        private TextBox txtTenLoaiCay;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Panel panel6;
        private Label titleTable;
        private Label btnXoa;
        private Panel panel7;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private DataGridViewTextBoxColumn idLoaiCay;
        private DataGridViewTextBoxColumn tenLoaiCay;
        private DataGridViewTextBoxColumn moTa;
        private DataGridViewCheckBoxColumn selected;
        private DataGridViewImageColumn delete;
        private Panel panel9;
        private Button btnXuatDSLoaiCayCanh;
    }
}