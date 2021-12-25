using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string EmpName = "";
        public static string EmpId = "";
        public static int IdLog = 0;

        public static bool AuthorityLogin(string account, string password, string mode)
        {
            if (account != "" && (password) != "")
            {
                String query = "";
                if (mode == "USER")
                {
                    query = String.Format(@"select MaNV, TenNV, MatKhau from NhanVien as nv
                                               inner join TaiKhoan_NV as tk on nv.MaTK = tk.MaTK
											   inner join (  select distinct cv.MaCV from ChiTietPhanQuyen as ctpq 
														inner join ChucVu as cv on ctpq.MaCV = cv.MaCV	
														inner join (select maPQ, TenNQ from PhanQuyen as pq join NhomQuyen as nq on pq.MaNQ = nq.MaNQ where pq.HienThi = 1)
														 as pq on ctpq.MaPQ = pq.MaPQ 
														 Where TenNQ = N'Bán Hàng') as cv on nv.MaCV =cv.MaCV
                                               where tk.TenTK = '{0}'", account);
                }
                else
                {
                    query = String.Format(@" select MaNV, TenNV, MatKhau from NhanVien as nv
                                               inner join TaiKhoan_NV as tk on nv.MaTK = tk.MaTK
											   inner join (  select distinct cv.MaCV from ChiTietPhanQuyen as ctpq 
														inner join ChucVu as cv on ctpq.MaCV = cv.MaCV	
														inner join (select maPQ, TenNQ from PhanQuyen as pq join NhomQuyen as nq on pq.MaNQ = nq.MaNQ where pq.HienThi = 1)
														 as pq on ctpq.MaPQ = pq.MaPQ 
														 Where TenNQ != N'Bán Hàng') as cv on nv.MaCV =cv.MaCV
                                               where tk.TenTK = '{0}'", account);
                }
                DataTable dtContent = new DataTable();
                dtContent = conn.loadData(query);
                if (dtContent != null && dtContent.Rows.Count > 0)
                {
                    if ((dtContent.Rows[0]["MatKhau"]).ToString() == Controller.EncryptDecrypt.Encrypt(password))
                    {
                        DateTime dtNow = DateTime.Now;
                        EmpName = (dtContent.Rows[0]["TenNV"]).ToString();
                        EmpId = (dtContent.Rows[0]["MaNV"]).ToString();
                        string query_log = String.Format(@"Insert into Employee_log(MaNV, ThoiGianDangNhap, TrangThai) values('{0}', '{1}', 1)", EmpId, func.DateTimeToString(dtNow));
                        conn.executeDatabase(query_log);
                        IdLog = Convert.ToInt32(conn.getLastInsertedValue());
                        return true;
                    }
                    else
                    {
                        MyMessageBox.ShowMessage("Sai Mật Khẩu");
                    }
                }
                else
                {
                    MyMessageBox.ShowMessage("Tên Đăng Nhập Không Tồn Tại");
                }
            }
            else
            {
                MyMessageBox.ShowMessage("Vui Lòng! Nhập Đầy Đủ Thông Tin");
            }
            return false;
        }

        public static void destroy()
        {
            EmpName = "";
            EmpId = "";
            IdLog = 0;
        }
    }
}
