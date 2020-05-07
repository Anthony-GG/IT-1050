using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Examination
{
    class Passenger
    {
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {
            this.Weight = weight;
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
