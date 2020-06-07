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
    /// Логика взаимодействия для ExitPage.xaml
    /// </summary>
    public partial class ExitPage : Page
    {
        public MainWindow mainWindow;

        public ExitPage(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;

        }

        private void BtnExt_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.GlobalMenu);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.Journal_Base);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.CourseWorkPage);
        }
    }
}
