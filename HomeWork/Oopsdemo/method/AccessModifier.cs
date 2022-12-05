using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo.method
{
    class AccessModifier
    {
        int model;
        string name;
        int price;
        string colour;
        public int Model
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }
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
        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }
        public string Colour
        {
            set
            {
                colour = value;
            }
            get
            {
                return colour;
            }
        }

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.model = 2015;
            car1.name = "Vrena";
            car1.price = 1500000;
            car1.colour = "White";
            Console.WriteLine(car1.model + " " + car1.name + " " + car1.price + " " + car1.colour);


        }
    }

    class Student
    {
        int id;
        string name;
        int age;
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
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

        static void Main(string[] args)
        {
            Student st = new Student();
            st.id = 2022;
            st.name = "Umar";
            st.age = 23;
            Console.WriteLine(st.id + " " + st.name + " " + st.age);


        }
    }

    class Stu02
    {
        internal class Stu
        {
           

            public int Id { get; set; }
            public string Name { get; set; }
            public double Marks { get; set; }
        }

        static void Main(string[] args)
        {



            Stu obj1 = new Stu();
            obj1.Id = 1;
            obj1.Name = "aaa";
            obj1.Marks = 67.78;

            Stu obj2 = new Stu();
            obj2.Id = 2;
            obj2.Name = "bbb";
            obj2.Marks = 76.45;

            if (obj1.Marks > obj2.Marks)
            {
                Console.WriteLine("Id := " + obj1.Id);
                Console.WriteLine("Name := " + obj1.Name);
                Console.WriteLine("Makrs := " + obj1.Marks);
            }
            else
            {
                Console.WriteLine("Id := " + obj2.Id);
                Console.WriteLine("Name := " + obj2.Name);
                Console.WriteLine("Makrs := " + obj2.Marks);
            }
            Console.ReadKey();
        }
    }



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
}
