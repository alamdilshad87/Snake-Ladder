using System;
public class SnakeAndLadder
{
    public static void Main(String[] args)
    {
        int pos = 0;
        int[] snakes = { 99, 90, 76, 54 };
        int[] snakeTo = { 10, 48, 25, 31 };

        int[] ladders = { 4, 9, 28, 40 };
        int[] ladderTo = { 14, 31, 84, 59 };

        bool valid = true;
        while (pos < 100)
        {
            Console.Write("Enter dice number (1–6): ");
            int dice = int.Parse(Console.ReadLine());

            if (dice < 1 || dice > 6)
            {
                Console.WriteLine("Invalid Dice Number.");
                valid = false;
                break;
            }

            pos += dice;

            for (int i = 0; i < ladders.Length; i++)
            {
                if (pos == ladders[i])
                {
                    Console.WriteLine($"Ladder from {ladders[i]} to {ladderTo[i]}!");
                    pos = ladderTo[i];
                }
            }

            for (int i = 0; i < snakes.Length; i++)
            {
                if (pos == snakes[i])
                {
                    Console.WriteLine($"Snake from {snakes[i]} to {snakeTo[i]}!");
                    pos = snakeTo[i];
                }
            }

            if (pos > 100) pos = 100;
            Console.WriteLine("Current Position: " + pos + "\n");
        }

        if (valid && pos >= 100)
            Console.WriteLine("Jeet Gaya");
    }
}
