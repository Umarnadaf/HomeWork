using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.FirstAssignment
{
    class First
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

    class Second
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int a = int.Parse(Console.ReadLine());
            if ((a %5==0)&&(a % 11==0))
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("not Divisible");
            }
        }
    }

    class Third
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int c = int.Parse(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine(a+" is greater");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine(b+" is greater");
            }
            else
            {
                Console.WriteLine(c + " is greater");
            }

        }
    }

    class Four
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch=='a'||ch=='e')
            {
                Console.WriteLine("Is vowel");
            }
            else if ((ch=='i'||ch=='o') || ch=='u')
            {
                Console.WriteLine("is vowel");
            }
            else
            {
                Console.WriteLine("is constent");
            }
        }
    }

    class Five
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Action to be Perform");
            Console.WriteLine("Press 1 for Add");
            Console.WriteLine("Press 2 for sub");
            Console.WriteLine("Press 3 for multiply");
            Console.WriteLine("Press 4 for divide");
            int action = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Two Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    
                        result = (a + b);
                        Console.WriteLine("Ans = " + result);
                        break;
                    
                case 2:
                    
                        result = (a - b);
                        Console.WriteLine("Ans = "+result);
                        break;
                    
                case 3:
                    
                        result = (a * b);
                        Console.WriteLine("Ans = " + result);
                        break;
                    
                case 4:
                    
                        result = (a / b);
                        Console.WriteLine("Ans = " + result);
                        break;
                    
                default:
                    
                        Console.WriteLine("wrong Action");
                        break;
                    
            }

        }
    }

    class Six
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else if (n == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else
            {
                Console.WriteLine("Number Is Positive");
            }
        }
    }

    class Seven
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

    class Eight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Number Is Even");
            }
            else
            {
                Console.WriteLine("Number Is Odd");
            }
        }
    }

    class Nine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amout for Denomination");
            int amt = int.Parse(Console.ReadLine());

            while (amt >= 2000)
            {
                int a = amt / 2000;
                amt %= 2000;
                Console.WriteLine($"Total Number of 2000 Rupees * {a}");
                break;
            }
            while(amt>=500)
            {
                int b = amt / 500;
                amt %= 500;
                Console.WriteLine($"Total Number of 500 Rupees * {b}");
                break;
            }
            while (amt >= 100)
            {
                int c = amt / 100;
                amt %= 100;
                Console.WriteLine($"Total Number of 100 Rupees * {c}");
                break;
            }
            while (amt >= 50)
            {
                int d = amt / 50;
                amt %= 50;
                Console.WriteLine($"Total Number of 50 Rupees * {d}");
                break;
            }
            while (amt >= 20)
            {
                int e = amt / 20;
                amt %= 20;
                Console.WriteLine($"Total Number of 20 Rupees * {e}");
                break;
            }
            while (amt >= 10)
            {
                int f = amt / 10;
                amt %= 10;
                Console.WriteLine($"Total Number of 10 Rupees * {f}");
                break;
            }
            while (amt >= 1)
            {
                int g = amt / 1;
                amt %= 1;
                Console.WriteLine($"Total Number of 1 Rupees * {g}");
                break;
            }
        }
    }

    class Ten
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}


