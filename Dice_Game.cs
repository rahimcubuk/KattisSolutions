using System;

namespace DiceGame
{
    class Program
    {
        static int Main(string[] args)
        {
            int sum_E, sum_G, temp;
            int[] data = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (int.TryParse(Console.ReadLine(), out temp) == true) data[i] = temp;
            }
            sum_G = data[0] + data[1] + data[2] + data[3];
            sum_E = data[4] + data[5] + data[6] + data[7];
            Console.WriteLine(sum_G > sum_E ? "Gunnar" : (sum_E > sum_G ? "Emma" : "Tie"));
            return 0;
        }
    }
}