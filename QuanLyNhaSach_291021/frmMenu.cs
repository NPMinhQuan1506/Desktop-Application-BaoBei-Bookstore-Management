using DevExpress.XtraBars;
using QuanLyNhaSach_291021.View.Notification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyNhaSach_291021
{
    public partial class frmMenu : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void aceDashboard_Click(object sender, EventArgs e)
        {
            MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
            DialogResult Result = MyMessageBox.ShowMessage("Dashboard Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                MyMessageBox.ShowMessage("Yes!");
            }
            else if (Result == DialogResult.No)
            {
                MyMessageBox.ShowMessage("No!");
            }
        }

        private void aceCustomer_Click(object sender, EventArgs e)
        {
            if (!pnContainer.Controls.Contains(View.Customer.ctrCustomerList.instance))
            {
                pnContainer.Controls.Add(View.Customer.ctrCustomerList.instance);
                View.Customer.ctrCustomerList.instance.Dock = DockStyle.Fill;
                View.Customer.ctrCustomerList.instance.BringToFront();
            }
            View.Customer.ctrCustomerList.instance.BringToFront();
            //pnContainer.Controls.Clear();
            //View.Customer.ctrCustomerList ctr = new View.Customer.ctrCustomerList();
            //ctr.Dock = DockStyle.Fill;
            //pnContainer.Controls.Add(ctr);
        }

        // Product Management
        private void aceAuthor_Click(object sender, EventArgs e)
        {
            if (!pnContainer.Controls.Contains(View.Author.ctrAuthorList.instance))
            {
                pnContainer.Controls.Add(View.Author.ctrAuthorList.instance);
                View.Author.ctrAuthorList.instance.Dock = DockStyle.Fill;
                View.Author.ctrAuthorList.instance.BringToFront();
            }
            View.Author.ctrAuthorList.instance.BringToFront();
        }

        private void acePublisher_Click(object sender, EventArgs e)
        {
            if (!pnContainer.Controls.Contains(View.Publisher.ctrPublisherList.instance))
            {
                pnContainer.Controls.Add(View.Publisher.ctrPublisherList.instance);
                View.Publisher.ctrPublisherList.instance.Dock = DockStyle.Fill;
                View.Publisher.ctrPublisherList.instance.BringToFront();
            }
            View.Publisher.ctrPublisherList.instance.BringToFront();
        }

        private void aceCategories_Click(object sender, EventArgs e)
        {
            if (!pnContainer.Controls.Contains(View.Categories.ctrCategoriesList.instance))
            {
                pnContainer.Controls.Add(View.Categories.ctrCategoriesList.instance);
                View.Categories.ctrCategoriesList.instance.Dock = DockStyle.Fill;
                View.Categories.ctrCategoriesList.instance.BringToFront();
            }
            View.Categories.ctrCategoriesList.instance.BringToFront();
        }

        private void aceProduct_Click(object sender, EventArgs e)
        {

        }

        private void acgEmployee_Click(object sender, EventArgs e)
        {

        }

        //CRM
        private void aceDepartment_Click(object sender, EventArgs e)
        {

        }

        private void aceSupplier_Click(object sender, EventArgs e)
        {
            if (!pnContainer.Controls.Contains(View.Supplier.ctrSupplierList.instance))
            {
                pnContainer.Controls.Add(View.Supplier.ctrSupplierList.instance);
                View.Supplier.ctrSupplierList.instance.Dock = DockStyle.Fill;
                View.Supplier.ctrSupplierList.instance.BringToFront();
            }
            View.Supplier.ctrSupplierList.instance.BringToFront();
        }
    }
}
