using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("What is the first person's first name?");
            p1.firstName = Console.ReadLine();

            Console.WriteLine("What is the first person's last name?");
            p1.lastName = Console.ReadLine();

            Console.WriteLine("How old is the first person?");
            p1.age = Convert.ToInt32(Console.ReadLine());
            Person.SumOfAllAges = p1.age + Person.SumOfAllAges;

            Console.WriteLine("The first person is married. Is this true or false?");

            p1.marriageStatus = bool.Parse(Console.ReadLine());

            if (p1.marriageStatus == true)
            {
                p1.Spouse = new Person();
                p1.Spouse.lastName = p1.lastName;

                Console.WriteLine("What is the first name of the first person's spouse?");
                p1.Spouse.firstName = Console.ReadLine();

                Console.WriteLine("What is the age of the first person's spouse?");
                p1.Spouse.age = Convert.ToInt32(Console.ReadLine());

                p1.Spouse.Spouse = p1;
                p1.Spouse.marriageStatus = true;
                Person.SumOfAllAges = p1.Spouse.age + Person.SumOfAllAges;
            }

            Console.WriteLine("Alright, now on to the second person!");

            Console.WriteLine("What is the second person's first name?");
            p2.firstName = Console.ReadLine();

            Console.WriteLine("What is the second person's last name?");
            p2.lastName = Console.ReadLine();

            Console.WriteLine("How old is the second person?");
            p2.age = Convert.ToInt32(Console.ReadLine());

            Person.SumOfAllAges = p2.age + Person.SumOfAllAges;

            Console.WriteLine("This second person is married. Is this true or false?");

            p2.marriageStatus = bool.Parse(Console.ReadLine());


            if (p2.marriageStatus == true)
            {
                p2.Spouse = new Person();
                p2.Spouse.lastName = p2.lastName;

                Console.WriteLine("What is the first name of the first person's spouse");
                p2.Spouse.firstName = Console.ReadLine();

                Console.WriteLine("What is the age of the first person's spouse?");
                p2.Spouse.age = Convert.ToInt32(Console.ReadLine());

                p2.Spouse.Spouse = p2; 
                p2.Spouse.marriageStatus = true;
                Person.SumOfAllAges = p2.Spouse.age + Person.SumOfAllAges;
            }
            Console.WriteLine("Now that we have all of that out of the way. Let's summarize the information. Press any key to continue.");

            Console.ReadKey();

           p1.PrintNameandAge();

            if (p1.marriageStatus == true)
            {
                p1.Spouse.PrintNameandAge();
            }

            p2.PrintNameandAge();

            if (p2.marriageStatus == true)
            {
                p2.Spouse.PrintNameandAge();
            }

            Console.WriteLine();

            Console.WriteLine(" The average age of every person involved is " + (Person.SumOfAllAges/4) + "!");

        }
    }
}
