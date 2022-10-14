using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.FirstAssignment
{
    class ClassAssignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("c for circle");
            Console.WriteLine("r for Rectangle");

            String ch = Console.ReadLine();
            switch (ch)
            {
                case "c":
                    Console.WriteLine("r = ");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine(3.142*r*r);
                    break;
                case "r":
                    Console.WriteLine("Enter L And W");
                    int l = int.Parse(Console.ReadLine());
                    int w = int.Parse(Console.ReadLine());
                    Console.WriteLine(l*w);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    class CountNumber
    {
        static void Main(string[] args)
        {
           for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class CountNumber1
    {
        static void Main(string[] args)
        {
            for(int i = 175; i >= 120; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class CountNumber2
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 20; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class PrintSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int p = 0;
            for(int i = 1; i <= n; i++)
            {
                p = (p * 2) + 1;
                Console.WriteLine(p);
            }
        }
    }
}
   
