using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyNhaSach_291021.View.Notification;
using System.IO;
using System.Text.RegularExpressions;

namespace QuanLyNhaSach_291021.View.Revenue
{
    public partial class ctrOverviewStatistics : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        DateTime dteFrom = new DateTime();
        DateTime dteTo = new DateTime();
        string mode = "";
        //defind variable
        #endregion

        #region //Contructor

        public ctrOverviewStatistics()
        {
            InitializeComponent();
            DateTime dtNow = DateTime.Now;
        }
        public ctrOverviewStatistics(DateTime dteFrom, DateTime dteTo, string mode):this()
        {
            this.dteTo = dteTo;
            this.dteFrom = dteFrom;
            this.mode = mode;
        }
        #endregion

        private void loadChart()
        {
            DateTime dtNow = DateTime.Now;
            //DateTime dtTo = DateTime.Now.AddMonths(-5);
            //dtTo = new DateTime(dtTo.Year, dtTo.Month, 1);
            string query = String.Format(@"select dt.*,v.Von from (select  hd.NgayBan, sum(hd.TongTien) as DoanhThu
                                            from (select distinct hd.TongTien, Cast(hd.NgayTao as date) as NgayBan from HoaDon as hd 
                                             join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                            where hd.HienThi = 1 and ct.HienThi = 1) as hd
                                             where hd.NgayBan  between '{0}' and '{1}'
                                            group by hd.NgayBan) as dt
                                            join 
                                            (select sum(t.SoLuong*t.GiaNhap)as Von,  t.NgayBan  from (
                                            select sum(hd.SoLuong) as SoLuong, NgayBan , hd.SKU, ctpn.GiaNhap,   ROW_NUMBER() OVER (PARTITION BY hd.SKU ORDER BY ctpn.NgayNhap desc) AS RowNumber
                                            from (select distinct ct.SKU, ct.SoLuong, Cast(hd.NgayTao as date) as NgayBan from HoaDon as hd 
                                             join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                            where hd.HienThi = 1 and ct.HienThi = 1) as hd
                                            inner join 
                                            (select ct.SKU,ct.GiaNhap, pn.NgayTao as NgayNhap from PhieuNhap as pn join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN) as ctpn on hd.SKU = ctpn.SKU 
                                             where NgayBan between '{0}' and '{1}'
                                            group by NgayBan, hd.SKU, ctpn.GiaNhap, ctpn.NgayNhap) as t where t.RowNumber = 1
                                            group by t.NgayBan) as v on dt.NgayBan =v.NgayBan; ", func.DateTimeToString((DateTime)dteFrom), func.DateTimeToString((DateTime)dteTo));

          
            DataTable dtChart = new DataTable();
            dtChart = conn.loadData(query);
         
            DateTime date;
            int dteDiff = func.DurationBetween2Date((DateTime)dteFrom, (DateTime)dteTo);
            refreshChart();
            for (int i = dteDiff; i >= 0; i--)
            {
                date = DateTime.Now.AddDays(-i).Date;
                //int maxPoint = Convert.ToInt32(dtChart.AsEnumerable().OrderByDescending(x => x.Field<int>("TongNhap")).First());
                //return false if it exists record

                if (dtChart.AsEnumerable().Any(x => x.Field<DateTime>("NgayBan").Date == date.Date))
                {
                    DataRow drChart = getRow(dtChart, "NgayBan", date);
                    // DataRow drCapital = getRow(dtChart.Tables[1], "NgayNhap", date);
                    if (drChart != null)
                    {
                        decimal dSale = (decimal)drChart["DoanhThu"];
                        chartOverview.Series["Doanh Thu"].Points.Add((double)dSale);
                        chartOverview.Series["Doanh Thu"].Points[dteDiff - i].AxisLabel = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                        chartOverview.Series["Doanh Thu"].Points[dteDiff - i].LegendText = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                        chartOverview.Series["Doanh Thu"].Points[dteDiff - i].Label = drChart["DoanhThu"].ToString();
                        decimal dCapital = (decimal)drChart["Von"];
                        chartOverview.Series["Vốn"].Points.Add((double)dCapital);
                        chartOverview.Series["Vốn"].Points[dteDiff - i].Label = drChart["Von"].ToString();

                    }
                }
                else
                {
                    chartOverview.Series["Doanh Thu"].Points.Add(1);
                    chartOverview.Series["Doanh Thu"].Points[dteDiff - i].AxisLabel = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                    chartOverview.Series["Doanh Thu"].Points[dteDiff - i].LegendText = Convert.ToDateTime(date).ToString("dd-MM-yyyy");
                    chartOverview.Series["Doanh Thu"].Points[dteDiff - i].Label = "0";

                    chartOverview.Series["Vốn"].Points.Add(1);
                    chartOverview.Series["Vốn"].Points[dteDiff - i].Label = "0";
                }
            }
            
        }

        private void refreshChart()
        {
            foreach (var series in chartOverview.Series)
            {
                series.Points.Clear();
            }
        }

        private DataRow getRow(DataTable dataTable, string field, DateTime date)
        {
            foreach (DataRow dr in dataTable.Rows) // search whole table
            {
                if ((DateTime)dr[field] == date)
                {
                    return dr;
                }
            }
            return null;
        }

        private void ctrOverviewStatistics_Load(object sender, EventArgs e)
        {
            lbDateFrom.Text = Convert.ToDateTime(dteFrom).ToString("dd-MM-yyyy");
            lbDateTo.Text = Convert.ToDateTime(dteTo).ToString("dd-MM-yyyy");
            loadChart();
        }
    }
}
