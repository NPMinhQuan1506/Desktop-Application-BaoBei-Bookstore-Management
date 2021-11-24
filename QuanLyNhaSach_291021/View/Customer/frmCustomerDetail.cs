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
        }

        public frmCustomerDetail(string _id):this()
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
                string query = String.Format(@"select * from Supplier where id = {0}", this.id);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent.Rows.Count > 0)
                {
                    //txtName.Text = (dtContent.Rows[0]["Name"]).ToString();
                    //txtPhone.Text = (dtContent.Rows[0]["Phone"]).ToString();
                    //txtEmail.Text = (dtContent.Rows[0]["Email"]).ToString();
                    //txtAddress.Text = (dtContent.Rows[0]["Address"]).ToString();
                }
            }
        }
        #endregion

        #region //Load ComboboxData

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

        #region //Clear Value of Control
        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtName.Text = "";
            //txtPhone.Text = "";
            //txtEmail.Text = "";
            //txtAddress.Text = "";
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