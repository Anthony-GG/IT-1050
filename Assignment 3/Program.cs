using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            Student Jane = new Student("Jane", 0, John);
            Student Joe = new Student("Joe", 0, John);
            Student Melissa = new Student("Melissa", 0, Mike);
            Student Matt = new Student("Matt", 0, Mike);

            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.StudentPrintInformation();
            Joe.StudentPrintInformation();
            Melissa.StudentPrintInformation();
            Matt.StudentPrintInformation();
        }
        
    }
}
