using System;

namespace EX_CH5_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentfib = 0;
            int nexfib = 1;

            Console.WriteLine(currentfib);
            Console.WriteLine(nexfib);

            for (int i = 0; i < 18; i++)
            {
                int NextNextfib = currentfib + nexfib;
                Console.WriteLine(NextNextfib);
                currentfib = nexfib;
                nexfib = NextNextfib;
            }
        }
    }
}
