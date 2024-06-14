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
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoSystemOfData.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для FilledDataUserPage.xaml
    /// </summary>
    public partial class FilledDataUserPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public FilledDataUserPage()
        {
            InitializeComponent();

            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }
        
        private void Export(object sender, RoutedEventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook workbook = exApp.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            for (int j = 0; j < DataGridFilledDataView.Columns.Count; j++)
            {
                Excel.Range myRange = (Excel.Range)ws.Cells[1, j + 1];
                ws.Cells[1, j + 1].Font.Bold = true;
                ws.Columns[j + 1].ColumnWidth = 20;
                myRange.Value2 = DataGridFilledDataView.Columns[j].Header;
            }
            for (int i = 0; i < DataGridFilledDataView.Columns.Count; i++)
            {
                for (int j = 0; j < DataGridFilledDataView.Items.Count; j++)
                {
                    TextBlock b = DataGridFilledDataView.Columns[i].GetCellContent(DataGridFilledDataView.Items[j]) as TextBlock;

                    if (b == null)
                        continue;

                    Excel.Range myRange = (Excel.Range)ws.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
            exApp.Visible = true;
        }
        
        private void FillFormsWithDate(object sender, EventArgs e)
        {
            string orgName = orgTextBlock.Text;
            DateTime? firstDate = DatePickerStart.SelectedDate;
            DateTime? endDate = DatePickerEnd.SelectedDate;
            if(firstDate.HasValue && endDate.HasValue)
            {
                if (firstDate > endDate)
                {
                    MessageBox.Show("Значение начала периода не может быть больше конца периода", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    db.DisplayFilledData(orgName, firstDate, endDate, DataGridFilledDataView);
                    this.DataGridFilledDataView.Columns[0].Width = 110;
                    this.DataGridFilledDataView.Columns[1].Width = 110;
                    this.DataGridFilledDataView.Columns[2].Width = 110;
                    this.DataGridFilledDataView.Columns[3].Width = 110;
                }
                
            }
            else
            {
                MessageBox.Show("Введите значения в поля Дата начала и Дата конца периода", "Не введены значения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        //Методы для навигации по страницам
        private void Go_ToMainUserPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MainUserPage());
        }

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
    }
}
