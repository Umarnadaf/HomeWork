using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Studentx
    {
        public int id;
        public string name;
        public int marks;

        public Studentx(int id,string name,int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;

        }
    }
    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<Studentx> q = new Queue<Studentx>();
            {
                q.Enqueue(new Studentx(101, "Umar", 95));
                q.Enqueue(new Studentx(101, "omkar", 90));
                q.Enqueue(new Studentx(101, "prathmesh", 60));
                q.Enqueue(new Studentx(101, "bhushan", 50));
            }

            foreach(var x in q)
            {
                if (x.marks >=60)
                {
                    Console.WriteLine( x.id+" "+x.name+" "+x.marks);
                }
            }
            
        }
    }
}