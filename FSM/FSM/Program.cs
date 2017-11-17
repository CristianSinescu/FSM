using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> d =
                new Dictionary<string, Dictionary<string, string>>()
                {
                    {"0", new Dictionary<string, string>() {{"5", "5"}, {"10", "10"}, {"0", "0"}}},
                    {"5", new Dictionary<string, string>() {{"5", "10"}, {"10", "15"}}},
                    {"10", new Dictionary<string, string>() {{"5", "15"}, {"C10", "0"}}},
                    {"15", new Dictionary<string, string>() {{"C10", "5"}, {"C15", "0"}}}

                };
            string action = string.Empty;
            int choose = 0;
            Console.WriteLine("Do you want to start the coffe machine?");
            Console.WriteLine("Press 1 for start and 0 for not");
            choose = Convert.ToInt32(Console.ReadLine());
            while (choose != 0)
            {
                switch (choose)
                {
                    case 1:
                        {
                            Console.WriteLine("Insert action!");
                            action = Convert.ToString(Console.ReadLine());
                            CoffeMachine cf = new CoffeMachine(d, action);
                            cf.execute();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Your choice isn't valid");
                            break;
                        }

                }
                Console.WriteLine("Press 1 to continue or 0 to exit");
                choose = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
