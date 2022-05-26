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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AccessBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Password.Password))
                {
                    MessageBox.Show("Введите логин и/или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                using (var BD = new ЮвелиркаEntities())
                {
                    var users = BD.Сотрудники.AsNoTracking().FirstOrDefault(u => u.Фамилия == Login.Text && u.Пароль == Password.Password);

                    if (users == null)
                    {
                        MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    else
                    {
                        switch (users.Должность.ID_Должность)
                        {
                            case 1:
                                MessageBox.Show("Вы заходите как Адмнистратор!", "Информирование", MessageBoxButton.OK, MessageBoxImage.Information);
                                AdminMenu w = new AdminMenu();
                                w.Show();
                                Close();
                                break;

                            case 2:
                                MessageBox.Show("Вы заходите как Кассир!", "Информирование", MessageBoxButton.OK, MessageBoxImage.Information);
                                CashierMenu ww = new CashierMenu();
                                ww.Show();
                                Close();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения!" + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

                        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
