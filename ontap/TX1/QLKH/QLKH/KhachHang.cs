using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKH
{
    internal class KhachHang
    {
        private string _hoten;
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        private bool _gioitinh;
        public bool gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private int _slmua;
        public int slmua
        {
            get { return _slmua; }
            set {_slmua = value;}
        }
        private int _dongia;
        public int dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        public double tinhtong()
        {
            if (slmua < 100)
            {
                return (double)slmua * dongia;
            }
            else
            {
                return (double) 0.9 * (slmua * dongia);
            }
        }
        public void input(string hoten,bool gioittinh,int slmua,int dongia)
        {
            this.hoten=hoten;
            this.gioitinh=gioittinh;
            this.slmua=slmua;
            this.dongia=dongia;
        }
        public override string ToString()
        {
            return string.Format("{1}\t{2}\t{3}\t{4}\t{5}",this.hoten,this.gioitinh,this.slmua,this.dongia,this.tinhtong());
        }

    }
}
