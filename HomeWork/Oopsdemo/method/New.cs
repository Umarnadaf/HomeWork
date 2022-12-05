using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo.method
{
    class Denomination
    {
        public int cash { get; set; }
        public void Amount()
        {
            while (cash >= 0)
            {
                if (cash >= 2000)
                {
                    Console.WriteLine("2000:" + (cash / 2000));
                    cash = cash % 2000;
                }
                else if (cash >= 500)
                {
                    Console.WriteLine("500:" + (cash / 500));
                    cash = cash % 500;
                }
                else if (cash >= 200)
                {
                    Console.WriteLine("200:" + (cash / 200));
                    cash = cash % 200;
                }
                else if (cash >= 100)
                {
                    Console.WriteLine("100:" + (cash / 100));
                    cash = cash % 100;
                }
                else if (cash >= 50)
                {
                    Console.WriteLine("50:" + (cash / 50));
                    cash = cash % 50;
                }
                else if (cash >= 20)
                {
                    Console.WriteLine("20:" + (cash / 20));
                    cash = cash % 20;
                }
                else if (cash >= 10)
                {
                    Console.WriteLine("10:" + (cash / 10));
                    cash = cash % 10;
                }
                else if (cash >= 1)
                {
                    Console.WriteLine("1:" + (cash / 1));
                    cash = cash % 1;
                }
            }
        }
        static void Main(string[] args)
        {
            Denomination d = new Denomination();
            Console.WriteLine("Enter the amount in rupees:");
            d.cash = int.Parse(Console.ReadLine());
            d.Amount();
        }
    }

    class Toggel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int ch;
            ch = char.Parse(Console.ReadLine());

            if (ch >= 65 && ch <= 90)
                ch = ch + 32;
            else
                ch = ch - 32;
            Console.WriteLine("Enter Character Is =" + (char)ch);
        }



    }

    class Task15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("You Enter Character");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("You Enter Number");
            }
            else
            {
                Console.WriteLine("You Enter Special Character");
            }

        }
    }
    class Calender
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter days ");
            int days = int.Parse(Console.ReadLine());
            int year = (days / 365);
            int weeks = (days % 365) / 7;
            days = (days % 365) % 7;
            Console.WriteLine("years = " + year);
            Console.WriteLine("weeks = " + weeks);
            Console.WriteLine("days = " + days);

        }
    }

    class Foreven
    {
        static void Main(string[] args)
        {
            for (int i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    int sum = i;
                    Console.WriteLine(i);
                }

            }

        }
    }

    class ForOdd
    {
        static void Main(string[] args)
        {
            for (int i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    int sum = i;
                    Console.WriteLine(i);
                }

            }

        }

    }

    class Prime  // break
    {
        public void Prim()
        {
            int count = 1;
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    count = 0;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine(n + " is prime numner");
            }
            else
            {
                Console.WriteLine(n + " is not prime number");
            }
        }
        static void Main(string[] args)
        {
            Prime p = new Prime();
            p.Prim();
        }
    }

    class Alphabets
    {
        public void Print()
        {
            for (int i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine((char)i);
            }
        }
        static void Main(string[] args)
        {
            Alphabets a = new Alphabets();
            a.Print();
        }
    }

    class EvenAdd
    {
        public void Sum()
        {
            int sum = 0;
            Console.WriteLine("Enter the range:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of even numbers: " + sum);
        }
        static void Main(string[] args)
        {
            EvenAdd e = new EvenAdd();
            e.Sum();
        }
    }

    class OddAdd
    {
        public void Sum()
        {
            int sum = 0;
            Console.WriteLine("Enter the range:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of odd numbers: " + sum);
        }
        static void Main(string[] args)
        {
            OddAdd e = new OddAdd();
            e.Sum();
        }
    }

    class NumDigit
    {
        public void Digits()
        {
            int count = 0;
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Number of Digit in number " + temp + " are " + count);
        }
        static void Main(string[] args)
        {
            NumDigit a = new NumDigit();
            a.Digits();
        }
    }

    class Frequency
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int rem,cnt,t = -1;
            for(int i = 0; i <= 9; i++)
            {
                cnt = 0;
                for(int j = n; j > 0; j = j / 10)
                {
                    rem = j % 10;
                    if (rem == i)
                    {
                        t = i;
                        cnt++;
                    }
                }
                if (t == i)
                {
                    Console.WriteLine("Frequency of digit " + i + " is "+ cnt);
                }
            }
        }
    }

    class PrimeNumber
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Enter The Number");
           int n = int.Parse(Console.ReadLine());
           int temp = 0, sum = 0;
           for (int j = 300; j <= n; j++)
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
               }
           }
          
       }
   }

    class Expo
    {
        static void Main(string[] args)
        {
            int power = 1;
            Console.WriteLine("Enter Base");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Index");
            int i = int.Parse(Console.ReadLine());

            for (int j = i; j >= 1; j--)
            {
                power = power * b;
            }
            Console.WriteLine("The Power Is:" + power);
        }
    }

    class Task110
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Num");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int x = 2;
                if (i % 2 == 0)
                {
                    Console.WriteLine(-i);
                }
                else
                {
                    Console.WriteLine(i);
                }
                x += 2;
            }


        }
    }

     class Series
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int term = 1 + ((i * (i + 1)) / 2);
                Console.WriteLine(term + " ");
            }
        }
    }


}




