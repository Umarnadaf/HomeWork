using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo.method
{
    class AutoImpliment
    {

        internal class Employ
        {


            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }

        static void Main(string[] args)
        {



            Employ obj1 = new Employ();
            obj1.Id = 1;
            obj1.Name = "Umar";
            obj1.Salary = 67000;

            Employ obj2 = new Employ();
            obj2.Id = 2;
            obj2.Name = "Prathmesh";
            obj2.Salary = 76000;

            if (obj1.Salary > obj2.Salary)
            {
                Console.WriteLine("Id := " + obj1.Id);
                Console.WriteLine("Name := " + obj1.Name);
                Console.WriteLine("Makrs := " + obj1.Salary);
            }
            else
            {
                Console.WriteLine("Id := " + obj2.Id);
                Console.WriteLine("Name := " + obj2.Name);
                Console.WriteLine("Makrs := " + obj2.Salary);
            }
            Console.ReadKey();
        }
    }

    class Clock
    {
        internal class Time
        {
            public int hr
            {
                get;
                set;
            }
            public int min
            {
                get;
                set;
            }
            public void display()
            {
                Console.WriteLine("Time is " + hr + " : " + min);


            }


            public void add(Time t1, Time t2)
            {
                hr = t1.hr + t2.hr;
                min = t1.min + t2.min;
                if (min >= 60)
                {
                    min = min % 60;
                    hr++;
                }
            }


        }

        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.hr = 1;
            t1.min = 42;
            Time t2 = new Time();
            t2.hr = 1;
            t2.min = 42;
            Time t3 = new Time();
            t3.add(t1, t2);
            t1.display();
            t2.display();
            t3.display();




            Console.ReadKey();
        }

    }

    class Clock2
    {
        internal class Time
        {
            public int hr
            {
                get;
                set;
            }
            public int min
            {
                get;
                set;
            }
            public void display()
            {
                Console.WriteLine("Time is " + hr + " : " + min);


            }


            public Time add(Time t1, Time t2)
            {
                Time t = new Time();
                t.hr = t1.hr + t2.hr;
                t.min = t1.min + t2.min;
                if (t.min >= 60)
                {
                    t.min = t.min % 60;
                    t.hr++;
                }
                return t;
            }


        }

        static void Main(string[] args)
        {
            Time t1 = new Time();
            t1.hr = 1;
            t1.min = 42;
            Time t2 = new Time();
            t2.hr = 1;
            t2.min = 42;
            Time t3 = new Time();
            t3 = t3.add(t1, t2);
            t1.display();
            t2.display();
            t3.display();




            Console.ReadKey();
        }

    }

    /* class X1
     {
         internal class Person
         {
             string name;
             int age;
             public string Name
             {
                 set
                 {
                     name = value;
                 }
                 get
                 {
                     return name;
                 }
             }
             public int Age
             {
                 set
                 {
                     age = value;
                 }
                 get
                 {
                     return age;
                 }
             }


             public Person compare(Person age)
             {
                 Person p = new Person();
                 if (p > p.age)
                     return p;
                 else
                     s.display();
             }


             public void display()
             {
                 Console.WriteLine("Id := " + Id);
                 Console.WriteLine("Name := " + Name);
                 Console.WriteLine("Marks := " + Marks);
             }
         }

         static void Main(string[] args)
         {
             Student obj1 = new Student();
             obj1.Id = 1;
             obj1.Name = "aaa";
             obj1.Marks = 67.78;

             Student obj2 = new Student();
             obj2.Id = 2;
             obj2.Name = "bbb";
             obj2.Marks = 76.45;

             obj1.compare(obj2);

             Console.ReadKey();
         }

     }
 }
 }*/
}
