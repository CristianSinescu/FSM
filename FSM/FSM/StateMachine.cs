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
        public void execute()
        {
            Console.WriteLine("The initial state is "+currentState);
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
            if (String.Equals(action, "C10")|| String.Equals(action, "C15"))
            {
                Console.WriteLine("Your coffe is ready!");
            }
            Console.WriteLine("The current state is "+currentState);
        }

    }
}
