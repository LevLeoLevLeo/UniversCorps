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
using System.Windows.Shapes;
using UniversCorps.DataBase;
using UniversCorps.PagesCorp;

namespace UniversCorps.DialogBox
{
    /// <summary>
    /// Логика взаимодействия для WinDeleteQ.xaml
    /// </summary>
    public partial class WinDeleteQ : Window
    {
        public WinDeleteQ()
        
        {
            
            InitializeComponent();

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
       
        {

            this.DialogResult = true;

        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        
        {

            this.Close();

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            this.Topmost = true;
        }

        private void Window_Deactivated(object sender, EventArgs e)
        {
            this.Topmost = false;
        }
    }
}
