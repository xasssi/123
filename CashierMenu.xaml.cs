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

namespace WatchShop_Vasilyev_isp27
{
    /// <summary>
    /// Логика взаимодействия для CashierMenu.xaml
    /// </summary>
    public partial class CashierMenu : Window
    {
        public CashierMenu()
        {
            InitializeComponent();
        }

        private void MainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWin2 w = new MainWin2();
            w.Show();
            Close();
        }

        private void DirWin_Click(object sender, RoutedEventArgs e)
        {
            DirWin2 w = new DirWin2();
            w.Show();
            Close();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow w = new AuthWindow();
            w.Show();
            Close();
        }
    }
}
