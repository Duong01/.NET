using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tong_Hop
{
    internal class KhachHang
    {
        private string _hoten;
        public string Hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        private bool _gioitinh;
        public bool Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private int _slmua;
        public int Slmua
        {
            get { return _slmua; }
            set { _slmua = value; }
        }
        private int _dongia;
        public int Dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        public KhachHang() { }
        public KhachHang(string hoten,bool gioitinh,int slmua,int dongia)
        {
            this.Hoten = hoten;
            this.Gioitinh = gioitinh;
            this.Slmua = slmua;
            this.Dongia = dongia;
        }
        //public void input()
        //{
            
        //}
        public double tinhtong()
        {
            if (this.Slmua < 100)
            {
                return Slmua * Dongia;
            }
            else
            {
                return 0.9 * Slmua * Dongia;
            }
        }
        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}", this.Hoten, this.Gioitinh, this.Slmua, this.Dongia,this.tinhtong()) ;

        }

    }
}
