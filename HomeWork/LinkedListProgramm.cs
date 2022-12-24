using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class LinkedListProgramm
    {
        static void Main(string[] args)
        {
            /*List<int> li = new List<int>();
            {
                li.Add(1);
                li.Add(2);
                li.Add(3);
                li.Add(4);

            };*/
            var evenNum = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };
            int i = 0;
            for (i = 1; i < evenNum.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "  ");
                }
            }
        }
    }

    class PrimeList
    {
        static void Main(String[] args)
        {

            var PrimeNumber = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            for (int i = 0; i < PrimeNumber.Count; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class SortedList
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(1, "google");
            st.Add(2, "fb");
            st.Add(3, "micro");
            st.Add(4, "Info");
            int i = 0;
            foreach (var even in st)
            {

                if (even.Key % 2 == 0)
                {
                    Console.WriteLine(even.Key + " " + even.Value);
                }
            }
        }
    }

    class Employe
    {
        public int id;
        public string name;
        public double salary;
        public Employe(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

    }
    class EmployeeCustomList
    {
        static void Main(string[] args)
        {
            List<Employe> ep = new List<Employe>();
            ep.Add(new Employe(1, "Harry", 25000));
            ep.Add(new Employe(2, "John", 30000));
            ep.Add(new Employe(3, "Peter", 35000));

            foreach (Employe e in ep)
            {
                if (e.salary > 25000)
                {
                    Console.WriteLine(e.id + " " + e.name + " " + e.salary);
                }
            }
        }
    }

    class Employees : IComparable
    {
        public int id;
        public string name;
        public int salary;

        public Employees(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int CompareTo(object obj)
        {
            Employees e = (Employees)obj;

            return e.salary - this.salary;
        }
    }

    class CostomList
    {
        static void Main(string[] args)
        {
            List<Employees> li = new List<Employees>();
            li.Add(new Employees(101, "abhishek", 50000));
            li.Add(new Employees(102, "Prathmesh", 600000));
            li.Add(new Employees(103, "Bhushan", 40000));
            li.Add(new Employees(104, "Pramod", 55000));

            foreach (Employees e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
            Console.WriteLine("...................................");

            li.Sort();
            foreach (Employees e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.salary);
            }
        }
    }


    class Car : IComparable
    {
        public int model;
        public string name;
        public int price;

        public Car(int model, string name, int price)
        {
            this.model = model;
            this.name = name;
            this.price = price;
        }

        public int CompareTo(object obj)
        {
            Car e = (Car)obj;

            return e.price - this.price;

            if (e.price == this.price)
            {
                return e.name.CompareTo(this.name);
            }
            else
            {
                return e.model - this.model;

            }
        }
    }

    class CostomCar
    {
        static void Main(string[] args)
        {
            List<Car> li = new List<Car>();
            li.Add(new Car(2015, "Audi", 500000));
            li.Add(new Car(2020, "Bugati", 500000));
            li.Add(new Car(2010, "Mini", 400000));
            li.Add(new Car(2013, "Mini", 550000));

            foreach (Car e in li)
            {
                Console.WriteLine(e.model + " " + e.name + " " + e.price);
            }
            Console.WriteLine("...................................");

            li.Sort();
            foreach (Car e in li)
            {
                Console.WriteLine(e.model + " " + e.name + " " + e.price);
            }
        }
    }

    class Car2
    {
        public int model;
        public string name;
        public int price;

        public Car2(int model, string name, int price)
        {
            this.model = model;
            this.name = name;
            this.price = price;
        }
    }

        class SortbyPrice : IComparer<Car2>
        {
            int IComparer<Car2>.Compare(Car2 x, Car2 y)
            {
                return x.price - y.price;
            }
        }
    

        class CostomCar2
        {
            static void Main(string[] args)
            {
                List<Car2> li = new List<Car2>();
                li.Add(new Car2(2015, "Audi", 500000));
                li.Add(new Car2(2020, "Bugati", 500000));
                li.Add(new Car2(2010, "Mini", 400000));
                li.Add(new Car2(2013, "Mini", 550000));

                foreach (Car2 e in li)
                {
                    Console.WriteLine(e.model + " " + e.name + " " + e.price);
                }
                Console.WriteLine("...................................");

                li.Sort(new SortbyPrice());
                foreach (Car2 e in li)
                {
                    Console.WriteLine(e.model + " " + e.name + " " + e.price);
                }
            }
        }


    class Train
    {
        public int id;
        public string name;
        public int seats;

        public Train(int id, string name, int seats)
        {
            this.id = id;
            this.name = name;
            this.seats = seats;
        }
    }

    class SortbySeats : IComparer<Train>
    {
        int IComparer<Train>.Compare(Train x, Train y)
        {
            if(x.seats == y.seats)
            {
                return x.name.CompareTo(y.name);
            }
            return x.seats - y.seats;
        }
    }


    class CostomTrain
    {
        static void Main(string[] args)
        {
            List<Train> li = new List<Train>();
            li.Add(new Train(2015, "chennai Express", 300));
            li.Add(new Train(2020, "Maharashtra Express", 350));
            li.Add(new Train(2010, "Goa Express", 260));
            li.Add(new Train(2013, "Nijauddin Express", 350));

            foreach (Train e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.seats);
            }
            Console.WriteLine("...................................");

            li.Sort(new SortbySeats());
            foreach (Train e in li)
            {
                Console.WriteLine(e.id + " " + e.name + " " + e.seats);
            }
        }
    }

    class SortString
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>()
            {
                "Pune",
                 "Mumbai",
                 "Banglore",
                  "Goa",
                 "Nasik"
            };
            foreach (string st in li)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine(".................Sorted list.........");
            li.Sort();
            foreach (string st in li)
            {
                Console.WriteLine(st);
            }
        }
    }

    class Marks
    {
        public int maths;
        public int eng;
        public int sci;
        public int comp;

        public Marks(int maths, int eng, int sci, int comp)
        {
            this.maths = maths;
            this.eng = eng;
            this.sci = sci;
            this.comp = comp;

        }
    }
    class Students02
    {
        public int id;
        public string name;
        public List<Marks> al;
        public Students02(int id, string name, List<Marks> al)
        {
            this.id = id;
            this.name = name;
            this.al = al;
        }
    }

    class CustomListStud
    {
        static void Main(string[] args)
        {
            List<Students02> li = new List<Students02>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                List<Marks> em = new List<Marks>();
                Console.WriteLine("Enter the details of employee");
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("Enter maths marks:");
                    int maths = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter maths eng:");
                    int eng = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maths sci:");
                    int sci = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter maths comp:");
                    int comp = int.Parse(Console.ReadLine());


                    em.Add(new Marks(maths, eng, sci, comp));
                }
                li.Add(new Students02(id, name, em));
            }
            Console.WriteLine(".................................................");
            foreach (var d in li)
            {
                Console.WriteLine(d.id + " " + d.name + " ");
                foreach (var e in d.al)
                {
                    Console.Write(" " + e.maths + " " + e.eng + " " + e.sci + " " + e.comp);
                }
            }
            Console.WriteLine();
        }
    }
}

