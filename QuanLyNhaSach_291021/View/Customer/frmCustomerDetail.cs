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

namespace QuanLyNhaSach_291021.View.Customer
{
    public partial class frmCustomerDetail : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();

        //defind variable
        String id = "";

        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmCustomerDetail()
        {
            InitializeComponent();
            loadAllLookups();
        }

        public frmCustomerDetail(string _id):this()
        {
            this.id = _id;
            loadData();
            txtPassword.ReadOnly = true;
            ckeDefaultPassword.Checked = false;
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
                            from KhachHang as kh
                            left join HinhAnh as ha on kh.MaHA = ha.MaHA
                            left join TaiKhoan_KH as tk on kh.MaTK = tk.MaTK
                            where kh.HienThi = 1 and kh.MaKH = '{0}'", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    peAvatar.Image = Image.FromStream(new MemoryStream((byte[])dtContent.Rows[0]["Anh"]));
                    txtCustomerID.Text = (dtContent.Rows[0]["MaKH"]).ToString();
                    txtCustomerName.Text = (dtContent.Rows[0]["TenKH"]).ToString();
                    txtPhone.Text = (dtContent.Rows[0]["DienThoai"]).ToString();
                    txtEmail.Text = (dtContent.Rows[0]["Email"]).ToString();
                    luGender.EditValue = (dtContent.Rows[0]["MaGT"]).ToString();
                    string strDateOfBirth = (dtContent.Rows[0]["NgaySinh"]).ToString();
                    dteDateOfBirth.EditValue = func.StringToDateTime(strDateOfBirth);
                    luCustomerGroup.EditValue = (dtContent.Rows[0]["MaNK"]).ToString();
                    luCustomerType.EditValue = (dtContent.Rows[0]["MaLK"]).ToString();
                    txtAccount.Text = (dtContent.Rows[0]["TaiKhoan"]).ToString();
                    txtPassword.Text = (dtContent.Rows[0]["MatKhau"]).ToString();
                    mmeAddress.Text = (dtContent.Rows[0]["DiaChi"]).ToString();
                    mmeNote.Text = (dtContent.Rows[0]["GhiChu"]).ToString();
                }
            }
        }
        #endregion

        #region //Load ComboboxData
        private void loadAllLookups()
        {
            loadLookupData(luGender, "MaGT", "TenGT", "GioiTinh");
            loadLookupData(luCustomerGroup, "MaNK", "TenNK", "NhomKhach");
            loadLookupData(luCustomerType, "MaLK", "TenLK", "LoaiKhach");
        }

        private void loadLookupData(LookUpEdit lu, string value, string display, string tableName)
        {
            string query = String.Format(@"select {0}, {1} from {2}", value, display, tableName);
            lu.Properties.DataSource = conn.loadData(query);
            lu.Properties.DisplayMember = display;
            lu.Properties.ValueMember = value;
        }
        #endregion

        #region //Save Data
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && txtAddress.Text != "")
            //{
            //    // Event Add Data
            //    if (this.id == "")
            //    {
            //        String query = String.Format(@"INSERT INTO Supplier(Name, Phone, Email, Address) 
            //                                    values (N'{0}', N'{1}', N'{2}', N'{3}')",
            //                                    txtName.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
            //        conn.executeDatabase(query);
            //        MessageBox.Show("Created Data Successfully");
            //        this.Close();
            //    }
            //    // Event Update Data
            //    else
            //    {
            //        String query = String.Format(@"UPDATE Supplier SET Name = N'{0}',
            //                                                           Phone = N'{1}',
            //                                                           Email = N'{2}', 
            //                                                           Address = N'{3}' 
            //                                       WHERE id = {4}",
            //                                       txtName.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text, this.id);
            //        conn.executeDatabase(query);
            //        MessageBox.Show("Updated Data Successfully");
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter full information");
            //}
        }
        #endregion

        #region //Read Image 
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = openFileDialog1.FileName;
                openFileDialog1.FileName = "NhanVien_999";
                Bitmap original = (Bitmap)Image.FromFile(fileName);
                peAvatar.Image = new Bitmap(original, new Size(120, 120));
            }
        }
        #endregion

        #region //Clear Value of Control
        private void lbClear_Click(object sender, EventArgs e)
        {
            peAvatar.Image = null;
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            luGender.EditValue = null;
            dteDateOfBirth.EditValue = null;
            luCustomerGroup.EditValue = null;
            luCustomerType.EditValue = null;
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
        private void frmCustomerDetail_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmCustomerDetail_Shown(object sender, EventArgs e)
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