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

namespace curt
{
    /// <summary>
    /// Логика взаимодействия для EnteryPage.xaml
    /// </summary>
    public partial class EnteryPage : Page
    {
        public MainWindow mainWindow;
        public EnteryPage(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

        }
        

        private void BtnStudy_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.Stud);
            BtnSub.Visibility = Visibility.Hidden;
            BtnGui.Visibility = Visibility.Hidden;
            BtnSaveTheme.Visibility = Visibility.Hidden;
            BtnCurs.Visibility = Visibility.Hidden;
            BtnExit.Visibility = Visibility.Hidden;
            BtnStudy.Visibility = Visibility.Hidden;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.GlobalMenu);
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.SubPage);
            BtnSub.Visibility = Visibility.Hidden;
            BtnGui.Visibility = Visibility.Hidden;
            BtnSaveTheme.Visibility = Visibility.Hidden;
            BtnCurs.Visibility = Visibility.Hidden;
            BtnExit.Visibility = Visibility.Hidden;
            BtnStudy.Visibility = Visibility.Hidden;
        }

        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.GuidePage);
        }

        private void BtnSaveTheme_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.SaveWorks);
        }

        private void BtnCurs_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.Course_works);
        }
    }
}
