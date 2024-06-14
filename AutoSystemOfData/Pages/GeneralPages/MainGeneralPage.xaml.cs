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
using System.Windows.Threading;

namespace AutoSystemOfData.Pages.GeneralPages
{
    /// <summary>
    /// Логика взаимодействия для MainGeneralPage.xaml
    /// </summary>
    public partial class MainGeneralPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();

        public MainGeneralPage()
        {
            InitializeComponent();
            FillTextBlockData();

            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();

            LiveDateTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy");

            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY = { 1, 4, 9, 16, 25 };
            DynamicWpfPlot.Plot.Add.Scatter(dataX, dataY);
            DynamicWpfPlot.Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LiveTimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FillTextBlockData()
        {
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddDays(-7);

            countOrgTextBlock.Text = Convert.ToString(db.GetCountOrgForWeeks(startDate, endDate));
            countFillsTextBlock.Text = Convert.ToString(db.GetCountFillForWeeks(startDate, endDate));
        }

        //Методы для навигации по страницам
        private void Go_ToMyRequestGeneral(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MyRequestGeneral());
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
