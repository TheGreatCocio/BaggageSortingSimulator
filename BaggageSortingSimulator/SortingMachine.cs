using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaggageSortingSimulator.System;

namespace BaggageSortingSimulator
{
    public class SortingMachine
    {
        private static SortingMachine instance;
        private DAL dal = new DAL();
        List<string> Terminals = new List<string>();
        public static SortingMachine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SortingMachine();
                }
                return instance;
            }
        }
        private SortingMachine()
        {

        }
        public void SendToTerminal(int terminalNo)
        {
            
            
            
            switch (terminalNo)
            {
                case 0:
                    Terminals.Add("Not Active");
                    break;
                case 1:
                    Terminals.Add(dal.GetDestination(0));
                    break;
                case 2:
                    Terminals.Add(dal.GetDestination(1));
                    break;
                case 3:
                    Terminals.Add(dal.GetDestination(2));
                    break;
                case 4:
                    Terminals.Add(dal.GetDestination(3));
                    break;
                case 5:
                    Terminals.Add(dal.GetDestination(4));
                    break;
                case 6:
                    Terminals.Add(dal.GetDestination(5));
                    break;
                case 7:
                    Terminals.Add(dal.GetDestination(6));
                    break;
                case 8:
                    Terminals.Add(dal.GetDestination(7));
                    break;
                    
            }

        }
        public string Test()
        {
            string test = "";
            foreach (string t in Terminals)
            {
                test=t;
            }
            return test;
        }
    }
    
}
