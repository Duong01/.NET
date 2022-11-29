using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp1
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
        List<NhanVien> li = new List<NhanVien>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NhanVien nv = new NhanVien("M01", "Nguyễn Văn Dương", "Nam", "Tổ chức", "09-11-2001", 23);
            li.Add(nv);
            dtgDS.ItemsSource = li;
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra())
            {
                string gt;
                if (rbtnNam.IsChecked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nu";
                }
                string ns = ((DateTime)dtNgaySinh.SelectedDate).ToString("dd-MM-yyyy");

                NhanVien nv = new NhanVien(txtMaNV.Text, txtHoTen.Text, gt, cbPhongBan.Text, ns, int.Parse(txtHSL.Text));
                foreach(var item in li)
                {
                    if (item.MaNV == txtMaNV.Text)
                    {
                        MessageBox.Show("Trung ma nhan vien");
                        return;
                    }
                    
                }
                li.Add(nv);
                dtgDS.ItemsSource = null;

                dtgDS.ItemsSource = li;
            }
        }
        bool kiemtra()
        {
            if (txtMaNV.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap ma NV", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtMaNV.Focus();
                return false;
            }
            if (txtHoTen.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap ten NV", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHoTen.Focus();
                return false;
            }
            if (dtNgaySinh.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap ngay sinh NV", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                dtNgaySinh.Focus();
                return false;
            }
            else
            {
                DateTime ns = (DateTime)dtNgaySinh.SelectedDate;
                int tuoi = DateTime.Now.Year - ns.Year;
                if (tuoi < 18)
                {
                    MessageBox.Show("Tuoi phai lon hon 18", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    dtNgaySinh.Focus();
                    return false;
                }
            }
            if (txtHSL.Text == String.Empty)
            {
                MessageBox.Show("Ban chua nhap HSL", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                txtHSL.Focus();
                return false;
            }
            else
            {
                try
                {
                    int hsl=int.Parse(txtHSL.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("HSL phai la so", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtHSL.SelectAll();
                    txtHSL.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            string Manvsua=txtMaNV.Text;
            if (kiemtra())
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].MaNV == Manvsua)
                    {
                        li[i].Hoten = txtHoTen.Text;
                        if (rbtnNam.IsChecked == true)
                        {
                            li[i].GioiTinh = "Nam";
                        }
                        else
                        {
                            li[i].GioiTinh = "Nu";
                        }
                        li[i].PhongBan = cbPhongBan.Text;
                        li[i].NgaySinh = dtNgaySinh.Text;
                        string ns = ((DateTime)dtNgaySinh.SelectedDate).ToString("dd-MM-yyyy");

                        li[i].HSL = int.Parse(txtHSL.Text);
                        dtgDS.ItemsSource = null;
                        dtgDS.ItemsSource = li;
                    }
                    
                }
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            if (kiemtra())
            {
                string Manvxoa = txtMaNV.Text;

                for (int i = 0; i < li.Count; i++)
                {
                    if(li[i].MaNV == Manvxoa)
                    {
                        li.RemoveAt(i);
                        dtgDS.ItemsSource = null;
                        dtgDS.ItemsSource= li;
                    }
                }
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            int tuoimax = li.Max(nv => nv.HSL);
            List<NhanVien> listtuoi = li.FindAll(nv => nv.HSL == tuoimax);
            Window1 win = new Window1();
            win.dtgWD1.ItemsSource = listtuoi;
            win.Show();
        }
    }
}
