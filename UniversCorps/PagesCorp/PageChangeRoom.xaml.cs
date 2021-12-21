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
    /// Логика взаимодействия для PageChangeRoom.xaml
    /// </summary>
    public partial class PageChangeRoom : Page
    {
        public PageChangeRoom()

        {

            try

            {

                InitializeComponent();

                Title = "Изменения кабинета " + ClassDataBase.CurrentRoom.Room;

                TxbRoomNumber.Text = ClassDataBase.CurrentRoom.Room.ToString();

                TxbWidth.Text = ClassDataBase.CurrentRoom.WidthMeters.ToString();

                TxbLenght.Text = ClassDataBase.CurrentRoom.LengthMeters.ToString();

                CmdLocal.SelectedValuePath = "Id";
                CmdLocal.DisplayMemberPath = "Location.Name";
                CmdLocal.ItemsSource = ClassDataBase.UniversClassFundEntities.LocHei.ToList();
                CmdLocal.SelectedItem = ClassDataBase.UniversClassFundEntities.LocHei.FirstOrDefault(x => ClassDataBase.CurrentRoom.IdLocHei == x.Id);

                CmdHeight.SelectedValuePath = "Id";
                CmdHeight.DisplayMemberPath = "Ceiling.HeightMeters";
                int y = Convert.ToInt32(CmdLocal.SelectedValue);
                CmdHeight.ItemsSource = ClassDataBase.UniversClassFundEntities.LocHei.Where(x => x.IdCeiling == y).ToList();
                CmdHeight.SelectedItem = ClassDataBase.UniversClassFundEntities.LocHei.FirstOrDefault(x => ClassDataBase.CurrentRoom.IdLocHei == x.Id);

                CmdPurporseRoom.SelectedValuePath = "Id";
                CmdPurporseRoom.DisplayMemberPath = "Name";
                CmdPurporseRoom.ItemsSource = ClassDataBase.UniversClassFundEntities.Purporse.ToList();
                CmdPurporseRoom.SelectedItem = ClassDataBase.UniversClassFundEntities.Purporse.FirstOrDefault(x => ClassDataBase.CurrentRoom.IdPurporse == x.Id);

                CmdTypeRoom.SelectedValuePath = "Id";
                CmdTypeRoom.DisplayMemberPath = "Name";
                CmdTypeRoom.ItemsSource = ClassDataBase.UniversClassFundEntities.TypeOfRoom.ToList();
                CmdTypeRoom.SelectedValue = ClassDataBase.CurrentRoom.IdTypeOfRoom;

                CmdDivision.SelectedValuePath = "Id";
                CmdDivision.DisplayMemberPath = "Name";
                CmdDivision.ItemsSource = ClassDataBase.UniversClassFundEntities.Department.ToList();
                CmdDivision.SelectedItem = ClassDataBase.UniversClassFundEntities.Department.FirstOrDefault(x => ClassDataBase.CurrentRoom.Division.IdDepartment == x.Id);

                CmdFaculty.SelectedValuePath = "Id";
                CmdFaculty.DisplayMemberPath = "Name";
                CmdFaculty.ItemsSource = ClassDataBase.UniversClassFundEntities.Faculty.ToList();
                CmdFaculty.SelectedItem = ClassDataBase.UniversClassFundEntities.Faculty.FirstOrDefault(x => ClassDataBase.CurrentRoom.Division.IdFaculty == x.Id);

                CmdLaboratory.SelectedValuePath = "Id";
                CmdLaboratory.DisplayMemberPath = "Name";
                CmdLaboratory.ItemsSource = ClassDataBase.UniversClassFundEntities.Laboratory.ToList();
                CmdLaboratory.SelectedItem = ClassDataBase.UniversClassFundEntities.Laboratory.FirstOrDefault(x => ClassDataBase.CurrentRoom.Division.IdLaboratory == x.Id);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassDataBase.CurrentRoom = null;
                ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

            }

        }

        private void BtnChangeRoom_Click(object sender, RoutedEventArgs e)

        {

            try

            {

                if (string.IsNullOrWhiteSpace(TxbRoomNumber.Text) || string.IsNullOrWhiteSpace(TxbWidth.Text) || string.IsNullOrWhiteSpace(TxbLenght.Text)
                    || CmdLocal.SelectedItem == null || CmdHeight.SelectedItem == null || CmdPurporseRoom.SelectedItem == null ||
                    CmdTypeRoom.SelectedItem == null)

                {

                    MessageBox.Show("Вы что-то не заполнили, проверьте введенные данные", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);

                }

                else

                {
                        
                    try

                    {

                        Convert.ToInt32(TxbRoomNumber.Text);
                        float.Parse(TxbWidth.Text, CultureInfo.InvariantCulture.NumberFormat);
                        float.Parse(TxbLenght.Text, CultureInfo.InvariantCulture.NumberFormat);

                    }

                    catch (Exception)

                    {

                        MessageBox.Show("В поля допускается ввод только целочисленных и десятичных чисел",
                        "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);

                        return;

                    }

                        int y = Convert.ToInt32(TxbRoomNumber.Text);

                        var roomNumber = ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Where(x => x.IdCorps == ClassDataBase.CurrentCorpus.Id).FirstOrDefault(x => x.Room == y);

                        if (y != ClassDataBase.CurrentRoom.Room && roomNumber != null)

                        {

                            MessageBox.Show("Данная комната уже имеется в базе данных", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                            TxbRoomNumber.Text = null;

                        }

                        else

                        {

                            ClassDataBase.CurrentRoom.Room = Convert.ToInt32(TxbRoomNumber.Text);
                            ClassDataBase.CurrentRoom.IdLocHei = Convert.ToInt32(CmdLocal.SelectedValue);
                            ClassDataBase.CurrentRoom.WidthMeters = float.Parse(TxbWidth.Text, CultureInfo.InvariantCulture.NumberFormat);
                            ClassDataBase.CurrentRoom.LengthMeters = float.Parse(TxbLenght.Text, CultureInfo.InvariantCulture.NumberFormat);
                            ClassDataBase.CurrentRoom.IdPurporse = Convert.ToInt32(CmdPurporseRoom.SelectedValue);
                            ClassDataBase.CurrentRoom.IdTypeOfRoom = Convert.ToInt32(CmdTypeRoom.SelectedValue);
                            ClassDataBase.CurrentRoom.Division.IdDepartment = Convert.ToInt32(CmdDivision.SelectedValue);
                            ClassDataBase.CurrentRoom.Division.IdFaculty = Convert.ToInt32(CmdFaculty.SelectedValue);
                            ClassDataBase.CurrentRoom.Division.IdLaboratory = Convert.ToInt32(CmdLaboratory.SelectedValue);
                            
                            ClassDataBase.UniversClassFundEntities.SaveChanges();

                            ClassDataBase.CurrentRoom = null;

                            ClassNavigate.ClassFrmMain.Navigate(new PageRoom());

                        }
                    }
                }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());

            }

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        
        {

            ClassDataBase.CurrentRoom = null;
            ClassNavigate.ClassFrmMain.Navigate(new PageRoom());

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

    }

}
