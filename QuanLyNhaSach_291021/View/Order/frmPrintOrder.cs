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

namespace QuanLyNhaSach_291021.View.Order
{
    public partial class frmPrintOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmPrintOrder()
        {
            InitializeComponent();
        }

        public void printInvoice(string orderID)
        {
            InvoiceReport report = new InvoiceReport();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            {
                p.Visible = false;
            }
            report.BindData(orderID);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}