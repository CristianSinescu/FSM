using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class CoffeMachine :StateMachine
    {
        public CoffeMachine(Dictionary<string, Dictionary<string, string>> d,string action):base(action)
        {
            table = d;
        }
        public override void execute()
        {
            Console.WriteLine("The initial state is " + currentState);
            base.execute();
            if (String.Equals(action, "C10") || String.Equals(action, "C15"))
            {
                Console.WriteLine("Your coffe is ready!");
            }
            Console.WriteLine("The current state is " + currentState);
        }
    }
}
