using System;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string stars = new string('*', i);

                // Console.WriteLine("{0}{1} | {1}{0}", spaces , stars);

                Console.Write(spaces);
                Console.Write(stars);
                Console.Write(" | ");
                Console.Write(stars);
                Console.WriteLine(spaces);
            }
        }
    }
}
