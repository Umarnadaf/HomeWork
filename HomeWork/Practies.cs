using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    
    class mult
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 2;
            int sum = 0;
            for(int i = 1; i <= a; i++)
            {
                sum+= b;
            }
            Console.WriteLine(sum);
        }
    }

    class JaggedArr
    {
        static void Main(String[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 6 };
            jaggedArray[1] = new int[] { 5, 6 };
            jaggedArray[2] = new int[] { 7, 8, 9 };
            Console.WriteLine("Jagged Array is = ");
            Console.WriteLine();
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + " ");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public int allow;
        public int it;

        public Employee()
        {
            id = 0;
            name = "";
            salary = 0;
            allow = 0;
           
        }
        // this keyword constructor
        public Employee(int id, string name, int salary, int allow, int it) : this()
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.allow = allow;
            this.it = it;
        }
        public void CalculateSalary(int salary, int allow, int it)
        {
            int totalSalary = salary + allow;
            int netSalary = totalSalary - it;
            Console.WriteLine("Total Salary = "+totalSalary);
            Console.WriteLine("Net Salary = "+netSalary);

        }
        public void GetInfo(int id, string name = " ")
        {
            this.id = id;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("ID : " + id + "\nName : " + name );
        }
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.GetInfo(01, "Umar");
            obj.Display();
            obj.CalculateSalary(25000,10000,2500);
            
        }

    }

    class Unary
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            int c = a * b + (a++ + --b) - b;
            Console.WriteLine(c);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
