using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QuanLyNhaSach_291021.View.Order
{
    public partial class InvoiceReport : DevExpress.XtraReports.UI.XtraReport
    {
        Model.Database conn = new Model.Database();
        Controller.Common func = new Controller.Common();
        public InvoiceReport()
        {
            InitializeComponent();
        }
        public void BindData(string orderID)
        {
            String query = String.Format(@"Select hd.MaHD, KH.TenKH as KhachHang, KH.DienThoai, nv.TenNV as NhanVien, hd.TongTien, GiamGia,hd.NgayTao
                            from HoaDon as hd
                            inner join KhachHang as KH on hd.MaKH = KH.MaKH
                            inner join NhanVien as nv on hd.MaNV = nv.MaNV
                            where hd.HienThi = 1 and hd.MaHD = '{0}'",orderID);
            DataTable dtContent = conn.loadData(query);
            pCustomerName.Value = (dtContent.Rows[0]["KhachHang"]).ToString();
            pPhone.Value = (dtContent.Rows[0]["DienThoai"]).ToString();
            pEmployeeName.Value = (dtContent.Rows[0]["NhanVien"]).ToString();
            pOrderID.Value = (dtContent.Rows[0]["MaHD"]).ToString();
            String strDte = (dtContent.Rows[0]["NgayTao"]).ToString();
            pDate.Value = func.StringToDateTime(strDte);
            pOrderDiscount.Value = (decimal)(dtContent.Rows[0]["GiamGia"]);
            pOrderTotal.Value = (decimal)(dtContent.Rows[0]["TongTien"]);

            query = String.Format(@"select ct.MaHD, sp.TenSP as SanPham, ct.SoLuong, ct.GiaBan, GiamGia, ct.SKU, (ct.SoLuong*(ct.GiaBan - GiamGia)) as TongTien from ChiTietHoaDon as ct
                                    inner join SanPham as sp on ct.SKU = sp.SKU
                                    where ct.HienThi = 1 and ct.MaHD = '{0}'", orderID);
            dtContent = conn.loadData(query);
            this.DataSource = dtContent;

            xrProduct.DataBindings.Add("Text", dtContent, "SanPham");
            xrAmount.DataBindings.Add("Text", dtContent, "SoLuong");
            xrPrice.DataBindings.Add("Text", dtContent, "GiaBan");
            xrProductDiscount.DataBindings.Add("Text", dtContent, "GiamGia");
            xrProductTotal.DataBindings.Add("Text", dtContent, "TongTien");
        }
    }
}
