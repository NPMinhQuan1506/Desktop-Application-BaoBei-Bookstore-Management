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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Timers;

namespace QuanLyNhaSach_291021.View.Dashboard
{
    public partial class ctrDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string query = "";
        string emptyGridText = "Không có dữ liệu";

        //defind datatable
        DataTable dtMaster = new DataTable();
        DataTable dtDetail = new DataTable();
        //defind variable search and filter

        //defind generate instance   

        //private static ctrDashboard _instance;

        //public static ctrDashboard instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ctrDashboard();
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        #region //Contructor

        public ctrDashboard()
        {
            InitializeComponent();
            DataTable dtContent = new DataTable();
        }

        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvOrder_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column == NO)
            {
                if (e.RowHandle > -1)
                {
                    e.DisplayText = Convert.ToString(e.RowHandle + 1);
                }
            }
        }

        //Setup Text Align For Grid Column
        private void gvOrder_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "OrderName")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }

        //Setup notify text when grid is nullable data
        private void gvOrder_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        #region //Read

        private void gcOrder_Load(object sender, EventArgs e)
        {
            loadData();
            gvOrder.DataController.AllowIEnumerableDetails = true;
        }

        private void loadData()
        {
            //loadData Master
            query = @"Select Top 10 hd.MaHD, KH.TenKH as KhachHang, nv.TenNV as NhanVien, hd.TongTien, GiamGia, hd.GhiChu, hd.NgayTao, hd.NgayCapNhat
                            from HoaDon as hd
                            inner join KhachHang as KH on hd.MaKH = KH.MaKH
                            inner join NhanVien as nv on hd.MaNV = nv.MaNV
                            where hd.HienThi = 1 and Cast( hd.NgayTao as Date) = Cast(GetDate() as Date)";

            dtMaster = conn.loadData(query + "order by hd.NgayTao ASC");
            //loadDataDetail
            string query1 = @"select ct.MaHD, sp.TenSP as SanPham, ct.SoLuong, ct.GiaBan, GiamGia, ct.SKU from ChiTietHoaDon as ct
                                    inner join SanPham as sp on ct.SKU = sp.SKU
                                    where ct.HienThi = 1";
            dtDetail = conn.loadData(query1);
            gcOrder.DataSource = dtMaster;
        }

        private void loadData(string _query)
        {
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(_query);
            gcOrder.DataSource = dtContent;
        }

        // If Master don't have Detail, a plus is enable
        private void gvOrder_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (gvOrder.GetRowCellValue(e.RowHandle, OrderID) != null)
            {
                string ID = gvOrder.GetRowCellValue(e.RowHandle, OrderID).ToString();
                e.IsEmpty = !dtDetail.AsEnumerable().Any(x => x.Field<string>("MaHD") == ID);
            }
        }

        //LoadData Detail
        private void gvOrder_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            if (gvOrder.GetRowCellValue(e.RowHandle, OrderID) != null)
            {
                string ID = gvOrder.GetRowCellValue(e.RowHandle, OrderID).ToString();
                e.ChildList = GetBatchFromItem(ID);
                gvDetail.ViewCaption = "Chi Tiết Hóa Đơn " + ID;
            }
        }

        DataView GetBatchFromItem(string ID)
        {
            DataView dv = new DataView(dtDetail);
            dv.RowFilter = String.Format(@"[MaHD] = '{0}'", ID);
            return dv;
        }

        //Set 1: Detail
        private void gvOrder_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        //Set Relationship
        private void gvOrder_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        #endregion

        #region //Get Id
        private string getID(string fieldName)
        {
            string ID = "";
            var view = gcOrder.FocusedView as GridView;
            if (view.GetFocusedRowCellValue(fieldName) != null)
            {
                ID = view.GetFocusedRowCellValue(fieldName).ToString();
            }
            return ID;
        }
        #endregion

        #region //Load Data Header
        private void loadDataHeader()
        {
            //loadData Master
            query = @"select dt.*, (dt.DoanhThu - v.Von) as LoiNhuan, kh.TongKH, el.TongNV from (select  hd.NgayBan, sum(hd.TongTien) as DoanhThu
                                                    from (select distinct hd.TongTien, Cast(hd.NgayTao as date) as NgayBan from HoaDon as hd 
                                                     join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                    where hd.HienThi = 1 and ct.HienThi = 1 ) as hd
                                                     where Cast( hd.NgayBan as Date) = Cast(GetDate() as Date)
                                                    group by hd.NgayBan) as dt
                                                    join 
                                                    (select sum(t.SoLuong*t.GiaNhap)as Von,  t.NgayBan  from (
                                                    select sum(hd.SoLuong) as SoLuong, NgayBan , hd.SKU, ctpn.GiaNhap,   ROW_NUMBER() OVER (PARTITION BY hd.SKU ORDER BY ctpn.NgayNhap desc) AS RowNumber
                                                    from (select distinct ct.SKU, ct.SoLuong, Cast(hd.NgayTao as date) as NgayBan from HoaDon as hd 
                                                     join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                    where hd.HienThi = 1 and ct.HienThi = 1) as hd
                                                    inner join 
                                                    (select ct.SKU,ct.GiaNhap, pn.NgayTao as NgayNhap from PhieuNhap as pn join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN) as ctpn on hd.SKU = ctpn.SKU 
                                                     where Cast( hd.NgayBan as Date) = Cast(GetDate() as Date)
                                                    group by NgayBan, hd.SKU, ctpn.GiaNhap, ctpn.NgayNhap) as t where t.RowNumber = 1
                                                    group by t.NgayBan) as v on dt.NgayBan =v.NgayBan
													join
													(select sum(hd.MaKH) as TongKH, Cast( hd.NgayTao as Date) as NgayTao from (select count(hd.MaKH) as MaKH, Cast( hd.NgayTao as Date) as NgayTao
                                                                                                                                from HoaDon as hd where Cast( hd.NgayTao as Date) = Cast(GetDate() as Date) group by Cast( hd.NgayTao as Date)) as hd 
                                                    group by hd.NgayTao) as kh on dt.NgayBan = kh.NgayTao 
													join
													(select sum(el.MaNV) as TongNV, Cast( el.ThoiGianDangNhap as Date) as ThoiGianDangNhap from (select count(el.MaNV) as MaNV, Cast( el.ThoiGianDangNhap as Date) as ThoiGianDangNhap
                                                                                                                                                from [Employee_log] as el where Cast( el.ThoiGianDangNhap as Date) = Cast(GetDate() as Date) and el.TrangThai = 1 group by Cast( el.ThoiGianDangNhap as Date)) as el 
                                                    group by el.ThoiGianDangNhap ) as el  on dt.NgayBan = el.ThoiGianDangNhap";

            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                lbSale.Text = ((decimal)dtContent.Rows[0]["DoanhThu"]).ToString("n0") + " VNĐ";
                lbRevenue.Text = ((decimal)dtContent.Rows[0]["LoiNhuan"]).ToString("n0") + " VNĐ";
                lbCustomer.Text = (dtContent.Rows[0]["TongKH"]).ToString() + " Khách Hàng";
                lbEmployee.Text = (dtContent.Rows[0]["TongNV"]).ToString() + " Nhân Viên";
            }
        }
        #endregion

        #region //Load Data Chart
        private void ctrDashboard_Load(object sender, EventArgs e)
        {
            loadDataHeader();
            loadChart();
            initTimer();
        }
        private void loadChart()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtTo = dtNow.AddHours(-5);
            dtTo = new DateTime(dtTo.Year, dtTo.Month, dtTo.Day, dtTo.Hour, 0,0);
            string query_chart = String.Format(@"select sum(SoLuongBan) as TongBan,thd.TongHD,
                        CASE
						    WHEN s.GioBan IS NULL THEN -1
						    ELSE s.GioBan
					    END AS GioBan from (
                                            select	
					                                CASE
						                                WHEN sum(ctb.SoLuong) IS NULL THEN 0
						                                ELSE sum(ctb.SoLuong)
					                                END AS SoLuongBan,  DATEPART(HOUR, ctb.NgayTao) as GioBan
                                            from SanPham as sp
                      
                                            left join (select ct.SKU, hd.NgayTao, ct.SoLuong from HoaDon as hd 
                                                                                             join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                                                             where hd.HienThi = 1 and ct.HienThi = 1) as ctb 
                                            on sp.SKU = ctb.SKU

                                            where (  ctb.NgayTao between '{0}' and GetDate())
                                            group by sp.TenSP, DATEPART(HOUR, ctb.NgayTao)
                                                )as s  
								join (select sum(hd.MaHD) as TongHD, DATEPART(HOUR, hd.NgayTao) as GioBan
										from (select count(hd.MaHD) as MaHD, hd.NgayTao from HoaDon as hd 
														inner join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD
														where hd.NgayTao between '{0}' and GetDate() group by hd.NgayTao) as hd 
											 group by hd.NgayTao) as thd on s.GioBan = thd.GioBan
						group by s.GioBan, thd.TongHD", func.DateTimeToString((DateTime)dtTo));
            DataTable dtChart = new DataTable();
            dtChart = conn.loadData(query_chart);
            int hour = 0;
            refreshChart();
            for (int i = 5; i >= 0; i--)
            {
                hour = DateTime.Now.AddHours(-i).Hour;
                //int maxPoint = Convert.ToInt32(dtChart.AsEnumerable().OrderByDescending(x => x.Field<int>("TongNhap")).First());
                //return false if it exists record
                if (dtChart.AsEnumerable().Any(x => x.Field<int>("GioBan") == hour))
                {
                    DataRow dr = getRow(dtChart, hour);
                    if (dr != null)
                    {
                        chartDashboard.Series["Số Lượng Hóa Đơn"].Points.Add((int)dr["TongHD"]);
                        chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].AxisLabel =  hour.ToString() + " Giờ ";
                        chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].LegendText = hour.ToString() + " Giờ ";
                        chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].Label = dr["TongHD"].ToString();

                        chartDashboard.Series["Tổng Sản Phẩm"].Points.Add((int)dr["TongBan"]);
                        chartDashboard.Series["Tổng Sản Phẩm"].Points[5 - i].Label = dr["TongBan"].ToString();
                    }
                }
                else
                {
                    chartDashboard.Series["Số Lượng Hóa Đơn"].Points.Add(0);
                    chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].AxisLabel = hour.ToString() + " Giờ ";
                    chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].LegendText = hour.ToString() + " Giờ ";
                    chartDashboard.Series["Số Lượng Hóa Đơn"].Points[5 - i].Label = "0";

                    chartDashboard.Series["Tổng Sản Phẩm"].Points.Add(0);
                    chartDashboard.Series["Tổng Sản Phẩm"].Points[5 - i].Label = "0";
                }
            }
        }

        private DataRow getRow(DataTable dataTable, int hour)
        {
            foreach (DataRow dr in dataTable.Rows) // search whole table
            {
                if ((int)dr["GioBan"] == hour)
                {
                    return dr;
                }
            }
            return null;
        }


        private void refreshChart()
        {
            foreach (var series in chartDashboard.Series)
            {
                series.Points.Clear();
            }
        }
        #endregion

        #region Interval Load

        private void initTimer()
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;//5 minutes
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshMyForm();
        }

        private void RefreshMyForm()
        {
            loadDataHeader();
            loadChart();
        }
        #endregion
    }
}
