using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        // your code goes here
        int moves;

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (i == j)
                {
                    moves = (n - 1) % i == 0 ? (n - 1) / i : -1;
                    Console.Write(moves.ToString() + " ");
                }
                else if ((n - 1) % (i + j) == 0)
                {
                    moves = (n - 1) / (i + j) * 2;
                    Console.Write(moves.ToString() + " ");
                }
                else if (i == (n - 1))
                {
                    moves = i % j == 0 ? i * i / (2 * j) : -1;
                    Console.Write(moves.ToString() + " ");
                }
                else if (j == (n - 1))
                {
                    moves = j % i == 0 ? j * j / (2 * i) : -1;
                    Console.Write(moves.ToString() + " ");
                }
                else if ((n - 1) % i == 0 && (n - 1) % j == 0)
                {
                    if (i < j)
                    {
                        moves = ((n - 1) / (((n - 1) / i) / ((n - 1) / j))) + 2;
                        Console.Write(moves.ToString() + " ");
                    }
                    else
                    {
                        moves = ((n - 1) / (((n - 1) / j) / ((n - 1) / i))) + 2;
                        Console.Write(moves.ToString() + " ");
                    }
                }
                else if((n - 1) % i == 0)
                {
                    moves = (n - 1) / i * 2;
                    Console.Write(moves.ToString() + " ");
                }
                else if ((n - 1) % j == 0)
                {
                    moves = (n - 1) / j * 2;
                    Console.Write(moves.ToString() + " ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}