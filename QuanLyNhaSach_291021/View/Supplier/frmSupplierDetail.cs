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

namespace QuanLyNhaSach_291021.View.Supplier
{
    public partial class frmSupplierDetail : DevExpress.XtraEditors.XtraForm
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
        //MovePanel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmSupplierDetail()
        {
            InitializeComponent();
            dtNow = func.DateTimeToString(DateTime.Now);
        }

        public frmSupplierDetail(string _id) : this()
        {
            this.id = _id;
            loadData();
            txtSupplierID.ReadOnly = true;
        }
        #endregion

        #region //Load Data For Updating Event
        private void loadData()
        {
            if (this.id != "")
            {
                string query = String.Format(@"Select * from NhaCungCap
                            where HienThi = 1 and MaNCC = '{0}'", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    txtSupplierID.Text = (dtContent.Rows[0]["MaNCC"]).ToString();
                    txtSupplierName.Text = (dtContent.Rows[0]["TenNCC"]).ToString();
                    txtTaxCode.Text = (dtContent.Rows[0]["MaSoThue"]).ToString();
                    txtPhone.Text = (dtContent.Rows[0]["DienThoai"]).ToString();
                    txtEmail.Text = (dtContent.Rows[0]["Email"]).ToString();
                    mmeAddress.Text = (dtContent.Rows[0]["DiaChi"]).ToString();
                    mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                }
            }
        }
        #endregion


        #region //Validation
        private bool doValidate()
        {
            vali.SetValidationRule(txtSupplierID, valueE_ContainRule);
            vali.SetValidationRule(txtSupplierName, validE_ContainRule);
            vali.SetValidationRule(txtEmail, empty_ContainRule);
            vali.SetValidationRule(txtPhone, empty_ContainRule);
            vali.SetValidationRule(mmeAddress, empty_ContainRule);
            vali.SetValidationRule(txtTaxCode, value_ContainRule);
            return (vali.Validate());
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (doValidate())
            {
                // Event Add Data
                if (this.id == "")
                {
                    if (checkExistence())
                    {
                        String query = String.Format(@"INSERT INTO NhaCungCap(MaNCC, TenNCC, MaSoThue, Email, DienThoai, DiaChi, GhiChu, NgayTao) 
                                                values ('{0}', N'{1}', '{2}', '{3}', '{4}', N'{5}', N'{6}', '{7}')",
                                txtSupplierID.Text,
                                txtSupplierName.Text,
                                txtTaxCode.Text,
                                txtEmail.Text,
                                txtPhone.Text,
                                mmeAddress.Text,
                                mmeNote.Text,
                                dtNow);

                        conn.executeDatabase(query);
                        MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Mã Nhà Cung Cấp Đã Tồn Tại!");
                    }

                }
                // Event Update Data
                else
                {
                    String query = String.Format(@"UPDATE NhaCungCap SET TenNCC = N'{0}',
                                                                    MaSoThue = '{1}', 
                                                                    Email = N'{2}',
                                                                    DienThoai = '{3}', 
                                                                    DiaChi = N'{4}',
                                                                    GhiChu = N'{5}',
                                                                    NgayCapNhat = N'{6}' 
                                               WHERE MaNCC = '{7}'",
                                                   txtSupplierName.Text,
                                                   txtTaxCode.Text,
                                                   txtEmail.Text,
                                                   txtPhone.Text,
                                                   mmeAddress.Text,
                                                   mmeNote.Text,
                                                   dtNow,
                                                   this.id);
                    conn.executeDatabase(query);
                    MyMessageBox.ShowMessage("Sửa Dữ Liệu Thành Công!");
                    this.Close();
                }
            }
        }

        #endregion

        #region //Check existence data
        private bool checkExistence()
        {
            string query = String.Format("select count(MaNCC) as count from NhaCungCap where MaNCC = '{0}' or MaSoThue = '{1}'", txtSupplierID.Text, txtTaxCode.Text);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            if ((int)(dt.Rows[0]["count"]) > 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region //Clear Value of Control
        private void lbClear_Click(object sender, EventArgs e)
        {
            if (this.id == "")
            {
                txtSupplierID.Text = "";
                txtTaxCode.Text = "";
            }
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            mmeAddress.Text = "";
            mmeNote.Text = "";
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
        private void frmSupplierDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmSupplierDetail_Shown(object sender, EventArgs e)
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