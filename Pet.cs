//Problem ID: pet
//CPU Time limit: 1 second
//Memory limit: 1024 MB
//Difficulty: 1.4
/*
	- PET
	In the popular show “Dinner for Five”, five contestants compete in preparing culinary 
delights. Every evening one of them makes dinner and each of other four then grades it 
on a scale from 1 to 5. The number of points a contestant gets is equal to the sum of 
grades they got. The winner of the show is of course the contestant that gets the most 
points.
	Write a program that determines the winner and how many points they got.

	- INPUT
	Five lines, each containing 4 integers, the grades a contestant got. The contestants 
are numbered 1 to 5 in the order in which their grades were given.

	- OUTPUT
	Output on a single line the winner’s number and their points, separated by a space. 
The input data will guarantee that the solution is unique.

Sample Input 1	||  Sample Output 1
5 4 4 5			||  4 19
5 4 4 4         ||  
5 5 4 4         ||  
5 5 5 4         ||  
4 4 4 5         ||  
				||  
Sample Input 2	||  Sample Output 2
4 4 3 3			||  2 17
5 4 3 5         ||  
5 5 2 4         ||  
5 5 5 1         ||  
4 4 4 4			||  
*/
using System;
using System.Linq;

namespace Pet_DinnerForFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] points = new int[5,4];
            int j = 0;
            while (j < 5)
            {
                int i = 0;
                string[] read_points = Console.ReadLine().Split(' ');
                foreach (var data in read_points)
                {
                    points[j,i] = int.Parse($"{data}");
                    i++;
                }
                j++;
            }
            totalPoint(points);
        }

        static void totalPoint(int[,] points)
        {
            int[] totalPoints = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                for(int j=0;j<4; j++)
                {
                    totalPoints[i] = totalPoints[i] + points[i,j];
                }
            }
            winner(totalPoints);
        }

        static void winner(params int[] totalPoints)
        {
            int[] winner = new int[2];
            winner[0] = (totalPoints.ToList().IndexOf(totalPoints.Max())) + 1;
            winner[1] = totalPoints.Max();

            Console.WriteLine(winner[0] + " " + winner[1]);
        }
    }
}
