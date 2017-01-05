using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list1 = new int[6] { -1, -1, 0, -9, -2, -2 };
            int[] list2 = new int[6] { -2, -1, -6, -8, -2, -5 };
            int[] list3 = new int[6] { -1, -1, -1, -2, -3, -4 };
            int[] list4 = new int[6] { -1, -9, -2, -4, -4, -5 };
            int[] list5 = new int[6] { -7, -3, -3, -2, -9, -9 };
            int[] list6 = new int[6] { -1, -3, -1, -2, -4, -5 };

            int[][] arr = new int[][] { list1, list2, list3, list4, list5, list6 };
            //int[][] arr = new int[6][];
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}
            int maxSum = 0, intermediateSum = 0;
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    try
                    {
                        for (int j = 0; j <= 3; j++)
                        {
                            try
                            {
                                intermediateSum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] +
                                    arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                                maxSum = maxSum > intermediateSum ? maxSum : intermediateSum;
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                    catch
                    {
                        continue;
                    }
                }
                Console.WriteLine(maxSum);
            }
            catch
            {
                Console.WriteLine(maxSum);
            }
        }
    }
}
