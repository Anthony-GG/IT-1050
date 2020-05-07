using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment_4
{
    class Patrons
    {
        private int Age;

        public Patrons()
        {
        }
        public int DayChildTickets;
        public int DayAdultTickets;
        public int DaySeniorTickets;
        public int NightChildTickets;
        public int NightAdultTickets;
        public int NightSeniorTickets;
        public int SmallSoda;
        public int LargeSoda;
        public int HotDog;
        public int Popcorn;
        public int Candy;

        public void GatherInfo()
        {
        
        }
        public double GetTotalMoviePrice()
        {
            double totalMoviePrice = 0;

            totalMoviePrice += this.DayChildTickets * TicketsP.DayChildTicket;
            totalMoviePrice += this.DayAdultTickets * TicketsP.DayAdultTicket;
            totalMoviePrice += this.DaySeniorTickets * TicketsP.DaySeniorTicket;
            totalMoviePrice += this.NightChildTickets * TicketsP.NightChildTicket;
            totalMoviePrice += this.NightAdultTickets * TicketsP.NightAdultTicket;
            totalMoviePrice += this.NightSeniorTickets * TicketsP.NightSeniorTicket;

            totalMoviePrice += this.SmallSoda * ConcessionsP.SmallSoda;
            totalMoviePrice += this.LargeSoda * ConcessionsP.LargeSoda;
            totalMoviePrice += this.HotDog * ConcessionsP.HotDog;
            totalMoviePrice += this.Popcorn * ConcessionsP.Popcorn;
            totalMoviePrice += this.Candy * ConcessionsP.Candy;


            return totalMoviePrice;
        }

    }
}
