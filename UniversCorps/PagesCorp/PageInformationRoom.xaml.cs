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
    /// Логика взаимодействия для PageInformationRoom.xaml
    /// </summary>
    public partial class PageInformationRoom : Page
    {
        public PageInformationRoom()
        {
            
            InitializeComponent();

            try

            {

                TxbRoomNumber.Text = ClassDataBase.CurrentRoom.Room.ToString();
                TxbLocation.Text = ClassDataBase.CurrentRoom.LocHei.Location.Name;
                TxbHeight.Text = ClassDataBase.CurrentRoom.LocHei.Ceiling.HeightMeters.ToString();
                TxbWidth.Text = ClassDataBase.CurrentRoom.WidthMeters.ToString();
                TxbLenght.Text = ClassDataBase.CurrentRoom.LengthMeters.ToString();
                TxbArea.Text = Convert.ToString(ClassDataBase.CurrentRoom.WidthMeters * ClassDataBase.CurrentRoom.LengthMeters);
                TxbVolume.Text = Convert.ToString(ClassDataBase.CurrentRoom.WidthMeters * ClassDataBase.CurrentRoom.LengthMeters *
                    ClassDataBase.CurrentRoom.LocHei.Ceiling.HeightMeters);
                TxbPurporse.Text = ClassDataBase.CurrentRoom.Purporse.Name;
                TxbTypeRoom.Text = ClassDataBase.CurrentRoom.TypeOfRoom.Name;

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassNavigate.ClassFrmMain.Navigate(new PageRoom());

            }

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassNavigate.ClassFrmMain.Navigate(new PageRoom());
        }
    }
}
