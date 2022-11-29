using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL
{
    internal class KhachHangThanThiet:KhachHang
    {
        public string mathethanhvien { get; set; }
        public string quatang()
        {
            if (this.tongtien() <= 1000)
            {
                return "Coupon 200";
            }
            else
            {
                return "Coupon 500";    
            }
        }
        public KhachHangThanThiet()
        {

        }
        public KhachHangThanThiet(string name,bool gioitinh,int slmua,int dongia,string mathethanhvien) : base(name, gioitinh, slmua, dongia)
        {
            this.mathethanhvien = mathethanhvien;
        }
        public override string ToString()
        {
            return base.ToString()+"\t"+this.mathethanhvien;
        }
    }
}
