using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        elements = a;
    }

    public void computeDifference()
    {
        maximumDifference = maxDiff(elements)[1] - maxDiff(elements)[0];
    }

    public int[] maxDiff(int[] array)
    {
        int[] local = new int[2];
        if (array.Length > 1)
        {
            int mid = array.Length / 2;
            int[] leftLocal = maxDiff(array.Take(mid).ToArray());
            int[] rightLocal = maxDiff(array.Skip(mid).ToArray());
            local[0] = leftLocal[0] < rightLocal[0] ? leftLocal[0] : rightLocal[0];
            local[1] = leftLocal[1] > rightLocal[1] ? leftLocal[1] : rightLocal[1];
            return local;
        }
        else
        {
            return new int[] { array[0], array[0] };
        }
    }
} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
        Console.ReadLine();
    }
}