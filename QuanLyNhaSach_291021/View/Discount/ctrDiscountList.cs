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

namespace QuanLyNhaSach_291021.View.Discount
{
    public partial class ctrDiscountList : DevExpress.XtraEditors.XtraUserControl
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

        //private static ctrDiscountList _instance;

        //public static ctrDiscountList instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new ctrDiscountList();
        //        }
        //        return _instance;
        //    }
        //}
        #endregion

        #region //Contructor

        public ctrDiscountList()
        {
            InitializeComponent();

            string placehoder = txtSearch.Properties.NullText;
            func.createPlaceHolderControl(txtSearch, placehoder);
        }

        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvDiscount_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        private void gvDiscount_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "DiscountName")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }

        //Setup notify text when grid is nullable data
        private void gvDiscount_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
            frmDiscountDetail frm = new frmDiscountDetail();
            frm.ShowDialog();
            loadData();
        }
        #endregion

        #region //Read

        private void gcDiscount_Load(object sender, EventArgs e)
        {
            loadData();
            gvDiscount.DataController.AllowIEnumerableDetails = true;
        }

        private void loadData()
        {
            //loadData Master
            query = @"select * from KhuyenMai where HienThi = 1";

            dtMaster = conn.loadData(query + "order by NgayTao ASC");
            //loadDataDetail
            string query1 = @"select sp.TenSP as SanPham, ct.* from ChiTietKhuyenMai as ct
                                    inner join SanPham as sp on ct.SKU = sp.SKU
                                    where ct.HienThi = 1";
            dtDetail = conn.loadData(query1);
            gcDiscount.DataSource = dtMaster;
        }

        private void loadData(string _query)
        {
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(_query);
            gcDiscount.DataSource = dtContent;
        }

        // If Master don't have Detail, a plus is enable
        private void gvDiscount_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            if (gvDiscount.GetRowCellValue(e.RowHandle, DiscountID) != null)
            {
                string ID = gvDiscount.GetRowCellValue(e.RowHandle, DiscountID).ToString();
                e.IsEmpty = !dtDetail.AsEnumerable().Any(x => x.Field<string>("MaKM") == ID);
            }
        }

        //LoadData Detail
        private void gvDiscount_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            if (gvDiscount.GetRowCellValue(e.RowHandle, DiscountID) != null)
            {
                string ID = gvDiscount.GetRowCellValue(e.RowHandle, DiscountID).ToString();
                e.ChildList = GetBatchFromItem(ID);
                gvDetail.ViewCaption = "Khuyến Mãi Sản Phẩm ";
            }
        }

        DataView GetBatchFromItem(string ID)
        {
            DataView dv = new DataView(dtDetail);
            dv.RowFilter = String.Format(@"[MaKM] = '{0}'", ID);
            return dv;
        }

        //Set 1: Detail
        private void gvDiscount_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        //Set Relationship
        private void gvDiscount_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        #endregion

        #region //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void gvDiscount_DoubleClick(object sender, EventArgs e)
        {
            if (gvDiscount.FocusedColumn.Name != "NO")
            {
                update();
            }
        }

        private void update()
        {
            if (getID("MaKM") != "")
            {
                string ID = getID("MaKM");
                frmDiscountDetail frm = new frmDiscountDetail(ID);
                frm.ShowDialog();
                loadData();
            }
        }

        #endregion

        #region //Delete

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (gvDiscount.FocusedColumn.Name == "Delete")
            {
                if (getID("MaKM") != "")
                {
                    string ID = getID("MaKM");
                    MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                    DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Khuyến Mãi Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

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
                string DiscountID = getID("MaKM");
                string SKU = getID("SKU");

                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Chi Tiết Khuyến Mãi Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    if (checkConstraints(DiscountID) > 1)
                    {
                        delete(DiscountID, SKU);
                    }
                    else if (checkConstraints(DiscountID) == 1)
                    {
                        delete(DiscountID);
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
            string query_del = String.Format("Update ChiTietKhuyenMai Set HienThi = 0 Where MaKM = '{0}';", ID);
            query_del += String.Format("Update KhuyenMai Set HienThi = 0 Where MaKM = '{0}'; ", ID);
            conn.executeDatabase(query_del);
            MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
            loadData();
        }
        private void delete(string DiscountID, string SKU)
        {
            string query_del = String.Format("Update ChiTietKhuyenMai Set HienThi = 0 Where MaKM = '{0}' and SKU = '{1}';", DiscountID, SKU);
            conn.executeDatabase(query_del);
            MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
            loadData();
        }

        private int checkConstraints(string ID)
        {
            string query = String.Format("select count(MaKM)  as count from ChiTietKhuyenMai where MaKM = '{0}'", ID);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            return (int)(dt.Rows[0]["count"]);
        }
        //private bool checkConstraints(string ID)
        //{
        //    string query = String.Format(@"select count(hd.MaKM) as count1, count(pn.MaKM) as count2, count(km.MaKM) as count3 
        //                                            from ChiTietHoaDon as hd, 
        //                                                 ChiTietKhuyenMai as pn, 
        //                                                 ChiTietKhuyenMai as km
        //                                    where hd.MaKM = '{0}' or pn.MaKM = '{0}' or km.MaKM = '{0}'", ID);
        //    DataTable dt = new DataTable();
        //    dt = conn.loadData(query);
        //    if ((int)(dt.Rows[0]["count1"]) > 0 || (int)(dt.Rows[0]["count2"]) > 0 || (int)(dt.Rows[0]["count3"]) > 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}
        #endregion

        #region //Get Id
        private string getID(string fieldName)
        {
            string ID = "";
            var view = gcDiscount.FocusedView as GridView;
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
                string field = func.removeUnicode((cbbField.Text).Replace("Khuyến Mãi", "KM"))
                                                                  .Replace(" ", "");
                if (searchInfo != txtSearch.Properties.NullText && !string.IsNullOrWhiteSpace(searchInfo))
                {
                    int index = cbbField.SelectedIndex;
                    if (index != 0)
                    {
                        string querySearch = "";
                        if (field == "SanPham")
                        {
                            querySearch = String.Format(@"Select * from ({0}) as t where t.MaKM In  (select MaKM from ChiTietKhuyenMai as ct
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
                                                                                                    MaKM, 
                                                                                                    TenKM) like N'%{1}%' 
                                                                                             or t.MaKM In  (select MaKM from ChiTietKhuyenMai as ct
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

    }
}
