
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiCayCanh));
            panel3 = new Panel();
            panel5 = new Panel();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            panel4 = new Panel();
            panel7 = new Panel();
            rtxtMota = new RichTextBox();
            btnIn = new Button();
            label2 = new Label();
            txtTenLoaiCay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            btnXoa = new Label();
            titleTable = new Label();
            btnHuyTimKiem = new Button();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            dgvLoaiCayCanh = new DataGridView();
            idLoaiCay = new DataGridViewTextBoxColumn();
            tenLoaiCay = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            selected = new DataGridViewCheckBoxColumn();
            delete = new DataGridViewImageColumn();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiCayCanh).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(777, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6, 7, 6, 7);
            panel3.Size = new Size(423, 520);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(btnReset);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(6, 432);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(411, 81);
            panel5.TabIndex = 13;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.write;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(161, 16);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(10, 0, 10, 0);
            btnSua.Size = new Size(101, 51);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(18, 16);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 10, 0);
            btnThem.Size = new Size(101, 51);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.circular;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(304, 16);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 10, 0);
            btnReset.Size = new Size(101, 51);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(btnIn);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtTenLoaiCay);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(6, 7);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 506);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(rtxtMota);
            panel7.Location = new Point(110, 136);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(292, 127);
            panel7.TabIndex = 13;
            // 
            // rtxtMota
            // 
            rtxtMota.BorderStyle = BorderStyle.None;
            rtxtMota.Location = new Point(-1, 0);
            rtxtMota.Margin = new Padding(3, 4, 3, 4);
            rtxtMota.Name = "rtxtMota";
            rtxtMota.Size = new Size(299, 125);
            rtxtMota.TabIndex = 8;
            rtxtMota.Text = "";
            // 
            // btnIn
            // 
            btnIn.Image = Properties.Resources.print;
            btnIn.ImageAlign = ContentAlignment.MiddleLeft;
            btnIn.Location = new Point(300, 4);
            btnIn.Name = "btnIn";
            btnIn.Padding = new Padding(10, 0, 10, 0);
            btnIn.Size = new Size(101, 51);
            btnIn.TabIndex = 11;
            btnIn.Text = "In";
            btnIn.TextAlign = ContentAlignment.MiddleRight;
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 9;
            label2.Text = "Thông tin loại cây cảnh:";
            // 
            // txtTenLoaiCay
            // 
            txtTenLoaiCay.Location = new Point(110, 81);
            txtTenLoaiCay.Name = "txtTenLoaiCay";
            txtTenLoaiCay.Size = new Size(292, 27);
            txtTenLoaiCay.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 136);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 12;
            label4.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 10;
            label3.Text = "Tên loại cây:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(btnHuyTimKiem);
            panel2.Controls.Add(btnTimKiem);
            panel2.Controls.Add(txtTimkiem);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 113);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnXoa);
            panel6.Controls.Add(titleTable);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 73);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(777, 40);
            panel6.TabIndex = 16;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = Properties.Resources.bin;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(623, 13);
            btnXoa.MinimumSize = new Size(143, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(143, 27);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa mục đã chọn";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseMnemonic = false;
            btnXoa.Visible = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleTable.Location = new Point(11, 8);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(240, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "Danh sách loại cây cảnh";
            // 
            // btnHuyTimKiem
            // 
            btnHuyTimKiem.BackColor = Color.Transparent;
            btnHuyTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnHuyTimKiem.FlatAppearance.BorderSize = 0;
            btnHuyTimKiem.FlatStyle = FlatStyle.Flat;
            btnHuyTimKiem.Image = Properties.Resources.clear2;
            btnHuyTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyTimKiem.Location = new Point(623, 19);
            btnHuyTimKiem.Name = "btnHuyTimKiem";
            btnHuyTimKiem.Padding = new Padding(10, 0, 10, 0);
            btnHuyTimKiem.Size = new Size(143, 35);
            btnHuyTimKiem.TabIndex = 3;
            btnHuyTimKiem.Text = "Hủy tìm kiếm";
            btnHuyTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnHuyTimKiem.UseVisualStyleBackColor = false;
            btnHuyTimKiem.Visible = false;
            btnHuyTimKiem.Click += btnHuyTimKiem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(494, 19);
            btnTimKiem.MaximumSize = new Size(117, 35);
            btnTimKiem.MinimumSize = new Size(117, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Padding = new Padding(6, 0, 6, 0);
            btnTimKiem.Size = new Size(117, 35);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(156, 20);
            txtTimkiem.MaximumSize = new Size(331, 40);
            txtTimkiem.MinimumSize = new Size(331, 33);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(331, 33);
            txtTimkiem.TabIndex = 1;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Nội dung tìm kiếm:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dgvLoaiCayCanh);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 13, 11, 13);
            panel1.Size = new Size(777, 407);
            panel1.TabIndex = 6;
            // 
            // dgvLoaiCayCanh
            // 
            dgvLoaiCayCanh.AllowUserToResizeColumns = false;
            dgvLoaiCayCanh.BackgroundColor = SystemColors.Control;
            dgvLoaiCayCanh.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLoaiCayCanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLoaiCayCanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiCayCanh.Columns.AddRange(new DataGridViewColumn[] { idLoaiCay, tenLoaiCay, moTa, selected, delete });
            dgvLoaiCayCanh.Dock = DockStyle.Fill;
            dgvLoaiCayCanh.EnableHeadersVisualStyles = false;
            dgvLoaiCayCanh.Location = new Point(11, 13);
            dgvLoaiCayCanh.Margin = new Padding(3, 4, 3, 4);
            dgvLoaiCayCanh.MultiSelect = false;
            dgvLoaiCayCanh.Name = "dgvLoaiCayCanh";
            dgvLoaiCayCanh.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLoaiCayCanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLoaiCayCanh.RowHeadersVisible = false;
            dgvLoaiCayCanh.RowHeadersWidth = 51;
            dgvLoaiCayCanh.RowTemplate.Height = 25;
            dgvLoaiCayCanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiCayCanh.Size = new Size(755, 381);
            dgvLoaiCayCanh.TabIndex = 0;
            dgvLoaiCayCanh.CellContentClick += dgvLoaiCayCanh_CellContentClick;
            dgvLoaiCayCanh.Click += dgvLoaiCayCanh_Click;
            // 
            // idLoaiCay
            // 
            idLoaiCay.HeaderText = "Mã loại cây";
            idLoaiCay.MinimumWidth = 6;
            idLoaiCay.Name = "idLoaiCay";
            idLoaiCay.Width = 165;
            // 
            // tenLoaiCay
            // 
            tenLoaiCay.HeaderText = "Tên loại cây";
            tenLoaiCay.MinimumWidth = 6;
            tenLoaiCay.Name = "tenLoaiCay";
            tenLoaiCay.Width = 165;
            // 
            // moTa
            // 
            moTa.HeaderText = "Mô tả";
            moTa.MinimumWidth = 6;
            moTa.Name = "moTa";
            moTa.Width = 164;
            // 
            // selected
            // 
            selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            selected.HeaderText = "";
            selected.MinimumWidth = 6;
            selected.Name = "selected";
            selected.Visible = false;
            selected.Width = 125;
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Image = Properties.Resources.remove;
            delete.MinimumWidth = 20;
            delete.Name = "delete";
            delete.Width = 125;
            // 
            // FormLoaiCayCanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 520);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLoaiCayCanh";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại cây cảnh";
            FormClosed += FormLoaiCayCanh_FormClosed;
            Load += FormLoaiCayCanh_Load;
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoaiCayCanh).EndInit();
            ResumeLayout(false);
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
        private Button btnIn;
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
    }
}