using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using QuanLyNhaSach_291021.View.Notification;
using System.Data;

namespace QuanLyNhaSach_291021.Controller
{
    class Global
    {
        //defind class
        private static Model.Database conn = new Model.Database();
        private static Controller.Common func = new Controller.Common();
        //static variable
        public static string EmpName;
        public static string EmpId;

        public static bool AuthorityLogin(string account, string password)
        {
            if (account != "" && (password) != "")
            {
                String query = String.Format(@"select MaNV, TenNV, MatKhau from NhanVien as nv
                                               inner join TaiKhoan_NV as tk on nv.MaTK = tk.MaTK
                                               where tk.TenTK = '{0}'", account);
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent != null && dtContent.Rows.Count > 0)
                {
                    if ((dtContent.Rows[0]["MatKhau"]).ToString() == Controller.EncryptDecrypt.Encrypt(password))
                    {
                        EmpName = (dtContent.Rows[0]["MaNV"]).ToString();
                        EmpId = (dtContent.Rows[0]["TenNV"]).ToString();
                        return true;
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Sai Mật Khẩu");
                    }
                }
                else
                {
                    MyMessageBox.ShowMessage("Sai Tên Đăng Nhập");
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Vui Lòng! Nhập Đầy Đủ Thông Tin");
            }
            return false;
        }
    }
}
