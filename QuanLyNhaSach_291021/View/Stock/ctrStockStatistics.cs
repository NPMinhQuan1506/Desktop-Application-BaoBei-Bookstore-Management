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

namespace QuanLyNhaSach_291021.View.Stock
{
    public partial class ctrStockStatistics : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string query = "";
        string emptyGridText = "Không có dữ liệu";
        DataTable dtContent;
        //defind variable search and filter

        //defind generate instance   

        //private static ctrStockStatistics _instance;

        //public static ctrStockStatistics instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ctrStockStatistics();
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        #region //Contructor

        public ctrStockStatistics()
        {
            InitializeComponent();
            DataTable dtContent = new DataTable();
            DateTime dtNow = DateTime.Now;
            dteTo.EditValue = dtNow.Date;
            dtNow = dtNow.AddMonths(-1);
            dteFrom.EditValue = dtNow.Date;
        }

        #endregion

        #region //Setup GridView
        private void gvStock_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                if (e.RowHandle > -1)
                {
                    e.DisplayText = Convert.ToString(e.RowHandle + 1);

                }
            }


        }

        private void gvStock_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "Product")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }

            if (e.Column.Name == "StockAmount")
            {
                if (e.RowHandle >= 0)
                {
                    if ((int)dtContent.Rows[e.RowHandle]["HieuSoTon"] < 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(122, 16, 16);
                        e.Appearance.ForeColor = Color.FromArgb(255, 239, 239);
                    }
                }
            }
        }

        private void gvStock_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {

            Rectangle emptyGridTextBounds;
            int offsetFromTop = 10;
            e.DefaultDraw();
            Size size = e.Appearance.CalcTextSize(e.Cache, emptyGridText, e.Bounds.Width).ToSize();
            int x = (e.Bounds.Width - size.Width) / 2;
            int y = e.Bounds.Y + offsetFromTop;
            emptyGridTextBounds = new Rectangle(new Point(x, y), size);
            e.Appearance.DrawString(e.Cache, emptyGridText, emptyGridTextBounds, Brushes.Gray);
        }
        #endregion

        #region //LoadData
        private void gcStock_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            query = String.Format(@"select *, ABS(SoLuongNhap - SoLuongBan - SoLuongTon) as SoLuongChenhLech 
                                        from (
                                                select 
                                                        CASE
						                                    WHEN sum(ctn.SoLuong) IS NULL THEN 0
						                                    ELSE sum(ctn.SoLuong)
					                                    END AS SoLuongNhap,  
					                                    CASE
						                                    WHEN sum(ctb.SoLuong) IS NULL THEN 0
						                                    ELSE sum(ctb.SoLuong)
					                                    END AS SoLuongBan, 
				                                        sp.TenSP,sum(sp.SoLuongTon) as SoLuongTon,
	                                                    sp.SoLuongTon - sp.TonToiThieu as HieuSoTon , 
	                                                    ROW_NUMBER() OVER (order by sp.SoLuongTon - sp.TonToiThieu ) AS RowNum 
                                                    from SanPham as sp
                                                    left join (select ct.SKU, pn.NgayTao, ct.SoLuong from PhieuNhap as pn 
                                                                                                     join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN 
                                                                                                     where pn.HienThi = 1 and ct.HienThi = 1) as ctn on sp.SKU = ctn.SKU
                                                    left join (select ct.SKU, hd.NgayTao, ct.SoLuong from HoaDon as hd 
                                                                                                     join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                                                                     where hd.HienThi = 1 and ct.HienThi = 1) as ctb on sp.SKU = ctb.SKU

                                                    where (ctn.NgayTao between '{0}' and '{1}' or  ctb.NgayTao between '{0}' and '{1}')
                                       group by ctn.SKU, sp.TenSP, sp.SoLuongTon,sp.TonToiThieu, ctb.SKU)as s ",
                    func.DateTimeToString((DateTime)dteFrom.EditValue),
                    func.DateTimeToString((DateTime)dteTo.EditValue));
            dtContent = conn.loadData(query);
            gcStock.DataSource = dtContent;
        }

        private void loadData(string _query)
        {
            dtContent = conn.loadData(_query);
            gcStock.DataSource = dtContent;
        }
        #endregion

        #region //Filter
        private void filterStatistic()
        {
            string filterOption = cbbField.Text;
            string filter_query = "";
            switch (filterOption)
            {
                case "Tất Cả Sản Phẩm":
                    loadData();
                    break;
                case "Sản Phẩm Cần Nhập":
                    filter_query = query + " where HieuSoTon < 0";
                    loadData(filter_query);
                    break;
                case "Top 10 Tồn Nhiều Nhất":
                    filter_query = query+ " where RowNum between 1 and 10 order by SoLuongTon desc";
                    loadData(filter_query);
                    break;
                case "Top 10 Bán Nhiều Nhất":
                    filter_query = query + " where RowNum between 1 and 10 order by SoLuongBan desc";
                    loadData(filter_query);
                    break;
                case "Top 10 Bán Ít Nhất":
                    filter_query = query + " where RowNum between 1 and 10 order by SoLuongBan asc";
                    loadData(filter_query);
                    break;
            }
        }

        private void cbbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStatistic();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            filterStatistic();
        }
        #endregion

        #region //Load Data
        private void ctrStockStatistics_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        private void loadChart()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtTo = DateTime.Now.AddMonths(-5);
            dtTo = new DateTime(dtTo.Year, dtTo.Month, 1);
            string query_chart = String.Format(@"select sum(SoLuongNhap) as TongNhap, sum(SoLuongBan) as TongBan, sum(SoLuongTon) as TongTon, 
                        CASE
						    WHEN NgayNhap IS NULL THEN 0
						    ELSE NgayNhap
					    END AS NgayNhap,
                        CASE
						    WHEN NgayBan IS NULL THEN 0
						    ELSE NgayBan
					    END AS NgayBan from (
                                            select	CASE
						                                WHEN sum(ctn.SoLuong) IS NULL THEN 0
						                                ELSE sum(ctn.SoLuong)
					                                END AS SoLuongNhap,  
					                                CASE
						                                WHEN sum(ctb.SoLuong) IS NULL THEN 0
						                                ELSE sum(ctb.SoLuong)
					                                END AS SoLuongBan, sum(sp.SoLuongTon) as SoLuongTon,  MONTH(ctn.NgayTao) as NgayNhap, MONTH(ctb.NgayTao) as NgayBan
                                            from SanPham as sp
                                            left join (select ct.SKU, pn.NgayTao, ct.SoLuong from PhieuNhap as pn 
                                                                                             join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN 
                                                                                             where pn.HienThi = 1 and ct.HienThi = 1) as ctn 
                                            on sp.SKU = ctn.SKU
                                            left join (select ct.SKU, hd.NgayTao, ct.SoLuong from HoaDon as hd 
                                                                                             join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                                                             where hd.HienThi = 1 and ct.HienThi = 1) as ctb 
                                            on sp.SKU = ctb.SKU

                                            where (ctn.NgayTao between '{0}' and GETDATE() or ctb.NgayTao between '{0}' and GETDATE())
                                            group by sp.TenSP, sp.SoLuongTon,sp.TonToiThieu,  MONTH(ctn.NgayTao) ,  MONTH(ctb.NgayTao)
                                                )as s group by NgayNhap , NgayBan", func.DateTimeToString((DateTime)dtTo));
            DataTable dtChart = new DataTable();
            dtChart = conn.loadData(query_chart);
            int month = 0;
            for (int i = 5; i >= 0; i--)
            {
                month = DateTime.Now.AddMonths(-i).Month;
                //int maxPoint = Convert.ToInt32(dtChart.AsEnumerable().OrderByDescending(x => x.Field<int>("TongNhap")).First());
                //return false if it exists record
                if (dtChart.AsEnumerable().Any(x => x.Field<int>("NgayNhap") == month) || dtChart.AsEnumerable().Any(x => x.Field<int>("NgayBan") == month))
                {
                    DataRow dr = getRow(dtChart, month);
                    if(dr != null)
                    {
                        chartStock.Series["Số Lượng Bán"].Points.Add((int)dr["TongBan"]);
                        chartStock.Series["Số Lượng Bán"].Points[5-i].AxisLabel = "Thang " + month.ToString();
                        chartStock.Series["Số Lượng Bán"].Points[5 - i].LegendText = "Thang " + month.ToString();
                        chartStock.Series["Số Lượng Bán"].Points[5 - i].Label = dr["TongBan"].ToString();

                        chartStock.Series["Số Lượng Nhập"].Points.Add((int)dr["TongNhap"]);
                        chartStock.Series["Số Lượng Nhập"].Points[5 - i].Label = dr["TongNhap"].ToString();

                        chartStock.Series["Số Lượng Tồn"].Points.Add((int)dr["TongTon"]);
                        chartStock.Series["Số Lượng Tồn"].Points[5 - i].Label = dr["TongTon"].ToString();
                    }
                }
                else
                {
                    chartStock.Series["Số Lượng Bán"].Points.Add(1);
                    chartStock.Series["Số Lượng Bán"].Points[5 - i].AxisLabel = "Thang " + month.ToString();
                    chartStock.Series["Số Lượng Bán"].Points[5 - i].LegendText = "Thang " + month.ToString();
                    chartStock.Series["Số Lượng Bán"].Points[5 - i].Label = "0";

                    chartStock.Series["Số Lượng Nhập"].Points.Add(1);
                    chartStock.Series["Số Lượng Nhập"].Points[5 - i].Label = "0";

                    chartStock.Series["Số Lượng Tồn"].Points.Add(1);
                    chartStock.Series["Số Lượng Tồn"].Points[5 - i].Label = "0";
                }
            }
        }

        private DataRow getRow(DataTable dataTable, int month)
        {
            foreach (DataRow dr in dataTable.Rows) // search whole table
            {
                if ((int)dr["NgayNhap"] == month || (int)dr["NgayBan"] == month)
                {
                    return dr;
                }
            }
            return null;
        }
        #endregion

        #region //Setup min value date edit
        private void dteFrom_EditValueChanged(object sender, EventArgs e)
        {
            dteTo.Properties.MinValue = (DateTime)dteFrom.EditValue;
        }
        #endregion
    }
}
