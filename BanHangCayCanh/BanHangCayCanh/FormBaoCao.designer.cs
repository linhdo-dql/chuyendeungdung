namespace BanHangCayCanh
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbbLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTieuChi = new System.Windows.Forms.Panel();
            this.tcHoaDon = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbTPValue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbValue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbThanhPhan = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTieuChi.SuspendLayout();
            this.tcHoaDon.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 150);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panelTieuChi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1298, 150);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbbLoaiBaoCao);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(303, 150);
            this.panel4.TabIndex = 4;
            // 
            // cbbLoaiBaoCao
            // 
            this.cbbLoaiBaoCao.FormattingEnabled = true;
            this.cbbLoaiBaoCao.Items.AddRange(new object[] {
            "Cây cảnh",
            "Hóa đơn",
            "Khách hàng",
            "Nhân viên",
            "Loại cây cảnh"});
            this.cbbLoaiBaoCao.Location = new System.Drawing.Point(118, 20);
            this.cbbLoaiBaoCao.Name = "cbbLoaiBaoCao";
            this.cbbLoaiBaoCao.Size = new System.Drawing.Size(157, 24);
            this.cbbLoaiBaoCao.TabIndex = 3;
            this.cbbLoaiBaoCao.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiBaoCao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại báo cáo:";
            // 
            // panelTieuChi
            // 
            this.panelTieuChi.Controls.Add(this.tcHoaDon);
            this.panelTieuChi.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTieuChi.Location = new System.Drawing.Point(303, 0);
            this.panelTieuChi.Name = "panelTieuChi";
            this.panelTieuChi.Size = new System.Drawing.Size(995, 150);
            this.panelTieuChi.TabIndex = 2;
            // 
            // tcHoaDon
            // 
            this.tcHoaDon.Controls.Add(this.button2);
            this.tcHoaDon.Controls.Add(this.btnLoc);
            this.tcHoaDon.Controls.Add(this.label9);
            this.tcHoaDon.Controls.Add(this.cbbTPValue);
            this.tcHoaDon.Controls.Add(this.label8);
            this.tcHoaDon.Controls.Add(this.cbbValue);
            this.tcHoaDon.Controls.Add(this.label7);
            this.tcHoaDon.Controls.Add(this.cbbThanhPhan);
            this.tcHoaDon.Controls.Add(this.dtpEnd);
            this.tcHoaDon.Controls.Add(this.label6);
            this.tcHoaDon.Controls.Add(this.dtpStart);
            this.tcHoaDon.Controls.Add(this.label5);
            this.tcHoaDon.Controls.Add(this.label4);
            this.tcHoaDon.Controls.Add(this.cbbTime);
            this.tcHoaDon.Controls.Add(this.label3);
            this.tcHoaDon.Controls.Add(this.cbbTrangThai);
            this.tcHoaDon.Controls.Add(this.label2);
            this.tcHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcHoaDon.Location = new System.Drawing.Point(0, 0);
            this.tcHoaDon.Name = "tcHoaDon";
            this.tcHoaDon.Size = new System.Drawing.Size(995, 150);
            this.tcHoaDon.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(823, 107);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(132, 35);
            this.btnLoc.TabIndex = 18;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "=";
            // 
            // cbbTPValue
            // 
            this.cbbTPValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTPValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTPValue.FormattingEnabled = true;
            this.cbbTPValue.Items.AddRange(new object[] {
            "Thời gian",
            "Giá trị",
            "Khách hàng",
            "Trạng thái",
            "Nhân viên",
            ""});
            this.cbbTPValue.Location = new System.Drawing.Point(366, 65);
            this.cbbTPValue.Name = "cbbTPValue";
            this.cbbTPValue.Size = new System.Drawing.Size(226, 24);
            this.cbbTPValue.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giá trị:";
            // 
            // cbbValue
            // 
            this.cbbValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbValue.FormattingEnabled = true;
            this.cbbValue.Items.AddRange(new object[] {
            "Tất cả",
            "Dưới 1 triệu",
            "Từ 1 triệu đến 5 triệu",
            "Trên 5 triệu"});
            this.cbbValue.Location = new System.Drawing.Point(713, 65);
            this.cbbValue.Name = "cbbValue";
            this.cbbValue.Size = new System.Drawing.Size(242, 24);
            this.cbbValue.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành phần:";
            // 
            // cbbThanhPhan
            // 
            this.cbbThanhPhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbThanhPhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbThanhPhan.FormattingEnabled = true;
            this.cbbThanhPhan.Items.AddRange(new object[] {
            "Tất cả",
            "Khách hàng",
            "Nhân viên",
            "Tên cây cảnh",
            "Loại cây cảnh"});
            this.cbbThanhPhan.Location = new System.Drawing.Point(185, 65);
            this.cbbThanhPhan.Name = "cbbThanhPhan";
            this.cbbThanhPhan.Size = new System.Drawing.Size(153, 24);
            this.cbbThanhPhan.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(859, 21);
            this.dtpEnd.MaxDate = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(96, 22);
            this.dtpEnd.TabIndex = 11;
            this.dtpEnd.Value = new System.DateTime(2023, 4, 20, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(820, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "đến:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(713, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(96, 22);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Từ ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khung thời gian:";
            // 
            // cbbTime
            // 
            this.cbbTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Items.AddRange(new object[] {
            "Tất cả",
            "1 ngày",
            "1 tuần",
            "1 tháng",
            "1 quý ",
            "1 năm"});
            this.cbbTime.Location = new System.Drawing.Point(481, 20);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(111, 24);
            this.cbbTime.TabIndex = 5;
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái:";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTrangThai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Chờ xử lý",
            "Đang giao",
            "Đã thanh toán",
            "Đã hủy"});
            this.cbbTrangThai.Location = new System.Drawing.Point(185, 20);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(153, 24);
            this.cbbTrangThai.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bộ lọc";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reportViewer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1298, 721);
            this.panel3.TabIndex = 1;
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1298, 721);
            this.reportViewer.TabIndex = 0;
            this.reportViewer.Load += new System.EventHandler(this.reportViewer_Load);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 871);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBaoCao_FormClosed);
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTieuChi.ResumeLayout(false);
            this.tcHoaDon.ResumeLayout(false);
            this.tcHoaDon.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbbLoaiBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTieuChi;
        private System.Windows.Forms.Panel tcHoaDon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTPValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbValue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbThanhPhan;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label2;
    }
}