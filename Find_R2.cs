using System;

namespace Find_R2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];
            string[] words = Console.ReadLine().Split(' ');

            int i = 0;
            foreach (var word in words)
            {
                numbers[i] = int.Parse($"{word}");
                i++;
            }
            findR2(numbers);
            Console.ReadKey();
        }

        static void findR2(int[] numbers)
        {
            Console.WriteLine(2 * numbers[1] - numbers[0]);
        }
    }
}
