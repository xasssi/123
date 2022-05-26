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
    /// Логика взаимодействия для DirWin.xaml
    /// </summary>
    public partial class DirWin : Window
    {
        public DirWin()
        {
            InitializeComponent();
        }

        private void BrandWin_Click(object sender, RoutedEventArgs e)
        {
            BrandWin w = new BrandWin();
            w.Show();
            Close();
        }

        private void BracMatWin_Click(object sender, RoutedEventArgs e)
        {
            CashierMenu w = new CashierMenu();
            w.Show();
            Close();
        }

        private void BodyMatWin_Click(object sender, RoutedEventArgs e)
        {
            BodyMatWin w = new BodyMatWin();
            w.Show();
            Close();
        }

        private void MechWin_Click(object sender, RoutedEventArgs e)
        {
            MechWin w = new MechWin();
            w.Show();
            Close();
        }

        private void SupplrWin_Click(object sender, RoutedEventArgs e)
        {
            SupplrWin w = new SupplrWin();
            w.Show();
            Close();
        }

        private void EmplWin_Click(object sender, RoutedEventArgs e)
        {
            EmplWin w = new EmplWin();
            w.Show();
            Close();
        }

        private void GlassWin_Click(object sender, RoutedEventArgs e)
        {
            GlassWin w = new GlassWin();
            w.Show();
            Close();
        }

        private void CountryWin_Click(object sender, RoutedEventArgs e)
        {
            CountryWin w = new CountryWin();
            w.Show();
            Close();
        }

        private void WatchWin_Click(object sender, RoutedEventArgs e)
        {
            WatchWin w = new WatchWin();
            w.Show();
            Close();
        }

        private void PositionWin_Click(object sender, RoutedEventArgs e)
        {
            PositionWin w = new PositionWin();
            w.Show();
            Close();
        }

        private void Backbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminMenu w = new AdminMenu();
            w.Show();
            Close();
        }
    }
}
