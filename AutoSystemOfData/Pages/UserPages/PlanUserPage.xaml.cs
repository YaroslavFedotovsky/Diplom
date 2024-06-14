using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для PlanUserPage.xaml
    /// </summary>
    public partial class PlanUserPage : Page
    {
        DatabaseConnect db = new DatabaseConnect();
        
        public PlanUserPage()
        {
            InitializeComponent();
            LoadCultures();
            ResourceDictionary resources = App.Current.Resources;
            orgTextBlock.Text = (string)resources["organizationName"];
        }

        private void LoadCultures()
        {
            try
            {
                // Получаем данные о культурах из базы данных
                DataTable culturesTable = db.GetCultures();

                // Проходим по строкам DataTable и добавляем значения в ComboBox
                foreach (DataRow row in culturesTable.Rows)
                {
                    cmbCultures.Items.Add(row["culture_name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке культур: " + ex.Message);
            }
        }

        private void SaveForms_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int orgId = db.GetOrgIdByName(orgTextBlock.Text);
                int stageId = 5;
                int volumeWork = 0;

                if (valueBox.Text.Length > 0)
                {
                    try
                    {
                        volumeWork = Convert.ToInt32(valueBox.Text);



                        // Получаем выбранную культуру из ComboBox
                        string selectedCultures = cmbCultures.SelectedItem as string;

                        // Проверка, чтобы не добавлять данные без выбранной культуры
                        if (string.IsNullOrWhiteSpace(selectedCultures))
                        {
                            MessageBox.Show("Выберите культуру.", "Не выбран параметр", MessageBoxButton.OK, MessageBoxImage.Warning);
                            return;
                        }

                        // Получаем Id культуры по её названию
                        int cultureId = db.GetCultureIdByName(selectedCultures);

                        // Вызов метода добавления данных в базу данных
                        db.SaveForms(orgId, stageId, cultureId, volumeWork);

                        // Очистить текстовые поля и сбросить выбор в ComboBox после успешного добавления
                        valueBox.Clear();
                        cmbCultures.SelectedIndex = -1; // Сбрасываем выбор в ComboBox
                    }
                    catch { MessageBox.Show("Введите число без лишних символов", "Неправильный ввод", MessageBoxButton.OK, MessageBoxImage.Warning); }
                }
                else
                {
                    MessageBox.Show("Введите количество выполненной работы.", "Не введены данные", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void FillDataOfThisStage(object sender, EventArgs e)
        {
            try
            {
                int orgId = db.GetOrgIdByName(orgTextBlock.Text);
                int stageId = 5;

                db.DisplayFilledDataInForms(orgId, stageId, DataGridPlanView);

                this.DataGridPlanView.Columns[0].Width = 114;
                this.DataGridPlanView.Columns[1].Width = 114;
                this.DataGridPlanView.Columns[2].Width = 114;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
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
