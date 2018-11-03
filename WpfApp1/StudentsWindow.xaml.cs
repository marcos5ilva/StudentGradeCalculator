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
using System.Windows.Shapes;
using WpfApp1.Class;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for StudentsWindow.xaml
    /// </summary>
    public partial class StudentsWindow : Window
    {
        public StudentsWindow()
        {
            InitializeComponent();
            this.comboBoxInternational.Items.Add("Yes");
            this.comboBoxInternational.Items.Add("No");
            this.comboBoxInternational.SelectedIndex = 0;
            this.radioButtonGenderFemale.IsChecked = true;
            DataContext = Student.Read();

            
        }

        String gender;
        readonly String EMPTYFIELD = " ";
        //private IpersonManager pm = new DLLFacade().GetPersonManager();

       
        private void AddStudentButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(this.StudentIDTextBox.Text);
            String dateOfBirth = this.BirthdateMonthTextBox.Text + "/" + this.BirthdateDayTextBox.Text + "/" + this.BirthdateYearTextBox.Text;
            
            Student student = new Student(id, this.FirstNameTextBox.Text,
            this.LastNameTextBox.Text, this.EmailTextBox.Text, dateOfBirth, gender, 
            this.comboBoxInternational.SelectedItem.ToString(), 
            this.checkBox.IsChecked==true ? "true":"false"       );

            if (student.Insert())
            {
                //Display success message.
                MessageBox.Show("Student's record have been saved successfully!");
                ClearForm();          
            }
            else
            {
                //Display error message.
                MessageBox.Show("ERROR: Student's record haven't been saved!");
                ClearForm();
            }

            //Reload Grid Info
            DataContext = Student.Read();

        }

        private void radioButtonGenderFemale_Checked(object sender, RoutedEventArgs e)
        {

            gender = "F";
        }

        private void radioButtonGenderMale_Checked(object sender, RoutedEventArgs e)
        {
            gender = "M";
        }

        public void ClearForm()
        {
            this.StudentIDTextBox.Text = EMPTYFIELD;
            this.FirstNameTextBox.Text = EMPTYFIELD;
            this.LastNameTextBox.Text = EMPTYFIELD;
            this.EmailTextBox.Text = EMPTYFIELD;
            this.BirthdateMonthTextBox.Text = EMPTYFIELD;
            this.BirthdateDayTextBox.Text = EMPTYFIELD;
            this.BirthdateYearTextBox.Text = EMPTYFIELD;
            this.radioButtonGenderFemale.IsChecked = true;
            this.radioButtonGenderMale.IsChecked = false;

        }

        private void DataGridReloadBtn(object sender, RoutedEventArgs e)
        {
            DataContext = Student.Read();
        }

        private void EditStudentGrade(object sender, RoutedEventArgs e)
        {
            if(this.myDataGrid.SelectedItem != null)
            {
                Student student = (Student)this.myDataGrid.SelectedItem;
                GradesWindow gradesWindow = new GradesWindow(student.fisrtName, student.lastName, ""+student.iD);
               
                gradesWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR: Select an Student");
                //alert pedindo para selecionar estudante
            }
        }
    }
}
