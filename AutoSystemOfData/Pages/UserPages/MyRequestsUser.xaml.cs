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

namespace AutoSystemOfData.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для MyRequestsUser.xaml
    /// </summary>
    public partial class MyRequestsUser : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public MyRequestsUser()
        {
            InitializeComponent();
            FillForms();
            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }

        public void FillForms()
        {
            ResourceDictionary resources = App.Current.Resources;
            string email = (string)resources["email"];

            db.DisplayRequestsForForms(email, DataGridRequestView);

        }

        private void Go_ToCreateRequestPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new CreateRequestPage());
        }
        //Методы для навигации по страницам
        private void Go_ToMainUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MainUserPage());
        }

        private void Go_ToPlanUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new PlanUserPage());
        }

        private void Go_ToSittingUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new SittingUserPage());
        }

        private void Go_ToFeedingUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new FeedingUserPage());
        }

        private void Go_ToChemicalRegimentUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ChemicalRegimentUserPage());
        }

        private void Go_ToHarvestingUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new HarvestingUserPage());
        }

        private void Go_ToFilledDataUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new FilledDataUserPage());
        }
    }
}
