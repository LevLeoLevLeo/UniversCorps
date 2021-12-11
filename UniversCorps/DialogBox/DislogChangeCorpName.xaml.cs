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

namespace UniversCorps.DialogBox
{
    /// <summary>
    /// Логика взаимодействия для DislogChangeCorpName.xaml
    /// </summary>
    public partial class DislogChangeCorpName : Window
    {
        public DislogChangeCorpName()
        
        {
        
            InitializeComponent();

            TxbCorrectName.Text = ClassDataBase.CurrentCurpus.Name;
        
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        
        {

            try

            {

                if (!string.IsNullOrWhiteSpace(TxbNewName.Text))

                {

                    this.DialogResult = true;

                    ClassDataBase.CurrentCurpus.Name = TxbNewName.Text;
                    ClassDataBase.UniversClassFundEntities.SaveChanges();

                }

                else MessageBox.Show("Вы не ввели новое название для корпуса!", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();

            }

        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        
        {
            
            this.Close();
        
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        
        {
        
            this.Close();
        
        }
    }
}
