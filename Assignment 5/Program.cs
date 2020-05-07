using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Anthony = new Person("Anthony", "Iacano");
            Person Jeremiah = new Person("Jeremiah", "Ukwela");
            Person Natalie = new Person("Natalie", "Kozelka");

            Person[] people = new Person[3];
            people[0] = Anthony;
            people[1] = Jeremiah;
            people[2] = Natalie;

            foreach (Person human in people) 
            {
                human.PrintFullName();
            }

        }
    }
}
