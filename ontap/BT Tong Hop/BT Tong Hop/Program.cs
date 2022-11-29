
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tong_Hop
{
    internal class Program
    {
        static List<KhachHang> li = new List<KhachHang>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("== 1.Nhap thong tin                    ==");
                Console.WriteLine("== 2.Hien thi cac thong tin            ==");
                Console.WriteLine("== 3.Sua thong tin khach hang          ==");
                Console.WriteLine("== 4.Xoa khach hang                    ==");
                Console.WriteLine("== 5.Tim kiem khach hang               ==");
                Console.WriteLine("== 6.Sap xep                           ==");
                Console.WriteLine("== 7.Thoat                             ==");
                Console.WriteLine("=========================================");
                Console.Write("Nhap lua chon: ");
                string luachon = Console.ReadLine();
                switch (luachon)
                {
                    case "1":
                        Console.WriteLine("Nhap thong tin: ");
                        input();
                        break;
                    case "2":
                        output();
                        break;
                    case "3":
                        Console.WriteLine("Sua thong tin khach hang: ");
                        Console.Write("Nhap ten khach hang muon sua: ");
                        string namesua = Console.ReadLine();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].Hoten == namesua)
                            {
                                Console.Write("Nhap so luong mua: ");
                                li[i].Slmua = int.Parse(Console.ReadLine());
                                Console.Write("Nhap don gia: ");
                                li[i].Dongia = int.Parse(Console.ReadLine());

                            }
                            foreach(var item in li)
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Xoa khach hang: ");
                        Console.Write("Nhap ten khach hang muon xoa: ");
                        string namexoa = Console.ReadLine();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].Hoten == namexoa)
                            {
                                li.RemoveAt(i);
                            }

                        }
                        Console.WriteLine("Danh sach sau khi xoa: ");
                        foreach(var item in li)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case "5":
                        Console.WriteLine("Tim kiem khach hang: ");
                        Console.Write("Nhap ten khach hang tim kiem: ");
                        string nametim = Console.ReadLine();
                        for(int i = 0; i < li.Count; i++)
                        {
                            if (li[i].Hoten == nametim)
                            {
                                Console.WriteLine("Tim thay: ");
                                foreach(var item in li)
                                {
                                    Console.WriteLine(item.ToString());
                                }

                            }
                            else
                            {
                                Console.WriteLine("Khong tim thay ten khach hang!");

                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("Sap xep: ");
                        li.Sort(delegate (KhachHang kh1, KhachHang kh2)
                        {
                            return kh1.Slmua.CompareTo(kh2.Slmua);
                        });
                        Console.WriteLine("Danh sach sau khi sap xep: ");
                        foreach(var item in li)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        break;
                    case "7":
                        Console.WriteLine("Ban da thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("Nhap sai,vui long nhap lai!");
                        break;
                }
                

            }

        }
        private static void output()
        {
            Console.WriteLine("Danh sach khach hang: ");
            foreach(var item in li)
            {
                
               Console.WriteLine( item.ToString());
            }
        }
        private static void input()
        {
            while (true)
            {
                Console.WriteLine("lua chon khach hang: ");
                Console.WriteLine("1.Khach hang");
                Console.WriteLine("2.Khach Hang Than Thiet");

                Console.Write("Nhap loai khach hang: ");
                string key=Console.ReadLine();
                switch (key)
                {
                    case "1":
                        Console.WriteLine("1.Khach hang");
                        Console.Write("Nhap ho ten: ");
                        string hoten = Console.ReadLine();
                        //bool gioitinhtt = bool.Parse(Console.ReadLine());
                        Console.Write("Nhap gioi tinh: ");
                        string gioitinh = Console.ReadLine();
                        bool gender;
                        if (gioitinh.Equals("nam"))
                        {
                            gender = true;
                        }
                        else
                        {
                            gender = false;
                        }
                        Console.Write("Nhap so luong mua: ");
                        int slmua = int.Parse(Console.ReadLine());
                        Console.Write("Nhap don gia: ");
                        int dongia = int.Parse(Console.ReadLine());
                        KhachHang kh1=new KhachHang(hoten,gender,slmua,dongia);
                        li.Add(kh1);
                        return;
                    case "2":
                        Console.WriteLine("Khach Hang Than Thiet: ");
                        Console.Write("Nhap ho ten: ");
                        string hotentt = Console.ReadLine();
                        //bool gioitinhtt = bool.Parse(Console.ReadLine());
                        string gioitinhtt = Console.ReadLine();
                        bool gendertt;
                        if (gioitinhtt.Equals("nam"))
                        {
                            gendertt= true;
                        }
                        else
                        {
                            gendertt = false;
                        }
                        Console.Write("Nhap so luong mua: ");
                        int slmuatt=int.Parse(Console.ReadLine());
                        Console.Write("Nhap don gia: ");
                        int dongiatt = int.Parse(Console.ReadLine());
                        Console.Write("Nhap ma the thanh vien: ");
                        string mathe=Console.ReadLine();
                        KhachHangThanThiet kh2 = new KhachHangThanThiet(hotentt, gendertt, slmuatt, dongiatt, mathe);
                        li.Add(kh2);
                        return ;
                    default:
                        Console.WriteLine("Nhap sai vui long nhap lai!");
                        break;
                }
            }
            

        }
    }
}
