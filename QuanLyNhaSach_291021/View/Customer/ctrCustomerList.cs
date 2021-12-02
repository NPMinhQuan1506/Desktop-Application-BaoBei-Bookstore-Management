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

namespace QuanLyNhaSach_291021.View.Customer
{
    public partial class ctrCustomerList : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string query = "";
        string emptyGridText = "Không có dữ liệu";

        //defind variable search and filter

        //defind generate instance 

        private static ctrCustomerList _instance;

        public static ctrCustomerList instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctrCustomerList();
                }
                return _instance;
            }
        }
        #endregion

        #region //Contructor

        public ctrCustomerList()
        {
            InitializeComponent();

            string placehoder = txtSearch.Properties.NullText;
            func.createPlaceHolderControl(txtSearch, placehoder);
        }

        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvCustomer_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        private void gvCustomer_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "CustomerName")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }


        private void gvCustomer_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
            frmCustomerDetail frm = new frmCustomerDetail();
            frm.ShowDialog();
            loadData();
        }
        #endregion

        #region //Read

        private void gcCustomer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            query = @"Select MaKH,
                                    TenKH, 
                                    gt.TenGT as GioiTinh, 
                                    ha.Anh as Anh,
                                    lk.TenLK as LoaiKhach, 
                                    nk.TenNK as NhomKhach, 
                                    tk.TenTK as TaiKhoan,
	                                NgaySinh, 
                                    Email, 
                                    DienThoai, 
                                    DiaChi, 
                                    kh.GhiChu
                            from KhachHang as kh
                            left join GioiTinh as gt on kh.MaGT = gt.MaGT
                            left join HinhAnh as ha on kh.MaHA = ha.MaHA
                            inner join LoaiKhach as lk on kh.MaLK = lk.MaLK
                            inner join NhomKhach as nk on kh.MaNK = nk.MaNK
                            left join TaiKhoan_KH as tk on kh.MaTK = tk.MaTK
                            where kh.HienThi = 1 ";
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query + "order by kh.NgayTao ASC");
            gcCustomer.DataSource = dtContent;
        }

        private void loadData(string _query)
        {
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(_query);
            gcCustomer.DataSource = dtContent;
        }

        #endregion

        #region //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void gvCustomer_DoubleClick(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (getID() != "")
            {
                string ID = getID();
                frmCustomerDetail frm = new frmCustomerDetail(ID);
                frm.ShowDialog();
                loadData();
            }
        }

        #endregion

        #region //Delete

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (getID() != "")
            {
                string ID = getID();
                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Khách Hàng Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

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

        private void delete(string ID)
        {
            if (checkConstraints(ID))
            {

                string query = String.Format(@"Delete TaiKhoan_KH where MaTK = (Select MaTK from KhachHang Where MaKH = '{0}'); ", ID);
                query += String.Format(@"Delete HinhAnh where MaHA = (Select MaHA from KhachHang Where MaKH = '{0}'); ", ID);
                query += String.Format("Delete KhachHang Where MaKH = '{0}'; ", ID);
                conn.executeDatabase(query);
                MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
                loadData();
            }
            else
            {
                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage(@"Lưu Ý! Tồn Tại Hóa Đơn Của Khách Hàng Này.\n Bạn Vẫn Muốn Tiếp Tục?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    string query = String.Format("Update KhachHang Set HienThi = 0 Where MaKH = '{0}'", ID);
                    MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công! Thông Tin Khách Hàng Vẫn Sẽ Được Lưu Lại Trong Hóa Đơn");
                    loadData();
                }
                else if (Result == DialogResult.No)
                {
                    MyMessageBox.ShowMessage("Dữ liệu vẫn tồn tại!");
                }
            }
        }

        private bool checkConstraints(string ID)
        {
            string query = String.Format("select count(MaKH)  as count from HoaDon where MaKH = '{0}'", ID);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            if ((int)(dt.Rows[0]["count"]) > 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region //Get Id
        private string getID()
        {

            if (gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, CustomerId) != null)
            {
                //string ID = gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, "MaKH").ToString();
                string ID = gvCustomer.GetRowCellValue(gvCustomer.FocusedRowHandle, CustomerId).ToString();
                return ID;
            }
            return "";
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
            if(txtSearch.EditValue != null)
            {
                string searchInfo = Regex.Replace(txtSearch.EditValue.ToString(), @"[\s\']+", "");
                string field = func.removeUnicode((cbbField.Text).Replace("Khách Hàng", "KH"))
                                                                 .Replace(" ", "");
                if (searchInfo != txtSearch.Properties.NullText && !string.IsNullOrWhiteSpace(searchInfo))
                {
                    int index = cbbField.SelectedIndex;
                    if (index != 0)
                    {
                        string querySearch = String.Format(@"{0} and {1} like N'%{2}%'", query, field, searchInfo);
                        loadData(querySearch);
                    }
                    else
                    {
                        String querySearch = String.Format(@"{0} and CONCAT('',  
                                                                    MaKH, 
                                                                    TenKH,
                                                                    NgaySinh, 
                                                                    Email, 
                                                                    DienThoai, 
                                                                    DiaChi) like N'%{1}%'", query, searchInfo);
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

        #region //Import and Export Data File
        private void btnInport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel (2010) (.xlsx)|*.xlsx|Excel (1997-2003)(.xls)|*.xls|CSV file (.csv)|*.csv" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    DataTable dtMyExcel = Controller.MyExcel.GetDataTableFromExcel(fileName);
                    ConvertColumnType(ref dtMyExcel, "NgaySinh", typeof(DateTime));
                    conn.executeDataSet("uspInsertCustomers", dtMyExcel);
                }
            }
            loadData();
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
                        DateTime dtTemp = DateTime.ParseExact(dr[columnName].ToString(), "dd/MM/yyyy", null);
                        dr[dc.ColumnName] = func.DateTimeToString(dtTemp);
                        //Convert.ChangeType(dr[columnName], newType);
                    }
                    else
                    {
                        dr[dc.ColumnName] = Convert.ChangeType(dr[columnName], newType);
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
            saveDialog.FileName = "Report_" + func.DateTimeToString(DateTime.Now);
            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Excel (1997-2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gvCustomer.ExportToXls(exportFilePath);
                        break;
                    case ".xlsx":
                        gvCustomer.ExportToXlsx(exportFilePath);
                        break;
                    case ".rtf":
                        gvCustomer.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gvCustomer.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gvCustomer.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gvCustomer.ExportToMht(exportFilePath);
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
