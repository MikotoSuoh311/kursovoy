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
    /// Логика взаимодействия для GuidePage.xaml
    /// </summary>
    public partial class GuidePage : Page
    {
        public MainWindow mainWindow;
        public GuidePage(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            DGridGuide.ItemsSource = Courses_projectEntities.GetContext().Guide.ToList();
        }
    }
}
