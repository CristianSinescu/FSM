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
    }
}
