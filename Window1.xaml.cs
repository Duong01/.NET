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
using System.Windows.Shapes;
using WpfApp7.Models;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        QLNhanvienContext db=new QLNhanvienContext();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from nv in db.Nhanviens
                        join pb in db.PhongBans
                        on nv.MaPhong equals pb.MaPhong
                        select new
                        {
                            nv.MaNv,
                            nv.Hoten,
                            nv.Luong,
                            nv.Thuong,
                            pb.MaPhong,
                            pb.TenPhong
                        };
            dtgWin.ItemsSource = query.ToList();
        }
    }
}
