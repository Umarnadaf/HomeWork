using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class Test03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 5 == 0 && i % 10 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }

    class Que3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even" + i);
                }
                else
                {
                    Console.WriteLine("odd" + i * i);
                }
            }
            Console.WriteLine();
        }
    }

    class Que4
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 1; i <= 20; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }

    class Que5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0, sum = 0, count = 0;
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
    class Que6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                }
            }
        }
    }


    class Que7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int real = n;
            int sum = 0;
            int t = 0;
            while (n > 0)
            {
                t = n % 10;
                int fact = 1;
                for (int i = 1; i <= t; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                n = n / 10;
            }

            if (real == sum)
            {
                Console.WriteLine("is Krishnamurthy Number");
            }
            else
            {
                Console.WriteLine(" Not Krishnamurthy");
            }


        }
    }

    class OddDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0, sum = 0;
            while (n > 0)
            {
                t = n % 10;
                n = n / 10;
                if (t % 2 != 0)
                {
                    sum = sum + t;
                }
            }
            Console.WriteLine(sum);
        }
    }

    class Pallindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0, temp = n, sum = 0;
            while (n > 0)//121
            {
                t = n % 10;//1-2-1
                sum = (sum * 10) + t;//1-12-121
                n = n / 10;

            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
    class Table
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            while (i <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.WriteLine(i * j);
                    j++;
                }
                i++;
            }
            Console.WriteLine();
        }
    }

    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            for (int j = 2; j <= n; j++)
            {
                int count = 0;
                for (int i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(j);

                }
            }
        }
    }

    class PrimeNum
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            int n = 1;
            //Console.WriteLine("Enter any Number := ");
            //n = int.Parse(Console.ReadLine());
            Boolean isPrime;
            while (n <= 100)
            {
                isPrime = true;
                int i = 2;
                while (i <= n / 2)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                    Console.WriteLine(n);
                n++;
            }
            Console.ReadKey();
        }
    }
}



