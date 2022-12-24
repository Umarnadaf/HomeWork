using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oops
{
    interface IInput
    {
        public int Sum(int x);
    }
    class Display : IInput
    {
        int sum;
        public int Sum(int y)
        {
            for (int i = 1; i <= y; i++)
            {
                if (y % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
    class FactUsingInterface
    {
        static void Main(string[] args)
        {
            Display d = new Display();
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of factor is: " + d.Sum(num));
        }
    }
}
