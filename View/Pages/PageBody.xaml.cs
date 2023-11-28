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
    /// Логика взаимодействия для PageBody.xaml
    /// </summary>
    public partial class PageBody : Page
    {
        public PageBody()
        {
            InitializeComponent();
        }

        private void GroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.PageGroup());
        }

        private void EventsBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.PageActivity());
        }

        private void AccauntingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.PageAccaunt());
        }

        private void JournalBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new View.Pages.PageJournal());
        }
    }
}
