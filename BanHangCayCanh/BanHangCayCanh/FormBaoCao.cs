
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormBaoCao : Form
    {   
        private int _index = 0;
        DataTable dt = new DataTable();
       
        public FormBaoCao()
        {
            InitializeComponent();
        }

        public FormBaoCao(int index)
        {
            InitializeComponent();
            _index = index;
            if(index == 1)
            {
                LoadPanelTieuChi();
            }
        }

        private void LoadPanelTieuChi()
        {
            panelTieuChi.Visible = true;
            cbbTrangThai.SelectedIndex = 0;
            cbbTime.SelectedIndex = 0;
            cbbTPValue.Text = "";
            cbbValue.SelectedIndex = 0;
            cbbThanhPhan.SelectedIndex = 0;
            dtpStart.MinDate = DateTime.Parse("1/1/1999");
            dtpStart.MaxDate = DateTime.Now.AddMinutes(1);
            dtpStart.Value = DateTime.Now;
            dtpEnd.MinDate = DateTime.Parse("1/1/1999");
            dtpEnd.MaxDate = DateTime.Now.AddMinutes(1);
            dtpEnd.Value = DateTime.Now;
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {   
            cbbLoaiBaoCao.SelectedIndex = _index;
        }

        private void LoadReport(DataTable dt, string reportPath)
        {
            ReportDocument report = new ReportDocument();
            
            
            try
            {
                // Load the report file into the ReportDocument object
                report.Load(reportPath);
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            report.SetDataSource(ds.Tables[0]);
            string tenNV = Data.GetPropertiesById("NhanVien", "idNhanVien", ConfigurationManager.AppSettings["AccountSaved"].ToString()).Rows[0]["tenNV"].ToString();
            report.SetParameterValue("nguoiLap", tenNV);
            report.SetParameterValue("ngayLap", "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy"));
            reportViewer.ReportSource = report;
            reportViewer.Refresh();
        }


        private void FormBaoCao_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void cbbLoaiBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = "D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\Reports\\";
            panelTieuChi.Visible = false;
            switch (cbbLoaiBaoCao.Text)
            {
                case "Cây cảnh": 
                    dt = Data.GetDataToTable("Select * from CayCanh");
                    path += "RPCayCanh.rpt";
                    break;
                case "Hóa đơn":
                    LoadPanelTieuChi();
                    dt = Data.GetDataToTable("Select * from HoaDon");
                    path += "RPHoaDon.rpt";
                    break;
                case "Khách hàng":
                    dt = Data.GetDataToTable("Select * from KhachHang");
                    path += "RPKhachHang.rpt";
                    break;
                case "Nhân viên":
                    dt = Data.GetDataToTable("Select * from NhanVien");
                    path += "RPNhanVien.rpt";
                    break;
                case "Loại cây cảnh": 
                    dt = Data.GetDataToTable("Select * from LoaiCay");
                    path += "RPLoaiCayCanh.rpt"; 
                    break;
            }
            LoadReport(dt, path);
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            reportViewer.Zoom(75);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string path = "D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\Reports\\";
            string sql = "Select DISTINCT hd.idHoaDon, hd.idKH, hd.idNhanVien, hd.ngayLap, hd.tongTien, hd.trangThai, hd.chietKhau from HoaDon hd INNER JOIN ChiTietHoaDon cthd ON hd.idHoaDon = cthd.idHoaDon " +
                "INNER JOIN CayCanh cc ON cc.idCayCanh = cthd.idCayCanh " +
                "INNER JOIN LoaiCay lcc ON cc.idLoaiCay = lcc.idLoaiCay where ";
            if(cbbTrangThai.SelectedIndex!=0)
            {
                sql += "hd.trangThai like N'" + cbbTrangThai.Text + "'";
            }
            if (cbbTime.SelectedIndex != 0)
            {
                if(cbbTrangThai.SelectedIndex!=0)
                {
                    sql += "and ";
                } 
                sql += "hd.ngayLap between '" + dtpStart.Value + "' and '" + dtpEnd.Value + "'";
            }
            if (cbbThanhPhan.SelectedIndex != 0)
            {   
                if(cbbTrangThai.SelectedIndex !=0 || cbbTime.SelectedIndex !=0)
                {
                    sql += "and ";
                }
                switch (cbbThanhPhan.Text)
                {
                    case "Khách hàng":
                        sql += "hd.idKH like N'" + cbbTPValue.SelectedValue.ToString() + "'";
                        break;
                    case "Nhân viên":
                        sql += "hd.idNhanVien like N'" + cbbTPValue.SelectedValue.ToString() + "'";
                        break;
                    case "Cây cảnh":
                        sql += "cc.idCayCanh like N'" + cbbTPValue.SelectedValue.ToString() + "'";
                        break;
                    case "Loại cây cảnh":
                        sql += "lcc.idLoaiCayCanh N'" + cbbTPValue.SelectedValue.ToString() + "'";
                        break;
                }
            }
            if(cbbValue.SelectedIndex!=0)
            {

            }
            if (cbbTrangThai.SelectedIndex == 0 && cbbTime.SelectedIndex == 0 && cbbThanhPhan.SelectedIndex == 0)
            {
                // Chưa chọn điều kiện nào, hiển thị toàn bộ hóa đơn
                sql = "SELECT DISTINCT hd.idHoaDon, hd.idKH, hd.idNhanVien, hd.ngayLap, hd.tongTien, hd.trangThai, hd.chietKhau FROM HoaDon hd";
            }
            dt = Data.GetDataToTable(sql);
            path += "RPHoaDon.rpt";
            LoadReport(dt, path);
            
            
        }

        private void cbbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            switch (cbbTime.SelectedIndex)
            {
                case 0:
                    dtpEnd.MinDate = DateTime.Parse("1/1/1999");
                    dtpEnd.MaxDate = DateTime.Now.AddMinutes(1);
                    dtpEnd.Value = DateTime.Now;
                    break;
                case 1:
                    dtpEnd.MinDate = dtpStart.Value;
                    dtpEnd.MaxDate = dtpStart.Value.AddDays(1) < DateTime.Now ? dtpStart.Value.AddDays(1) : DateTime.Now.AddMinutes(1);
                    dtpEnd.Value = dtpEnd.MaxDate;
                    break;
                case 2:
                    dtpEnd.MinDate = dtpStart.Value;
                    dtpEnd.MaxDate = dtpStart.Value.AddDays(7) < DateTime.Now ? dtpStart.Value.AddDays(7) : DateTime.Now.AddMinutes(1); ;
                    break;
                case 3:
                    dtpEnd.MinDate = dtpStart.Value;
                    dtpEnd.MaxDate = dtpStart.Value.AddMonths(1) < DateTime.Now ? dtpStart.Value.AddMonths(1) : DateTime.Now.AddMinutes(1);
                    break;
                case 4:
                    dtpEnd.MinDate = dtpStart.Value;
                    dtpEnd.MaxDate = dtpStart.Value.AddMonths(3) < DateTime.Now ? dtpStart.Value.AddMonths(3) : DateTime.Now.AddMinutes(1);
                    break;
                case 5:
                    dtpEnd.MinDate = dtpStart.Value;
                    dtpEnd.MaxDate = dtpStart.Value.AddYears(1) < DateTime.Now ? dtpStart.Value.AddYears(1) : DateTime.Now.AddMinutes(1);
                    break;
            }
        }
    }
}
