using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum_E = 0;
            int sum_G = 0;
            for (int i = 0; i < 4; i++)
            {
                sum_G = sum_G + Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                sum_E = sum_E + Convert.ToInt32(Console.ReadLine());
            }
            if (sum_E > sum_G) Console.WriteLine("Emma");
            else if (sum_E < sum_G) Console.WriteLine("Gunnar");
            else Console.WriteLine("Tie");
        }
    }
}
