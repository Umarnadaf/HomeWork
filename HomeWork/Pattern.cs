using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Pattern
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }

    class Pattern2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i = 4; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern4
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j%2);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern6
    {
        static void Main(string[] args)
        {
            for(int i=5;i>=1;i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern7
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    if (i == 1 || i == 4 || j == 1 || j == 4)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("\n ");
            }
        }
    }

    class Pattern8
    {
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    class Pattern9
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 3; i++)
            {
              
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }
    }

    class AddfirstLast
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;

            int firstDigit = n;
            int t = 0;

            while (n > 0)//123
            {
                t = n % 10;//3-->2-->1
                n = n / 10;//12-->1-->0
               
            }
            firstDigit = t;

            int sum = firstDigit + lastDigit;

            Console.WriteLine("Sum of first and last digit: " + sum);
        }
    }

    class Test30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            int sum = 0;
            int count = 0;
            while(n>0)
            {
               
                t = n % 10;
                n = n / 10;
                Console.WriteLine(t);
                sum = sum + t;
                count++;
                
            }
            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine(sum/count);

            
        }
    }

 class Pattern10
    {
        static void Main(string[] args)
        
        {
            int N = int.Parse(Console.ReadLine());
            int i, j, counter = 0;
            for (i = 0; i < N; i++)
            {
                Console.Write("*");
                for (j = 0; j <= N; j++)
                {
                    if (j == N)
                        Console.Write("*");
                    else if (j == counter)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                counter++;
                Console.Write("\n");
            }
        }
    }
}
