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

namespace WatchShop_Vasilyev_isp27
{
    /// <summary>
    /// Логика взаимодействия для ReceiptPDF.xaml
    /// </summary>
    public partial class ReceiptPDF : UserControl
    {
        Поставка Поставка;
        public ReceiptPDF(Поставка п)
        {
            InitializeComponent();
            Поставка = п;
            DataContext = п;
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(DG, "Печать");
            }
        }
    }
}
