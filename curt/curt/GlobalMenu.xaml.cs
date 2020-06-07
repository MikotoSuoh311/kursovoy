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
    /// Логика взаимодействия для GlobalMenu.xaml
    /// </summary>
    public partial class GlobalMenu : Page
    {
        public MainWindow mainWindow;
        public GlobalMenu(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            
        }
        

        

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.ExitPage);
            Button.Visibility = Visibility.Hidden;
            BtnStud.Visibility = Visibility.Hidden;
        }

        private void BtnStud_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.OpenPage(MainWindow.pages.EnteryPage);
            Button.Visibility = Visibility.Hidden;
            BtnStud.Visibility = Visibility.Hidden;
        }

        
    }
}
