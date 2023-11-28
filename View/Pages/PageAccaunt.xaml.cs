using Kinder.ClassPr;
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

namespace Kinder.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAccaunt.xaml
    /// </summary>
    public partial class PageAccaunt : Page
    {
        public PageAccaunt()
        {
            InitializeComponent();
        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Journal.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void VACmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedVA = Convert.ToInt32(VACmb.SelectedValue);
            DatGr.ItemsSource = App.context.Journal.Where
                (x => x.Activity.Direction_Id == SelectedVA).ToList();

        }
    }
}
