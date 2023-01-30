using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oops
{
    class Indexer
    {
        class MyIndexer
        {
            int[] count = new int[5];
            public int this[int i]
            {
                get { return count[i]; }
                set { count[i] = value; }
            }
        }
            static void Main(string[] args)
            {
                MyIndexer obj = new MyIndexer();
                obj[0] = 10;
                obj[1] = 20;
                obj[2] = 30;
                obj[3] = 40;
                obj[4] = 50;

                for (int i = 0; i < 5; i++)
                    Console.Write(obj[i] + " ");
                Console.ReadKey();
            }
        

    }

    class Stringbuilder
    {
        static void Main(string[] args)
        {
            string str = "jayu";
            string str1 = "jayu";
            Console.WriteLine("Reference for str: " + str.GetHashCode());
            Console.WriteLine("Reference for str: " + str1.GetHashCode());
            str = str + " Dhumal";
            Console.WriteLine("Reference for str: " + str.GetHashCode());
            Console.WriteLine("Reference for str: " + str1.GetHashCode());
            str = str + " Dhumal";
            str = str + " Engineer";
            str = str + " Lives in Pune";
            str = str + " Is a kind hearted person";
            Console.WriteLine("Reference for str: " + str.GetHashCode());
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World");
            Console.WriteLine("Reference for sb: " + str.GetHashCode());
            sb.Append(" C#");
            sb.Append(" Programming");
            Console.WriteLine("String is: " + sb.ToString());
            Console.WriteLine("Reference for sb: " + str.GetHashCode());
            //no new reference is created in this way stringbuilder is mutable
        }
    }

    internal class StringProgram
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("string length is = " + str);
            int len = 0;
            foreach (char ch in str)
            {
                Console.Write(ch);
                len++;
            }
            Console.WriteLine();
            Console.WriteLine("String length is = " + len);

        }
    }

    internal class StringProgram2
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine("string length is = " + str);
            Console.WriteLine("String length is = " + str.Length);
            
            Console.WriteLine("Enter Any character");
            char ch = char.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                    count++;
            }
            if (count == 0)
            {
                Console.WriteLine("Character is not present");
            }
            else
            {
                Console.WriteLine("Character is {0} present " + count);
            }

        }
    }

    class StringReverse
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            Console.WriteLine("String is=" + str);

            string strRev = "";
            for (int i = str.Length-1 ; i > 0; i--)
                strRev = strRev + str[i];

            Console.WriteLine("String is reverse order is " + strRev);
            Console.ReadKey();
        }
    }

    class VowelCount
    {
        public static void Main()
        {
            string myStr;
            int i, len, vowel, cons;
            myStr = "Hello World";
            vowel = 0;
            cons = 0;


            len = myStr.Length;
            for (i = 0; i < len; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    vowel++;
                }
                else
                {
                    cons++;
                }
            }
            Console.WriteLine("Vowels in the string:{0}", vowel);
        }
    }

    class wordcount
    {
        public static void Main()
        {
            string input = "Hello World";
            int spaces = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.WriteLine("SPACES: " + spaces);
        }
    }

    class Split
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("String is=" + str);
            char[] ch = new char[4];

            string[] strArr = str.Split(' ');
            Console.WriteLine("No of string present in{0} is {1}", str, strArr.Length);

            foreach (string str2 in strArr)
                Console.WriteLine(str2);

            Console.ReadKey();
        }
    }

    class idex
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine("String is=" + str);
            char ch = char.Parse(Console.ReadLine());
            for (int i = 0; i <= str.Length; i++)
            {
                if (ch == str[i])
                {
                    Console.WriteLine("index is " + i);
                    break;
                }
            }
        }
    }
    class StringPrograms1
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            Console.WriteLine("String is := " + str);
            //contains
            Console.WriteLine("Enter string to be found in present string := ");
            string strToFound = Console.ReadLine();

            bool isPresent = str.Contains(strToFound);
            if (isPresent)
                Console.WriteLine(strToFound + "is present in str");
            else
                Console.WriteLine(strToFound + " is not present in str");
            Console.ReadKey();
        }
    }


    class StringCombine
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            string str = "";
            foreach (char ch in str1)
                str = str + ch;

            foreach (char ch in str2)
                str = str + ch;

            Console.WriteLine("Concatinated string is " + str);
            Console.ReadKey();
        }
    }
    class Concanate1
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            foreach (char ch in str2)
            {
                str1 = str1 + ch;
            }
            Console.WriteLine("Concinated string is: " + str1);
        }
    }
    class StringProgra
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "Programming";

            string[] strArr = new string[3];
            strArr[0] = str1;
            strArr[1] = str2;
            strArr[2] = str3;

            string str = string.Concat(strArr);

            Console.WriteLine("Concatinated string is" + str);
            Console.ReadKey();
        }
    }

    class IndexofMethod
    {
        static void Main(string[] args)
        {
            string str = "Hello World Programming";
            string str1 = "World";

            int position = str.IndexOf(str1);
            Console.WriteLine("string {0} is present at {1} location", str1, position);
            Console.ReadKey();

        }
    }
    class CompareMethod
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            int comparison = string.Compare(str1, str2);

            if (comparison == 0)
                Console.WriteLine("Both the strings are equal");
            else
                if (comparison < 0)
                Console.WriteLine("less than 0 first string precedes thebsecond string in sort order");
            else
                Console.WriteLine("greater than 0 first string follows the second string in sort order");
            Console.ReadKey();



        }
    }

    class Copy
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "";

            str2 = string.Copy(str1);

            Console.WriteLine("Copied string is" + str2);
            Console.ReadKey();
        }
    }

    class StringPallindrom
    {
        static void Main(string[] args)
        {
            string str, reversestr = string.Empty;
            Console.Write("Enter a string : ");
            str = Console.ReadLine();
            if (str != null)
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversestr += str[i].ToString();
                }
                if (reversestr == str)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", str, reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", str, reversestr);
                }
            }
        }
    }
    class Department
    {
        string name;
        int id;

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void displayDepartment()
        {
            Console.WriteLine(id + " " + name);
        }

    }
    class Employee
    {
        string name;
        int salary;
        Department dep;

        public Employee(string name,int salary,Department dep)
        {
            this.name = name;
            this.salary = salary;
            this.dep = dep;

        }
        public void DisplayEmployee()
        {
            Console.WriteLine(name+" "+salary+" ");
            dep.displayDepartment();
        }
        static void Main(string[] args)
        {
            Employee e = new Employee("umar", 50000, new Department(01, "IT"));
            e.DisplayEmployee();
        }
    }

    class Abbreviate
    {
        // name to abbrevation
        public static string Abbr(string s)
        {
            string[] str = s.Split();
            string abbrevation = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Char[] Word = str[i].ToCharArray();
                    for (int j = 0; j < 1; j++)
                    {
                        if (j == 0)
                        {
                            abbrevation = abbrevation + Word[j] + ". ";
                        }
                    }
                }
                else
                {
                    abbrevation = abbrevation + str[i];
                }
            }
            return abbrevation;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            Console.WriteLine(" " + str);
            Console.WriteLine("Abbrivated Name: " + Abbreviate.Abbr(str));
        }
    }

}




