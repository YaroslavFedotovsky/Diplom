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

namespace AutoSystemOfData.Pages.GeneralPages
{
    /// <summary>
    /// Логика взаимодействия для CreateRequestGeneralPage.xaml
    /// </summary>
    public partial class CreateRequestGeneralPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public CreateRequestGeneralPage()
        {
            InitializeComponent();

            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }

        private void SendRequest(object sender, EventArgs e)
        {
            ResourceDictionary resources = App.Current.Resources;
            string email = (string)resources["email"];

            if (string.IsNullOrEmpty(txtBoxTheme.Text) || string.IsNullOrEmpty(txtBoxRequest.Text))
            {
                MessageBox.Show("Должны быть заполнены все поля", "Не заполнены поля", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                if (txtBoxRequest.Text.Length > 500)
                {
                    MessageBox.Show("Текст заявки не должен превышать 500 символов", "Нарушен объем", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else if (txtBoxTheme.Text.Length > 100)
                {
                    MessageBox.Show("Текст темы заявки не должен превышать 100 символов", "Нарушен объем", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    int orgId = db.GetIdInEmail(email);
                    string request = txtBoxRequest.Text;
                    string requestTheme = txtBoxTheme.Text;

                    db.SaveRequestInDB(orgId, requestTheme, request);
                }
            }
        }

        private void Go_ToMainGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MainGeneralPage());
        }

        private void Go_ToInfographicsGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new InfographicsGeneralPage());
        }

        private void Go_ToControlAndReportGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ControlAndReportGeneralPage());
        }
    }
}
