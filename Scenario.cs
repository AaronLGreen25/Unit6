using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

public class Scenario
{
    private DressingRooms dressingRooms;
    private List<Customer> customers;
    private Stopwatch stopwatch;
    private Random random;

    public Scenario(int rooms, int numCustomers, int maxItems)
    {
        dressingRooms = new DressingRooms(rooms);
        customers = new List<Customer>();
        random = new Random();

        for (int i = 0; i < numCustomers; i++)
        {
            customers.Add(new Customer(dressingRooms, maxItems));
        }
    }

    public void RunScenario()
    {
        stopwatch = Stopwatch.StartNew(); 

        List<Thread> threads = new List<Thread>();
        foreach (var customer in customers)
        {
            Thread thread = new Thread(customer.ThreadRun);
            threads.Add(thread);
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join(); 
        }

        stopwatch.Stop(); 
    }

    public void PrintResults()
    {
        
        TimeSpan elapsed = stopwatch.Elapsed;
        int numCustomers = customers.Count;
        double avgItems = customers.Average(c => c.MaxItems == 0 ? random.Next(1, 7) : c.MaxItems);

        
        Console.WriteLine($"Elapsed time: {elapsed}");
        Console.WriteLine($"Number of customers: {numCustomers}");
        Console.WriteLine($"Average number of items: {avgItems:F2}");
    }
}
