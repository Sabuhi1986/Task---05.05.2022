using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int m = 100;
            int sum = 0;
            int avg = 0;
            for (int i = n; i < m; i++)
            {
                sum += i;

                avg = sum / i;

            }
            Console.WriteLine(avg);
        }
    }
}
