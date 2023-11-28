using Kinder.ClassPr;
using Kinder.Model;
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
    /// Логика взаимодействия для PageGroup.xaml
    /// </summary>
    public partial class PageGroup : Page
    {
        public PageGroup()
        {
            InitializeComponent();
            CmbGV.SelectedValuePath = "ID";
            CmbGV.DisplayMemberPath = "Name";
            CmbGV.ItemsSource = App.context.VidGroup.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void BtnAddGroup_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(EnterGroupTb.Text))
                mes += "Введите группу\n";
            if (string.IsNullOrWhiteSpace(CmbGV.Text))
                mes += "Выберите вид группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Group group = new Group()
            {
                Name = ChoiceGroupTbl.Text,
                VidGroup1 = CmbGV.SelectedItem as VidGroup
            };
            App.context.Group.Add(group);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            ChoiceGroupTbl.Text = "";
            CmbGV.Text = "";
        }
    }
}
