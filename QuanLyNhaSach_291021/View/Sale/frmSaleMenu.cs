using DevExpress.XtraBars;
using QuanLyNhaSach_291021.Controller;
using QuanLyNhaSach_291021.View.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyNhaSach_291021.View.Sale
{
    public partial class frmSaleMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleMenu));
        public frmSaleMenu()
        {
            InitializeComponent();
            lbName.Text = Global.EmpName;
        }

        private void aceSale_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceSale");
            pnContainer.Controls.Clear();
            ctrSale ctr = new ctrSale();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);

        }

        private void aceLogout_Click(object sender, EventArgs e)
        {
            MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
            DialogResult Result = MyMessageBox.ShowMessage("Bạn Có Muốn Thoát Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                MyMessageBox.ShowMessage("Xin chào! Hẹn Gặp Lại");
                this.Close();
            }
            else if (Result == DialogResult.No)
            {
                string s = Controller.EncryptDecrypt.Encrypt("admin123");
            
                MyMessageBox.ShowMessage("Cảm Ơn!");
            }
        }

        private void setImageCurrentPage(string namePage)
        {
            this.lbCurrentListIcon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject(namePage + ".ImageOptions.SvgImage")));
        }

        private void aceStatistical_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceStatistical");
            DateTime dtNow = DateTime.Now;
            string mode = "Báo Cáo Theo Ngày";
            pnContainer.Controls.Clear();
            View.Revenue.ctrDetailStatistics ctr = new View.Revenue.ctrDetailStatistics((dtNow.AddDays(-1)).Date, dtNow, mode);
            ctr.Dock = DockStyle.Fill;
            ctr.BringToFront();
            pnContainer.Controls.Add(ctr);
        }
    }
}
