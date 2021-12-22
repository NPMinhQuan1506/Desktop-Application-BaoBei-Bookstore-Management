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

namespace QuanLyNhaSach_291021.View.Order
{
    public partial class ctrOrderList : DevExpress.XtraEditors.XtraUserControl
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
        //defind generate instance 

        //private static ctrOrderList _instance;

        //public static ctrOrderList instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ctrOrderList();
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        #region //Contructor

        public ctrOrderList()
        {
            InitializeComponent();

            string placehoder = txtSearch.Properties.NullText;
            func.createPlaceHolderControl(txtSearch, placehoder);
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

        #region //Create
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmOrderDetail frm = new frmOrderDetail();
            frm.ShowDialog();
            loadData();
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
            query = @"Select hd.MaHD, KH.TenKH as KhachHang, nv.TenNV as NhanVien, hd.TongTien, GiamGia, hd.GhiChu, hd.NgayTao, hd.NgayCapNhat
                            from HoaDon as hd
                            inner join KhachHang as KH on hd.MaKH = KH.MaKH
                            inner join NhanVien as nv on hd.MaNV = nv.MaNV
                            where hd.HienThi = 1";

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

        #region //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void gvOrder_DoubleClick(object sender, EventArgs e)
        {
            if (gvOrder.FocusedColumn.Name != "NO")
            {
                update();
            }
        }

        private void update()
        {
            //if (getID(gvOrder, "MaHD") != "")
            //{
            //    string ID = getID(gvOrder, "MaHD");
            //    frmOrderDetail frm = new frmOrderDetail(ID);
            //    frm.ShowDialog();
            //    loadData();
            //}
        }

        #endregion

        #region //Delete

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvOrder.FocusedColumn.Name == "Delete")
            {
                if (getID("MaHD") != "")
                {
                    string ID = getID("MaHD");
                    MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                    DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Hóa Đơn Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                    if (Result == DialogResult.Yes)
                    {
                        delete(ID);
                    }
                    else if (Result == DialogResult.No)
                    {
                        MyMessageBox.ShowMessage("Dữ liệu vẫn tồn tại!");
                    }
                }
            }
            else if (gvDetail.FocusedColumn.Name == "DetailDelete")
            {
                string OrderID = getID("MaHD");
                string SKU = getID("SKU");

                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Chi Tiết Hóa Đơn Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    if (checkConstraints(OrderID) > 1)
                    {
                        delete(OrderID, SKU);
                    }
                    else if (checkConstraints(OrderID) == 1)
                    {
                        delete(OrderID);
                    }
                }
                else if (Result == DialogResult.No)
                {
                    MyMessageBox.ShowMessage("Dữ liệu vẫn tồn tại!");
                }
            }
        }

        private void delete(string ID)
        {
            string query_del = String.Format("Update ChiTietHoaDon Set HienThi = 0 Where MaHD = '{0}';", ID);
            query_del += String.Format("Update HoaDon Set HienThi = 0 Where MaHD = '{0}'; ", ID);
            conn.executeDatabase(query_del);
            MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
            loadData();
        }
        private void delete(string OrderID, string SKU)
        {
            string query_del = String.Format("Update ChiTietHoaDon Set HienThi = 0 Where MaHD = '{0}' and SKU = '{1}';", OrderID, SKU);
            conn.executeDatabase(query_del);
            MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
            loadData();
        }

        private int checkConstraints(string ID)
        {
            string query = String.Format("select count(MaHD)  as count from ChiTietHoaDon where MaHD = '{0}'", ID);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            return (int)(dt.Rows[0]["count"]);
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

        #region //Search and Filter

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.EditValue = String.Empty;
            }
            search();
        }

        private void cbbField_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            //Add datatable if searching value is null, datatable will return "Search data doesn't exist"
            if (txtSearch.EditValue != null)
            {
                string searchInfo = Regex.Replace(txtSearch.EditValue.ToString(), @"[\']+", "").Trim();
                string field = func.removeUnicode((cbbField.Text).Replace("Hóa Đơn", "HD"))
                                                                  .Replace(" ", "");
                if (searchInfo != txtSearch.Properties.NullText && !string.IsNullOrWhiteSpace(searchInfo))
                {
                    int index = cbbField.SelectedIndex;
                    if (index != 0)
                    {
                        string querySearch = "";
                        if (field == "SanPham")
                        {
                            querySearch = String.Format(@"Select * from ({0}) as t where t.MaHD In  (select MaHD from ChiTietHoaDon as ct
																			                                inner join SanPham as sp on ct.SKU = sp.SKU
																			                                where ct.HienThi = 1 and TenSP like N'%{1}%')",
                                                                                                             query, searchInfo);
                        }
                        else
                        {
                            querySearch = String.Format(@"Select * from ({0}) as t where t.{1} like N'%{2}%'", query, field, searchInfo);
                        }

                        loadData(querySearch);
                    }
                    else
                    {
                        String querySearch = String.Format(@"Select * from ({0}) as t where CONCAT('',  
                                                                                                    MaHD, 
                                                                                                    t.KhachHang,
                                                                                                    t.NhanVien) like N'%{1}%' 
                                                                                             or t.MaHD In  (select MaHD from ChiTietHoaDon as ct
																			                                inner join SanPham as sp on ct.SKU = sp.SKU
																			                                where ct.HienThi = 1 and TenSP like N'%{1}%')",
                                                                                                             query, searchInfo);
                        loadData(querySearch);
                    }
                }
                else
                {
                    loadData();
                }
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.EditValue = "";
        }
        #endregion

        #region //Order and Export Data File
        private void btnInport_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (1997-2003)(.xls)|*.xls|CSV file (.csv)|*.csv" })
            //{
            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        string fileName = openFileDialog.FileName;
            //        DataTable dtMyExcel = Controller.MyExcel.GetDataTableFromExcel(fileName);
            //        System.Data.DataView view = new System.Data.DataView(dtMyExcel);
            //        System.Data.DataTable master = view.ToTable("MyTableMaster", false, "MaHD", "ISBN", "TenHD", "MaKH", "MaHT", "MaTL", "NgonNgu", "PhienBan",
            //            "SoLuongTon", "TonToiThieu", "DonViTinh", "GiaBan", "DanhGia", "MoTa");
            //        ConvertColumnType(ref master, "DanhGia", typeof(float));
            //        conn.executeDataSet("uspInsertOrders", master);
            //        System.Data.DataTable detail = view.ToTable("MyTableDetail", false, "ISBN", "MaNXB", "MaTG", "NamXuatBanDauTien", "NamXuatBanMoiNhat", "SoTrang");


            //        ConvertColumnType(ref detail, "NamXuatBanDauTien", typeof(DateTime));
            //        ConvertColumnType(ref detail, "NamXuatBanMoiNhat", typeof(DateTime));
            //        conn.executeDataSet("uspInsertOrderDetails", detail);
            //    }
            //}
            //loadData();
        }

        public void ConvertColumnType(ref DataTable dt, string columnName, Type newType)
        {
            using (DataColumn dc = new DataColumn(columnName + "_new", newType))
            {
                // Add the new column which has the new type, and move it to the ordinal of the old column
                int ordinal = dt.Columns[columnName].Ordinal;
                dt.Columns.Add(dc);
                dc.SetOrdinal(ordinal);

                // Get and convert the values of the old column, and insert them into the new
                foreach (DataRow dr in dt.Rows)
                {
                    if (newType == typeof(DateTime))
                    {
                        var x = dr[columnName].ToString();
                        DateTime dtTemp = DateTime.ParseExact(dr[columnName].ToString(), "dd/MM/yyyy", null);
                        dr[dc.ColumnName] = func.DateTimeToString(dtTemp);
                        //Convert.ChangeType(dr[columnName], newType);
                    }
                    else
                    {

                        if (dr[columnName] != DBNull.Value)
                        {
                            dr[dc.ColumnName] = Convert.ChangeType(dr[columnName], newType);
                        }

                    }
                }


                // Remove the old column
                dt.Columns.Remove(columnName);

                // Give the new column the old column's name
                dc.ColumnName = columnName;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            DateTime dtNow = DateTime.Now;
            saveDialog.FileName = "Report_Order_" + dtNow.Day.ToString() + "_" + dtNow.Month.ToString() + "_" + dtNow.Year.ToString()
                                                     + "_" + dtNow.Hour.ToString() + "_" + dtNow.Minute.ToString() + "_" + dtNow.Second.ToString();
            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Excel (1997-2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gvOrder.OptionsPrint.PrintDetails = true;
                        gvOrder.OptionsPrint.ExpandAllDetails = true;
                        XlsxExportOptionsEx opt = new XlsxExportOptionsEx();
                        opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvOrder.ExportToXlsx(exportFilePath, opt);
                        Process.Start(exportFilePath);
                        break;
                    case ".xlsx":
                        gvOrder.OptionsPrint.PrintDetails = true;
                        gvOrder.OptionsPrint.ExpandAllDetails = true;
                        XlsxExportOptionsEx opt1 = new XlsxExportOptionsEx();
                        opt1.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvOrder.ExportToXlsx(exportFilePath, opt1);
                        Process.Start(exportFilePath);
                        break;
                    case ".rtf":
                        gvOrder.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gvOrder.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gvOrder.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gvOrder.ExportToMht(exportFilePath);
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
