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
using System.Text.RegularExpressions;
using QuanLyNhaSach_291021.Controller;

namespace QuanLyNhaSach_291021.View.Order
{
    public partial class frmOrderDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        Controller.Validation.Empty_Contain empty_ContainRule = new Controller.Validation.Empty_Contain();
        //defind variable
        String OrdID = "", dtNow = "";
        string emptyGridText = "Không có dữ liệu";
        bool checkDiscount;
        decimal orderDiscount = 0;
        DataTable dtCart;
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmOrderDetail()
        {
            InitializeComponent();
            loadAllLookups();
            loadDataProduct();
            initDatatable();
            OrdID = InitOrderID();
            dtNow = func.DateTimeToString(DateTime.Now);
            checkDiscount = false;
        }

        //public frmOrderDetail(string _id) : this()
        //{
        //    this.id = _id;
        //    loadData();

        //}
        #endregion

        #region //Load Data For Updating Event

        #endregion

        #region //Load ComboboxData
        private void loadAllLookups()
        {
            loadLookupData(luCustomer, "MaKH", "TenKH", "KhachHang");
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
            string query = String.Format(@"Select  sp.SKU, sp.TenSP, tl.TenTL as TheLoai, sp.NgonNgu, sp.PhienBan, sp.GiaBan, cts.TacGia, h.Anh , cts.*, ctkm.GiamGiaSanPham
                                                from SanPham as sp
							                    left join HinhAnh as h on sp.MaHA = h.MaHA
												inner join TheLoai as tl on sp.MaTL = tl.MaTL
                                                left join (select ISBN as dISBN, tg.TenTG as TacGia
									                       from ChiTietSach as ct join TacGia as tg on ct.MaTG = tg.MaTG 
									                    ) as cts on sp.ISBN = cts.dISBN
												left join (select sum(GiamGiaSanPham) as GiamGiaSanPham, SKU 
                                                                  from (select ctkm.SKU, ctkm.GiamGiaSanPham from KhuyenMai as km 
                                                                                                             join ChiTietKhuyenMai as ctkm on km.MaKM = ctkm.MaKM 
												                        where km.ThoiGianBatDau < GetDate() and km.ThoiGianKetThuc > GETDATE()) as t group by SKU
                                                           ) as ctkm 
												on sp.SKU = ctkm.SKU
                                                where sp.HienThi = 1 ");
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                gcProduct.DataSource = dtContent;
            }
        }
        #endregion

        #region //Init Datatable Cart
        private void initDatatable()
        {
            dtCart = new DataTable();

            DataColumn dc = new DataColumn("MaHD", typeof(String));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("SKU", typeof(String));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("SanPham", typeof(String));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("GiaBan", typeof(Decimal));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("GiamGia", typeof(Decimal));
            dtCart.Columns.Add(dc);

            dc = new DataColumn("TongTien", typeof(Decimal));
            dtCart.Columns.Add(dc);
        }
        #endregion

        #region //Setup Order Grid

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

        #region //Validation
        private bool doValidate()
        {
            //return (vali.Validate());
            if (luCustomer.Text == String.Empty || dtCart.Rows.Count <= 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (doValidate())
            {
                if(checkDiscount)
                {
                    var total = gvOrder.Columns["TongTien"].SummaryItem.SummaryValue;
                    String query = String.Format(@"INSERT INTO HoaDon(MaHD, MaKH, MaNV, TongTien, GiamGia, GhiChu, NgayTao) 
                                                            values ('{0}', '{1}', '{2}', {3}, {4}, N'{5}', '{6}')",
                                                                OrdID,
                                                                luCustomer.EditValue,
                                                                Global.EmpId,
                                                                Convert.ToDecimal(txtTotalPrice.Text.Replace(",", "")),
                                                                orderDiscount,
                                                                mmeNote.Text,
                                                                dtNow);

                    conn.executeDatabase(query);
                    //Insert Detail
                    dtCart.Columns.Remove("SanPham");
                    dtCart.Columns.Remove("TongTien");
                    conn.executeDataSet("uspInsertOrderDetails", dtCart);

                    //update stocknumber
                    foreach (DataRow dr_update in dtCart.Rows) // search whole table
                    {
                        String query1 = String.Format(@"UPDATE SanPham SET SoLuongTon = SoLuongTon - {0} WHERE SKU = '{1}'",
                                                                    (int)dr_update["SoLuong"], dr_update["SKU"].ToString());
                        conn.executeDatabase(query1);

                    }
                    MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                    this.Close();
                }
                else
                {
                    MyMessageBox.ShowMessage("Vui Lòng Nhấn Lại Nút Áp Dụng Khuyến Mãi!");
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Vui Lòng Điền Thông Tin Đủ Và Hợp Lệ!");
            }
        }

        private string InitOrderID()
        {
            string query = @"select top 1 MaHD from HoaDon order by MaHD desc";
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                string OldID = (dtContent.Rows[0]["MaHD"]).ToString();
                if (OldID.Length > 2)
                {
                    return Regex.Replace(OldID, "\\d+", m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                }

            }
            return "";
        }
        #endregion

        #region //Add Customer

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer.frmCustomerDetail frm = new Customer.frmCustomerDetail(true);
            frm.cof = new Customer.frmCustomerDetail.CallOrderForm(loadAllLookups);
            frm.ShowDialog();
        }
        #endregion

        #region //Check Order Discount

        private void btnDiscountCheck_Click(object sender, EventArgs e)
        {
            checkDiscount = true;
            String query = @"select GiamGiaHoaDon, DonViGiam, DieuKien from KhuyenMai as km 
                                    where km.ThoiGianBatDau < GetDate() and km.ThoiGianKetThuc > GETDATE()
                                          and km.GiamGiaHoaDon is not Null";
            DataTable checkOrderDiscount = conn.loadData(query);

            var total = (decimal)gvOrder.Columns["TongTien"].SummaryItem.SummaryValue;
            string conditionDiscount = "", op_condition = "";
            decimal condition = 0;
            foreach (DataRow dr_discount in checkOrderDiscount.Rows) // search whole table
            {
                conditionDiscount = dr_discount["DieuKien"].ToString();
                string[] arrListStr = conditionDiscount.Split(' ');
                op_condition = arrListStr[0].ToString();
                condition = Convert.ToDecimal(arrListStr[1]);
                if (Common.Operator(op_condition, total, condition))
                {
                    if(dr_discount["DonViGiam"].ToString() == "%")
                    {
                        orderDiscount = (decimal)dr_discount["GiamGiaHoaDon"];
                        total = (Convert.ToDecimal(((float)total - (float)total * (double)orderDiscount / 100)));
                        orderDiscount = Convert.ToDecimal((float)total * (double)orderDiscount / 100);
                        txtTotalPrice.Text = total.ToString() +"đ";
                    }
                    else
                    {
                        total = (total - (decimal)dr_discount["GiamGiaHoaDon"]);
                        orderDiscount = (decimal)dr_discount["GiamGiaHoaDon"];
                        txtTotalPrice.Text = total.ToString()+"đ";
                    }
                    
                }

            }
        }

        #endregion

        #region //Handle Cart
        //Add Product into cart
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            checkDiscount = false;
            String product_id = getID();
            AddToCart(product_id);
        }

        private void AddToCart(string ID)
        {
            //gvOrder.AddNewRow();

            //int rowHandle = gvOrder.GetRowHandle(gvOrder.DataRowCount);
            //DataRow dataRow = getProduct(strSKU);
            //if (gvOrder.IsNewItemRow(rowHandle))
            //{
            //    gvOrder.SetRowCellValue(rowHandle, gvOrder.Columns["OrdSKU"], dataRow["SKU"]);
            //    gvOrder.SetRowCellValue(rowHandle, gvOrder.Columns["Product"], dataRow["SanPham"]);
            //    gvOrder.SetRowCellValue(rowHandle, gvOrder.Columns["Amount"], 1);
            //    gvOrder.SetRowCellValue(rowHandle, gvOrder.Columns["OrderPrice"], 0);
            //    gvOrder.SetRowCellValue(rowHandle, gvOrder.Columns["TotalPrice"], 0);
            //}

            DataRow dataRow = getProduct(ID);
            DataRow dr = dtCart.NewRow();
            string strSKU = dataRow["SKU"].ToString();
            if (checkExistenceCart(strSKU))
            {
                dr[0] = OrdID;
                dr[1] = strSKU;
                dr[2] = dataRow["SanPham"].ToString();
                dr[3] = 1;
                dr[4] = (decimal)dataRow["GiaBan"];
                dr[5] = (decimal)dataRow["GiamGia"];
                dr[6] = Convert.ToDecimal(((int)dr[3] * ((Decimal)dr[4] - (Decimal)dr[5])));

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
                        dr_update["TongTien"] = Convert.ToDecimal(((int)dr_update["SoLuong"] * ((Decimal)dr_update["GiaBan"] - (Decimal)dr_update["GiamGia"])));
                        break;
                    }
                }
            }
            gcOrder.DataSource = dtCart;
            //int Position = 0;
            //dtCart.Rows.InsertAt(dr, Position);
        }

        private DataRow getProduct(string strSKU)
        {
            string query = String.Format(@"Select  sp.SKU, sp.TenSP as SanPham, sp.GiaBan, Cast((sp.GiaBan*ctkm.GiamGiaSanPham/100) as decimal) as GiamGia
                                                from SanPham as sp
												left join (select sum(GiamGiaSanPham) as GiamGiaSanPham, SKU from (select
											    ctkm.SKU, ctkm.GiamGiaSanPham from KhuyenMai as km join ChiTietKhuyenMai as ctkm on km.MaKM = ctkm.MaKM 
												where km.ThoiGianBatDau < GetDate() and km.ThoiGianKetThuc > GETDATE()) as t group by SKU) as ctkm 
												 on sp.SKU = ctkm.SKU
                                                where sp.HienThi = 1  and sp.SKU = '{0}'", strSKU);
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                return dtContent.Rows[0];
            }
            return null;
        }

        //Update data of cart
        private void spAmount_EditValueChanged(object sender, EventArgs e)
        {
            checkDiscount = false;
            string strSKU = "";
            int amount = 0;
            decimal Discount = 0;
            if (gvOrder.GetRowCellValue(gvOrder.FocusedRowHandle, OrdSKU) != null)
            {
                strSKU = gvOrder.GetRowCellValue(gvOrder.FocusedRowHandle, OrdSKU).ToString();
            }
            SpinEdit s = sender as SpinEdit;
            amount = Convert.ToInt32(s.Text);
            foreach (DataRow dr_update in dtCart.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update["SoLuong"] = amount;
                    dr_update["TongTien"] = Convert.ToDecimal(((int)dr_update["SoLuong"] * ((Decimal)dr_update["GiaBan"] - (Decimal)dr_update["GiamGia"])));
                    break;
                }
            }
            gcOrder.DataSource = dtCart;
        }


        //Delete product in cart
        private void btnDelete_Click(object sender, EventArgs e)
        {
            checkDiscount = false;
            string strSKU = "";
            if (gvOrder.GetRowCellValue(gvOrder.FocusedRowHandle, OrdSKU) != null)
            {
                strSKU = gvOrder.GetRowCellValue(gvOrder.FocusedRowHandle, OrdSKU).ToString();
            }
            foreach (DataRow dr_update in dtCart.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update.Delete();
                    break;
                }
            }
            dtCart.AcceptChanges();
            gcOrder.DataSource = dtCart;
        }

        #endregion

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
        private void frmOrderDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmOrderDetail_Shown(object sender, EventArgs e)
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