using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        int n, root;
        bool prime = true;
        while (t-- > 0)
        {
            n = Convert.ToInt32(Console.ReadLine());
            root = Convert.ToInt32(Math.Sqrt(n));
            prime = true;
            if (n == 1)
                Console.WriteLine("Not prime");
            else
            {
                while (root > 1)
                {
                    if (n % root == 0 && root != 1)
                    {
                        prime = false;
                        break;
                    }
                    root--;
                }
                Console.WriteLine((prime ? "Prime" : "Not prime"));
            }
        }
        Console.ReadLine();
    }
}