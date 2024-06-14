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
using System.Windows.Threading;

namespace AutoSystemOfData.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для MainAdminPage.xaml
    /// </summary>
    public partial class MainAdminPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public MainAdminPage()
        {
            InitializeComponent();
            GetCountData();

            ResourceDictionary resources = App.Current.Resources;
            string emailData = (string)resources["email"];

            db.GetUserData(emailData, out string name, out string phone);

            userTextBlock.Text = name;

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();

            LiveDateTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LiveTimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void GetCountData()
        {
            countRequestTextBlock.Text = db.GetCountRequests();
            countOrgTextBlock.Text = db.GetCountOrganization();
            countUserTextBlock.Text = db.GetCountUsers();
            countCultureTextBlock.Text = db.GetCountCultures();
        }

        //Методы навигации
        private void Go_ToRequestsOfUsersPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new RequestsOfUsersPage());
        }

        private void Go_ToViewUsersPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ViewUsersPage());
        }
        private void Go_ToViewOrgsPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ViewOrgsPage());
        }
        private void Go_ToViewCulturesPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ViewCulturesPage());
        }
        private void Go_ToViewDataPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ViewDataPage());
        }

        private void Go_ToReportPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ReportPage());
        }
    }
}
