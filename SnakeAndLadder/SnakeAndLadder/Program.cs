using System;
using System.Globalization;
public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Player Starts From 0\n");
        Console.WriteLine("1 - 6 : Dice Roll");
        Console.WriteLine(" 0 - No Play \n 1 - Ladder \n 2 - Snake\n\n");
        int pos = 0;
        Console.WriteLine($"Player at {pos} ");
        Random r = new Random();
        int dice = r.Next(1, 7);
        Console.WriteLine($"Dice Number: {dice}");
    }
}
