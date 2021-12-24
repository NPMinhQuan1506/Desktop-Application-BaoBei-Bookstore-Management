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

namespace QuanLyNhaSach_291021.View.Discount
{
    public partial class frmDiscountDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        Controller.Validation.Empty_Contain empty_ContainRule = new Controller.Validation.Empty_Contain();
        //defind variable
        String DiscountID = "", dtNow = "";
        bool flag = true;
        string emptyGridText = "Không có dữ liệu";
        DataTable dtProductDiscount;
        DataTable dtContent ;
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmDiscountDetail()
        {
            InitializeComponent();
            loadDataProduct();
            initDatatable();
            dtNow = func.DateTimeToString(DateTime.Now);
            rdTypeDiscount.SelectedIndex = 0;
        }

        public frmDiscountDetail(string _id) : this()
        {
            this.DiscountID = _id;
            DataTable dtContent = new DataTable();
            flag = false;
            loadData();

        }
        #endregion

        #region //Load Data For Updating Event
        private void loadData()
        {
            if (!flag)
            {
                rdTypeDiscount.Enabled = false;
                if(checkConstraints(this.DiscountID) > 0)
                {
                    rdTypeDiscount.SelectedIndex = 1;
                    string query = String.Format(@"Select km.MaKM, km.TenKM, km.ThoiGianBatDau, km.ThoiGianKetThuc, km.GhiChu, 
                                                          ct.SKU, ct.SanPham, ct.GiamGiaSanPham, ct.SoLuong from KhuyenMai as km 
                                               inner join (select sp.TenSP as SanPham, ct.* from ChiTietKhuyenMai as ct inner join SanPham as sp on ct.SKU = sp.SKU) as ct 
											   on km.MaKM = ct.MaKM
                                               Where km.MaKM = '{0}'", this.DiscountID);
                    
                    dtContent = conn.loadData(query);
                    if (dtContent.Rows.Count > 0)
                    {
                        string strDte = "";
                        gcDiscount.DataSource = dtContent;
                        DataView view = new System.Data.DataView(dtContent);
                        DataTable tempProductDiscount =
                                view.ToTable("Selected", false, "MaKM", "SKU", "SanPham", "SoLuong", "GiamGiaSanPham");
                        dtProductDiscount = tempProductDiscount;
                        txtDiscountName.Text = (dtContent.Rows[0]["TenKM"]).ToString();
                        strDte = (dtContent.Rows[0]["ThoiGianBatDau"]).ToString();
                        dteStartTime.EditValue = func.StringToDateTime(strDte);
                        strDte = (dtContent.Rows[0]["ThoiGianKetThuc"]).ToString();
                        dteEndTime.EditValue = func.StringToDateTime(strDte);
                        mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                    }
                }
                else
                {
                    rdTypeDiscount.SelectedIndex = 0;
                    string query = String.Format(@"Select * from KhuyenMai as km Where km.MaKM = '{0}'", this.DiscountID);
                    DataTable dtContent = new DataTable();
                    dtContent = conn.loadData(query);
                    if (dtContent.Rows.Count > 0)
                    {
                        string strDte = "";

                        txtDiscountName.Text = (dtContent.Rows[0]["TenKM"]).ToString();
                        strDte = (dtContent.Rows[0]["ThoiGianBatDau"]).ToString();
                        dteStartTime.EditValue = func.StringToDateTime(strDte);
                        strDte = (dtContent.Rows[0]["ThoiGianKetThuc"]).ToString();
                        dteEndTime.EditValue = func.StringToDateTime(strDte);
                        string conditionDiscount = (dtContent.Rows[0]["DieuKien"]).ToString();
                        string[] arrListStr = conditionDiscount.Split(' ');
                        spCondition.EditValue = Convert.ToInt32(arrListStr[1]);
                        cbbConditionUnit.EditValue = arrListStr[0].ToString();
                        cbbDiscountUnit.EditValue = (dtContent.Rows[0]["DonViGiam"]).ToString();
                        spOrderDiscount.EditValue = (decimal)(dtContent.Rows[0]["GiamGiaHoaDon"]);
                        mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                    }
                }
            }
        }
        #endregion

        #region //Set Rule Of Control
        private void rdTypeDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            setUpDiscountType();
        }

        private void setUpDiscountType()
        {
            if (rdTypeDiscount.SelectedIndex == 0)
            {
                gcProduct.Enabled = false;
                gcDiscount.Enabled = false;
                lbProduct.Enabled = false;
                lbProductDiscount.Enabled = false;
                spOrderDiscount.Enabled = true;
                cbbDiscountUnit.Enabled = true;
                spCondition.Enabled = true;
                cbbConditionUnit.Enabled = true;
            }
            else
            {

                gcProduct.Enabled = true;
                gcDiscount.Enabled = true;
                lbProduct.Enabled = true;
                lbProductDiscount.Enabled = true;
                spOrderDiscount.Enabled = false;
                cbbDiscountUnit.Enabled = false;
                spCondition.Enabled = false;
                cbbConditionUnit.Enabled = false;
            }
        }

        private void cbbDiscountUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbConditionUnit.Text == "%")
            {
                spOrderDiscount.Properties.MaxValue = 100;
            }
            else
            {
                spOrderDiscount.Properties.MaxValue = (decimal)spCondition.EditValue;
            }
        }


        private void spCondition_EditValueChanged(object sender, EventArgs e)
        {

            if (cbbConditionUnit.Text == "VNĐ")
            {
                spOrderDiscount.Properties.MaxValue = (decimal)spCondition.EditValue;
            }
        }


        private void dteStartTime_EditValueChanged(object sender, EventArgs e)
        {
            dteEndTime.Properties.MinValue = (DateTime)dteStartTime.EditValue;
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
                                                where sp.HienThi = 1");
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
            dtProductDiscount = new DataTable();

            DataColumn dc = new DataColumn("MaKM", typeof(String));
            dtProductDiscount.Columns.Add(dc);

            dc = new DataColumn("SKU", typeof(String));
            dtProductDiscount.Columns.Add(dc);

            dc = new DataColumn("SanPham", typeof(String));
            dtProductDiscount.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(int));
            dtProductDiscount.Columns.Add(dc);

            dc = new DataColumn("GiamGiaSanPham", typeof(Decimal));
            dtProductDiscount.Columns.Add(dc);
        }
        #endregion

        #region //Setup Discount Grid

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

            if (e.Column.Name == "DiscountsName")
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

        #region //Validation
        private bool doValidate()
        {
            //return (vali.Validate());
            //if (luSupplier.Text == String.Empty || dtProductDiscount.Rows.Count <= 0)
            //{
            //    return false;
            //}
            return true;
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (doValidate())
            {
                if (rdTypeDiscount.SelectedIndex == 0)
                {
                    saveOrderDiscount();
                }
                else
                {
                    saveProductDiscount();
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Vui Lòng Điền Thông Tin Đủ Và Hợp Lệ!");
            }
        }

        private void saveOrderDiscount()
        {
            if (flag)
            {

                String query = String.Format(@"INSERT INTO KhuyenMai(MaKM, TenKM, ThoiGianBatDau, ThoiGianKetThuc, GiamGiaHoaDon, DonViGiam, DieuKien, GhiChu, NgayTao) 
                                                            values ('{0}', N'{1}', '{2}', '{3}',{4}, N'{5}', '{6}', N'{7}', '{8}')",
                                                            InitDiscountID(),
                                                            txtDiscountName.Text,
                                                            func.DateTimeToString((DateTime)dteStartTime.EditValue),
                                                            func.DateTimeToString((DateTime)dteEndTime.EditValue),
                                                            (decimal)spOrderDiscount.EditValue,
                                                            cbbDiscountUnit.Text,
                                                            cbbConditionUnit.Text + " " + spCondition.EditValue.ToString(),
                                                            mmeNote.Text,
                                                            dtNow);

                conn.executeDatabase(query);
                MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                this.Close();
            }
            else
            {
                String query = String.Format(@"Update KhuyenMai Set TenKM = N'{0}', ThoiGianBatDau = '{1}', ThoiGianKetThuc = '{2}', 
                                                                    GiamGiaHoaDon = {3}, DonViGiam = N'{4}', DieuKien = '{5}', GhiChu = N'{6}'
                                                                    Where MaKM = '{7}'",
                                            txtDiscountName.Text,
                                            func.DateTimeToString((DateTime)dteStartTime.EditValue),
                                            func.DateTimeToString((DateTime)dteEndTime.EditValue),
                                            (decimal)spOrderDiscount.EditValue,
                                            cbbDiscountUnit.Text,
                                            cbbConditionUnit.Text + " " + spCondition.EditValue.ToString(),
                                            mmeNote.Text,
                                            DiscountID);

                conn.executeDatabase(query);
                MyMessageBox.ShowMessage("Sửa Dữ Liệu Thành Công!");
                this.Close();
            }
        }

        private void saveProductDiscount()
        {
            if (flag)
            {
                String query = String.Format(@"INSERT INTO KhuyenMai(MaKM, TenKM, ThoiGianBatDau, ThoiGianKetThuc, GhiChu, NgayTao) 
                                                            values ('{0}', N'{1}', '{2}', '{3}', N'{4}', '{5}')",
                                                            InitDiscountID(),
                                                            txtDiscountName.Text,
                                                            func.DateTimeToString((DateTime)dteStartTime.EditValue),
                                                            func.DateTimeToString((DateTime)dteEndTime.EditValue),
                                                            mmeNote.Text,
                                                            dtNow);

                conn.executeDatabase(query);
                //Insert Detail
                dtProductDiscount.Columns.Remove("SanPham");
                conn.executeDataSet("uspInsertDiscountDetails", dtProductDiscount);
                MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                this.Close();
            }
            else
            {
                String query = String.Format(@"Update KhuyenMai Set TenKM = N'{0}', ThoiGianBatDau = '{1}', ThoiGianKetThuc = '{2}', GhiChu = N'{3}' Where MaKM = '{4}'",
                                                            txtDiscountName.Text,
                                                            func.DateTimeToString((DateTime)dteStartTime.EditValue),
                                                            func.DateTimeToString((DateTime)dteEndTime.EditValue),
                                                            mmeNote.Text,
                                                            DiscountID);

                conn.executeDatabase(query);
                //Insert Detail
                dtProductDiscount.Columns.Remove("SanPham");
                
                foreach (DataRow dr_update in dtContent.Rows) // search whole table
                {
                    if (checkExistenceCart(dr_update["SKU"].ToString()))
                    {
                        query = String.Format(@"Update ChiTietKhuyenMai set HienThi = 0 where MaKM = '{0}' and SKU = '{1}'", DiscountID, dr_update["SKU"].ToString());
                        conn.executeDatabase(query);
                    }
                }
                conn.executeDataSet("uspUpdateDiscountDetails", dtProductDiscount);
                MyMessageBox.ShowMessage("Sửa Dữ Liệu Thành Công!");
                this.Close();
            }
        }

        private string InitDiscountID()
        {
            string query = @"select top 1 MaKM from KhuyenMai order by MaKM desc";
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            if (dtContent.Rows.Count > 0)
            {
                string OldID = (dtContent.Rows[0]["MaKM"]).ToString();
                if (OldID.Length > 2)
                {
                    return Regex.Replace(OldID, "\\d+", m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                }

            }
            return "";
        }
        #endregion

        #region //Handle Cart
        //Add Product into cart
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            String product_id = getID();
            AddToCart(product_id);
        }

        private void AddToCart(string ID)
        {
            //gvDiscount.AddNewRow();

            //int rowHandle = gvDiscount.GetRowHandle(gvDiscount.DataRowCount);
            //DataRow dataRow = getProduct(strSKU);
            //if (gvDiscount.IsNewItemRow(rowHandle))
            //{
            //    gvDiscount.SetRowCellValue(rowHandle, gvDiscount.Columns["ImpSKU"], dataRow["SKU"]);
            //    gvDiscount.SetRowCellValue(rowHandle, gvDiscount.Columns["Product"], dataRow["SanPham"]);
            //    gvDiscount.SetRowCellValue(rowHandle, gvDiscount.Columns["Amount"], 1);
            //    gvDiscount.SetRowCellValue(rowHandle, gvDiscount.Columns["DiscountPrice"], 0);
            //    gvDiscount.SetRowCellValue(rowHandle, gvDiscount.Columns["TotalPrice"], 0);
            //}

            DataRow dataRow = getProduct(ID);
            DataRow dr = dtProductDiscount.NewRow();
            string strSKU = dataRow["SKU"].ToString();
            if (checkExistenceCart(strSKU))
            {
                if (flag)
                {
                    dr[0] = InitDiscountID();
                }
                else
                {
                    dr[0] = DiscountID;
                }
                dr[1] = strSKU;
                dr[2] = dataRow["SanPham"].ToString();
                dr[3] = 1;
                dr[4] = 1;

                dtProductDiscount.Rows.Add(dr);
            }
            else
            {
                foreach (DataRow dr_update in dtProductDiscount.Rows) // search whole table
                {
                    if (dr_update["SKU"].ToString() == strSKU)
                    {
                        int amount = 0;
                        if (dr_update["SoLuong"] != null)
                        {
                            amount = (int)dr_update["SoLuong"];
                        }

                        dr_update["SoLuong"] = amount + 1;
                        break;
                    }
                }
            }
            gcDiscount.DataSource = dtProductDiscount;
            //int Position = 0;
            //dtProductDiscount.Rows.InsertAt(dr, Position);
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

        //Update data of cart
        private void spAmount_EditValueChanged(object sender, EventArgs e)
        {
            string strSKU = "";
            int amount = 0;
            if (gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU) != null)
            {
                strSKU = gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU).ToString();
            }
            SpinEdit s = sender as SpinEdit;
            amount = Convert.ToInt32(s.Text);
            foreach (DataRow dr_update in dtProductDiscount.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update["SoLuong"] = amount;
                    break;
                }
            }
            gcDiscount.DataSource = dtProductDiscount;
        }

        private void spPrice_EditValueChanged(object sender, EventArgs e)
        {
            string strSKU = "";
            decimal price = 0;
            if (gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU) != null)
            {
                strSKU = gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU).ToString();
            }
            SpinEdit s = sender as SpinEdit;
            price = (decimal)s.EditValue;
            foreach (DataRow dr_update in dtProductDiscount.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update["GiamGiaSanPham"] = price;
                    break;
                }
            }
            gcDiscount.DataSource = dtProductDiscount;
        }

        //Delete product in cart
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strSKU = "";
            if (gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU) != null)
            {
                strSKU = gvDiscount.GetRowCellValue(gvDiscount.FocusedRowHandle, ImpSKU).ToString();
            }
            foreach (DataRow dr_update in dtProductDiscount.Rows) // search whole table
            {
                if (dr_update["SKU"].ToString() == strSKU)
                {
                    dr_update.Delete();
                    break;
                }
            }
            dtProductDiscount.AcceptChanges();
            gcDiscount.DataSource = dtProductDiscount;
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
            bool check = !dtProductDiscount.AsEnumerable().Any(x => x.Field<string>("SKU") == strSKU);
            return check;
        }

        private int checkConstraints(string ID)
        {
            string query = String.Format("select count(MaKM)  as count from ChiTietKhuyenMai where MaKM = '{0}'", ID);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            return (int)(dt.Rows[0]["count"]);
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
        private void frmDiscountsDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmDiscountsDetail_Shown(object sender, EventArgs e)
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