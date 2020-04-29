using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote = false;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your middle initial?");
            middleInitial = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            fullName = firstName + " " + middleInitial + "." + " " + lastName;

            Console.WriteLine("What is your height in feet? (Please choose the closest value. 4, 5 or 6)");
            heightFeet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many inches beyond this base feet should be added to your height?");
            heightInches = Convert.ToInt32(Console.ReadLine());

            totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

            Console.WriteLine("How old are you exactly?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you a citizen of the United States? Please answer if this is 'true' or 'false'");
            isCitizen = bool.Parse(Console.ReadLine());
            
            if (age>=18 && isCitizen == true)
            {
                canVote = true;
            }

            Console.WriteLine("You are " + fullName + " and you are " + totalHeightCM + " centimeters tall.");

            if (canVote)
            {
                Console.WriteLine("You have the ability to vote within the United States of America.");
            }
            else
            {
                Console.WriteLine("You do not have the ability to vote within the United States of America.");
            }



            System.Console.Write("Press any key to continue");
            System.Console.ReadKey();
        }
    }
}
