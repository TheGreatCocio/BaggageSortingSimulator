using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaggageSortingSimulator.Model
{
    class Counter
    {
        private static int counterIncrementer = 1;
        private int counterId;

        public int CounterId { get => counterId; set => counterId = value; }

        public Counter()
        {
            counterId = counterIncrementer++;
        }
    }
}
