using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSortingSimulator.Model
{
    class LuggageFactory
    {
        Random rnd = new Random();

        public Luggage CreateLuggage()
        {
            int num = rnd.Next(1, 5);
            switch (num)
            {
                case 1: // If the terminal is open then create a new Bagage
                    
                    return null;
                default: return null;
            }
        }
    }
}
