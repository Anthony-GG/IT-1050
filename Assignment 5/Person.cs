using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string fullName;
        public Person(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }


        public void PrintFullName()
        {
            fullName = this.firstName + " " + this.lastName;
            Console.WriteLine(fullName);
        }
    }
}
