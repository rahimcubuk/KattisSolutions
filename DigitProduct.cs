//Problem ID: sifferprodukt
//CPU Time limit: 1 second
//Memory limit: 1024 MB
//Difficulty: 1.5

/*
	- DIGIT PRODUCT
	Consider a positive integer x. Multiply its nonzero digits and you get another 
integer y. Repeating this process, you eventually arrive at a single digit 
between 1 and 9. Write a program that reads x and outputs the resulting digit.

	- INPUT
	An integer x with 10≤x≤1000.

	- OUTPUT
	Print a digit between 1 and 9, the result of repeatedly multiplying the nonzero 
digits of x as described above.

	- Explanation of Sample Inputs
	In Sample Input 1, we have x=808. Multiplying 8 and 8, we arrive at 64. Then 
we get 6x4=24, and finally 2x4=8, which is the sample output.

	In Sample Input 2, there is only a single nonzero digit, 2. The product of 
all digits in a set containing only a single element is the digit itself. Thus 
the answer is 2.

Sample Input 1	||  Sample Output 1
808				||  8
Sample Input 2	||  Sample Output 2
20				||  2
*/
using System;

namespace DigitProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1;
            N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DigitProduct(N1));
        }

        static int DigitProduct(int number)
        {
            int res = 1;
            if (number <= 1000 && number >= 10)
            {
                while (number != 0)
                {
                    if (number % 10 != 0) res = (number % 10) * res;
                    number = number / 10;
                }

                if (res >= 10) res = DigitProduct(res);
				
                return res;
            }
            else
            {
                return 0;
            }
        }

    }
}
