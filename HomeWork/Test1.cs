using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Test1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter side");
            int a = int.Parse(Console.ReadLine());
            double area = (1.73 * a * a) / 4;
            Console.WriteLine("Area of Equilateral Triangle is " + area);
        }
    }

    class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Marks");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int total = a + b + c + d + e;
            float average = total / 5f;
            float percentage = average * 100;
            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Total Average = " + average);
            Console.WriteLine("Total Percentage = " + percentage);
        }
    }

    class Test3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year");
            int a = int.Parse(Console.ReadLine());
            if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
            {
                Console.WriteLine("year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is Not Leap");
            }
        }
    }

    class Test4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            if ((a % 5 == 0) && (a % 11 == 0))
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("not Divisible");
            }
        }
    }

    class Test5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greater");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " is greater");
            }
            else
            {
                Console.WriteLine(c + " is greater");
            }

        }
    }

    class Test6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e')
            {
                Console.WriteLine("Is vowel");
            }
            else if ((ch == 'i' || ch == 'o') || ch == 'u')
            {
                Console.WriteLine("is vowel");
            }
            else
            {
                Console.WriteLine("is constent");
            }
        }
    }

    class Test7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num1 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (sign == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (sign == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (sign == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (sign == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Wrong operation sign ...");
            }

            Console.ReadLine();
        }
    }
    class Test8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("You Enter Alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("You Enter Digit");
            }
            else
            {
                Console.WriteLine("You Enter Special Character");
            }

        }
    }
    class Test9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }

    class Test10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = n % 10; //38724 = 4
                n = n / 10; //3874= 387
                if (sum % 2 == 0)
                {
                    Console.WriteLine(sum);
                }

            }
        }
    }

    class Palindrom
    {
        static void Main(string[] args)
        {
            int n = 23532;
            int t = 0, sum = 0;
            int temp = n;
            while (n > 0)
            {
                t = n % 10;//23532--2
                sum = (10 * sum) + t;
                n = n / 10;//
            }
            if (temp == sum)
            {
                Console.WriteLine("Pallindrom");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }

    class Happy
    {

        static void Main(string[] args)
        {
            int n = 503;
            int t,sum=0;
            for(int i=0;i<=n;i++)
            {
                 t = n % 10;
                n = n / 10;
                sum = sum + t;
            }
            
            if (sum % 2 != 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
           
    }
    class Sumofprime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int [5];
            for(int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
                int Count = 0;
                for(int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        Count = 1;
                        break;
                    }
                }
                if (Count == 0)
                {
                     sum = sum + arr[i];
                  
                }
            }
            Console.WriteLine(sum);
        }
    }
}



