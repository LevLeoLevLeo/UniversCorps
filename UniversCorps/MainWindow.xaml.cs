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
using UniversCorps.PagesCorp;

namespace UniversCorps
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();

            ClassNavigate.ClassFrmMain = FrmMain;

            FrmMain.Navigate(new PageCorpMain());

        }

        #region Верхняя панель

        /// <summary>
        /// Завершение работы приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();

        }

        /// <summary>
        /// Восстановить/развернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSizeWindow_Click(object sender, RoutedEventArgs e)
        {

            switch (this.WindowState)

            {

                case WindowState.Maximized:
                    this.WindowState = WindowState.Normal;
                    break;

                case WindowState.Normal:
                    this.WindowState = WindowState.Maximized;
                    break;
            
            }
 
        }

        /// <summary>
        /// Свернуть окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinWindow_Click(object sender, RoutedEventArgs e)
        {

            this.WindowState = WindowState.Minimized;

        }

        /// <summary>
        ///Изменение ToolTip для BtnSizeWindow в соответствии с размером окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            switch (this.WindowState)

            {

                case WindowState.Maximized:
                    BtnSizeWindow.ToolTip = "Восстановить";
                    break;

                case WindowState.Normal:
                    BtnSizeWindow.ToolTip = "Развернуть";
                    break;

            }

        }
        
        #endregion

    }

}