using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class Test_8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            string str2 = Console.ReadLine();

            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1=new string (ch1);
            string val2 = new string(ch2);

            if(val1 == val2)
            {
                Console.WriteLine("both Are Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }
        }
    }

    class Pattern
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                string str = "ESHAN";
                Console.WriteLine(str);
                string[] str1 = str.Split();
                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(str1[j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
