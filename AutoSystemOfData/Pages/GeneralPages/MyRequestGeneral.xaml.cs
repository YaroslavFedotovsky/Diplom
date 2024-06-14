using AutoSystemOfData.Pages.UserPages;
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
    /// Логика взаимодействия для MyRequestGeneral.xaml
    /// </summary>
    public partial class MyRequestGeneral : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public MyRequestGeneral()
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

        private void Go_ToCreateRequestGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new CreateRequestGeneralPage());
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
