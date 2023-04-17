
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
        public FormBaoCao()
        {
            InitializeComponent();
        }
        

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            cbbLoaiBaoCao.SelectedIndex = 0;
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
            DataTable dt = new DataTable();
            string path = "";
            switch (cbbLoaiBaoCao.Text)
            {
                case "Cây cảnh": dt = Data.GetDataToTable("Select * from CayCanh");
                    path = "D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\Reports\\RPCayCanh.rpt";
                    break;  
                case "Loại cây cảnh": dt = Data.GetDataToTable("Select * from LoaiCay");
                    path = "D:\\CDUD\\chuyendeungdung\\BanHangCayCanh\\BanHangCayCanh\\Reports\\RPLoaiCayCanh.rpt"; break;
            }
            LoadReport(dt, path);
        }
    }
}
