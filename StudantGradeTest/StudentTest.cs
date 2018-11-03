using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Class;
using Xunit;

namespace StudantGradeTest
{
    public class StudentTest
    {
        [Fact]
        public void ShouldReturnStudentFirstName()
        {

            WpfApp1.Class.Student student = new Student(1000, "irla", "Svendsen", "irla@irla.com", "12/14/1985",
                "F", "Yes", "false");
            String expected = "irla";

            student.Insert();
            List<Student> list = Student.Read();
            //Act
            String actual = "";
            foreach (var line in list)
            {
                if (line.iD == student.iD)
                {
                    actual = line.fisrtName;
                }

            }

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnStudentFileNotFound()
        {
            WpfApp1.Class.Student student = new Student(1101, "irla", "Svendsen", "irla@irla.com", "12/14/1985",
                "F", "Yes", "false");
            String expected = "file not found";


            List<Student> list = Student.Read();
            //Act
            String actual = "file not found";
            foreach (var line in list)
            {
                if (line.iD == student.iD)
                {
                    actual = line.fisrtName;
                }

            }

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnGrade()
        {
            WpfApp1.Class.Student student = new Student(1000, "irla", "Svendsen", "irla@irla.com", "12/14/1985",
                "F", "Yes", "false");
            WpfApp1.Class.Grades grade = new Grades("assingment1", "89");

            String expected = "89";

            student.Insert();
            grade.Insert("" + student.iD);
            List<Student> list = Student.Read();
            List<Grades> listGrade = Grades.Read("" + student.iD);
            //Act
            String actual = "";
            foreach (var line in listGrade)
            {
                if (line.Assignment == grade.Assignment)
                {
                    actual = line.Grade;
                }

            }

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
