using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int m = 50;
            int sum = 0;

            for (int i = n; i < m; i++)
            {
                sum += i;

            }
            Console.WriteLine(sum);
        }
    }
}
