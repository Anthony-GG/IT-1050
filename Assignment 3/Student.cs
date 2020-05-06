using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student (string Name, int Grade, Instructor Teacher)
        {
            this.Name = "Nameless";
            this.Name = Name;
            this.Teacher = Teacher;
            this.Grade = 0;
        }

        public void SetGrade(int Grade)
        {
            this.Grade = Grade;
        }

        public void StudentPrintInformation()
        {
            Console.WriteLine("Name: " + Name + " ");
            Console.WriteLine("Grade: " + Grade + " ");
            Console.WriteLine("Teacher: " + "");
            Teacher.PrintInformation();
            Console.WriteLine(" ");
        }
    }
}
