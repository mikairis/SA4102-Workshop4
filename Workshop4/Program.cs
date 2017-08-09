using System;

namespace Workshop4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] name = { { "geoff", "dick", "harry"},
                               { "liam", "sam", "jack" }
            };

            int x = 2;
            int y = 3;

            //int[,] number = {   { 1, 2, 3 },
            //                    { 4, 5, 6 }
            //};

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(name[i,j] + " ");
                }
            }
            Console.ReadKey();
            
        }
    }
}
