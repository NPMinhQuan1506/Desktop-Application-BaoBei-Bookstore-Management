﻿using DevExpress.XtraBars;
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
        public frmMenu()
        {
            InitializeComponent();
        }

        private void aceDashboard_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceDashboard");
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
            setImageCurrentPage("aceCustomer");
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
            setImageCurrentPage("aceAuthor");
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
            setImageCurrentPage("acePublisher");
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
            setImageCurrentPage("aceCategories");
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
            setImageCurrentPage("aceProduct");
            pnContainer.Controls.Clear();
            View.Product.ctrProductList ctr = new View.Product.ctrProductList();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
            //if (!pnContainer.Controls.Contains(View.Product.ctrProductList.instance))
            //{
            //    pnContainer.Controls.Add(View.Product.ctrProductList.instance);
            //    View.Product.ctrProductList.instance.Dock = DockStyle.Fill;
            //    View.Product.ctrProductList.instance.BringToFront();
            //}
            //View.Product.ctrProductList.BringToFront();
        }

        private void acgEmployee_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("acgEmployee");
        }

        //CRM
        private void aceDepartment_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceDepartment");
        }

        private void aceSupplier_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceSupplier");
            if (!pnContainer.Controls.Contains(View.Supplier.ctrSupplierList.instance))
            {
                pnContainer.Controls.Add(View.Supplier.ctrSupplierList.instance);
                View.Supplier.ctrSupplierList.instance.Dock = DockStyle.Fill;
                View.Supplier.ctrSupplierList.instance.BringToFront();
            }
            View.Supplier.ctrSupplierList.instance.BringToFront();
        }

        private void aceImport_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceImport");
            pnContainer.Controls.Clear();
            View.Imports.ctrImportsList ctr = new View.Imports.ctrImportsList();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
            //if (!pnContainer.Controls.Contains(View.Imports.ctrImportsList.instance))
            //{
            //    pnContainer.Controls.Add(View.Imports.ctrImportsList.instance);
            //    View.Imports.ctrImportsList.instance.Dock = DockStyle.Fill;
            //    View.Imports.ctrImportsList.instance.BringToFront();
            //}
            //View.Imports.ctrImportsList.instance.BringToFront();
        }

        private void aceStock_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceStock");
            pnContainer.Controls.Clear();
            View.Stock.ctrStockStatistics ctr = new View.Stock.ctrStockStatistics();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
            //if (!pnContainer.Controls.Contains(View.Stock.ctrStockStatistics.instance))
            //{
            //    pnContainer.Controls.Add(View.Stock.ctrStockStatistics.instance);
            //    View.Stock.ctrStockStatistics.instance.Dock = DockStyle.Fill;
            //    View.Stock.ctrStockStatistics.instance.BringToFront();
            //}
            //View.Stock.ctrStockStatistics.instance.BringToFront();
        }


        private void aceDiscount_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceDiscount");
            pnContainer.Controls.Clear();
            View.Discount.ctrDiscountList ctr = new View.Discount.ctrDiscountList();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
            //if (!pnContainer.Controls.Contains(View.Discount.ctrDiscountList.instance))
            //{
            //    pnContainer.Controls.Add(View.Discount.ctrDiscountList.instance);
            //    View.Discount.ctrDiscountList.instance.Dock = DockStyle.Fill;
            //    View.Discount.ctrDiscountList.instance.BringToFront();
            //}
            //View.Discount.ctrDiscountList.instance.BringToFront();
        }

        private void aceOrder_Click(object sender, EventArgs e)
        {
            setImageCurrentPage("aceOrder");
            pnContainer.Controls.Clear();
            View.Order.ctrOrderList ctr = new View.Order.ctrOrderList();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
            //if (!pnContainer.Controls.Contains(View.Order.ctrOrderList.instance))
            //{
            //    pnContainer.Controls.Add(View.Order.ctrOrderList.instance);
            //    View.Order.ctrOrderList.instance.Dock = DockStyle.Fill;
            //    View.Order.ctrOrderList.instance.BringToFront();
            //}
            //View.Order.ctrOrderList.instance.BringToFront();
        }

        private void setImageCurrentPage(string namePage)
        {
            this.lbCurrentListIcon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject(namePage+".ImageOptions.SvgImage")));
        }
    }
}
