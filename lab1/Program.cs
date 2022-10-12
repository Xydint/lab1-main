using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int i, j = 0;
            int[] cash = new int[n];
            int result = 0;
            for (j = 0; j < n; j++)
            {
                cash[j] = customers[j];
            }
            while (j < n || cash.Any(c => c > 0))
            {
                for (i = 0; i < n; i++)
                {
                    cash[i]--;
                    if (cash[i] == 0 && j < customers.Length)
                        cash[i] = customers[j++];
                }
                result++;
            }
            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
            Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
            Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
        }
    }
}