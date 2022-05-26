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
    /// Логика взаимодействия для DirWin2.xaml
    /// </summary>
    public partial class DirWin2 : Window
    {
        public DirWin2()
        {
            InitializeComponent();
        }

        private void WatchWin_Click(object sender, RoutedEventArgs e)
        {
            WatchWin w = new WatchWin();
            w.Show();
            Close();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            CashierMenu w = new CashierMenu();
            w.Show();
            Close();
        }
    }
}
