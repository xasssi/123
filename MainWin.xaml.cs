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
using WatchShop_Vasilyev_isp27.Wins;

namespace WatchShop_Vasilyev_isp27
{
    /// <summary>
    /// Логика взаимодействия для MainWin.xaml
    /// </summary>
    public partial class MainWin : Window
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void SuppWin_Click(object sender, RoutedEventArgs e)
        {
            SuppWin sw = new SuppWin();
            sw.Show();
            Close();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu w = new AdminMenu();
            w.Show();
            Close();
        }

        private void SalesWin_Click_1(object sender, RoutedEventArgs e)
        {
            SalesWin sw = new SalesWin();
            sw.Show();
            Close();
        }
    }
}
