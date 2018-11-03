using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using WpfApp1.Class;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Grades.xaml
    /// </summary>
    public partial class GradesWindow : Window
    {

        String iDStudent;

            public GradesWindow(String fisrtName, String lastName, String iD)
        {
            InitializeComponent();

            
            this.labelFristName.Content += fisrtName;
            this.labelLastName.Content += lastName;
            this.iDStudent = iD;

            DataContext = Grades.Read(""+iD);
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void WriteGradesBtn(object sender, RoutedEventArgs e)
        {
            Grades grades = new Grades(this.textBoxAssignment.Text, this.textBoxGrade.Text);

            //Insert Grid Info
            grades.Insert(iDStudent);
            //Reload Grid Info
            DataContext = Grades.Read(iDStudent);

            //Clearing fieds
            this.textBoxAssignment.Text = " ";
            this.textBoxGrade.Text = " ";
        }

        
    }
}
