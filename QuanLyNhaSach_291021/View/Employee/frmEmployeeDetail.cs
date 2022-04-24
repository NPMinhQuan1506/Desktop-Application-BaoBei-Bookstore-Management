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

namespace QuanLyNhaSach_291021.View.Employee
{
    public partial class frmEmployeeDetail : DevExpress.XtraEditors.XtraForm
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
        //Delegate Add Order
        public delegate void CallOrderForm();
        public CallOrderForm cof;
        //defind variable
        String id = "", dtNow = "";
        bool flag = false;
        bool isAddOrder = false;
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmEmployeeDetail()
        {
            InitializeComponent();
            loadAllLookups();
            dtNow = func.DateTimeToString(DateTime.Now);
        }

        public frmEmployeeDetail(string _id) : this()
        {
            this.id = _id;
            loadData();
            setUpAccountField();
            txtEmployeeID.ReadOnly = true;
        }

        public frmEmployeeDetail(bool isAddOrder = true) : this()
        {
            this.isAddOrder = isAddOrder;
        }
        #endregion

        #region //Load Data For Updating Event
        private void loadData()
        {
            if (this.id != "")
            {
                string query = String.Format(@"Select kh.*,
                                    ha.Anh as Anh,
                                    tk.TenTK as TaiKhoan,
                                    tk.MatKhau as MatKhau
                            from NhanVien as kh
                            left join HinhAnh as ha on kh.MaHA = ha.MaHA
                            left join TaiKhoan_KH as tk on kh.MaTK = tk.MaTK
                            where kh.HienThi = 1 and kh.MaKH = '{0}'", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    if (dtContent.Rows[0]["Anh"] != DBNull.Value)
                    {
                        peAvatar.Image = Image.FromStream(new MemoryStream((byte[])dtContent.Rows[0]["Anh"]));
                    }

                    txtEmployeeID.Text = (dtContent.Rows[0]["MaKH"]).ToString();
                    txtEmployeeName.Text = (dtContent.Rows[0]["TenKH"]).ToString();
                    txtPhone.Text = (dtContent.Rows[0]["DienThoai"]).ToString();
                    txtEmail.Text = (dtContent.Rows[0]["Email"]).ToString();
                    luGender.EditValue = (dtContent.Rows[0]["MaGT"]).ToString();
                    string strDateOfBirth = (dtContent.Rows[0]["NgaySinh"]).ToString();
                    dteDateOfBirth.EditValue = func.StringToDateTime(strDateOfBirth);
                    spSalary.EditValue = (decimal)(dtContent.Rows[0]["Luong"]);
                    String strDte = (dtContent.Rows[0]["NgayThue"]).ToString();
                    dteHiredDate.EditValue = func.StringToDateTime(strDte);
                    txtCitizenID.EditValue = (decimal)(dtContent.Rows[0]["CMND_CCCD"]);
                    luDepartment.EditValue = (dtContent.Rows[0]["MaCV"]).ToString();
                    txtAccount.Text = (dtContent.Rows[0]["TaiKhoan"]).ToString();
                    if ((dtContent.Rows[0]["TaiKhoan"]).ToString() != "")
                    {
                        txtPassword.Text = "User@123";
                    }
                    mmeAddress.Text = (dtContent.Rows[0]["DiaChi"]).ToString();
                    mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                }
            }
        }

        //Set up for account and password in updating case
        private void setUpAccountField()
        {
            if (txtAccount.Text != "" && txtPassword.Text != "")
            {
                txtAccount.ReadOnly = true;
                txtPassword.ReadOnly = true;
                flag = false;
            }
            else
            {
                flag = true;
            }
        }
        #endregion

        #region //Load ComboboxData
        private void loadAllLookups()
        {
            loadLookupData(luGender, "MaGT", "TenGT", "GioiTinh");
            loadLookupData(luDepartment, "MaCV", "TenCV", "ChucVu");
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
            if (isAddOrder)
            {
                vali.SetValidationRule(txtEmployeeID, valueE_ContainRule);
                vali.SetValidationRule(txtEmployeeName, validE_ContainRule);
                vali.SetValidationRule(txtPhone, empty_ContainRule);
                return (vali.Validate());
            }
            vali.SetValidationRule(txtEmployeeID, valueE_ContainRule);
            vali.SetValidationRule(txtEmployeeName, validE_ContainRule);
            vali.SetValidationRule(txtEmail, empty_ContainRule);
            vali.SetValidationRule(txtPhone, empty_ContainRule);
            if (txtAccount.Text != "")
            {
                vali.SetValidationRule(txtPassword, empty_ContainRule);
            }
            vali.SetValidationRule(txtAccount, valid_ContainRule);
            vali.SetValidationRule(txtPassword, valid_ContainRule);
            return (vali.Validate());
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (doValidate())
            {
               
                string MaHA = SaveAvartar(),
                       MaTK = SaveAccount();
                MaHA = MaHA != "" ? MaHA : "null";
                MaTK = MaTK != "" ? MaTK : "null";
                // Event Add Data
                if (this.id == "")
                {
                    if (checkExistence())
                    {
                        String query = String.Format(@"INSERT INTO NhanVien(MaKH, TenKH, MaGT, MaHA, MaCV, CMND_CCCD, MaTK, NgaySinh, Email, DienThoai, DiaChi, GhiChu, NgayTao, Luong, NgayThue) 
                                                values ('{0}', N'{1}', {2}, {3}, {4}, '{5}', {6}, '{7}', N'{8}', '{9}', N'{10}', N'{11}', '{12}',{13},'{14}')",
                                txtEmployeeID.Text,
                                txtEmployeeName.Text,
                                luGender.EditValue,
                                MaHA,
                                luDepartment.EditValue,
                                txtCitizenID.EditValue,
                                MaTK,
                                func.DateTimeToString((DateTime)dteDateOfBirth.EditValue),
                                txtEmail.Text,
                                txtPhone.Text,
                                mmeAddress.Text,
                                mmeNote.Text,
                                dtNow,
                                spSalary.EditValue,
                                func.DateTimeToString((DateTime)dteHiredDate.EditValue));

                        conn.executeDatabase(query);
                        MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Mã Khách Hàng Đã Tồn Tại!");
                    }

                }
                // Event Update Data
                else
                {
                    String query = String.Format(@"UPDATE NhanVien SET TenKH = N'{0}',
                                                                    MaGT = {1}, 
                                                                    MaCV = {2},
                                                                    CMND_CCCD = '{3}',
                                                                    NgaySinh = '{4}',
                                                                    Email = N'{5}',
                                                                    DienThoai = '{6}', 
                                                                    DiaChi = N'{7}',
                                                                    GhiChu = N'{8}',
                                                                    NgayCapNhat = N'{9}',
                                                                    Luong = {10},
                                                                    NgayThue = '{11}'
                                               WHERE MaKH = '{12}'",
                                                   txtEmployeeName.Text,
                                                   luGender.EditValue,
                                                   luDepartment.EditValue,
                                                   txtCitizenID.EditValue,
                                                   func.DateTimeToString((DateTime)dteDateOfBirth.EditValue),
                                                   txtEmail.Text,
                                                   txtPhone.Text,
                                                   mmeAddress.Text,
                                                   mmeNote.Text,
                                                   dtNow,
                                                   spSalary.EditValue,
                                                   func.DateTimeToString((DateTime)dteHiredDate.EditValue),
                                                   this.id);
                    conn.executeDatabase(query);
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
                if (path != "Anh_Khach_Hang")
                {

                    string ext = Path.GetExtension(openFileDialog1.FileName).Remove(0, 1);
                    // Event Add Data
                    if (this.id == "")
                    {
                        String query = String.Format(@"INSERT INTO HinhAnh(Anh, DuoiTep, ChuSoHuu) 
                                                SELECT BulkColumn, '{1}' , 'NhanVien'
                                                       FROM Openrowset( Bulk '{0}', Single_Blob) as img", path, ext);
                        conn.executeDatabase(query);
                        return conn.getLastInsertedValue();
                    }
                    // Event Update Data
                    else
                    {
                        String query = String.Format(@"Update HinhAnh Set Anh = (SELECT BulkColumn
                                                       FROM Openrowset( Bulk '{0}', Single_Blob) as img), DuoiTep = '{1}' 
                                                where MaHA = (Select MaHA from NhanVien Where MaKH = '{2}')", path, ext, this.id);
                        conn.executeDatabase(query);
                        return conn.getLastInsertedValue();
                    }
                }

            }
            return "";
        }

        private string SaveAccount()
        {
            // Event Add Data
            if (this.id == "")
            {
                if (txtAccount.Text != "" && txtPassword.Text != "")
                {
                    String query = String.Format(@"INSERT INTO TaiKhoan_KH(TenTK, MatKhau, NgayTao) 
                                                values ('{0}', '{1}', '{2}')",
                                                    txtAccount.Text,
                                                     Controller.EncryptDecrypt.Encrypt(txtPassword.Text),
                                                    dtNow);
                    conn.executeDatabase(query);
                    return conn.getLastInsertedValue();
                }
            }
            // Event Update Data
            else
            {
                string query = "";
                //flag = true when it's new account
                if (flag)
                {
                    query = String.Format(@"INSERT INTO TaiKhoan_KH(TenTK, MatKhau, NgayTao) 
                                                values ('{0}', '{1}', '{2}'); 
                                            UPDATE NhanVien SET MaTK = (SELECT SCOPE_IDENTITY()) 
                                            where MaTK = (Select MaTK from NhanVien Where MaKH = '{3}');",
                                                     txtAccount.Text,
                                                      Controller.EncryptDecrypt.Encrypt(txtPassword.Text),
                                                     dtNow,
                                                     this.id);

                }
                else
                {
                    if (ckeDefaultPassword.Checked)
                    {
                        query = String.Format(@"Update TaiKhoan_KH Set MatKhau = '{0}', NgayCapNhat = '{1}' 
                                                where MaTK = (Select MaTK from NhanVien Where MaKH = '{2}')",
                                                   Controller.EncryptDecrypt.Encrypt(txtPassword.Text),
                                                   dtNow,
                                                   this.id);
                    }
                }
                if (query != "")
                {
                    conn.executeDatabase(query);
                    return conn.getLastInsertedValue();
                }
            }
            return "";
        }

        private void ckeDefaultPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckeDefaultPassword.Checked)
            {
                txtPassword.Text = @"User@123";
                txtPassword.ReadOnly = true;
            }
            else
            {
                if (this.id == "" || flag)
                {
                    txtPassword.Text = "";
                    txtPassword.ReadOnly = false;
                }
            }
        }
        #endregion

        #region //Check existence data
        private bool checkExistence()
        {
            string query = String.Format("select count(MaKH)  as count from NhanVien where MaKH = '{0}'", txtEmployeeID.Text);
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
            if (this.id == "")
            {
                txtEmployeeID.Text = "";
                txtAccount.Text = "";
                txtPassword.Text = "";
            }
            txtCitizenID.Text = "";
            txtEmployeeName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            spSalary.EditValue = 1000;
            luGender.EditValue = null;
            dteDateOfBirth.EditValue = null;
            dteHiredDate.EditValue = null;
            luDepartment.EditValue = null;
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
        private void frmEmployeeDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmEmployeeDetail_Shown(object sender, EventArgs e)
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