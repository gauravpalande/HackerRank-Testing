using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            if (i != input.Length - 1)
                if (input[i] == input[i + 1])
                {
                    input = input.Remove(i, 2);
                    Console.WriteLine(input);
                    i = -1;
                }
        }
        Console.WriteLine(input == "" ? "Empty String" : input);
    }
}