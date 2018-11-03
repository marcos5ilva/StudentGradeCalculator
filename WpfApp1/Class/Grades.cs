using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Class
{
    public class Grades
    {
        String ID { get; set; }
        public String Assignment { get; set; }
        public String Grade { get; set; }
      
       /* public String First_Name { get; set; }
        public String Last_Name { get; set; }
        public int Assignment1 { get; set; }
        public int Assignment2 { get; set; }
        public int Assignment3 { get; set; }
        public int Assignment4 { get; set; }*/
        
       
        
       static readonly string filePathGrades = @"C:\Users\Marcos\file\Grades.csv";
       static readonly string filePathStudent = @"C:\Users\Marcos\file\Student.csv";
       private List<string> fileLines;
       private List<string> FileLines { get => FileLines; set => FileLines = value; }

       public Grades ( String assignment, String grade)
        {
          //  this.ID = ID;
            this.Grade = grade;
            this.Assignment = assignment;
          //  this.Assignment2 = Assignment2;
          //  this.Assignment3 = Assignment3;
          //  this.Assignment4 = Assignment4; 

        }

        
        public  Boolean Insert(String id)
        {
            String line =   this.Assignment+ "," + this.Grade;
            String idStudent = id;
            StreamWriter file = new StreamWriter((@"C:\Users\Marcos\file\Grades" + idStudent + ".csv"), true);

            //Opening file to write
            file.WriteLine(line);

            //Closing file
            file.Close();

            return true;

        }

        public static List<Grades> Read(String idStudent)
        {
            try
            {
                List<String> fileLines = File.ReadAllLines(@"C:\Users\Marcos\file\Grades" + idStudent + ".csv").ToList();
                List<Grades> studentesGrades = new List<Grades>();

                foreach (var line in fileLines)
                {
                    string[] entries = line.Split(',');

                    //Grades newStudentGrades = new Grades(Convert.ToInt32(entries[0]), entries[1], entries[2], Convert.ToInt32(entries[3]), Convert.ToInt32(entries[4]), Convert.ToInt32(entries[5]), Convert.ToInt32(entries[6]));
                    Grades newStudentGrades = new Grades(entries[0], entries[1]);
                    studentesGrades.Add(newStudentGrades);

                }

                return studentesGrades;
            }catch(FileNotFoundException e)
            {
                return new List<Grades>();
            }

        }

        
    }
}
