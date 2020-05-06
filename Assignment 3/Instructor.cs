using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string Name, string CourseName)
        {
            this.Name = "Teacher";
            this.Name = Name;
            this.CourseName = "Lunch";
            this.CourseName = CourseName;
        }
        public void SetStudentGrade(Student student, int Grade)
        {
            student.SetGrade(Grade);
        }

        public void PrintInformation()
        {
            Console.WriteLine(" " + "FirstName: " + Name + " ");
            Console.WriteLine(" " + "CourseName: " + CourseName + "");
        }
        
    }
}
