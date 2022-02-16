using System;

namespace Lab_1_new
{
    class Program
    {
        public class HW1
        {
            private static int find_max(int[] arr)
            {
                int max = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] > arr[max])
                    {
                        max = i;
                    }
                }
                return max;
            }
            private static int find_min(int[] arr)
            {
                int min = 0;
                for (int i = 0; i < arr.Length; ++i)
                {
                    if (arr[i] < arr[min])
                    {
                        min = i;
                    }
                }
                return min;
            }
            public static long QueueTime(int[] customers, int cass_amount)
            {
                if (cass_amount >= customers.Length)
                {
                    return customers[find_max(customers)];
                }
                else
                {
                    int[] casses = new int[cass_amount];
                    for (int i = 0; i < cass_amount; ++i)
                    {
                        casses[i] = customers[i];
                    }

                    for (int i = cass_amount; i < customers.Length; ++i)
                    {
                        int min = find_min(casses);
                        casses[min] += customers[i];
                    }

                    return casses[find_max(casses)];
                }
            }
        }
        static void Main()
        {
            //int cass_amount = 3;
            //int[] customers = { 2, 5, 9, 2, 3, 1, 5, 7, 10, 1 };
            //Console.WriteLine(HW1.QueueTime(customers, cass_amount));

            Console.WriteLine("Test 1: " + HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
            Console.WriteLine("Test 2: " + HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
            Console.WriteLine("Test 3: " + HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
        }
    }
}