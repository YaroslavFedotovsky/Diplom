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

namespace AutoSystemOfData.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void LoginToTheSystem(object sender, RoutedEventArgs e)
        {
            //Забираем данные из полей
            string login = logField.Text;
            string password = passField.Password;

            if(string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Должны быть заполнены все поля (Логин и Пароль)", "Не заполнены поля", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (db.AuthenticateUser(login, password))
                {
                    int userRoleId = db.GetUserRoleId(login, password);

                    string organizationName = db.GetOrganizationNameForUser(login, password);
                    string email = db.GetEmailForUser(login, password);

                    App.Current.Resources["organizationName"] = organizationName;
                    App.Current.Resources["email"] = email;

                    if (userRoleId == 1)
                    {
                        // Перенаправление на первую страницу для роли 1 (Пользователь).
                        UserPages.MainUserPage mainUserPage = new UserPages.MainUserPage();
                        NavigationPage.MainFrame.Navigate(mainUserPage);
                    }
                    else if (userRoleId == 2)
                    {
                        // Перенаправление на вторую страницу для роли 2 (Начальник).
                        GeneralPages.MainGeneralPage generalPage = new GeneralPages.MainGeneralPage();
                        NavigationPage.MainFrame.Navigate(generalPage);
                    }
                    else if (userRoleId == 3)
                    {
                        // Перенаправление на третью страницу для роли 3 (Администратор).
                        AdminPages.MainAdminPage adminPage = new AdminPages.MainAdminPage();
                        NavigationPage.MainFrame.Navigate(adminPage);
                    }
                    else
                    {
                        // Обработка других значений роли или ошибок.
                        MessageBox.Show("Неверная роль пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            
        }
    }
}
