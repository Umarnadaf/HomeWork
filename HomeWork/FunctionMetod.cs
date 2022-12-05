using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    internal class Demo
    {
        public void show()
        {
            int a, b, sum;
            a = 3;
            b = 6;
            sum = a + b;
            Console.WriteLine("Addition is "+ sum);
        }
        public void add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition is " + sum);
        }

        public int sum(int a,int b)
        {
            int s = a + b;
            return s;
        }
    }
}
