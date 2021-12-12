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
using UniversCorps.Class;
using UniversCorps.DataBase;

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

        }

        private void BtnDeleteRoom_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInfoRoom_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
