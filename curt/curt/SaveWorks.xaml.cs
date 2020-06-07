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
    /// Логика взаимодействия для SaveWorks.xaml
    /// </summary>
    public partial class SaveWorks : Page
    {
        public MainWindow mainWindow;
        public SaveWorks(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            DGridSaveWorks.ItemsSource = Courses_projectEntities.GetContext().SaveWork.ToList();
        }
    }
}
