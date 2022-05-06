using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
                
            Console.WriteLine("Yash");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)

            {
                Console.WriteLine("Netice");
                int point = Convert.ToInt32(Console.ReadLine());
                if (point > 50)

                {
                    Console.WriteLine("Qebul olundu");
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Imtina");
                    goto Start;
                } 
            }
            else
            {
                goto Start;
            }    }
    }
}
