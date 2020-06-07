using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Journal_Base.xaml
    /// </summary>
    public partial class Journal_Base : Page
    {
        public MainWindow mainWindow;
       
        
            
    
        
        public Journal_Base(MainWindow _mainWindow)
        {
            InitializeComponent();
            mainWindow = _mainWindow;
            DGridJournal.ItemsSource = Courses_projectEntities.GetContext().Journal.ToList();

        }
       
        
    }
}
