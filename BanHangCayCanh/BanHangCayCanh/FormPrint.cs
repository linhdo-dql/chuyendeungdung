using CrystalDecisions.CrystalReports.Engine;
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
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        public FormPrint(string idHoaDon)
        {
            InitializeComponent();
            LoadCrystalReport(idHoaDon);
        }

        private void LoadCrystalReport(string idHoaDon)
        {
            ReportDocument report = new ReportDocument();
            report.Load("D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\Reports\\HoaDonBanHang.rpt");
            string sql = "Select HoaDon.idHoaDon, HoaDon.chietKhau, HoaDon.tongTien, HoaDon.ngayLap, NhanVien.tenNV, KhachHang.tenKH, KhachHang.sdtKH, KhachHang.diaChiKH, ChiTietHoaDon.soLuong, ChiTietHoaDon.donGia, CayCanh.tenCay " +
                "from HoaDon " +
                "inner join NhanVien on HoaDon.idNhanVien = NhanVien.idNhanVien " +
                "inner join KhachHang on HoaDon.idKH = KhachHang.idKH " +
                "inner join ChiTietHoaDon on HoaDon.idHoaDon = ChiTietHoaDon.idHoaDon " +
                "inner join CayCanh on ChiTietHoaDon.idCayCanh = CayCanh.idCayCanh " +
                "where HoaDon.idHoaDon like N'" + idHoaDon +"'";
            DataSet ds = new DataSet();
            ds.Tables.Add(Data.GetDataToTable(sql));
            report.SetDataSource(ds.Tables[0]);
            crv.ReportSource = report;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void FormPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormBanHang().Show();
        }
    }
}
