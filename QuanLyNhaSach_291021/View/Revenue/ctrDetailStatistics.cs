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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Office.Utils;
using DevExpress.XtraPrinting;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;

namespace QuanLyNhaSach_291021.View.Revenue
{
    public partial class ctrDetailStatistics: DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string emptyGridText = "Không có dữ liệu";
        DateTime dteFrom = new DateTime();
        DateTime dteTo = new DateTime();
        string mode = "";
        //defind datatable
        DataTable dtMaster = new DataTable();
        DataTable dtDetail = new DataTable();
        #endregion

        #region //Contructor

        public ctrDetailStatistics()
        {
            InitializeComponent();
        }

        public ctrDetailStatistics(DateTime dteFrom, DateTime dteTo, string mode) :this()
        {
            this.dteTo = dteTo;
            this.dteFrom = dteFrom;
            this.mode = mode;
            lbDateFrom.Text = Convert.ToDateTime(dteFrom).ToString("dd-MM-yyyy");
            lbDateTo.Text = Convert.ToDateTime(dteTo).ToString("dd-MM-yyyy");
        }
        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvRevenue_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        private void gvRevenue_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }
        }

        //Setup notify text when grid is nullable data
        private void gvRevenue_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gcRevenue_Load(object sender, EventArgs e)
        {
            loadData();
            gvRevenue.DataController.AllowIEnumerableDetails = true;
        }

        private void loadData()
        {
            //loadData Master
            string query = String.Format(@"select dt.*,v.Von, dt.DoanhThu as BanHang, (dt.DoanhThu - v.Von) as LoiNhuan, ROUND(Abs(((dt.DoanhThu - v.Von)/dt.DoanhThu)*100),2) as PhanTramLoiNhuan from (select  hd.NgayBan, sum(hd.TongTien) as DoanhThu
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

            dtMaster = conn.loadData(query);
            //loadDataDetail
            string query1 = String.Format(@"select dt.*,v.Von, (dt.TongTien - v.Von) as LoiNhuan
                                                    from (select  hd.NgayBan, sum(hd.TongTien) as TongTien, hd.MaHD, hd.GiamGia
                                                    from (select distinct hd.TongTien, Cast(hd.NgayTao as date) as NgayBan, hd.MaHD, hd.GiamGia from HoaDon as hd 
                                                     join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                    where hd.HienThi = 1 and ct.HienThi = 1) as hd
                                                     where hd.NgayBan  between '{0}' and '{1}'
                                                    group by hd.NgayBan, hd.MaHD, hd.GiamGia) as dt
                                                    join 
                                                    (select sum(t.SoLuong*t.GiaNhap)as Von,  t.NgayBan,t.MaHD  from (
                                                    select sum(hd.SoLuong) as SoLuong, NgayBan , hd.SKU, hd.MaHD, ctpn.GiaNhap,   ROW_NUMBER() OVER (PARTITION BY hd.SKU, hd.MaHD ORDER BY ctpn.NgayNhap desc) AS RowNumber
                                                    from (select distinct ct.SKU, ct.SoLuong, Cast(hd.NgayTao as date) as NgayBan, hd.MaHD from HoaDon as hd 
                                                     join ChiTietHoaDon as ct on hd.MaHD = ct.MaHD 
                                                    where hd.HienThi = 1 and ct.HienThi = 1) as hd
                                                    inner join 
                                                    (select ct.SKU,ct.GiaNhap, pn.NgayTao as NgayNhap from PhieuNhap as pn join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN) as ctpn on hd.SKU = ctpn.SKU 
                                                     where NgayBan between '{0}' and '{1}'
                                                    group by NgayBan, hd.SKU, hd.MaHD, ctpn.GiaNhap, ctpn.NgayNhap) as t where t.RowNumber = 1
                                                    group by t.NgayBan, t.MaHD) as v 
                                                    on dt.MaHD =v.MaHD; ", func.DateTimeToString((DateTime)dteFrom), func.DateTimeToString((DateTime)dteTo));
            dtDetail = conn.loadData(query1);
            gcRevenue.DataSource = dtMaster;
        }

        private void loadData(string _query)
        {
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(_query);
            gcRevenue.DataSource = dtContent;
        }

        // If Master don't have Detail, a plus is enable
        private void gvRevenue_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (gvRevenue.GetRowCellValue(e.RowHandle, OrderDate) != null)
            {
                DateTime orderDate = (DateTime)gvRevenue.GetRowCellValue(e.RowHandle, OrderDate);
                e.IsEmpty = !dtDetail.AsEnumerable().Any(x => x.Field<DateTime>("NgayBan") == orderDate);
            }
        }

        //LoadData Detail
        private void gvRevenue_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            if (gvRevenue.GetRowCellValue(e.RowHandle, OrderDate) != null)
            {
                String orderDate = func.DateTimeToString((DateTime)gvRevenue.GetRowCellValue(e.RowHandle, OrderDate));
                e.ChildList = GetBatchFromItem(orderDate);
                gvDetail.ViewCaption = "Chi Tiết Báo Cáo Ngày " + orderDate;
            }
        }

        DataView GetBatchFromItem(string orderDate)
        {
            DataView dv = new DataView(dtDetail);
            dv.RowFilter = String.Format(@"[NgayBan] = '{0}'", orderDate);
            return dv;
        }

        //Set 1: Detail
        private void gvRevenue_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        //Set Relationship
        private void gvRevenue_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        #endregion

        #region //Revenue and Export Data File


        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            DateTime dtNow = DateTime.Now;
            saveDialog.FileName = "Report_Revenue_" + dtNow.Day.ToString() + "_" + dtNow.Month.ToString() + "_" + dtNow.Year.ToString()
                                                     + "_" + dtNow.Hour.ToString() + "_" + dtNow.Minute.ToString() + "_" + dtNow.Second.ToString();
            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Excel (1997-2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gvRevenue.OptionsPrint.PrintDetails = true;
                        gvRevenue.OptionsPrint.ExpandAllDetails = true;
                        XlsxExportOptionsEx opt = new XlsxExportOptionsEx();
                        opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvRevenue.ExportToXlsx(exportFilePath, opt);
                        Process.Start(exportFilePath);
                        break;
                    case ".xlsx":
                        gvRevenue.OptionsPrint.PrintDetails = true;
                        gvRevenue.OptionsPrint.ExpandAllDetails = true;
                        XlsxExportOptionsEx opt1 = new XlsxExportOptionsEx();
                        opt1.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvRevenue.ExportToXlsx(exportFilePath, opt1);
                        Process.Start(exportFilePath);
                        break;
                    case ".rtf":
                        gvRevenue.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gvRevenue.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gvRevenue.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gvRevenue.ExportToMht(exportFilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        //Try to open the file and let windows decide how to open it.
                        System.Diagnostics.Process.Start(exportFilePath);
                    }
                    catch
                    {
                        String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        #endregion

    }
}
