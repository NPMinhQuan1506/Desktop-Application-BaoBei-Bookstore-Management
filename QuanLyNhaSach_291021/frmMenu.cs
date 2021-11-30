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

        private void aceAuthor_Click(object sender, EventArgs e)
        {
            MessageBoxButtons Bouton = MessageBoxButtons.YesNo;
            DialogResult Result = MessageBox.Show("Bạn Có Chắc Xóa Khách Hàng Này Không?", "Thông Báo!", Bouton, MessageBoxIcon.Question);

            if (Result == DialogResult.Yes)
            {
                MessageBox.Show("a!");
            }
            else if (Result == DialogResult.No)
            {
                MessageBox.Show("Dữ liệu vẫn tồn tại!");
            }
        }

        private void acePublisher_Click(object sender, EventArgs e)
        {
            Controller.EncryptDecrypt ende = new Controller.EncryptDecrypt();
            for(int i =0; i< 10; i++)
            MyMessageBox.ShowMessage(Controller.EncryptDecrypt.Encrypt("User@123"));
            MyMessageBox.ShowMessage(Controller.EncryptDecrypt.Decrypt(Controller.EncryptDecrypt.Encrypt("ABC")));
        }
    }
}
