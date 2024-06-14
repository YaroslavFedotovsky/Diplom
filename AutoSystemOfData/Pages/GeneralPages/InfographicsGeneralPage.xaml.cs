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
    /// Логика взаимодействия для InfographicsGeneralPage.xaml
    /// </summary>
    public partial class InfographicsGeneralPage : Page
    {
        public InfographicsGeneralPage()
        {
            InitializeComponent();

            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }

        private void Go_ToMainGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MainGeneralPage());
        }

        private void Go_ToMyRequestGeneral(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MyRequestGeneral());
        }

        private void Go_ToControlAndReportGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new ControlAndReportGeneralPage());
        }
    }
}
