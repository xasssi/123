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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void MainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWin w = new MainWin();
            w.Show();
            Close();
        }

        private void DirWin_Click(object sender, RoutedEventArgs e)
        {
            DirWin w = new DirWin();
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
