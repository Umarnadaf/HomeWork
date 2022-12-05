using System;

namespace HomeWork
{
    class Program //Write a  program to enter two numbers and perform all arithmetic operations Different Program for each 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition " + (a + b));
            Console.WriteLine("Subtraction " + (a - b));
            Console.WriteLine("Multiplication " + (a * b));
            Console.WriteLine("Division " + (a / b));
            Console.WriteLine("Modulus " + (a % b));
        }
    }

    class Task
    { //Write a  program to enter length and breadth of a rectangle and find its Area
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area Of Rectangle = "+ (l*w));

        }
    }

    class Task2
    { //Write a  program to enter base and height of a triangle and find its area.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base of Triangle");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hight of Triangle");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area Of Triangle = " + (0.5*x*y));
        }
    }

    class Task3
    { //Write a  Program to calculate Square of given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Square of a Number = " + a * a);
        }
    }

    class Task4
    { //Write a  Program to calculate cube of given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("cube of a Number = "+a*a*a);
        }
    }

    class Task5
    { //Write a  program to enter length in centimeter and convert it into meter and kilometer.
        static void Main(string[] args)
        {
            Console.WriteLine("enter value in CM");
            int a = int.Parse(Console.ReadLine());
            float Meter = a / 100f;
            float Kilometer = a / 100000f;
            Console.WriteLine("Length In Meter = "+ Meter+" M");
            Console.WriteLine("Length In Kilometer = " + Kilometer+" KM");
        }
    }

    class Task6
    { //Write a  program to enter marks of five subjects and calculate total, average and percentage.
        static void Main(string[] args)
        {
            Console.WriteLine("enter Marks");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int total = a+b+c+d+e;
            float average = total / 5f;
            float percentage = average * 100;
            Console.WriteLine("Total Marks = "+ total);
            Console.WriteLine("Total Average = " + average);
            Console.WriteLine("Total Percentage = " + percentage);
        }
    }

    class Task7
    {  //Write a  program to enter P, T, R and calculate Simple Interest.
        static void Main(string[] args)
        {
            Console.WriteLine("enter Principle Amount");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate Of Interest");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time");
            int t = int.Parse(Console.ReadLine());
            float SimpleInterest = (p * t * r) / 100;
            Console.WriteLine("Simple Interest = "+ SimpleInterest);
        }
    }

    class Task8
    { //Write a  program to enter length and breadth of a rectangle and find its perimeter
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of Rectangle");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perimeter Of Rectangle = " + 2*(l + w));

        }
    }

    class Task9
    { //Write a program to calculate area of an equilateral triangle.
        static void Main(string[] args)
        {
            Console.WriteLine("enter side");
            int a = int.Parse(Console.ReadLine());
            double area = (1.73 * a * a) / 4;
            Console.WriteLine("Area of Equilateral Triangle is " +area);
        }
    }

    class Task10
    { //Write a  program to compute the specified expressions and print the output.
        static void Main(string[] args)
        {
            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
        }
    }

    class Task11
    { //Write a program to compute a specified formula
        static void Main(string[] args)
        {
            double result = 4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11));
            Console.WriteLine(result);
        }
    }

    class Task12
    { //Write a program to enter temperature in °Celsius and convert it into °Fahrenheit.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature In Celsius");
            int celsius = int.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("celsius " + celsius+" --> "+fahrenheit + " fahrenheit");
        }
    }

    class Task13
    { //Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature In fahrenheit");
            int fahrenheit = int.Parse(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5/ 9;
            Console.WriteLine("fahrenheit " + fahrenheit + " --> " + celsius + " celsius");
        }
    }

    class Task14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter days ");
            int days = int.Parse(Console.ReadLine());
            int year = (days / 365);
            int weeks = (days % 365) / 7;
            days = (days % 365) % 7;
            Console.WriteLine("years = "+year);
            Console.WriteLine("weeks = "+weeks);
            Console.WriteLine("days = " + days);

        }
    }

    class Task15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch>='a'&& ch<='z') || (ch>='A'&& ch <= 'Z'))
            {
                Console.WriteLine("You Enter Character");
            }
            else if (ch>='0'&& ch<='9')
            {
                Console.WriteLine("You Enter Number");
            }
            else
            {
                Console.WriteLine("You Enter Special Character");
            }

        }
    }

    class Task16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

    }

    class Task17
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
            if (percentage>71)
            {
                Console.WriteLine("Distigtion");
            }
            else if(percentage<=70 && percentage>=60)
            {
                Console.WriteLine("First Class");
            }
            else if (percentage <= 59 && percentage >= 50)
            {
                Console.WriteLine("Second Class");
            }
            else if (percentage <= 49 && percentage >= 35)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }

    class Task18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int Umar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Friend age");
            int Bhushan = int.Parse(Console.ReadLine());
            if (Umar>Bhushan)
            {
                Console.WriteLine("hi");
            }
            else if (Bhushan>Umar)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("How Are You");
            }
            
        }
    }

    class Task19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Task20
    {
        static void Main(string[] args)
        {
            
            for (int i = 10; i >=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Task21
    {
        static void Main(string[] args)
        {
         
            for (int i = 1; i <= 20; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Task22
    {
        static void Main(string[] args)
        {

            for (int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Task23
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Base");
            Console.WriteLine("Enter Exponent");
            int Base = int.Parse(Console.ReadLine());
            int Expo = int.Parse(Console.ReadLine());
            int power =1;
            for (int i = 1; i <= Expo; i++)
            {
                power =  power * Base;
               
            }
            Console.WriteLine(power);
        }
    }

    class Task24
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Number");
            int a = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);
            }
            
        }
    }

    class Task25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            int add = 0;
            for(int i = 2; i <= n; i+=2)
            {

                add = add + i;

            }
            Console.WriteLine($"sum of all even number 1 to {n} = {add}");
        }
    }

    class Task26
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }
        }
    }

   
}



