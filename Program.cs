using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit6_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Scenario 1: 3 dressing rooms, 10 customers, random items
            Scenario scenario1 = new Scenario(3, 10, 0);
            scenario1.RunScenario();
            scenario1.PrintResults();

            Console.WriteLine();

            // Scenario 2: 5 dressing rooms, 10 customers, fixed 6 items per customer
            Scenario scenario2 = new Scenario(5, 10, 6);
            scenario2.RunScenario();
            scenario2.PrintResults();

            Console.WriteLine();

            // Scenario 3: 3 dressing rooms, 10 customers, fixed 3 items per customer
            Scenario scenario3 = new Scenario(3, 10, 3);
            scenario3.RunScenario();
            scenario3.PrintResults();

            Console.ReadKey();
        }
    }
}