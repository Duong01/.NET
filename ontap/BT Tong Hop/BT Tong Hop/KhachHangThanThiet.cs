using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tong_Hop
{
    internal class KhachHangThanThiet:KhachHang
    {
        public string mathethanhvien { get; set; }
        public KhachHangThanThiet()
        {

        }
        public KhachHangThanThiet(string hoten,bool gioitinh,int slmua,int dongia,string mathethanhvien) : base(hoten, gioitinh, slmua, dongia)
        {
            this.mathethanhvien = mathethanhvien;
        }
        public string quatang()
        {
            if (this.tinhtong() <= 1000)
            {
                return "Coupon 200";
            }
            else
            {
                return "Coupon 500";
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\t"+this.mathethanhvien;
        }
    }
}
