using DevExpress.XtraBars;
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

        private void aceCustomer_Click(object sender, EventArgs e)
        {
            //if (!pnContainer.Controls.Contains(View.Customer.ctrCustomerList.instance))
            //{
            //   pnContainer.Controls.Add(View.Customer.ctrCustomerList.instance);
            //    View.Customer.ctrCustomerList.instance.Dock = DockStyle.Fill; 
            //    View.Customer.ctrCustomerList.instance.BringToFront();
            //}
            //View.Customer.ctrCustomerList.instance.BringToFront();
            pnContainer.Controls.Clear();
            View.Customer.ctrCustomerList ctr = new View.Customer.ctrCustomerList();
            ctr.Dock = DockStyle.Fill;
            pnContainer.Controls.Add(ctr);
        }
    }
}
