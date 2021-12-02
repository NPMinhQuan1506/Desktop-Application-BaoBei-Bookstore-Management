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

namespace QuanLyNhaSach_291021.View.Author
{
    public partial class ctrAuthorList : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string id = "";
        string emptyGridText = "Không có dữ liệu";

        //defind variable search and filter

        //defind generate instance   

        private static ctrAuthorList _instance;

        public static ctrAuthorList instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctrAuthorList();
                }
                return _instance;
            }
        }
        #endregion

        #region //Contructor

        public ctrAuthorList()
        {
            InitializeComponent();

            string placehoder = txtAuthorName.Properties.NullText;
            func.createPlaceHolderControl(txtAuthorName, placehoder);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveData();
            loadData();
        }

        private void saveData()
        {
            var dtNow = func.DateTimeToString(DateTime.Now);
            // Event Add Data
            if ((txtAuthorName.EditValue).ToString().Trim() != "")
            {
                if (this.id == "")
                {
                    if (checkExistence())
                    {
                        String query = String.Format(@"INSERT INTO TacGia(TenTG, NgayTao) 
                                                values (N'{0}', '{1}')",
                                txtAuthorName.EditValue, dtNow);

                        conn.executeDatabase(query);
                        MyMessageBox.ShowMessage("Thêm Dữ Liệu Thành Công!");
                        txtAuthorName.EditValue = String.Empty;
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Tên Tác Giả Đã Tồn Tại!");
                    }

                }
                // Event Update Data
                else
                {
                    String query = String.Format(@"UPDATE TacGia SET TenTG = N'{0}',
                                                                    NgayCapNhat = N'{1}' 
                                               WHERE MaTG = '{2}'",
                                                   txtAuthorName.EditValue,
                                                   dtNow,
                                                   this.id);
                    conn.executeDatabase(query);
                    MyMessageBox.ShowMessage("Sửa Dữ Liệu Thành Công!");
                    txtAuthorName.EditValue = String.Empty;
                    this.id = "";
                    txtAuthorName.EditValue = "";
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Không Được Để Trống Tên Tác Giả!");
            }
        }

        private bool checkExistence()
        {
            string query = String.Format("select count(MaTG) as count from TacGia where TenTG = N'{0}'", txtAuthorName.EditValue);
            DataTable dt = new DataTable();
            dt = conn.loadData(query);
            if ((int)(dt.Rows[0]["count"]) > 0)
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.id = "";
            txtAuthorName.EditValue = "";
        }
        #endregion

        #region //Read

        private void gcCustomer_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = @"Select * from TacGia where HienThi = 1 ";
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            gcAuthor.DataSource = dtContent;
        }

        #endregion

        #region //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            loadDataUpdating();
        }

        private void gvCustomer_DoubleClick(object sender, EventArgs e)
        {
            loadDataUpdating();
        }

        private void loadDataUpdating()
        {
            this.id = getID();
            if (this.id != "")
            {
                string query = String.Format(@"Select * from TacGia where HienThi = 1 and MaTG = {0}", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    txtAuthorName.EditValue = (dtContent.Rows[0]["TenTG"]).ToString();
                }
            }
        }

        #endregion

        #region //Delete

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (getID() != "")
            {
                string IdDeleting = getID();
                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Tác Giả Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    delete(IdDeleting);
                }
                else if (Result == DialogResult.No)
                {
                    MyMessageBox.ShowMessage("Dữ liệu vẫn tồn tại!");
                }
            }
        }

        private void delete(string IdDeleting)
        {
            this.id = "";
            txtAuthorName.EditValue = "";
            if (checkConstraints(IdDeleting))
            {

                string query = String.Format("Delete TacGia Where MaTG = '{0}'; ", IdDeleting);
                conn.executeDatabase(query);
                MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
                loadData();
            }
            else
            {
                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage(@"Lưu Ý! Tồn Tại Sách Thuộc Tác Giả Này.\n Bạn Vẫn Muốn Tiếp Tục?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    string query = String.Format("Update TacGia Set HienThi = 0 Where MaTG = '{0}'", IdDeleting);
                    MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
                    loadData();
                }
                else if (Result == DialogResult.No)
                {
                    MyMessageBox.ShowMessage("Dữ liệu vẫn tồn tại!");
                }
            }
        }

        private bool checkConstraints(string IdDeleting)
        {
            string query = String.Format("select count(MaTG) as count from ChiTietSach where MaTG = '{0}'", IdDeleting);
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
            if (gvAuthor.GetRowCellValue(gvAuthor.FocusedRowHandle, AuthorId) != null)
            {
                string ID = gvAuthor.GetRowCellValue(gvAuthor.FocusedRowHandle, AuthorId).ToString();
                return ID;
            }
            return "";
        }
        #endregion

        #region //Search and Filter

        private void txtAuthorName_EditValueChanged(object sender, EventArgs e)
        {
            if (txtAuthorName.Text != txtAuthorName.Properties.NullText)
            {
                if(txtAuthorName.Text == "")
                {
                    txtAuthorName.EditValue = "";
                }
                txtAuthorName.ForeColor = Color.FromArgb(0, 0, 20);
            }
            else
            {
                txtAuthorName.ForeColor = Color.FromArgb(144, 142, 144);
            }
            gvAuthor.FindFilterText = string.Format("\"{0}\"", txtAuthorName.EditValue);

        }
        #endregion
    }
}
