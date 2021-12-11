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
using UniversCorps.DataBase;
using UniversCorps.DialogBox;

namespace UniversCorps.PagesCorp
{
    /// <summary>
    /// Логика взаимодействия для PageCorpMain.xaml
    /// </summary>
    public partial class PageCorpMain : Page
    {
        public PageCorpMain()
        {

            try

            {

                InitializeComponent();

                DGCorps.ItemsSource = ClassDataBase.UniversClassFundEntities.Corps.ToList();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();

            }

        }

        /// <summary>
        /// Добавление корпуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddCorp_Click(object sender, RoutedEventArgs e)
        
        {



        }

        /// <summary>
        /// Изменение информации о корпусе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChangeCorp_Click(object sender, RoutedEventArgs e)
        
        {

            try

            {

                if (DGCorps.SelectedValue != null)

                {

                    ClassDataBase.CurrentCurpus = (Corps)DGCorps.SelectedValue;

                    DislogChangeCorpName dialogNameCh = new DislogChangeCorpName();
                    dialogNameCh.ShowDialog();

                    if (dialogNameCh.DialogResult == true)

                    {

                        DGCorps.ItemsSource = ClassDataBase.UniversClassFundEntities.Corps.ToList();
                    
                    }

                }

                else MessageBox.Show("Для изменения имени выберите корпус", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

       /// <summary>
       /// Удаление корпуса
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnDeleteCorp_Click(object sender, RoutedEventArgs e)
        {

            try

            {

                if (DGCorps.SelectedValue != null)

                {

                    ClassDataBase.CurrentCurpus = (Corps)DGCorps.SelectedValue;
                
                    WinDeleteQ winDeleteQ = new WinDeleteQ();
                    SystemSounds.Beep.Play();
                    winDeleteQ.ShowDialog();

                    if (winDeleteQ.DialogResult == true)

                    {

                        ClassDataBase.UniversClassFundEntities.Corps.Remove(ClassDataBase.CurrentCurpus);
                        ClassDataBase.UniversClassFundEntities.SaveChanges();

                        DGCorps.ItemsSource = ClassDataBase.UniversClassFundEntities.Corps.ToList();

                    }

                    else winDeleteQ.Close();

                }

                else MessageBox.Show("Для удаления выберите корпус", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }
    }
}
