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

namespace QuanLyNhaSach_291021.View.Customer
{
    public partial class ctrCustomerList : DevExpress.XtraEditors.XtraUserControl
    {
        private static ctrCustomerList _instance;
        
        public static ctrCustomerList instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ctrCustomerList();
                }
                return _instance;
            }
        }
        public ctrCustomerList()
        {
            InitializeComponent();
        }
    }
}
