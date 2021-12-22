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

namespace QuanLyNhaSach_291021.View.Revenue
{
    public partial class ctrRevenueStatistics : DevExpress.XtraEditors.XtraUserControl
    {
        #region //Define Class and Variable

        //defind class
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        //defind variable
        string query = "";
        string emptyGridText = "Không có dữ liệu";
        DataTable dtContent;
        #endregion

        #region //Contructor

        public ctrRevenueStatistics()
        {
            InitializeComponent();
            DateTime dtNow = DateTime.Now;
            dteTo.EditValue = dtNow.Date;
            dtNow = dtNow.AddDays(-18);
            dteFrom.EditValue = dtNow.Date;
        }

        #endregion

        #region //Filter
        private void filterStatistic()
        {

        }

        private void cbbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            loadData();
        }
        #endregion

        #region //Setup min value date edit
        private void dteFrom_EditValueChanged(object sender, EventArgs e)
        {
            dteTo.Properties.MinValue = (DateTime)dteFrom.EditValue;
            DateTime dtTo = (DateTime)dteTo.EditValue;
            dteFrom.Properties.MaxValue = dtTo;
            dteFrom.Properties.MinValue = dtTo.AddDays(-18);
        }


        private void dteTo_EditValueChanged(object sender, EventArgs e)
        {
            
            DateTime dtTo = (DateTime)dteTo.EditValue;
            dteFrom.Properties.MaxValue = dtTo;
            dteFrom.Properties.MinValue = dtTo.AddDays(-18);
            dteTo.Properties.MinValue = (DateTime)dteFrom.EditValue;
        }
        #endregion

        private void tcStatisticMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadCtrChart();
        }

        private void loadData()
        {
            string mode = cbbCondition.Text;
            if (tbRevenue.SelectedIndex == 0)
            {
                View.Revenue.ctrOverviewStatistics ctr = new View.Revenue.ctrOverviewStatistics((DateTime)dteFrom.EditValue, (DateTime)dteTo.EditValue, mode);
                tpOverview.Controls.Clear();
                ctr.Dock = DockStyle.Fill;
                ctr.BringToFront();
                tpOverview.Controls.Add(ctr);
            }
            else
            {
                View.Revenue.ctrDetailStatistics ctr = new View.Revenue.ctrDetailStatistics((DateTime)dteFrom.EditValue, (DateTime)dteTo.EditValue, mode);
                tpDetail.Controls.Clear();
                ctr.Dock = DockStyle.Fill;
                ctr.BringToFront();
                tpDetail.Controls.Add(ctr);
            }
        }
            
        private void ctrRevenueStatistics_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void tbRevenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
