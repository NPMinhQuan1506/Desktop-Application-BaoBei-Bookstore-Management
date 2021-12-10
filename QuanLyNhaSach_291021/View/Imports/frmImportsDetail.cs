using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using QuanLyNhaSach_291021.View.Notification;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraLayout;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLyNhaSach_291021.View.Imports
{
    public partial class frmImportsDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        Controller.Validation.Empty_Contain empty_ContainRule = new Controller.Validation.Empty_Contain();
        //defind variable
        String id = "", dtNow = "";
        bool flag = false;
        DataTable dtCart;
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmImportsDetail()
        {
            InitializeComponent();
            loadAllLookups();
            loadDataProduct();
            initDatatable();
            dtNow = func.DateTimeToString(DateTime.Now);
        }

        public frmImportsDetail(string _id) : this()
        {
            this.id = _id;
            loadData();

        }
        #endregion

        #region //Load Data For Updating Event
        private void loadData()
        {
            if (this.id != "")
            {
                string query = String.Format(@"Select ct.*, sp.TenSP as SanPham,pn.MaNCC, pn.TongTien, pn.GhiChu from PhieuNhap as pn 
                                               inner join ChiTietPhieuNhap as ct on pn.MaPN = ct.MaPN
                                               inner join SanPham as sp on ct.SKU = sp.SKU Where pn.MaPN = '{0}'", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    gcImport.DataSource = dtContent;
                    luSupplier.EditValue = (dtContent.Rows[0]["MaNCC"]).ToString();
                    mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                }
            }
        }
        #endregion

        #region //Load ComboboxData
        private void loadAllLookups()
        {
            loadLookupData(luSupplier, "MaNCC", "TenNCC", "NhaCungCap");
        }

        private void loadLookupData(LookUpEdit lu, string value, string display, string tableName)
        {
            string query = String.Format(@"select {0}, {1} from {2}", value, display, tableName);
            lu.Properties.DataSource = conn.loadData(query);
            lu.Properties.DisplayMember = display;
            lu.Properties.ValueMember = value;
        }
        #endregion

        #region //Load Product CardView
        private void loadDataProduct()
        {
            string query = String.Format(@"Select  sp.SKU, sp.TenSP, tl.TenTL as TheLoai, sp.NgonNgu, sp.PhienBan, cts.TacGia, h.Anh , cts.*
                                                from SanPham as sp
							                    left join HinhAnh as h on sp.MaHA = h.MaHA
												inner join TheLoai as tl on sp.MaTL = tl.MaTL
                                                left join (select ISBN as dISBN, tg.TenTG as TacGia
									                       from ChiTietSach as ct join TacGia as tg on ct.MaTG = tg.MaTG 
									                    ) as cts on sp.ISBN = cts.dISBN
                                                where sp.HienThi = 1", this.id);
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                gcProduct.DataSource = dtContent;
            }
        }
        #endregion

        #region // Init Datatable Cart
        private void initDatatable()
        {
            dtCart = new DataTable();
            DataColumn dc = new DataColumn("SKU", typeof(String));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("SanPham", typeof(String));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("GiaNhap", typeof(Decimal));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("TongTien", typeof(Decimal));
            dtCart.Columns.Add(dc);
        }
        #endregion

        #region //Validation
        private bool doValidate()
        {
            return (vali.Validate());
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (doValidate())
            {

            }
        }


        #endregion

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            String product_id = getID();
            AddToCart(product_id);
        }

        private void AddToCart(string ID)
        {
            //gvImport.AddNewRow();

            //int rowHandle = gvImport.GetRowHandle(gvImport.DataRowCount);
            //DataRow dataRow = getProduct(strSKU);
            //if (gvImport.IsNewItemRow(rowHandle))
            //{
            //    gvImport.SetRowCellValue(rowHandle, gvImport.Columns["ImpSKU"], dataRow["SKU"]);
            //    gvImport.SetRowCellValue(rowHandle, gvImport.Columns["Product"], dataRow["SanPham"]);
            //    gvImport.SetRowCellValue(rowHandle, gvImport.Columns["Amount"], 1);
            //    gvImport.SetRowCellValue(rowHandle, gvImport.Columns["ImportPrice"], 0);
            //    gvImport.SetRowCellValue(rowHandle, gvImport.Columns["TotalPrice"], 0);
            //}

            DataRow dataRow = getProduct(ID);
            DataRow dr = dtCart.NewRow();
            string strSKU = dataRow["SKU"].ToString();
            if (checkExistenceCart(strSKU))
            {
                dr[0] = strSKU;
                dr[1] = dataRow["SanPham"].ToString();
                dr[2] = 1;
                dr[3] = 0;
                dr[4] = Convert.ToDecimal(((int)dr[2] * (Decimal)dr[3]));
                dtCart.Rows.Add(dr);
            }
            else
            {
                foreach (DataRow dr_update in dtCart.Rows) // search whole table
                {
                    if (dr_update["SKU"].ToString() == strSKU)
                    {
                        int amount = 0;
                        if (dr_update["SoLuong"] != null)
                        {
                            amount = (int)dr_update["SoLuong"];
                        }

                        dr_update["SoLuong"] = amount + 1;
                        dr_update["TongTien"] = Convert.ToDecimal(((int)dr_update["SoLuong"] * (Decimal)dr_update["GiaNhap"]));
                        break;
                    }
                }
            }
            gcImport.DataSource = dtCart;
            //int Position = 0;
            //dtCart.Rows.InsertAt(dr, Position);
        }

        private DataRow getProduct(string strSKU)
        {
            string query = String.Format(@"Select SKU, TenSP as SanPham from SanPham where SKU = '{0}'", strSKU);
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                return dtContent.Rows[0];
            }
            return null;
        }


        #region //Get Id
        private string getID()
        {
            string ID = "";
            if (lvProduct.GetRowCellValue(lvProduct.FocusedRowHandle, "SKU") != null)
            {
                ID = lvProduct.GetRowCellValue(lvProduct.FocusedRowHandle, "SKU").ToString();
            }
            return ID;
        }
        #endregion

        #region //Check existence data
        private bool checkExistenceCart(string strSKU)
        {
            //return false if it exists record
            bool check = !dtCart.AsEnumerable().Any(x => x.Field<string>("SKU") == strSKU);
            return check;
        }
        #endregion

        private void spAmount_EditValueChanged(object sender, EventArgs e)
        {
            string strSKU = "";
            int amount = 0;
            if (gvImport.GetRowCellValue(gvImport.FocusedRowHandle, ImpSKU) != null)
            {
                strSKU = gvImport.GetRowCellValue(gvImport.FocusedRowHandle, ImpSKU).ToString();
            }
            SpinEdit s = sender as SpinEdit;
            amount = Convert.ToInt32(s.Text);
            foreach (DataRow dr_update in dtCart.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update["SoLuong"] = amount;
                    dr_update["TongTien"] = Convert.ToDecimal(((int)dr_update["SoLuong"] * (Decimal)dr_update["GiaNhap"]));
                    break;
                }
            }
            gcImport.DataSource = dtCart;
        }

        private void spPrice_EditValueChanged(object sender, EventArgs e)
        {
            string strSKU = "";
            decimal price = 0;
            if (gvImport.GetRowCellValue(gvImport.FocusedRowHandle, ImpSKU) != null)
            {
                strSKU = gvImport.GetRowCellValue(gvImport.FocusedRowHandle, ImpSKU).ToString();
            }
            SpinEdit s = sender as SpinEdit;
            price = (decimal)s.EditValue;
            foreach (DataRow dr_update in dtCart.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update["GiaNhap"] = price;
                    dr_update["TongTien"] = Convert.ToDecimal(((int)dr_update["SoLuong"] * (Decimal)dr_update["GiaNhap"]));
                    break;
                }
            }
            gcImport.DataSource = dtCart;
        }

        #region //Clear Value of Control
        private void lbClear_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region //Close Button
        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region //Rounded Border Form 
        private void frmImportsDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmImportsDetail_Shown(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }
        #endregion

        #region // Move Panel
        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point screenPoint = PointToScreen(e.Location);
                Location = new Point(screenPoint.X - this.startPoint.X, screenPoint.Y - this.startPoint.Y);
            }
        }
        #endregion

    }
}