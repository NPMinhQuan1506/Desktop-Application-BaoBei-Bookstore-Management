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

namespace QuanLyNhaSach_291021.View.Department
{
    public partial class frmDepartmentDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        Controller.Validation.ValidEmpty_Contain validE_ContainRule = new Controller.Validation.ValidEmpty_Contain();
        //defind variable
        String id = "", dtNow = "";
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmDepartmentDetail()
        {
            InitializeComponent();
            dtNow = func.DateTimeToString(DateTime.Now);
        }

        public frmDepartmentDetail(string _id) : this()
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
                string query = String.Format(@"Select * from ChucVu where HienThi = 1 and MaCV = {0}", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    txtDepartmentName.EditValue = (dtContent.Rows[0]["TenCV"]).ToString();
                    mmeNote.EditValue = (dtContent.Rows[0]["GhiChu"]).ToString();
                }
            }
        }
        #endregion

        #region //Validation
        private bool doValidate()
        {
            vali.SetValidationRule(txtDepartmentName, validE_ContainRule);
            return (vali.Validate());
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (doValidate())
            {
                if (this.id == "")
                {
                    if (checkExistence())
                    {
                        String query = String.Format(@"INSERT INTO ChucVu(TenCV, GhiChu, NgayTao) 
                                                values (N'{0}', N'{1}', '{2}')",
                                txtDepartmentName.EditValue, mmeNote.Text, dtNow);

                        conn.executeDatabase(query);
                        MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                        this.Close();
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Tên Chức Vụ Đã Tồn Tại!");
                    }

                }
                // Event Update Data
                else
                {
                    String query = String.Format(@"UPDATE ChucVu SET TenCV = N'{0}',
                                                                        GhiChu = N'{1}',    
                                                                    NgayCapNhat = N'{2}' 
                                               WHERE MaCV = {3}",
                                                   txtDepartmentName.EditValue,
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
            string query = String.Format("select count(MaCV)  as count from ChucVu where TenCV = N'{0}'", txtDepartmentName.Text);
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
            txtDepartmentName.Text = "";
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
        private void frmDepartmentDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmDepartmentDetail_Shown(object sender, EventArgs e)
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