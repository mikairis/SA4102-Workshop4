using System;
using System.Globalization;

namespace Workshop4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[,] name = { { "geoff", "dick", "harry"},
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
            Console.ReadKey();*/

            Console.WriteLine("*********This is for Workshop 4 Task 4********");

            string nusISS = "institute of systems science";

            TextInfo textInfo = new CultureInfo("en-us", false).TextInfo;
            nusISS = textInfo.ToTitleCase(nusISS);

            Console.WriteLine(nusISS);
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine("**********************This is for Workshop 4 Task 5***********************");
            Console.WriteLine("*********This is a programme for listing student's name and grades********");
            Console.WriteLine();
            Console.Write("Please enter the number of students: ");
            int studNum = Convert.ToInt32(Console.ReadLine());
            string[] studentName = new string[studNum];

            Console.WriteLine();
            
            int[] studentMarks = new int[studNum];

            for (int i = 0; i < studNum; i++)
            {
                Console.Write("Enter student's name: ");
                studentName[i] = Console.ReadLine();
                
                Console.Write("Enter student's marks: ");
                studentMarks[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < studNum; i++)
            {
                Console.Write(studentName[i] + "\t" + studentMarks[i] + "\n");
            }
            Console.ReadKey();
        }
    }
}
