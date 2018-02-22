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

namespace Wpförnek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customers>list;
        public MainWindow()
        {
            InitializeComponent();
            list = new List<Customers>()
            {
                 new Customers() {AD="Ceyda", SOYAD="Erden"},
                 new Customers() {AD="Şeyda", SOYAD="Bıyıklıoğlu"},
                 new Customers() {AD="Ceren Yaren", SOYAD="Turan"},
                 new Customers() {AD="Şükran", SOYAD="Altun"},
            };
            Customers lst = new Customers();
            lst.AD = "Ali";
            lst.SOYAD = "KALABA";
            list.Add(lst);
        }
        public class Customers
        {
            public string AD { get; set; }
            public string SOYAD { get; set; }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbl1.ItemsSource = list;
        }
    }
}
