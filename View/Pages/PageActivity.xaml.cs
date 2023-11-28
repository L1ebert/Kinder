
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
    /// Логика взаимодействия для PageActivity.xaml
    /// </summary>
    public partial class PageActivity : Page
    {
        public PageActivity()
        {
            InitializeComponent();
            CmbActivity.SelectedValuePath = "ID";
            CmbActivity.DisplayMemberPath = "Name";
            CmbActivity.ItemsSource = App.context.Direction.ToList();
        }

        private void BtnBackActivity_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void BtnAddActivity_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(EnterActivityTb.Text))
                mes += "Введите активность\n";
            if (string.IsNullOrWhiteSpace(CmbActivity.Text))
                mes += "Выберите вид активность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Activity activity = new Activity()
            {
                Name = ChoiceActivityTb.Text,
                Direction = CmbActivity.SelectedItem as Direction
            };
            App.context.Activity.Add(activity);
            App.context.SaveChanges();
            MessageBox.Show("Активность добавлена");

            ChoiceActivityTb.Text = "";
            CmbActivity.Text = "";
        }
    }
}
