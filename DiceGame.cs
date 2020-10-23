//Problem ID: dicegame
//CPU Time limit: 1 second
//Memory limit: 1024 MB
//Difficulty: 1.5
// Rahim Çubuk: rahimcubuk@gmail.com
/*
	- DICE GAME
	Gunnar and Emma play a lot of board games at home, so they own many dice that are 
not normal 6-sided dice.For example they own a die that has 10 sides with numbers 
47,48,…,56 on it.
	There has been a big storm in Stockholm, so Gunnar and Emma have been stuck at home 
without electricity for a couple of hours. They have finished playing all the games 
they have, so they came up with a new one. Each player has 2 dice which he or she rolls. 
The player with a bigger sum wins. If both sums are the same, the game ends in a tie.

	- TASK
	Given the description of Gunnar’s and Emma’s dice, which player has higher chances 
of winning?
	All of their dice have the following property: each die contains numbers a,a+1,…,b, 
where a and b are the lowest and highest numbers respectively on the die. Each 
number appears exactly on one side, so the die has b−a+1 sides.

	- INPUT
	The first line contains four integers a1,b1,a2,b2 that describe Gunnar’s dice. Die 
number i contains numbers ai,ai+1,…,bi on its sides. You may assume that 1≤ai≤bi≤100. 
You can further assume that each die has at least four sides, so ai+3≤bi.
	The second line contains the description of Emma’s dice in the same format.

	- OUTPUT
	Output the name of the player that has higher probability of winning. Output “Tie” 
if both players have same probability of winning.

Sample Input 1	||	Sample Output 1
1 4 1 4         ||	Emma
1 6 1 6         ||	
				||	
Sample Input 2	||	Sample Output 2
1 8 1 8         ||	Tie
1 10 2 5		||	
				||	
Sample Input 3	||	Sample Output 3
2 5 2 7         ||	Gunnar
1 5 2 5			||	
*/
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