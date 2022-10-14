using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Mock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            int count = 0;
            int real = n;
            int sum = 0;
            while (n > 0)
            {
                t = n % 10;
                n = n / 10;
                Console.WriteLine(t);
                count++;
                
            }
            Console.WriteLine("count = "+count);
            n = real;
           
            while (n > 0) {
                int r = n % 10;
                int power = 1;
                for (int i = 1; i <= count; i++)
                {
                    power = power * r;

                }
                sum = sum + power;
                count--;
                n = n / 10;
               
            }
            Console.WriteLine(sum);
             if(real == sum)
            {
                Console.WriteLine("Disarium Number");
            }
            else
            {
                Console.WriteLine("Not Disarium");
            
        }
             }
    }

    class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());

            int sum = n * n ;
            int t = sum % 10;
            if (t == n)
            {
                Console.WriteLine("number is Automorphic  number " + t + "=" + n);
            }
            else
            {
                Console.WriteLine("Not Automorphic  number " + t + "=!" + n);
            }

        }
    }

    class Kaprekar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int power = 1;
            int real = n;
            int t = 0, sum = 0;
            for(int i = 1; i <= 2; i++)
            {
                power = power * n;
            }
            Console.WriteLine(power);
            while (power > 0)
            {
                t = power % 10;
                power = power / 10;
                sum = sum + t;
                
            }
            Console.WriteLine(sum);
            if(sum == real)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
            {
                Console.WriteLine("Not Kaprekar");
            }

        }
        
    }

    class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0,sum =0,count=0;
            while (n > 0)
            {
                t = n % 10;
                n = n / 10;
                sum = sum + t;
                count++;
            }
            Console.WriteLine(sum);
            if (sum % count == 0)
            {
                Console.WriteLine("Harshad Number");
            }
            else
            {
                Console.WriteLine("Not Harshad Number");
            }

        }
    }

    class Pluse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= (N * 2 - 1); i++)
            {
                // For the center horizontal plus
                if (i == N)
                {
                    for (int j = 1; j <= (N * 2 - 1); j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    // For spaces before single plus sign
                    for (int j = 1; j <= N - 1; j++)
                    {
                        Console.Write (" ");
                    }
                    Console.Write ("*");
                }

                Console.WriteLine("\n");
            }
        }
    }

    class Kaprekar2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int count = 0,t=0;
            int real = n;
            int sum = 0;
            t = n * n;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            n = real;
            int power =(int)(Math.Pow(10, count));
            int end = t % power;
            int start = t / power;
            /* Console.WriteLine(end +"end");
             Console.WriteLine("Start"+start);*/
            sum = end + start;
            if(sum == real)
            {
                Console.WriteLine("Kaprekar Number");
            }
            else
            {
                Console.WriteLine("Not Kaprekar number");
            }
        }
    }

    class DuckNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int real = n;
            int original = n;
            bool isduck = true;
         
            while (n> 0)
            {
                if (n % 10 == 0)
                {
                    isduck = false;
                    break;
                }
               n = n / 10;
            }
            while (real >= 10)
                real /= 10;
            Console.WriteLine(real);
            if (original>0 && isduck == false && real != 0)
            {
                Console.WriteLine("duck Number");
            }
            else
            {
                Console.WriteLine("Not Duck");
            }

        }
    }
    class Series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = (i * i * i);
                Console.WriteLine(sum-1);
            }
        }
    }

    class Series2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0, sum = 0;
            for(int i = 3; i <= n; i++)
            {
                t = i * 2 + 7;
                sum = t * 2 + 11;
                Console.WriteLine(t);
                Console.WriteLine(sum);

            }
            
        }
    }
    class Fibonaci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1+" "+n2+" ");
            for(int i = 2; i <= num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
    class Series3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(1);
                Console.Write(" ");
            }
        }
    }

   /* class PrimeAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int temp = 0, sum = 0;
            for (int j = 2; j <= n; j++)
            {
                int count = 0;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    count++;
                    break;

                }
                if (count == 0)
                {
                   Console.WriteLine(j);
                    sum = sum + j;
                    temp++;
                }
            }
            //Console.WriteLine(sum);
            int avg = sum / temp;
            Console.WriteLine("Average " + avg);
        }
    }*/

    class Pattern11
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                if (i % 2 == 0)
                {
                    char ch = 'A';
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                }
                else
                {
                    for(int k = 1; k <= i; k++)
                    {
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
