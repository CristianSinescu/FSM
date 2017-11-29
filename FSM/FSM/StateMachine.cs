using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class StateMachine
    {
        protected static string currentState="0";
        protected string action;
        protected Dictionary<string, Dictionary<string, string>> table;

        protected StateMachine( string action)
        {
            this.action = action;
        }
        public virtual void execute()
        {
           
            Dictionary<string, string> tmpDictionary = new Dictionary<string, string>();
            bool a = table.TryGetValue(currentState, out tmpDictionary);
            if (a == false)
            {
                Console.WriteLine("Initial state isn't valid");
                Console.WriteLine("Please try again!");
                return;
            }
            bool b = tmpDictionary.TryGetValue(action, out currentState);
            if (b == false)
            {
                Console.WriteLine("Action isn't valid");
                Console.WriteLine("Please try again!");
                return;
            }
            
        }

    }
}
