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

namespace AutoSystemOfData.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для MainUserPage.xaml
    /// </summary>
    public partial class MainUserPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public MainUserPage()
        {
            InitializeComponent();
            
            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
            string emailData = (string)resources["email"];
            
            db.GetUserData(emailData, out string name, out string phone);

            emailTextBlock.Text = emailData;
            userTextBlock.Text = name;
            phoneTextBlock.Text = phone;

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

        //Методы для навигации по страницам
        private void Go_ToMyRequestsUser(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MyRequestsUser());
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
