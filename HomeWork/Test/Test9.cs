using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class SortedList
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                9,6,3,2,5,8,7,1,10
            };

            for(int i = 0; i < li.Count; i++)
            {
                for(int j = i + 1; j < li.Count; j++)
                {
                    if (li[i] < li[j])
                    {
                        var temp = li[i];
                        li[i] = li[j];
                        li[j] = temp;
                    }
                }
            }
            foreach(var l in li)
            {
                Console.WriteLine(l+" ");
            }
        }
    }

    class DuplicateElement
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>()
            {
                9,6,3,2,5,8,7,1,10,9,5
            };

            for(int i = 0; i < li.Count; i++)
            {
                for(int j = i + 1; j < li.Count; j++)
                {
                    if (li[i].Equals(li[j]))
                    {
                        li.RemoveAt(j);
                    }
                }
            }
            foreach(var s in li)
            {
                Console.WriteLine(s+" ");
            }
        }
    }

    class pairs
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 5, -10, 8, 5, 20 };
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++) 
                {
                    if (arr[i] + arr[j] == 10)
                    {
                        Console.WriteLine(arr[i]+" + "+arr[j]+" = 10");
                    }
                }
            }
        }
    }
    class Dipartment
    {
        public int did;
        public string dname;

        public Dipartment(int did,string dname)
        {
            this.did = did;
            this.dname = dname;
        }
    }
    class Emp
    {
        public int empno;
        public string ename;
        public Dipartment dipartment;

        public Emp(int empno,string ename,Dipartment dipartment)
        {
            this.empno = empno;
            this.ename = ename;
            this.dipartment = dipartment;
        }

    }
    class Work
    {
        static void Main(string[] args)
        {
            List<Emp> li = new List<Emp>();
            {
                li.Add(new Emp(10, "Umar", new Dipartment(01, "HR")));
                li.Add(new Emp(20, "Omkar", new Dipartment(02, "RND")));
                li.Add(new Emp(30, "Prathmesh", new Dipartment(03, "Sales")));
                li.Add(new Emp(40, "Bhushan", new Dipartment(04, "HR")));
            }
            for(int i = 0; i < li.Count; i++)
            {
                if (li[i].empno == 10)
                {
                    for(int j = i + 1; j < li.Count; j++)
                    {
                        if (li[i].dipartment.dname.Equals(li[j].dipartment.dname))
                        {
                            li.RemoveAt(j);
                        }
                    }
                }
            }
            foreach(var e in li)
            {
                Console.WriteLine(e.empno+" "+e.ename+" "+e.dipartment.did+" "+e.dipartment.dname);
            }
        }
    }
}
