using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using UniversCorps.Class;
using UniversCorps.DataBase;
using UniversCorps.DialogBox;

namespace UniversCorps.PagesCorp
{
    /// <summary>
    /// Логика взаимодействия для PageRoom.xaml
    /// </summary>
    public partial class PageRoom : Page
    {
        public PageRoom()
        
        {
            
            try

            { 
            
            InitializeComponent();

                Title = "Кабинеты корпуса " + ClassDataBase.CurrentCorpus.Name;

            DGFund.ItemsSource = ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Where(x => x.IdCorps == ClassDataBase.CurrentCorpus.Id).ToList();
        
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();

            }

        }

        /// <summary>
        /// Переход на страницу добавление нового помещения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddRoom_Click(object sender, RoutedEventArgs e)
        
        {

            ClassNavigate.ClassFrmMain.Navigate(new PageAddRoom());

        }

        private void BtnChangeInfo_Click(object sender, RoutedEventArgs e)
        
        {

            try

            {

                if (DGFund.SelectedValue != null)

                {

                    ClassDataBase.CurrentRoom = (UniClassFundCorps)DGFund.SelectedValue;
                    ClassNavigate.ClassFrmMain.Navigate(new PageChangeRoom());

                }

                else MessageBox.Show("Для изменения информации выберите корпус", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        /// <summary>
        /// Кнопка удаления кабинета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDeleteRoom_Click(object sender, RoutedEventArgs e)
        
        {

            try

            {

                if (DGFund.SelectedValue != null)

                {

                    ClassDataBase.CurrentRoom = (UniClassFundCorps)DGFund.SelectedValue;

                    bool? Result = new WinDeleteQ("Вы действительно хотите удалить комнату " + ClassDataBase.CurrentRoom.Room + "?",
                        "Удаление комнаты", WinDeleteQ.MessageButtons.YesNo, WinDeleteQ.MessageSound.Warning).ShowDialog();

                    if (Result == true)

                    {

                        ClassDataBase.UniversClassFundEntities.Division.Remove(ClassDataBase.CurrentRoom.Division);
                        ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Remove(ClassDataBase.CurrentRoom);
                        ClassDataBase.UniversClassFundEntities.SaveChanges();

                        ClassDataBase.CurrentRoom = null;

                        DGFund.ItemsSource = ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Where(x => x.IdCorps == ClassDataBase.CurrentCorpus.Id).ToList();

                    }

                }

                else MessageBox.Show("Для удаления выберите корпус", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        /// <summary>
        /// Переход к информации о кабинете
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInfoRoom_Click(object sender, RoutedEventArgs e)
       
        {

            try

            {

                if (DGFund.SelectedValue != null)

                {

                    ClassDataBase.CurrentRoom = (UniClassFundCorps)DGFund.SelectedValue;
                    ClassNavigate.ClassFrmMain.Navigate(new PageInformationRoom());

                }

                else MessageBox.Show("Для просмотра информации выберите корпус", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        /// <summary>
        /// Кнопка назад
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        
        {

            ClassDataBase.CurrentRoom = null;
            ClassDataBase.CurrentCorpus = null;
            ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

        }
    }
}
