using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo.method
{
    internal class Constructor
    {
        int roll_no;
        string name;
        int marks;

        public Constructor(int roll_no, string name, int marks)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("Roll_no = " + roll_no);
            Console.WriteLine("name = " + name);
            Console.WriteLine("Marks = " + marks);
        }
        static void Main(string[] args)
        {
            Constructor c = new Constructor(1, "umar", 98);
            c.display();
        }
    }

    internal class Take
    {
        int roll_no;
        string name;
        int marks;

        public Take(int roll_no, string name, int marks)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }
        public void compare(Take stud2)
        {
            if (marks >= stud2.marks)
                this.display();
            else
            {
                stud2.display();
            }

        }

        public void display()
        {
            Console.WriteLine("Roll_no = " + roll_no);
            Console.WriteLine("name = " + name);
            Console.WriteLine("Marks = " + marks);
        }
        static void Main(string[] args)
        {
            Take stud1 = new Take(1, "jeetu", 78);
            Take stud2 = new Take(2, "harsh", 87);
            stud1.compare(stud2);


            Console.ReadKey();
        }
    }

    internal class Calculation
    {
        public void add(int a, int b)
        {
            int res = a + b;
            Console.WriteLine("add int " + res);
        }
        public void add(int a)
        {
            int res = a + 0;
            Console.WriteLine("add 1 int " + res);
        }
        public void add(double a, double b)
        {
            double res = a + b;
            Console.WriteLine("add of 2 double " + res);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation();
            obj.add(4, 5);
            obj.add(3);
            obj.add(4.5, 6.8);
            Console.ReadKey();
        }
    }

    internal class Calculate
    {
        public void area(int a, int b)
        {
            int area = a * b;
            Console.WriteLine("Rectangle " + area);
        }
        public void area(int a)
        {
            int area = a * a;
            Console.WriteLine("squre area " + area);
        }
        public void area(double a)
        {
            double area = 3.14 * a * a;
            Console.WriteLine("circle  " + area);
        }
        static void Main(string[] args)
        {
            Calculate obj = new Calculate();
            obj.area(4, 5);
            obj.area(3);
            obj.area(4.5);
            Console.ReadKey();
        }
    }

    internal class Take1
    {
        int rollno;
        string name;
        int marks;

        public Take1()
        {
            Console.WriteLine("This is default construction");
        }
        public Take1(int rollno, string name, int marks)
        {
            Console.WriteLine("This is 3 parameter construction");
            this.rollno = rollno;
            this.name = name;
            this.marks = marks;
        }
        public Take1 (int rollno,int marks)
        {
            Console.WriteLine("This is 2 parameter construction");
            this.rollno = rollno;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("rollno = "+rollno);
            Console.WriteLine("name = "+name);
            Console.WriteLine("marks = "+marks);
        }

        static void Main(string[] args)
        {
            Take1 obj = new Take1();
            obj.display();
            Take1 stud1 = new Take1(1,"jeetu",78);
            stud1.display();
            Take1 stud2 = new Take1(2, "Umar", 88);
            stud2.display();


        }
    }

    class GrossSalary
    {
        double hra;
        double da;
        double gross;
        public double salary { get; set; }

        public void Compare(double sa)
        {
            if (sa <= 10000)
            {
                hra = sa * 0.2;
                da = sa * 0.8;
            }
            else if (sa <= 20000)
            {
                hra = sa * 0.25;
                da = sa * 0.95;
            }
            else if (sa > 20000)
            {
                hra = sa * 0.3;
                da = sa * 0.95;
            }
            gross = sa + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("Gross Salary is: " + gross);
        }
        static void Main(string[] args)
        {
            GrossSalary sal = new GrossSalary();
            Console.WriteLine("Enter the basic salary:");
            sal.salary = int.Parse(Console.ReadLine());
            sal.Compare(sal.salary);
            sal.Display();

        }
    }

    class Percentage
    {
        double hra;
        double da;
        double gross;
        public double salary { get; set; }

        public void Compare(double sa)
        {
            if (sa <= 10000)
            {
                hra = sa * 0.2;
                da = sa * 0.8;
            }
            else if (sa <= 20000)
            {
                hra = sa * 0.25;
                da = sa * 0.95;
            }
            else if (sa > 20000)
            {
                hra = sa * 0.3;
                da = sa * 0.95;
            }
            gross = sa + hra + da;
        }

        public void Display()
        {
            Console.WriteLine("Gross Salary is: " + gross);
        }
        static void Main(string[] args)
        {
            GrossSalary sal = new GrossSalary();
            Console.WriteLine("Enter the basic salary:");
            sal.salary = int.Parse(Console.ReadLine());
            sal.Compare(sal.salary);
            sal.Display();

        }
    }
}

