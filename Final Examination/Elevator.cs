using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Examination
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double sum = 0;
            foreach (Passenger human in Occupants)
            {
               sum  += human.GetWeight();
            }

            return sum;
        }
        
        public bool IsOverMaxCapacity()
        {
            return (GetCurrentWeight() > MaxWeight);
        }
    }
}
