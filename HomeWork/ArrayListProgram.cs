using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "Umar",
                118,
                100.10,
                'U',
                146151894,

            };

            for (int i = 0; i < al.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(al[i] + "  ");
                }
            }
        }
    }
    class TaskArryList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string Array");
            string[] str = new string[6];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i].Length > str[j].Length)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                    else if (str[i].Length == str[j].Length)
                    {
                        if (str[i].CompareTo(str[j]) < 1)
                        {
                            string temp = str[i];
                            str[i] = str[j];
                            str[j] = temp;
                        }
                    }
                }
            }

            Console.WriteLine("Sorted Array");
            foreach (string name in str)
            {
                Console.WriteLine(name);
            }
        }
    }

    class DupArray
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
             al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");


            for (int i = 0; i < al.Count; i++)
            {
                for(int j = i+1; j < al.Count; j++)
                {
                    if (al[i].Equals(al[j]))
                    {
                        al.RemoveAt(j);
                        j--;
                    }
                }
            }
            foreach(string str in al)
            {
                Console.WriteLine(str+" ");
            }
        }
    }

    class SortArray
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList()
            {
                "India","Umar","Happy","New","Year"
            };
            for(int i = 0; i < al.Count; i++)
            {
                for(int j = i + 1; j < al.Count; j++)
                {
                    if (al[i].ToString().CompareTo(al[j].ToString()) < 1)
                    {
                        var temp = al[i];
                        al[i] = al[j];
                        al[j] = temp;
                    }
                }
            }
            foreach(var s in al)
            {
                Console.WriteLine(s+" ");
            }
        }
    }

}
