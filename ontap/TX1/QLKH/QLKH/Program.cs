
using System;
using System.Collections.Generic;

namespace QLKH // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                string luachon = "";
                do
                {


                    //KhachHangThanThiet kh = new KhachHangThanThiet();
                    Console.WriteLine("================================================");
                    Console.WriteLine("1. Nhap thong tin ");
                    Console.WriteLine("2. Hien thi thong tin cac khach hang ");
                    Console.WriteLine("3. Sua thong tin khach hang ");
                    Console.WriteLine("4. Xoa khach hang ");
                    Console.WriteLine("5. Tim khach hang ");
                    Console.WriteLine("6. Sap xep khach hang ");
                    Console.WriteLine("7. Thoat ");
                    Console.WriteLine("=================================================");
                    Console.Write("Nhap lua chon: ");
                    int key = int.Parse(Console.ReadLine());
                    switch (key)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            Console.WriteLine("Ban da thoat chuong trinh!");
                            return;
                        default:
                            Console.WriteLine("Nhap sai,vui long nhap lai!");
                            break;
                    }

                } while (luachon != "7");

                //private static void ouput()
                //{
                //    Console.WriteLine("Danh sach da nhap:");
                //    foreach (var item in ds)
                //    {
                //        Console.WriteLine(item.ToString());
                //    }
                //}
            }
        }
    }
}