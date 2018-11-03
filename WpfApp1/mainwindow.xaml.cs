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
using WpfApp1;
using WpfApp1.Class;

namespace StudentGradeCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       String gender;
       readonly String  EMPTYFIELD = " ";
        //private IpersonManager pm = new DLLFacade().GetPersonManager();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = Student.Read();
            Console.WriteLine(DataContext);
            //listBoxStudents.ItemsSource = myStudents;
        }

        

        

        private void Grades_Click(object sender, RoutedEventArgs e)
        {
            //GradesWindow grades = new GradesWindow();
            //grades.ShowDialog();
        }

        private void Students_Click(object sender, RoutedEventArgs e)
        {
            StudentsWindow studentsWindow = new StudentsWindow();
            studentsWindow.ShowDialog();
        }
    }
}
