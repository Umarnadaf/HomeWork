using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oops
{
    class Encapsulation
    {
        
        int id;
        string name;
        int age;

        public void GetInfo()
        {
            id = 1;
            name = "Ramesh";
            age = 23;
        }
        public void GetInfo(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void PutInfo()
        {
            Console.WriteLine("ID = " + id);
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
        }

        static void Main(string[] args)
        {
            Encapsulation obj = new Encapsulation();
            obj.GetInfo();

            obj.PutInfo();
            Encapsulation obj1 = new Encapsulation();
            obj.GetInfo(2, "Suresh", 24);
            obj.PutInfo();
            Console.ReadKey();
        }
    }

    public class Bank
    {
        int bal;

        public int GetBalance()
        {
            return bal;
        }
        public void Withdraw(int amt)
        {
            bal = bal - amt;
        }
        public void Deposit(int amt)
        {
            bal = bal + amt;
        }


        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.Deposit(3000);
            Console.WriteLine("Current balance after 3000 deposit is := " + bank.GetBalance());
            bank.Deposit(2000);
            Console.WriteLine("Current balance after 2000 deposit is := " + bank.GetBalance());

            bank.Withdraw(4000);
            Console.WriteLine("Current balance after 4000 withdrawal is := " + bank.GetBalance());
        }
    }

    public class Sample
    {
        int a, b;
        public void GetInfo(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Greatest()
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public void PutInfo()
        {
            Console.WriteLine("Gretest is := " + Greatest());
        }
    
    
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.GetInfo(4, 6);
            sample.PutInfo();
            Console.ReadKey();
        }
    }

    class StudentPer
    {
        string name;
        int sub1;
        int sub2;
        int sub3;
        double per;

       
        public void GetInfo(string name, int sub1, int sub2,int sub3)
        {
            this.name = name;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }
        public void PutInfo()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("sub1 = " + sub1);
            Console.WriteLine("sub2 = " + sub2);
            Console.WriteLine("sub3 = " + sub3);
        }
        public double Percentage()
        {
            double total = sub1 + sub2 + sub3;
            per = (double)(total / 300) * 100;
            return per;
        }

        public char Grade()
        {
            if (per >= 75)
            {
                return 'A';
            }
            else if (per < 75 && per >= 60)
            {
                return 'B';
            }
            else if (per < 60 && per >= 35)
            {
                return 'C';
            }
            else
            {
                return 'F';
            }
        }
        public void Display()
        {
            Console.WriteLine("Percentage are: " + Percentage());
            Console.WriteLine("Grade is: " + Grade());
        }

        static void Main(string[] args)
        {
            StudentPer obj = new StudentPer();

            obj.GetInfo("umar", 79,89,90);
            obj.PutInfo();
            obj.Percentage();
            obj.Display();
          
        }
    }

    /* class StudentGrad
     {
         double per, avg;
         int chem, phy, math, comp, sci;
         public void Accept()
         {
             Console.WriteLine("Enter Maths marks:");
             math = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Physics marks:");
             phy = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Chemistry marks:");
             chem = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Computer marks:");
             comp = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter Science marks:");
             sci = int.Parse(Console.ReadLine());

         }
         public double Percentage()
         {
             int total = math + chem + phy + comp + sci;
             per = (double)(total / 5);
             return per;
         }
         public char Grade()
         {
             if (per >= 75)
             {
                 return 'A';
             }
             else if (per < 75 && per >= 60)
             {
                 return 'B';
             }
             else if (per < 60 && per >= 35)
             {
                 return 'C';
             }
             else
             {
                 return 'F';
             }
         }
         public void Display()
         {
             Console.WriteLine("Percentage are: " + Percentage());
             Console.WriteLine("Grade is: " + Grade());
         }
         static void Main(string[] args)
         {
             StudentGrade obj = new StudentGrade();
             obj.Accept();
             obj.Percentage();
             obj.Display();
         }
     }*/

    class Students
    {
        internal class Student
        {
            public int Id
            {
                get;
                set;
            }
            public string Name
            {
                get;
                set;
            }
            public double Marks
            {
                get;
                set;
            }

            public void compare(Student s)
            {
                if (Marks > s.Marks)
                    display();
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

    class Student
    {
        public int id;
        public string name;
        public int age;

        public Student()
        {
            id = 0;
            name = "";
            age = 0;
            Console.WriteLine("Default");
        }
        // this keyword constructor
        public Student(int id, string name, int age) : this()
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student(Student s)
        {
            this.id = s.id;
            this.name = s.name;
            this.age = s.age;

        }
        public void Display()
        {
            Console.WriteLine("ID : " + id + "\nName : " + name + "\nAge : " + age);
        }
        static void Main(string[] args)
        {
            // Student student = new Student();
            // student.Display();
            Student student1 = new Student(101, "Shruti", 21);
            student1.Display();
            Student student2 = student1;
            student2.Display();
        }

    }

    public class Student1
    {
        int id;
        string name;
        int age;

        public Student1()
        {
            id = 0;
            name = "";
            age = 0;
            Console.WriteLine("Default Constructor");
        }
        public Student1(int id, string name, int age) : this(id, name)
        {

            this.id = id;
            this.name = name;
            this.age = age;
        }
        public Student1(int id, string name)
        {

            this.id = id;
            this.name = name;
            Console.WriteLine("Constructor with 2 parameters called");
        }
        public Student1(Student1 s)
        {
            this.id = s.id;
            this.name = s.name;
            this.age = s.age;
        }
        public void GetInfo(int id, string name = " ", int age = 16)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public void Display()
        {
            Console.WriteLine("Id := " + id + " Name := " + name + " Age := " + age);
        }

        static void Main(string[] args)
        {
            Student1 student = new Student1();//Default constructor calling
            student.GetInfo(10, "abc");
            student.Display();
            Student1 student2 = new Student1(1, "AAA", 89);//parameterised constructor
            student2.Display();
            Student1 student3 = student2;//copy constructor
            student3.Display();
            Console.ReadKey();
        }
    }

    class UseOfthis
    {
        int a, b;
        public UseOfthis()
        {
            Console.WriteLine("No Parameterized Constructor");
        }
        public UseOfthis(int a) : this()
        {
            //Console.WriteLine("Single Parametrised constructor called");
            this.a = a;
            //this.b = b;
            //sum = a + b;
            Console.WriteLine(a);
        }
        public UseOfthis(int a, int b) : this(a)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a + " " + b);
        }
        /*public void PutInfo()
        {
            Console.WriteLine("Addition="+sum);
        }*/
        static void Main(string[] args)
        {
            UseOfthis obj = new UseOfthis(2, 5);
            //obj.PutInfo();
            //obj = new UseOfthis(3);
            //obj.PutInfo();
            //obj = new UseOfthis(10, 3);
            //obj.PutInfo();
            Console.ReadKey();

        }

    }
    class Objects
    {
        int no;
        public Objects(int no)
        {
            this.no = no;
        }
        public void Add(Objects obj)
        {
            int sum = this.no + obj.no;
            Console.WriteLine("Addition of two objects=" + sum);
        }
        static void Main(string[] args)
        {
            Objects obj1 = new Objects(30);
            Objects obj2 = new Objects(20);
            obj1.Add(obj2);
            Console.ReadKey();
        }
    }

    class Object
    {
        int no, sum;
        public Object(int no)
        {
            this.no = no;
        }
        public void Add(Object obj)
        {
            int sum = this.no + obj.no;
            Console.WriteLine("Addition of two objects=" + sum);
        }
        public bool Compare(Object obj)
        {
            if (no > obj.no)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Object obj1 = new Object(30);
            Object obj2 = new Object(20);
            //obj1.Add(obj2);
            if (obj1.Compare(obj2))
                Console.WriteLine("First object is gtreater");
            else
                Console.WriteLine("Second object is greater");
            Console.ReadKey();
        }
    }

    class ObjectReturn
    {
        class ObjRet
        {
            int no;

            public ObjRet()
            {
                this.no = 0;
            }
            public ObjRet(int no)
            {
                this.no = no;
            }
            public void Display()
            {
                Console.WriteLine("Number is" + no);
            }
            public ObjRet add(ObjRet obj)
            {
                ObjRet temp = new ObjRet();
                temp.no = this.no + obj.no;
                return temp;
            }
            public ObjRet Compare(ObjRet obj)
            {
                ObjRet temp = new ObjRet();
                if (this.no > obj.no)
                    temp = this;
                else
                    temp = obj;
                return temp;

            }
        }
        static void Main(string[] args)
        {
            ObjRet obj1 = new ObjRet(9);
            ObjRet obj2 = new ObjRet(5);

            ObjRet obj3 = obj1.add(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();
            Console.WriteLine("After Comparison");
            obj3 = obj1.Compare(obj2);
            obj1.Display();
            obj2.Display();
            obj3.Display();

            Console.ReadKey();



        }
    }
    class Time
    {
        int hr, min;

        public Time()
        {
            hr = 0;
            min = 0;
        }
        public Time(int hr, int min)
        {
            this.hr = hr;
            this.min = min;
        }
        public void ShowTime()
        {
            Console.WriteLine("Time is " + hr, +min);

        }
        public Time AddTime(Time t)
        {
            Time temp = new Time();

            temp.hr = this.hr + t.hr;
            temp.min = this.min + t.min;

            if (temp.min >= 60)
            {
                temp.min = temp.min % 60;
                temp.hr++;
            }
            return temp;
        }
        static void Main(string[] args)
        {
            Time t1 = new Time(3, 40);
            Time t2 = new Time(4, 55);
            t1.ShowTime();
            t2.ShowTime();


            Time t3 = new Time();
            t3 = t1.AddTime(t2);
            t3.ShowTime();
            Console.ReadKey();
        }
    }

    class param
    {
        public static void Add(params int[] nos)
        {
            int sum = 0, avg = 0;
            foreach (int n in nos)
                sum = sum + n;
                
                Console.WriteLine("addition of "+nos.Length+" parameters is "+sum);
                avg = sum / nos.Length;
                Console.WriteLine("average" + avg);

        }
        public static void AddName(params string[] name)
        {
            string s = "";
            foreach (string str in name)
                s = s + str;
            Console.WriteLine("Concatinated String is"+s);

        }
        static void Main(string[] args)
        {
            Add(1, 2);
            Add(2, 3, 4);
            AddName("hi", "Umar");
        }
    }

    class Const
    {
        public static void show(int no)
        {
            Console.WriteLine("Constant is" + no);
        }
        public class Demo
        {
            const int no = 80;
            public void show()
            {
                Console.WriteLine("No is" + no);
            }
        }

        static void Main(string[] args)
        {
            const int a = 10;
            const double PI = 3.14;
            double r = 2.3, area;
            area = PI * r * r;
            Console.WriteLine("area is" + area);
            //a = 90; not allowed
            show(a);
            Console.WriteLine("Value of a is" + a);
            Console.ReadKey();
        }
    }

    class Stud
    {
        public readonly int rollno;
        public string name;
        public Stud(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Rollno=" + rollno);
            Console.WriteLine("Name=" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stud st1 = new Stud(1, "Rahul");
            Stud st2 = new Stud(2, "Nisha");
            Stud st3 = new Stud(3, "Peter");
            st1.Display();
            st2.Display();
            st3.Display();
            Console.ReadKey();

        }
    }
    public class Demo
    {
        static int no;
        int x;
        public void GetNo()
        {
            Console.WriteLine("Static value is" + no);


        }
        public void PutData(int n)
        {
            x = n;
            no++;
        }
        public void GetData()
        {
            Console.WriteLine("Instance Variable x=" + x);
        }

    }
    class StaticExample
    {
        static int x, y;
        int no = 4;




        static void Main(string[] args)
        {
            StaticExample obj = new StaticExample();
            x = 30;
            y = 56;

            Demo d1 = new Demo();
            Demo d2 = new Demo();
            Demo d3 = new Demo();

            d1.GetNo();
            d2.GetNo();
            d3.GetNo();

            d1.PutData(100);
            d2.PutData(200);
            d3.PutData(300);

            d1.GetNo();
            d2.GetNo();
            d3.GetNo();

            d1.GetData();
            d2.GetData();
            d3.GetData();
            Console.ReadKey();




        }
    }

    public class Course
    {
        private int id;
        private string name;
        private double fees;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Fees
        {
            get { return fees; }
            set { fees = value; }
        }

        static void Main(string[] args)
        {
            Course C1 = new Course();
            // property initializer syntax
            C1.Id = 1;
            C1.Name = "Pramod";
            C1.Fees = 25000;

            Console.WriteLine($"{C1.Id}  {C1.Name}  {C1.Fees}");
            // object initializer syntax
            Course C2 = new Course { Id = 2, Name = "Umar", Fees = 25000 };

            Console.WriteLine($"{C2.Id}  {C2.Name}  {C2.Fees}");


        }
    }

    public class Course01
    {
        private int id;
        private string name;
        private double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        static void Main(string[] args)
        {
            Course01 C1 = new Course01();
            // property initializer syntax
            C1.Id = 1;
            C1.Name = "Pramod";
            C1.salary = 25000;

            Console.WriteLine($"{C1.Id}  {C1.Name}  {C1.salary}");
            // object initializer syntax
            Course01 C2 = new Course01 { Id = 2, Name = "Umar", salary = 25000 };

            Console.WriteLine($"{C2.Id}  {C2.Name}  {C2.salary}");


        }
    }
}









