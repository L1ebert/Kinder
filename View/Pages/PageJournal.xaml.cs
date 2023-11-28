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
    /// Логика взаимодействия для PageJournal.xaml
    /// </summary>
    public partial class PageJournal : Page
    {
        public PageJournal()
        {
            InitializeComponent();
            VidGroupCmb.SelectedValuePath = "ID";
            VidGroupCmb.DisplayMemberPath = "Name";
            VidGroupCmb.ItemsSource = App.context.VidGroup.ToList();

            GroupCmb.SelectedValuePath = "ID";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.Group.ToList();

            ActivityCmb.SelectedValuePath = "ID";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.Direction.ToList(); 

            DirectionCmb.SelectedValuePath = "ID";
            DirectionCmb.DisplayMemberPath = "Name";
            DirectionCmb.ItemsSource = App.context.Activity.ToList(); 

            MarkCmb.SelectedValuePath = "ID";
            MarkCmb.DisplayMemberPath = "Name";
            MarkCmb.ItemsSource = App.context.Mark.ToList();


        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберете группу\n";

            if (string.IsNullOrWhiteSpace(VidGroupCmb.Text))
                mes += "Выберете вид группы\n";

            if (string.IsNullOrWhiteSpace(ActivityCmb.Text))
                mes += "Выберете мероприятие\n";

            if (string.IsNullOrWhiteSpace(DateSelectionDP.Text))
                mes += "Выберете дату\n";

            if (string.IsNullOrWhiteSpace(DirectionCmb.Text))
                mes += "Выберете вид мероприятия\n";

            if (string.IsNullOrWhiteSpace(MarkCmb.Text))
                mes += "Выберете оценку\n";
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            Journal journal = new Journal()
            {
                DateZan = (DateTime)DateSelectionDP.SelectedDate,
                Group = GroupCmb.SelectedItem as Group,
                Activity = DirectionCmb.SelectedItem as Activity,
                Mark = MarkCmb.SelectedItem as Mark
            };
            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Данные добавлены");

            DateSelectionDP.Text = "";
            GroupCmb.Text = "";
            VidGroupCmb.Text = "";
            ActivityCmb.Text = "";
            DirectionCmb.Text = "";
            MarkCmb.Text = "";
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.GoBack();
        }

        private void VidGroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedVG = Convert.ToInt32(VidGroupCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.Group.Where
                (x => x.VidGroup == SelectedVG).ToList();
        }

        private void GroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void GroupCmb_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            int SelectedVM = Convert.ToInt32(VidGroupCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.Activity.Where
                (x => x.Direction_Id == SelectedVM).ToList();
        }
    }
}
