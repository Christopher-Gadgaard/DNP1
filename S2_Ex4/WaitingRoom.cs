﻿namespace S2_Ex4;

public class WaitingRoom
{
    public Action<int>? NumberChange { get; set; }
    private int CurrentNumber = 1;
    private int TicketCount = 0;

    public void RunWaitingRoom()
    {
        while (CurrentNumber <= TicketCount)
        {
            NumberChange?.Invoke(CurrentNumber++);
            Console.WriteLine("Diing");
            Console.WriteLine($"Patient number {CurrentNumber} can now enter");
            Thread.Sleep(2000);
        }
    }

    public int DrawNumber()
    {
        TicketCount++;
        return TicketCount;
    }
}