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

namespace Kinder
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.context = new Tolmachev_KinderEntities();

            ClassFrame.FrameMenu = FrameMenuMain;
            FrameMenuMain.Navigate(new View.Pages.PageMenu());

            ClassFrame.FrameBody = FrameBodyMain;
            FrameBodyMain.Navigate(new View.Pages.PageBody());
        }
    }
}
