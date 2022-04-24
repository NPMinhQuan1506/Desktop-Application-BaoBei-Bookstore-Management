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

namespace QuanLyNhaSach_291021.View.Authority
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        #region //Define Class and Variable
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //Validation Rule
        //Controller.Validation.ValidEmpty_Contain validE_ContainRule = new Controller.Validation.ValidEmpty_Contain();
        //defind variable
        String mode = "USER";
        //Move Panel
        Boolean dragging = false;
        Point startPoint = new Point(0, 0);
        #endregion

        #region //Contructor
        public frmLogin()
        {
            InitializeComponent();
            txtAccount.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(0, 0, 20) });
            txtPassword.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(0, 0, 20) });
            this.Controls.Add(new Label()
            { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(0, 0, 20) });
            this.Controls.Add(new Label()
            { Width = 1, Dock = DockStyle.Left, BackColor = Color.FromArgb(0,0,20) });
            this.Controls.Add(new Label()
            { Width = 1, Dock = DockStyle.Right, BackColor = Color.FromArgb(0, 0, 20) });
        }
        #endregion

        #region //Login

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void login()
        {

            if (mode == "USER")
            {
                if (Controller.Global.AuthorityLogin(txtAccount.Text, txtPassword.Text, mode))
                {
                    View.Sale.frmSaleMenu frm = new Sale.frmSaleMenu();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                if (Controller.Global.AuthorityLogin(txtAccount.Text, txtPassword.Text, mode))
                {
                    frmMenu frm = new frmMenu();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
            }
        }

        #endregion

        #region //Change Mode login
        private void tgLoginMode_Toggled(object sender, EventArgs e)
        {
            if(tgLoginMode.IsOn == true)
            {
                mode = "ADMIN";
                lbTitle.Text = "Admin";
            }
            else
            {
                mode = "USER";
                lbTitle.Text = "User";
            }
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
        private void frmLogin_Resize(object sender, EventArgs e)
        {
            this.Region = DevExpress.Utils.Drawing.Helpers.NativeMethods.CreateRoundRegion(new Rectangle(Point.Empty, Size), 9);
        }

        private void frmLogin_Shown(object sender, EventArgs e)
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