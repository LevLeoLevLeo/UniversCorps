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
    /// Логика взаимодействия для DialogAddCorp.xaml
    /// </summary>
    public partial class DialogAddCorp : Window
    {
        public DialogAddCorp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try

            {

                if (string.IsNullOrWhiteSpace(TxbNewCorp.Text))

                {

                    MessageBox.Show("Вы не ввели название корпуса", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {   
                    var corpname = ClassDataBase.UniversClassFundEntities.Corps.FirstOrDefault(x => x.Name == TxbNewCorp.Text);

                    if (corpname != null) MessageBox.Show("Данный корпус уже внесен в базу данных.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);

                    else

                    {

                        this.DialogResult = true;

                        Corps corps = new Corps()

                        {

                            Name = TxbNewCorp.Text

                        };

                        ClassDataBase.UniversClassFundEntities.Corps.Add(corps);
                        ClassDataBase.UniversClassFundEntities.SaveChanges();

                    }       
                }
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
    }
}
