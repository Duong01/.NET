using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WpfApp1
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string Hoten { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string PhongBan { get; set; }
        public int HSL { get; set; }
        public NhanVien() { }
        public NhanVien(string maNV, string hoten, string gioiTinh, string phongBan, string ngaySinh, int hSL)
        {
            MaNV = maNV;
            Hoten = hoten;
            GioiTinh = gioiTinh;
            PhongBan = phongBan;
            NgaySinh = ngaySinh;
            HSL = hSL;
        }

        public int Tuoi
        {
            get
            {
                DateTime ns = DateTime.Parse(NgaySinh,new CultureInfo("vi-VI", true));
                return DateTime.Now.Year - ns.Year;
            }
        }
    }
}
