using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.Models;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        QLNhanvienContext db = new QLNhanvienContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDG();
            HienThiCB();
        }
        private void HienThiDG()
        {
            var query = from nv in db.Nhanviens
                        select new
                        {
                            nv.MaPhongNavigation.TenPhong,
                            nv.MaNv,
                            nv.Hoten,
                            nv.Luong,
                            nv.Thuong,
                            TongTien = nv.Luong + nv.Thuong
                        };
            dtgDS.ItemsSource = query.ToList();
        }
        private void HienThiCB()
        {
            var query = from pb in db.PhongBans select pb;
            cbMaPhong.ItemsSource = query.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var them = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(txtMaNV.Text));
            if(them == null)
            {
                if (kiemtra())
                {
                    Nhanvien nv = new Nhanvien();
                    nv.MaNv = txtMaNV.Text;
                    nv.Hoten = txtHoTen.Text;
                    nv.Luong = int.Parse(txtLuong.Text);
                    nv.Thuong = int.Parse(txtThuong.Text);
                    PhongBan pb = (PhongBan)cbMaPhong.SelectedItem;
                    nv.MaPhong = pb.MaPhong;
                    db.Nhanviens.Add(nv);
                    db.SaveChanges();
                    MessageBox.Show("Them thanh cong");
                    HienThiDG();
                }

            }
            else
            {
                MessageBox.Show("Ma nhan vien ton tai", "Thong bao");
            }
        }
        private bool kiemtra()
        {
            if (txtMaNV.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap ma nhan vien", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return false;
            }
            if (txtHoTen.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap ten nhan vien", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (txtLuong.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap luong nhan vien", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLuong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int lg = int.Parse(txtLuong.Text);
                    if (lg < 1000 || lg > 9000)
                    {
                        MessageBox.Show("Luong nam trong khoang 1000-9000");
                        return false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Luong phai la so", "Thong bao");
                    txtLuong.SelectAll();
                    txtLuong.Focus();
                    return false;
                }
            }
            if (txtThuong.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap thuong nhan vien", "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                txtThuong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int thg = int.Parse(txtThuong.Text);
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Thuong phai la so", "Thong bao");
                    txtThuong.SelectAll();
                    txtThuong.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var sua = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(txtMaNV.Text));
            if (sua != null)
            {
                if (kiemtra())
                {
                    Nhanvien nv = new Nhanvien();
                    sua.MaNv = txtMaNV.Text;
                    sua.Hoten = txtHoTen.Text;
                    sua.Luong = int.Parse(txtLuong.Text);
                    sua.Thuong = int.Parse(txtThuong.Text);
                    PhongBan pb = (PhongBan)cbMaPhong.SelectedItem;
                    sua.MaPhong = pb.MaPhong;
                    
                    db.SaveChanges();
                    MessageBox.Show("Sua thanh cong");
                    HienThiDG();
                }

            }
            else
            {
                MessageBox.Show("Khong co nhan vien nay", "Thong bao");
            }
        }

        private void dtgDS_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            object obj = dtgDS.SelectedItem;
            if (obj != null)
            {
                Type t = dtgDS.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtMaNV.Text = p[1].GetValue(dtgDS.SelectedItem).ToString();
                txtHoTen.Text = p[2].GetValue(dtgDS.SelectedItem).ToString();
                txtLuong.Text = p[3].GetValue(dtgDS.SelectedItem).ToString();
                txtThuong.Text = p[4].GetValue(dtgDS.SelectedItem).ToString();
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var xoa = db.Nhanviens.SingleOrDefault(t => t.MaNv.Equals(txtMaNV.Text));
            MessageBoxResult rs = MessageBox.Show("Ban chac chan muon xoa", "Thong bao", MessageBoxButton.YesNo);
            if (rs == MessageBoxResult.Yes)
            {


                if (xoa != null)
                {
                    db.Nhanviens.Remove(xoa);
                    db.SaveChanges();
                    MessageBox.Show("Xoa thanh cong");
                    HienThiDG();

                }
                else
                {
                    MessageBox.Show("Khong co nhan vien nay", "Thong bao");
                }
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            Window1 win = new Window1();
            win.Show();
        }
    }
}
