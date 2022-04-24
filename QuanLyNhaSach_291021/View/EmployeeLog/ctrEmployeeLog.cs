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
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace QuanLyNhaSach_291021.View.EmployeeLog
{
    public partial class ctrEmployeeLog : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string emptyGridText = "Không có dữ liệu";
        DataTable dtContent;
        //defind variable search and filter

        //defind generate instance 

        //private static ctrEmployeeLog _instance;

        //public static ctrEmployeeLog instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ctrEmployeeLog();
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        #region //Contructor

        public ctrEmployeeLog()
        {
            InitializeComponent();
            dtContent = new DataTable();
            string placehoder = txtSearch.Properties.NullText;
            func.createPlaceHolderControl(txtSearch, placehoder);
        }

        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvEmployeeLog_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        private void gvEmployeeLog_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "EmployeeLogName")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }

            if (e.Column.Name == "Status")
            {
                if (e.RowHandle >= 0)
                {
                    if (dtContent.Rows[e.RowHandle]["TrangThai"].ToString() == "Đang Hoạt Động")
                    {
                        e.Appearance.BackColor = Color.FromArgb(122, 16, 16);
                        e.Appearance.ForeColor = Color.FromArgb(255, 239, 239);
                    }
                }
            }
        }


        private void gvEmployeeLog_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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

        private void gcEmployeeLog_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = @"select el.MaNV, nv.TenNV, ThoiGianDangNhap, ThoiGianDangXuat, 
													CASE
						                                WHEN TrangThai = 0 THEN N'Đã Đăng Xuất'
						                                ELSE N'Đang Hoạt Động'
					                                END AS TrangThai from Employee_log as el
                            join NhanVien as nv on el.MaNV = nv.MaNV";
            dtContent = conn.loadData(query);
            gcEmployeeLog.DataSource = dtContent;
        }

        #endregion

        #region //Search and Filter

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != txtSearch.Properties.NullText)
            {
                if (txtSearch.Text == "")
                {
                    txtSearch.EditValue = "";
                }
                txtSearch.ForeColor = Color.FromArgb(0, 0, 20);
            }
            else
            {
                txtSearch.ForeColor = Color.FromArgb(144, 142, 144);
            }
            gvEmployeeLog.FindFilterText = string.Format("\"{0}\"", txtSearch.EditValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.EditValue = "";
        }
        #endregion

        #region //Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            DateTime dtNow = DateTime.Now;
            saveDialog.FileName = "Report_EmployeesLog_" + dtNow.Day.ToString() + "_" + dtNow.Month.ToString() + "_" + dtNow.Year.ToString()
                                                     + "_" + dtNow.Hour.ToString() + "_" + dtNow.Minute.ToString() + "_" + dtNow.Second.ToString();
            saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Excel (1997-2003)(.xls)|*.xls|RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (saveDialog.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = saveDialog.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gvEmployeeLog.OptionsPrint.PrintDetails = true;
                        XlsxExportOptionsEx opt = new XlsxExportOptionsEx();
                        opt.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvEmployeeLog.ExportToXlsx(exportFilePath, opt);
                        Process.Start(exportFilePath);
                        break;
                    case ".xlsx":
                        gvEmployeeLog.OptionsPrint.PrintDetails = true;
                        XlsxExportOptionsEx opt1 = new XlsxExportOptionsEx();
                        opt1.ExportType = DevExpress.Export.ExportType.WYSIWYG;
                        gvEmployeeLog.ExportToXlsx(exportFilePath, opt1);
                        Process.Start(exportFilePath);
                        break;
                    case ".rtf":
                        gvEmployeeLog.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gvEmployeeLog.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gvEmployeeLog.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gvEmployeeLog.ExportToMht(exportFilePath);
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
