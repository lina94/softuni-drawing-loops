using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars;
            if (n % 2 == 0)
            {
                stars = 2;
            }
            else
            {
                stars = 1;
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - 1) / 2 - i), new string('*', stars + 2 * i));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}