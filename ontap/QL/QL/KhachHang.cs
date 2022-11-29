using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL
{
    internal class KhachHang
    {
        public string name { get; set; }
        public bool gioitinh { get; set; }
        public int slmua { get; set; }
        public int dongia { get; set; }
        public double tongtien()
        {
            if (slmua < 100)
            {
                return slmua * dongia;
            }
            else
            {
                return 0.9 * (slmua * dongia);
            }
        }
        public KhachHang() { }
        public KhachHang(string name, bool gioitinh, int slmua, int dongia)
        {
            this.name = name;
            this.gioitinh = gioitinh;
            this.slmua = slmua;
            this.dongia = dongia;
        }

        public void input(string name,bool gioitinh,int slmua,int dongia)
        {
            this.name = name;
            this.gioitinh = gioitinh;
            this.slmua = slmua;
            this.dongia = dongia;
        }
        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", this.name,this.gioitinh,this.slmua,this.dongia,this.tongtien());

        }
    }
}
