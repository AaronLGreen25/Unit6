using System;
using System.Threading;

public class Customer
{
    private DressingRooms dressingRooms;
    private int maxItems; 
    private Random random;

    public int MaxItems 
    {
        get { return maxItems; }
    }

    public Customer(DressingRooms rooms, int maxItems)
    {
        dressingRooms = rooms;
        this.maxItems = maxItems;
        random = new Random();
    }

    public void TryOnClothes()
    {
        int numItems = maxItems == 0 ? random.Next(1, 7) : maxItems;
        Console.WriteLine($"Customer trying on {numItems} items.");

        
        Thread.Sleep(numItems * random.Next(1000, 3001)); 

        Console.WriteLine("Customer finished trying on clothes.");
    }

    public void UseRoom()
    {
        dressingRooms.RequestRoom(); 
        TryOnClothes(); 
        dressingRooms.ReleaseRoom(); 
    }

    public void ThreadRun()
    {
        UseRoom(); 
    }
}
