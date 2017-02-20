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

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                int leftRight = (n - 1) / 2 - i;
                int middle = n - 2 * leftRight - 2;

                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', leftRight), new string('*', stars));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', leftRight), new string('-', middle));
                }
            }

            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                int leftRight = (n - 1) / 2 - i;
                int middle = n - 2 * leftRight - 2;

                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', leftRight), new string('*', stars));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('-', leftRight), new string('-', middle));
                }
            }
        }
    }
}