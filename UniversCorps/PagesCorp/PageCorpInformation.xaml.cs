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
    /// Логика взаимодействия для PageCorpInformation.xaml
    /// </summary>
    public partial class PageCorpInformation : Page
    {
        public PageCorpInformation()
        {
            InitializeComponent();

            Title = "Информация о корпусе " + ClassDataBase.CurrentCorpus.Name;
               
            

            for (int i = 0; i < ClassDataBase.UniversClassFundEntities.UniClassFundCorps.Where(x => x.IdCorps == ClassDataBase.CurrentCorpus.Id).
                Where(x => x.Division.Faculty.Id == x.Division.IdFaculty).Count(); ++i)

            {

                xa = i;

            }

            TxtFuc.Text = xa.ToString();

        }

        public int xa;
        
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassDataBase.CurrentCorpus = null;
            ClassNavigate.ClassFrmMain.Navigate(new PageCorpMain());
        }
    }
}
