using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class SortString
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "new","small","India","Apple","Moon"
            };

            for (int i = 0; i < li.Count; i++)
            {
                for (int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].Length > li[j].Length)
                    {
                        string temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
        }
    }

    class q2
    {
        class Employye
        {
            string name;
            string designation;
            int salary;

            public Employye(string name, string designation, int salary)
            {
                this.name = name;
                this.designation = designation;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine(name + " " + designation + " " + salary);
            }
        }

        static void Main(string[] args)
        {
            List<Employye> li = new List<Employye>();
            {
                li.Add(new Employye("umar", "Developer", 65000));
                li.Add(new Employye("Bhushan", "Hr", 70000));
                li.Add(new Employye("Prathmesh", "sales", 50000));
            }

            foreach (Employye s in li)
            {
                s.display();
            }
        }
    }

    class Colours
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            {
                q.Enqueue("Orange");
                q.Enqueue("White");
                q.Enqueue("Green");
            }
            foreach (string str in q)
            {
                Console.WriteLine(str);
            }
        }
    }

    class Q3
    {
        class Employye
        {
            public int id;
            public  string name;
            public int salary;

            public Employye(int eid, string ename, int salary)
            {
                this.id = eid;
                this.name = ename;
                this.salary = salary;
            }
            public void display()
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }

        static void Main(string[] args)
        {
            HashSet<Employye> li = new HashSet<Employye>();
            Console.WriteLine("Enter no of Employye");
            int eno = int.Parse(Console.ReadLine());
            for (int i = 0; i < eno; i++)
            {
                Console.WriteLine("Enter Id");
                int id = int.Parse(Console.ReadLine());
                bool Ispresent = false;
                foreach (Employye em in li)
                {
                    if (em.id.Equals(id))
                    {
                        Console.WriteLine("Id Already Present");

                        Ispresent = true;
                        eno++;
                        break;
                    }
                }

                if (!Ispresent)
                {
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Salary");
                    int salary = int.Parse(Console.ReadLine());

                    Employye emp = new Employye(id, name, salary);
                    li.Add(emp);
                }
            }
            foreach(Employye emp in li)
            {
                emp.display();
            }
        }
    }
}

