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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
            
            OpenPage(pages.login);
        }
        public enum pages
        {
            login,
            regin,
            Stud,
            GlobalMenu,
            EnteryPage,
            ExitPage,
            SubPage,
            GuidePage,
            SaveWorks,
            Course_works,
            Journal_Base,
            CourseWorkPage
        }
        public void OpenPage(pages pages)
        {
            if (pages == pages.login)
            {
                Frame.Navigate(new login(this));
            }
            else if (pages == pages.regin)
            {
                Frame.Navigate(new regin(this));
            }
            else if (pages == pages.GlobalMenu)
            {
                Frame.Navigate(new GlobalMenu(this));
            }else if (pages == pages.EnteryPage)
            {
                Frame.Navigate(new EnteryPage(this));
            }else if (pages == pages.ExitPage)
            {
                Frame.Navigate(new ExitPage(this));
            }else if (pages == pages.Stud)
            {
                Frame.Navigate(new Stud(this));
            }else if (pages == pages.SubPage)
            {
                Frame.Navigate(new SubPage(this));
            }else if (pages == pages.GuidePage)
            {
                Frame.Navigate(new GuidePage(this));
            }else if (pages == pages.SaveWorks)
            {
                Frame.Navigate(new SaveWorks(this));
            }else if (pages == pages.Course_works)
            {
                Frame.Navigate(new Course_works(this));
            }else if (pages == pages.Journal_Base)
            {
                Frame.Navigate(new Journal_Base(this));
            }else if (pages == pages.CourseWorkPage)
            {
                Frame.Navigate(new CourseWorkPage(this));
            }


        }
        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection(@"server=DESKTOP-H9A6I14\SQLEXP;Trusted_Connection=Yes;DataBase=Courses_project;");
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }
    }
}
