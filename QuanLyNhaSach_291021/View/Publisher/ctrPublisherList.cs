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

namespace QuanLyNhaSach_291021.View.Publisher
{
    public partial class ctrPublisherList : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string emptyGridText = "Không có dữ liệu";

        //defind variable search and filter

        //defind generate instance 

        private static ctrPublisherList _instance;

        public static ctrPublisherList instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctrPublisherList();
                }
                return _instance;
            }
        }
        #endregion

        #region //Contructor

        public ctrPublisherList()
        {
            InitializeComponent();

            string placehoder = txtSearch.Properties.NullText;
            func.createPlaceHolderControl(txtSearch, placehoder);
        }

        #endregion

        #region //Setup GridView
        //Create Serial No For GridView
        private void gvPublisher_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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
        private void gvPublisher_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.Name == "NO")
            {
                e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            }

            if (e.Column.Name == "PublisherName")
            {
                e.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            }
        }


        private void gvPublisher_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
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
            frmPublisherDetail frm = new frmPublisherDetail();
            frm.ShowDialog();
            loadData();
        }
        #endregion

        #region //Read

        private void gcPublisher_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string query = @"Select * from NhaXuatBan where HienThi = 1 ";
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(query);
            gcPublisher.DataSource = dtContent;
        }

        private void loadData(string _query)
        {
            DataTable dtContent = new DataTable();
            dtContent = conn.loadData(_query);
            gcPublisher.DataSource = dtContent;
        }

        #endregion

        #region //Update
        private void btnEdit_Click(object sender, EventArgs e)
        {
            update();
        }

        private void gvPublisher_DoubleClick(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (getID() != "")
            {
                string ID = getID();
                frmPublisherDetail frm = new frmPublisherDetail(ID);
                frm.ShowDialog();
                loadData();
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
                DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Chắc Xóa Nhà Xuất Bản Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

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
            if (checkConstraints(IdDeleting))
            {

                string query = String.Format("Delete NhaXuatBan Where MaNXB = {0}; ", IdDeleting);
                conn.executeDatabase(query);
                MyMessageBox.ShowMessage("Xóa Dữ Liệu Thành Công!");
                loadData();
            }
            else
            {
                MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
                DialogResult Result = MyMessageBox.ShowMessage(@"Lưu Ý! Tồn Tại Sách Thuộc Nhà Xuất Bản Này.\n Bạn Vẫn Muốn Tiếp Tục?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    string query = String.Format("Update NhaXuatBan Set HienThi = 0 Where MaNXB = {0}", IdDeleting);
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
            string query = String.Format("select count(MaNXB) as count from ChiTietSach where MaNXB = {0}", IdDeleting);
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

            if (gvPublisher.GetRowCellValue(gvPublisher.FocusedRowHandle, PublisherId) != null)
            {
                string ID = gvPublisher.GetRowCellValue(gvPublisher.FocusedRowHandle, PublisherId).ToString();
                return ID;
            }
            return "";
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
            gvPublisher.FindFilterText = string.Format("\"{0}\"", txtSearch.EditValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.EditValue = "";
        }
        #endregion
    }
}
