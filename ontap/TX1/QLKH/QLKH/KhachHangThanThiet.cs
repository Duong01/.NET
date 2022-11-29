using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH
{
    internal class KhachHangThanThiet:KhachHang
    {
        public string xacdinhquatang()
        {
            if (this.tinhtong() <= 1000)
            {
                return "coupon 200";
            }
            else
            {
                return "coupon 500";
            }
        }
        public override string ToString()
        {
            return base.ToString()+"\t"+this.xacdinhquatang();
        }
        //public override void input()
        //{

        //}
        //public void input()
        //{
        //    Console.WriteLine("Nhap thong tin: ");
        //    Console.Write("Nhap ")
        //}
    }
}
