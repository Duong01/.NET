using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL
{
    internal class Program
    {
        static List<KhachHang> li = new List<KhachHang>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine("1.Nhap thong tin");
                Console.WriteLine("2.Hien thi thong tin khach hang");
                Console.WriteLine("3.Sua thong tin");
                Console.WriteLine("4.Xoa khach hang");
                Console.WriteLine("5.Tim khach hang");
                Console.WriteLine("6.Sap xep");
                Console.WriteLine("7.Thoat");
                Console.WriteLine("===============================================");
                Console.Write("Nhap lua chon: ");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.WriteLine("Them thong tin: ");
                        input();
                        break;
                    case "2":
                        Console.WriteLine("Hien thi thong tin cac khach hang: ");
                        output();
                        break;
                    case "3":
                        Console.WriteLine("Sua thong tin: ");
                        Console.Write("Nhap ten khach hang muon sua: ");
                        string tensua=Console.ReadLine().ToLower();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].name.ToLower() == tensua.ToLower())
                            {
                                Console.Write("Nhap so luong mua: ");
                                li[i].slmua = int.Parse(Console.ReadLine());
                                Console.Write("Nhap don gia: ");
                                li[i].dongia = int.Parse(Console.ReadLine());
                                Console.WriteLine(li[i].ToString());
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay ten khach hang nao!");
                            }
                            
                        }
                        break;
                    case "4":
                        Console.WriteLine("Xoa khach hang: ");
                        Console.Write("Nhap ten khach hang muon xoa: ");
                        string tenxoa=Console.ReadLine().ToLower();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].name.ToLower() == tenxoa.ToLower())
                            {
                                li.RemoveAt(i);
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay ten khach hang nao!");
                            }
                            
                        }
                        Console.WriteLine("Danh sach sau khi xoa: ");
                        output();
                        break;
                    case "5":
                        Console.WriteLine("Tim kiem khach hang: ");
                        Console.Write("Nhap ten khach hang can tim: ");
                        string findname= Console.ReadLine().ToLower();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].name.ToLower() == findname.ToLower())
                            {
                                Console.WriteLine("Tim thay: ");
                                //output();
                                foreach(var item in li)
                                {
                                    Console.WriteLine(li[i].name + "\t" + li[i].gioitinh + "\t" + li[i].slmua + "\t" + li[i].dongia);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay khach hang nao!");
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("Sap xep: ");
                        li.Sort(delegate (KhachHang kh1, KhachHang kh2)
                        {
                            return kh1.slmua.CompareTo(kh2.slmua);
                        });
                        Console.WriteLine("Danh sach khach hang sau khi sap xep: ");
                        output();
                        break;
                    case "7":
                        Console.WriteLine("Ban da thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("Nhap sai, vui long nhap lua chon trong chuong trinh");
                        break;
                }

            }
        }
        private static void input()
        {
            //Console.Write("Nhap loai khach hang: ")
            while (true)
            {
                Console.WriteLine("1.Khach hang");
                Console.WriteLine("2.Khach hang than thiet");
                Console.Write("Nhap lua chon: ");
                string loai = Console.ReadLine();
                switch (loai)
                {
                    case "1":
                        Console.WriteLine("Nhap khach hang: ");
                        Console.Write("Nhap ho ten: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhap gioi tinh: ");
                        bool gioitinh = bool.Parse(Console.ReadLine());
                        Console.Write("Nhap so luong mua: ");
                        int slmua = int.Parse(Console.ReadLine());
                        Console.Write("Nhap don gia: ");
                        int dongia = int.Parse(Console.ReadLine());
                        KhachHang kh = new KhachHang(name, gioitinh, slmua, dongia);
                        li.Add(kh);
                        return;
                    case "2":
                        Console.WriteLine("Nhap khach hang than thiet: ");
                        Console.Write("Nhap ho ten: ");
                        string namett = Console.ReadLine();
                        Console.Write("Nhap gioi tinh: ");
                        bool gioitinhtt = bool.Parse(Console.ReadLine());
                        Console.Write("Nhap so luong mua: ");
                        int slmuatt = int.Parse(Console.ReadLine());
                        Console.Write("Nhap don gia: ");
                        int dongiatt = int.Parse(Console.ReadLine());
                        Console.Write("Nhap ma the thanh vien: ");
                        string mathetv = Console.ReadLine();
                        KhachHangThanThiet khtt = new KhachHangThanThiet(namett, gioitinhtt, slmuatt, dongiatt,mathetv);
                        li.Add(khtt);
                        return;
                    default:
                        Console.WriteLine("Nhap sai,vui long nhap lai!");
                        break;
                }
            }
            
        }
        private static void output()
        {
            foreach(var item in li)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
