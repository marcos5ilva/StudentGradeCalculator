using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApp1.Class
{
    public class Student
    {
        public int iD { get; set; }
        public String fisrtName { get; set; }
        public String lastName { get; set; }
        public String email { get; set; }
        public String birthDate { get; set; }
        public String gender { get; set; }
        public String isInternacional { get; set; }
        public String isEndorse { get; set; }


        int grades;
        public static readonly string filePath = @"C:\Users\Marcos\file\Student.csv";
        List<Student> list = new List<Student>();
        private List<string> fileLines;
       

        private List<string> FileLines { get => FileLines; set => FileLines = value; }

        public Student(int iD, String fisrtName, String lastName, String email, String birthDate, String gender,
            String isInternacional, String isEndorse)
        {
            this.iD = iD;
            this.fisrtName = fisrtName;
            this.lastName = lastName;
            this.email = email;
            this.birthDate = birthDate;
            this.gender = gender;
            this.isInternacional = isInternacional;
            this.isEndorse = isEndorse;
        }

       

        public Boolean Insert()
        {
            String line = this.iD + "," + this.fisrtName + "," + this.lastName + "," + this.email + "," + this.birthDate + "," + this.gender + "," + this.isInternacional + "," + this.isEndorse;

            StreamWriter file = new StreamWriter(filePath, true);

          
            file.WriteLine(line);
            file.Close();
            return true;
           
        }

        public static List<Student> Read()
        {
            try
            {
                //Check Process.Start Method
                List<String> fileLines = File.ReadAllLines(filePath).ToList();
                List<Student> students = new List<Student>();

                foreach (var line in fileLines)
                {
                    string[] entries = line.Split(',');

                    Student newStudent = new Student(Convert.ToInt32(entries[0]), entries[1], entries[2], entries[3], entries[4], entries[5], entries[6], entries[7]);
                    students.Add(newStudent);

                }

                return students;
            }catch(FileNotFoundException e)
            {
                return null;
            }
        }

        




    }
}
