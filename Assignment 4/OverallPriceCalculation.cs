using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment_4
{
    class OverallPriceCalculation
    {

        public int dc = 0;
        public int da = 0;
        public int ds = 0;
        public int nc = 0;
        public int na = 0;
        public int ns = 0;
        public int ss = 0;
        public int ls = 0;
        public int hd = 0;
        public int pc = 0;
        public int cd = 0;

        public void InfoGather()
        {
      

            Console.WriteLine("Welcome to the Night at the Movies Calculator. This wonderful program will be used to assist you in calculating the price to enjoy a wonderful trip to our esablishment! Thank you for your continued support.");
            Console.WriteLine(" ");

            Console.WriteLine("When will you be attending the film? 'earlier' or in the 'evening'?");
            string TimeOfDay = Console.ReadLine();

            if (TimeOfDay == "evening") 
            {
                {
                    Console.WriteLine("Ah, I see you will be with us in the evening. Wonderful.");
                    Console.WriteLine(" ");
                    Console.WriteLine("How many patrons will be joining us at 'Night at the Movies'? Please count yourself in this total.");

                    int TotalNumberofPatrons = int.Parse(Console.ReadLine());

                    var AgesofPatrons = new List<int>();

                    for (int i = 0; i < TotalNumberofPatrons; i++)
                    {
                        Console.WriteLine("Please write age of Patron " + (i + 1));
                        AgesofPatrons.Add(int.Parse(Console.ReadLine()));
                    }
                    foreach (int age in AgesofPatrons)
                    {
                        if (age <= 17)
                        {
                            nc++;
                        }
                        else
                        if (age <= 59)
                        {
                            na++;

                        }
                        else
                        {
                            ns++;

                        }

                    }
                    Console.WriteLine(" ");
                    Console.WriteLine("Alright. With that out of the way, we can now get to the fun part. Drinkage and munchies.");
                    Console.WriteLine(" ");
                    Console.WriteLine("How many...");
                    Console.WriteLine("Small Soda(s)?");
                    ss = int.Parse(Console.ReadLine());
                    Console.WriteLine("Large Soda(s)?");
                    ls = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hotdog(s)?");
                    hd = int.Parse(Console.ReadLine());
                    Console.WriteLine("Popcorn?");
                    pc = int.Parse(Console.ReadLine());
                    Console.WriteLine("Candy?");
                    cd = int.Parse(Console.ReadLine());
                }
            }
            else
            { 
                Console.WriteLine("Ah, I see you will be with us earlier in the day. Wonderful.");
                Console.WriteLine(" ");
                Console.WriteLine("How many patrons will be joining us at 'Night at the Movies'? Please count yourself in this total.");

                int TotalNumberofPatrons = int.Parse(Console.ReadLine());

                var AgesofPatrons = new List<int>();

                for (int i = 0; i < TotalNumberofPatrons; i++)
                {
                    Console.WriteLine("Please write age of Patron " + (i + 1));
                    AgesofPatrons.Add(int.Parse(Console.ReadLine()));
                }
                foreach (int age in AgesofPatrons)
                {
                    if (age <= 17)
                    {
                        dc++;
                    }
                    else
                    if (age <= 59)
                    {
                        da++;

                    }
                    else
                    {
                        ds++;

                    }

                }
            }

           
        }
        

        public double GetTotalMoviePrice()
        {
            double totalMoviePrice = 0;

            totalMoviePrice += dc * TicketsP.DayChildTicket;
            totalMoviePrice += da * TicketsP.DayAdultTicket;
            totalMoviePrice += ds * TicketsP.DaySeniorTicket;
            totalMoviePrice += nc * TicketsP.NightChildTicket;
            totalMoviePrice += na * TicketsP.NightAdultTicket;
            totalMoviePrice += ns * TicketsP.NightSeniorTicket;

            totalMoviePrice += ss * ConcessionsP.SmallSoda;
            totalMoviePrice += ls * ConcessionsP.LargeSoda;
            totalMoviePrice += hd * ConcessionsP.HotDog;
            totalMoviePrice += pc * ConcessionsP.Popcorn;
            totalMoviePrice += cd * ConcessionsP.Candy;

            while (pc >= 1 && ls >= 1)
            {
                totalMoviePrice = totalMoviePrice - 2;
                pc--;
                ls--;
            }

            return totalMoviePrice;
        }
    }
}
