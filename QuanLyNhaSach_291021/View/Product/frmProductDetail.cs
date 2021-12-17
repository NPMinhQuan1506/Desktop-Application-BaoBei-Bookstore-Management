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

namespace QuanLyNhaSach_291021.View.Product
{
    public partial class frmProductDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        Controller.Validation.ValueEmpty_Contain valueE_ContainRule = new Controller.Validation.ValueEmpty_Contain();
        Controller.Validation.ValidEmpty_Contain validE_ContainRule = new Controller.Validation.ValidEmpty_Contain();
        Controller.Validation.Empty_Contain empty_ContainRule = new Controller.Validation.Empty_Contain();
        Controller.Validation.Value_Contain value_ContainRule = new Controller.Validation.Value_Contain();
        Controller.Validation.Valid_Contain valid_ContainRule = new Controller.Validation.Valid_Contain();
        //defind variable
        String id = "", dtNow = "";
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmProductDetail()
        {
            InitializeComponent();
            loadAllLookups();
            dtNow = func.DateTimeToString(DateTime.Now);
        }

        public frmProductDetail(string _id) : this()
        {
            this.id = _id;
            loadData();
            txtSKU.ReadOnly = true;
        }
        #endregion

        #region //Load Data For Updating Event
        private void loadData()
        {
            if (this.id != "")
            {
                string query = String.Format(@"Select  sp.*, h.Anh , cts.*
                                                from SanPham as sp
							                    left join HinhAnh as h on sp.MaHA = h.MaHA
                                                left join (select ISBN as dISBN, MaNXB, MaTG, NamXuatBanDauTien, NamXuatBanMoiNhat, SoTrang 
									                       from ChiTietSach as ct 
									                    ) as cts on sp.ISBN = cts.dISBN
                                                where sp.HienThi = 1 and SKU = '{0}'", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    string strDte = "";
                    if (dtContent.Rows[0]["Anh"] != DBNull.Value)
                    {
                        peAvatar.Image = Image.FromStream(new MemoryStream((byte[])dtContent.Rows[0]["Anh"]));
                    }
                    txtSKU.Text = (dtContent.Rows[0]["SKU"]).ToString();
                    txtProductName.Text = (dtContent.Rows[0]["TenSP"]).ToString();
                    luType.EditValue = (dtContent.Rows[0]["MaHT"]).ToString();
                    luCategory.EditValue = (dtContent.Rows[0]["MaTL"]).ToString();

                    cbbLanguage.EditValue = (dtContent.Rows[0]["NgonNgu"]).ToString();
                    txtEdition.Text = (dtContent.Rows[0]["PhienBan"]).ToString();
                    luAuthor.EditValue = (dtContent.Rows[0]["MaTG"]).ToString();
                    luPublisher.EditValue = (dtContent.Rows[0]["MaNXB"]).ToString();
                    luSupplier.EditValue = (dtContent.Rows[0]["MaNCC"]).ToString();
                    rtEvaluate.EditValue = (dtContent.Rows[0]["DanhGia"]);
                    spNumberStock.EditValue = (int)(dtContent.Rows[0]["SoLuongTon"]);
                    spMinNumberStock.EditValue = (int)(dtContent.Rows[0]["TonToiThieu"]);

                    cbbUnit.EditValue = (dtContent.Rows[0]["DonViTinh"]).ToString();
                    spPrice.EditValue = (Decimal)(dtContent.Rows[0]["GiaBan"]);
                    spNumberPage.EditValue = (dtContent.Rows[0]["SoTrang"]).ToString();

                    strDte = (dtContent.Rows[0]["NamXuatBanDauTien"]).ToString();
                    dteFirstYearPublication.EditValue = func.StringToDateTime(strDte);
                    strDte = (dtContent.Rows[0]["NamXuatBanMoiNhat"]).ToString();
                    dteLastestYearPublication.EditValue = func.StringToDateTime(strDte);

                    mmeDescription.Text = (dtContent.Rows[0]["MoTa"]).ToString();
                }
            }
        }
        #endregion

        #region //Load ComboboxData
        private void loadAllLookups()
        {
            loadLookupData(luType, "MaHT", "TenHT", "HinhThuc");
            loadLookupData(luCategory, "MaTL", "TenTL", "TheLoai");
            loadLookupData(luAuthor, "MaTG", "TenTG", "TacGia");
            loadLookupData(luPublisher, "MaNXB", "TenNXB", "NhaXuatBan");
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

        #region //Validation
        private bool doValidate()
        {
            vali.SetValidationRule(txtSKU, empty_ContainRule);
            vali.SetValidationRule(txtProductName, validE_ContainRule);
            return (vali.Validate());
        }


        private void dteFirstYearPublication_EditValueChanged(object sender, EventArgs e)
        {
            dteLastestYearPublication.Properties.MinValue = (DateTime)dteFirstYearPublication.EditValue;
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (doValidate())
            {
                string MaHA = SaveAvartar();
                MaHA = MaHA != "" ? MaHA : "null";
                // Event Add Data
                if (this.id == "")
                {
                    if (checkExistence())
                    {
                        String query = String.Format(@"INSERT INTO SanPham(SKU, ISBN, TenSP, MaHA, MaNCC, MaHT, MaTL, NgonNgu, PhienBan, 
                                                                           SoLuongTon, TonToiThieu, DonViTinh, GiaBan, DanhGia, MoTa, NgayTao) 
                                                values ('{0}', '{1}', N'{2}', {3}, '{4}', {5}, {6}, N'{7}', N'{8}', {9}, {10}, N'{11}', {12}, {13}, N'{14}', '{15}')",
                                txtSKU.Text,
                                txtSKU.Text,
                                txtProductName.Text,
                                MaHA,
                                luSupplier.EditValue,
                                luType.EditValue,
                                luCategory.EditValue,
                                cbbLanguage.EditValue,
                                txtEdition.Text,
                                spNumberPage.EditValue,
                                spMinNumberStock.EditValue,
                                cbbUnit.EditValue,
                                spPrice.EditValue,
                                rtEvaluate.EditValue,
                                mmeDescription.Text,
                                dtNow);

                        conn.executeDatabase(query);
                        //Insert Detail
                        String query1 = String.Format(@"INSERT INTO ChiTietSach(ISBN, MaNXB, MaTG, NamXuatBanDauTien, NamXuatBanMoiNhat, SoTrang) 
                                                values ('{0}', {1}, {2}, '{3}', '{4}', {5})",
                                txtSKU.Text,
                                luPublisher.EditValue,
                                luAuthor.EditValue,
                                func.DateTimeToString((DateTime)dteFirstYearPublication.EditValue),
                                func.DateTimeToString((DateTime)dteLastestYearPublication.EditValue),
                                spPrice.EditValue);
                        conn.executeDatabase(query1);
                        MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Mã Sản Phẩm Đã Tồn Tại!");
                    }

                }
                // Event Update Data
                else
                {
                    String query = String.Format(@"UPDATE SanPham SET  TenSP = N'{0}', 
                                                                       MaNCC = '{1}', 
                                                                       MaHT = {2}, 
                                                                       MaTL = {3}, 
                                                                       NgonNgu = N'{4}', 
                                                                       PhienBan = N'{5}', 
                                                                       SoLuongTon = {6},  
                                                                       TonToiThieu = {7}, 
                                                                       DonViTinh = N'{8}', 
                                                                       GiaBan = {9}, 
                                                                       DanhGia = {10}, 
                                                                       MoTa = N'{11}',
                                                                       NgayCapNhat = '{12}' 
                                               WHERE SKU = '{13}'",
                                                txtProductName.Text,
                                                luSupplier.EditValue,
                                                luType.EditValue,
                                                luCategory.EditValue,
                                                cbbLanguage.EditValue,
                                                txtEdition.Text,
                                                spNumberPage.EditValue,
                                                spMinNumberStock.EditValue,
                                                cbbUnit.EditValue,
                                                spPrice.EditValue,
                                                rtEvaluate.EditValue,
                                                mmeDescription.Text,
                                                dtNow,
                                                this.id);
                    conn.executeDatabase(query);
                    //Update Detail
                    String query1 = String.Format(@"UPDATE ChiTietSach Set MaNXB = {0}, 
                                                                   MaTG = {1}, 
                                                                   NamXuatBanDauTien = '{2}', 
                                                                   NamXuatBanMoiNhat = '{3}', 
                                                                   SoTrang = {4}
                                            WHERE ISBN = '{5}'",
                               luPublisher.EditValue,
                               luAuthor.EditValue,
                               func.DateTimeToString((DateTime)dteFirstYearPublication.EditValue),
                               func.DateTimeToString((DateTime)dteLastestYearPublication.EditValue),
                               spPrice.EditValue,
                               this.id);

                    conn.executeDatabase(query1);
                    MyMessageBox.ShowMessage("Sửa Dữ Liệu Thành Công!");
                    this.Close();
                }
            }
        }

        private string SaveAvartar()
        {
            if (peAvatar.EditValue != null)
            {
                string path = openFileDialog1.FileName;
                if (path != "Anh_San_Pham")
                {

                    string ext = Path.GetExtension(openFileDialog1.FileName).Remove(0, 1);
                    // Event Add Data
                    if (this.id == "")
                    {
                        String query = String.Format(@"INSERT INTO HinhAnh(Anh, DuoiTep, ChuSoHuu) 
                                                SELECT BulkColumn, '{1}' , 'SanPham'
                                                       FROM Openrowset( Bulk '{0}', Single_Blob) as img", path, ext);
                        conn.executeDatabase(query);
                        return conn.getLastInsertedValue();
                    }
                    // Event Update Data
                    else
                    {
                        String query = String.Format(@"Update HinhAnh Set Anh = (SELECT BulkColumn
                                                       FROM Openrowset( Bulk '{0}', Single_Blob) as img), DuoiTep = '{1}' 
                                                where MaHA = (Select MaHA from SanPham Where SKU = '{2}')", path, ext, this.id);
                        conn.executeDatabase(query);
                        return conn.getLastInsertedValue();
                    }
                }

            }
            return "";
        }
        #endregion

        #region //Check existence data
        private bool checkExistence()
        {
            string query = String.Format("select count(SKU)  as count from SanPham where SKU = '{0}'", txtSKU.Text);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            if ((int)(dt.Rows[0]["count"]) > 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region //Read Image 
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                Bitmap original = (Bitmap)Image.FromFile(fileName);
                peAvatar.Image = new Bitmap(original, new Size(120, 120));
            }
        }
        #endregion

        #region //Clear Value of Control
        private void lbClear_Click(object sender, EventArgs e)
        {
            peAvatar.Image = null;
            txtProductName.Text = String.Empty;
            luType.EditValue = null;
            luCategory.EditValue = null;

            cbbLanguage.EditValue = null;
            txtEdition.Text = String.Empty;
            luAuthor.EditValue = null;
            luPublisher.EditValue = null;
            luSupplier.EditValue = null;
            rtEvaluate.EditValue = null;
            spNumberStock.EditValue = null;
            spMinNumberStock.EditValue = null;

            cbbUnit.EditValue = null;
            spPrice.EditValue = null;
            spNumberPage.EditValue = null;

            dteFirstYearPublication.EditValue = null;

            dteLastestYearPublication.EditValue = null;

            mmeDescription.Text = String.Empty;
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
        private void frmProductDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmProductDetail_Shown(object sender, EventArgs e)
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