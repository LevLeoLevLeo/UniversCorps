using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Mail;
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
using static UniversCorps.DialogBox.WinDeleteQ;

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

            try

            {

               

                    DialogAddCorp dialogAddCorp = new DialogAddCorp();
                    dialogAddCorp.ShowDialog();

                    if (dialogAddCorp.DialogResult == true)

                    {

                       DGCorps.ItemsSource = ClassDataBase.UniversClassFundEntities.Corps.ToList();

                    }

              
                }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);

            }

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

                    ClassDataBase.CurrentCorpus = (Corps)DGCorps.SelectedValue;

                    DislogChangeCorpName dialogNameCh = new DislogChangeCorpName();
                    dialogNameCh.ShowDialog();

                    if (dialogNameCh.DialogResult == true)

                    {

                        ClassDataBase.CurrentCorpus = null;
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
                 
                    ClassDataBase.CurrentCorpus = (Corps)DGCorps.SelectedValue;

                    var emptyCorp = ClassDataBase.UniversClassFundEntities.UniClassFundCorps.FirstOrDefault(x => x.IdCorps == ClassDataBase.CurrentCorpus.Id);

                    if (emptyCorp == null)

                    {


                        bool? Result = new WinDeleteQ("Вы действительно хотите удалить корпус " + ClassDataBase.CurrentCorpus.Name + "?", "Удаление",
                            MessageButtons.YesNoCancel, MessageSound.Warning).ShowDialog();

                        if (Result == true)

                        {

                            ClassDataBase.UniversClassFundEntities.Corps.Remove(ClassDataBase.CurrentCorpus);
                            ClassDataBase.UniversClassFundEntities.SaveChanges();

                            ClassDataBase.CurrentCorpus = null;

                            DGCorps.ItemsSource = ClassDataBase.UniversClassFundEntities.Corps.ToList();

                        }

                    }  
                    
                    else
                    {
                        bool? Result = new WinDeleteQ("Выберите пустой корпус", "Внимание!", MessageButtons.Ok, MessageSound.Information).ShowDialog();
                    }
                }

                else MessageBox.Show("Для удаления выберите корпус", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        /// <summary>
        /// Переход на страницу с комнатами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChoice_Click(object sender, RoutedEventArgs e)
        {

            try

            {

                if (DGCorps.SelectedValue != null)

                {

                ClassDataBase.CurrentCorpus = (Corps)DGCorps.SelectedValue;

                ClassNavigate.ClassFrmMain.Navigate(new PageRoom());
                    
                }

                else MessageBox.Show("Для перехода к списку комнат выберите корпус", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void BtnInfo_Click(object sender, RoutedEventArgs e)
        {

            try

            {

                if (DGCorps.SelectedValue != null)

                {

                    ClassDataBase.CurrentCorpus = (Corps)DGCorps.SelectedValue;

                    ClassNavigate.ClassFrmMain.Navigate(new PageCorpInformation());

                }

                else MessageBox.Show("Для перехода к списку комнат выберите корпус", "Внимание!",
                    MessageBoxButton.OK, MessageBoxImage.Information);

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void BtnSendMsg_Click(object sender, RoutedEventArgs e)
        
        {

            MailAddress fromMailAddress = new MailAddress("testemailformailing@gmail.com", "UniversCorpsSupport");
            MailAddress toMailAddress = new MailAddress("Leo541541145@gmail.com", "UserName");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))

            using (SmtpClient smtpClient = new SmtpClient())

            {

                mailMessage.Subject = "Проверка";
                mailMessage.Body = "Работает";
                
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "r6h-Emq-SMH-uCL");

                smtpClient.Send(mailMessage);

            }

        }
    }
}
