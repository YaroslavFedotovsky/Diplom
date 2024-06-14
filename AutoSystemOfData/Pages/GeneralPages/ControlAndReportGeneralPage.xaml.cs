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

namespace AutoSystemOfData.Pages.GeneralPages
{
    /// <summary>
    /// Логика взаимодействия для ControlAndReportGeneralPage.xaml
    /// </summary>
    public partial class ControlAndReportGeneralPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public ControlAndReportGeneralPage()
        {
            InitializeComponent();
            FillOrganizationComboBox();

            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }

        private void FillOrganizationComboBox()
        {
            // Вызываем метод из класса базы данных
            db.FillOrganizationComboBox(comboBoxOrganization);
        }

        private void ButtonShowForms_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, что выбрана организация
            if (comboBoxOrganization.SelectedItem != null)
            {
                // Получаем выбранное имя организации из ComboBox
                string selectedOrganization = comboBoxOrganization.SelectedItem.ToString();

                // Вызываем метод для отображения форм для выбранной организации и обновления DataGrid
                db.DisplayFormsForOrganization(selectedOrganization, dataGridForms);
            }
            this.dataGridForms.Columns[0].Header = "Вид работы";
            this.dataGridForms.Columns[1].Header = "Выращиваемая культура";
            this.dataGridForms.Columns[2].Header = "Объем работ, га";
            this.dataGridForms.Columns[3].Header = "Дата";

            this.dataGridForms.Columns[0].Width = 110;
            this.dataGridForms.Columns[1].Width = 110;
            this.dataGridForms.Columns[2].Width = 110;
            this.dataGridForms.Columns[3].Width = 110;
        }

        private void Export(object sender, RoutedEventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook workbook = exApp.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet ws = (Excel.Worksheet)exApp.ActiveSheet;

            for (int j = 0; j < dataGridForms.Columns.Count; j++)
            {
                Excel.Range myRange = (Excel.Range)ws.Cells[1, j + 1];
                ws.Cells[1, j + 1].Font.Bold = true;
                ws.Columns[j + 1].ColumnWidth = 20;
                myRange.Value2 = dataGridForms.Columns[j].Header;
            }
            for (int i = 0; i < dataGridForms.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridForms.Items.Count; j++)
                {
                    TextBlock b = dataGridForms.Columns[i].GetCellContent(dataGridForms.Items[j]) as TextBlock;

                    if (b == null)
                        continue;

                    Excel.Range myRange = (Excel.Range)ws.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
            exApp.Visible = true;
        }

        //Методы для навигации по страницам
        private void Go_ToMainGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MainGeneralPage());
        }

        private void Go_ToMyRequestGeneral(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new MyRequestGeneral());
        }

        private void Go_ToInfographicsGeneralPage(object sender, EventArgs e)
        {
            NavigationPage.MainFrame.Navigate(new InfographicsGeneralPage());
        }
    }
}
