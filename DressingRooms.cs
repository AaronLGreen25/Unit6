using System;
using System.Collections.Generic;
using System.Threading;

public class DressingRooms
{
    private Semaphore semaphore;
    private int numberOfRooms;

    public DressingRooms(int rooms)
    {
        numberOfRooms = rooms;
        semaphore = new Semaphore(rooms, rooms); 
    }

    public void RequestRoom()
    {
        semaphore.WaitOne(); 
    }

    public void ReleaseRoom()
    {
        semaphore.Release(); 
    }
}
