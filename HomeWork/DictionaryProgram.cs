using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class DictionaryProgram
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            {
                li.Add("Pune");
                li.Add("Mumbai");
                li.Add("kolkata");
                li.Add("Hydrabad");
                li.Add("Pune");
            };

            for (int i = 0; i < li.Count; i++)
            {
                int cnt = 1;
                bool flag = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (li[i] == li[j])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int k = i + 1; k < li.Count; k++)
                    {
                        if (li[i] == li[k])
                        {
                            cnt++;
                        }
                    }
                    Console.WriteLine(li[i] + "  " + cnt);
                }
            }
        }
    }

    class EmployeeList
    {
        public int eid;
        public string ename;
        public int salary;

        public EmployeeList(int eid, string ename, int salary)
        {
            this.eid = eid;
            this.ename = ename;
            this.salary = salary;
        }
    }
    class EqualCheck : IEqualityComparer<EmployeeList>
    {
        bool IEqualityComparer<EmployeeList>.Equals(EmployeeList x, EmployeeList y)
        {
            return x.eid == y.eid && x.ename == y.ename;
        }
        int IEqualityComparer<EmployeeList>.GetHashCode(EmployeeList obj)
        {
            return obj.eid;
        }
    }
    class CustomDictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<EmployeeList, string> emp = new Dictionary<EmployeeList, string>(new EqualCheck());
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter Employee id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary:");
                int salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Dept Name:");
                string deptname = Console.ReadLine();
                EmployeeList e = new EmployeeList(id, name, salary);
                if (emp.ContainsKey(e))
                {
                    Console.WriteLine("Already Present");
                }
                else
                {
                    emp.Add(e, deptname);
                }
            }

            foreach (KeyValuePair<EmployeeList, string> dm in emp)
            {
                EmployeeList em = dm.Key;
                Console.WriteLine(em.eid + "  " + em.ename + "  " + em.salary + "  " + dm.Value);
            }
        }
    }

    class Department_
    {
        public int deptId;
        public string deptName;
        public Department_(int dId, string dName)
        {
            this.deptId = dId;
            this.deptName = dName;
        }
    }
    class Employee_
    {
        public int eId;
        public string eName;
        public Department_ edept;

        public Employee_(int eId, string eName, Department_ eDept)
        {
            this.eId = eId;
            this.eName = eName;
            this.edept = eDept;
        }
    }

    class ListEmpTask
    {
        static void Main(string[] args)
        {
            List<Employee_> li = new List<Employee_>();
            li.Add(new Employee_(101, "Nikhil", new Department_(10, "HR")));
            li.Add(new Employee_(106, "Abhishek", new Department_(30, "Sales")));
            li.Add(new Employee_(105, "Yash", new Department_(20, "HR")));
            li.Add(new Employee_(103, "Ritesh", new Department_(10, "Sales")));
            li.Add(new Employee_(102, "Pramod", new Department_(20, "Sales")));

            for (int i = 0; i < li.Count; i++)
            {
                for (int k = 0; k < li.Count; k++)
                {
                    if (li[i].eName.Equals("Nikhil") && li[k].edept.deptName.Equals(li[i].edept.deptName))
                    {
                        Console.WriteLine(li[k].eName + "  ");
                    }
                }
            }
        }
    }

    class Shipment
    {
        public int sid;
        public int sorder;

        public Shipment(int sid, int sorder)
        {
            this.sid = sid;
            this.sorder = sorder;
        }
        public void DisplayOrder()
        {
            Console.Write("\t" + sid + "  " + sorder );
        }
    }
    class MyDate 
    {
        public int dd;
        public int mm;
        public int yy;

        public MyDate(int dd,int mm,int yy)
        {
            this.dd = dd;
            this.mm = mm;
            this.yy = yy;
        }
        public void DisplayMydate()
        {
            Console.Write("\t" + dd + '/' + mm + '/' + yy);
        }
    }

    class Customer : IComparable<Customer>
    {
        public int cid;
        public string cname;
        public string city;
        public Shipment cshipment;
        public MyDate cmyDate;

        public Customer(int cid,string cname,string city, Shipment cshipment, MyDate cmyDate)
        {
            this.cid = cid;
            this.cname = cname;
            this.city = city;
            this.cshipment = cshipment;
            this.cmyDate = cmyDate;
        }

        int IComparable<Customer>.CompareTo(Customer other)
        {
            if (this.city.Equals(other.city))
            {
                return this.cmyDate.dd - other.cmyDate.dd;
            }
            else
            {
                return this.city.CompareTo(other.city);
            }
        }
        public void DisplayShipment()
        {
            Console.Write("\t" + cid + "  " + cname + " " + city);
            cshipment.DisplayOrder();
            cmyDate.DisplayMydate();
            Console.WriteLine();
        }

    }

    class ListTaskSort
    {
        static void Main(string[] args)
        {
            List<Customer> li = new List<Customer>();
            {
                li.Add(new Customer(101, "Umar", "Pune", new Shipment(10, 55), new MyDate(20, 12, 2022)));
                li.Add(new Customer(102, "Bhushan", "Pune", new Shipment(11, 60), new MyDate(22, 12, 2022)));
                li.Add(new Customer(103, "Omkar", "Mumbai", new Shipment(12, 70), new MyDate(23, 12, 2022)));
                li.Add(new Customer(104, "Prathmesh", "Miraj", new Shipment(13, 80), new MyDate(24, 12, 2022)));
            }

            li.Sort();
            foreach(Customer s in li)
            {
                s.DisplayShipment();
            }
        }
    }
}
