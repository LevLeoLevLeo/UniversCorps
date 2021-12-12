using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для PageAddRoom.xaml
    /// </summary>
    public partial class PageAddRoom : Page
    {
        public PageAddRoom()
        
        {
            try

            {
             
                InitializeComponent();

                CmdLocal.SelectedValuePath = "Id";
                CmdLocal.DisplayMemberPath = "Location.Name";
                CmdLocal.ItemsSource = ClassDataBase.UniversClassFundEntities.LocHei.ToList();

                CmdHeight.SelectedValuePath = "Id";
                CmdHeight.DisplayMemberPath = "Ceiling.HeightMeters";

                CmdPurporseRoom.SelectedValuePath = "Id";
                CmdPurporseRoom.DisplayMemberPath = "Name";
                CmdPurporseRoom.ItemsSource = ClassDataBase.UniversClassFundEntities.Purporse.ToList();

                CmdTypeRoom.SelectedValuePath = "Id";
                CmdTypeRoom.DisplayMemberPath = "Name";
                CmdTypeRoom.ItemsSource = ClassDataBase.UniversClassFundEntities.TypeOfRoom.ToList();

                CmdDivision.SelectedValuePath = "Id";
                CmdDivision.DisplayMemberPath = "Name";
                CmdDivision.ItemsSource = ClassDataBase.UniversClassFundEntities.Department.ToList();

                CmdFaculty.SelectedValuePath= "Id";
                CmdFaculty.DisplayMemberPath = "Name";
                CmdFaculty.ItemsSource = ClassDataBase.UniversClassFundEntities.Faculty.ToList();

                CmdLaboratory.SelectedValuePath = "Id";
                CmdLaboratory.DisplayMemberPath= "Name";
                CmdLaboratory.ItemsSource = ClassDataBase.UniversClassFundEntities.Laboratory.ToList();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

            }

        }

        private void CmdLocal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        
        {

            try

            {

                int y = Convert.ToInt32(CmdLocal.SelectedValue);

                CmdHeight.ItemsSource = ClassDataBase.UniversClassFundEntities.LocHei.Where(x => x.IdCeiling == y).ToList();

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

            }

        }

        private void BtnAddRoom_Click(object sender, RoutedEventArgs e)
        
        {

            try

            {

                try

                {

                    Convert.ToInt32(TxbRoomNumber.Text);
                    float.Parse(TxbWidth.Text, CultureInfo.InvariantCulture.NumberFormat);
                    float.Parse(TxbLenght.Text, CultureInfo.InvariantCulture.NumberFormat);

                }
               
                catch (Exception)

                {

                    MessageBox.Show("В поля допускается ввод только целочисленных и десятичных чисел, разделяемых запятой",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                if (string.IsNullOrWhiteSpace(TxbRoomNumber.Text) || string.IsNullOrWhiteSpace(TxbWidth.Text) || string.IsNullOrWhiteSpace(TxbLenght.Text)
                    || CmdLocal.SelectedItem == null || CmdHeight.SelectedItem == null || CmdPurporseRoom.SelectedItem == null ||
                    CmdTypeRoom.SelectedItem == null)

                {

                    MessageBox.Show("Вы что-то не заполнили, проверьте введенные данные", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {

                    UniClassFundCorps uniClass = new UniClassFundCorps()

                    {

                        IdCorps = ClassDataBase.CurrentCorpus.Id,
                        Room = Convert.ToInt32(TxbRoomNumber.Text),
                        IdLocHei = Convert.ToInt32(CmdLocal.SelectedValue),
                        WidthMeters = float.Parse(TxbWidth.Text, CultureInfo.InvariantCulture.NumberFormat),
                        LengthMeters = float.Parse(TxbLenght.Text, CultureInfo.InvariantCulture.NumberFormat),
                        IdPurporse = Convert.ToInt32(CmdPurporseRoom.SelectedValue),
                        IdTypeOfRoom = Convert.ToInt32(CmdTypeRoom.SelectedValue),

                    };

                    ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Add(uniClass);
                    ClassDataBase.UniversClassFundEntities.SaveChanges();
                    ClassNavigate.ClassFrmMain.Navigate(new PageRoom());

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

            }

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        
        {

            TxbRoomNumber.Text = null;
            CmdLocal.SelectedItem = null;
            CmdHeight.SelectedItem = null;
            TxbWidth.Text = null;
            TxbLenght.Text = null;
            CmdPurporseRoom.SelectedItem = null;
            CmdTypeRoom.SelectedItem = null;
            CmdDivision.SelectedItem = null;
            CmdFaculty.SelectedItem = null;
            CmdLaboratory.SelectedItem = null;

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        
        {

            if (ClassNavigate.ClassFrmMain.CanGoBack) ClassNavigate.ClassFrmMain.GoBack();

        }
    }
}
