using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment_2
{
    class Person
    {
        public int age;
        public string firstName;
        public string lastName;
        public bool marriageStatus;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {

            string fullName = "";
            fullName += this.firstName;
            fullName += " ";
            fullName += this.lastName;

            return fullName;
        }

        public void PrintNameandAge()
        {
            Console.Write("The name of the person is " + this.GetFullName() + ". ");
            if (this.marriageStatus == true)
                {

                Console.WriteLine("This person is married to " + this.Spouse.GetFullName() + ". ");
                }

            Console.Write("They are " + this.age + " years old. ");
            Console.WriteLine();
        }

}
  
}
