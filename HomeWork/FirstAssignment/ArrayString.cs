using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.FirstAssignment
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine($"enter {arr.Length} elements in array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());


            }

            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            Console.WriteLine("Max=" + max);




        }
    }

    class Class2
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Length={arr.Length}");
            int[,] arr2d = new int[3, 4];



            Console.WriteLine($"Length of 2d array={arr2d.Length}");
            Console.WriteLine("rows " + arr2d.GetLength(0));
            Console.WriteLine("cols " + arr2d.GetLength(1));

            for (int r = 0; r < arr2d.GetLength(0); r++)
            {
                Console.WriteLine("enter elements for row " + r);

                for (int c = 0; c < arr2d.GetLength(1); c++)
                {
                    arr2d[r, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int r = 0; r < 3; r++)
            {

                for (int c = 0; c < 4; c++)
                {
                    Console.Write(arr2d[r, c] + " ");


                }
                Console.WriteLine();
            }

            //2X3
            float[,] a2 = { {2.3f,4.5f,7.8f},
                            {3.3f,5.5f,6.8f}
            };


        }
    }

    class Class3
    {
        static void Main(string[] args)
        {
            //jagged array where no of cols in each row are different
            int[][] jarr = new int[3][];
            jarr[0] = new int[3];
            jarr[1] = new int[2];
            jarr[2] = new int[5];

            for (int r = 0; r < jarr.GetLength(0); r++)
            {
                Console.WriteLine($"Enter {jarr[r].Length} elements for row {r}");
                for (int c = 0; c < jarr[r].Length; c++)
                {
                    jarr[r][c] = int.Parse(Console.ReadLine());


                }

            }

            for (int r = 0; r < jarr.GetLength(0); r++)
            {

                for (int c = 0; c < jarr[r].Length; c++)
                {
                    Console.Write(jarr[r][c] + " ");
                }
                Console.WriteLine();

            }
        }
    }

    class Class4
    {
        static void Main(string[] args)
        {
            /* string s = "ThinkQuotient";
             string ss = "ThinkQuotient";
             //literal intern pool which stores unique string  object 
             string s2 = new string("riya");  //on heap
             string s4 = new string("riya");
             Console.WriteLine(s2==s4);
             Console.WriteLine(object.ReferenceEquals(s2,s4));
             Console.WriteLine("***************");
             Console.WriteLine(s == ss);
             Console.WriteLine(object.ReferenceEquals(s, ss));
             //operator overloading
             //==
             int a = 10, b = 90;
             // Console.WriteLine(a==b);*/


            //String str = "dasd";

            string s = "sonal"; //immutable 
            string s2 = s + "patil";
            s = s.ToUpper();
            string str = "  PRIYA  ";
            Console.WriteLine(str.Length);
            str = str.Trim();
            str = str.ToLower();
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(str);
            string sr = s2.Replace('a', 'u');
            Console.WriteLine(sr);
            Console.WriteLine(s2.Substring(5));
            Console.WriteLine(s2.Substring(5, 3));
            string str2 = "my name is priya";
            string[] arr = str2.Split();
            char[] carr = str2.ToCharArray();


            foreach (string sss in arr)
                Console.WriteLine(sss);

            string nm1 = new string("priya");
            string nm2 = "priya";
            Console.WriteLine(nm1 == nm2);
            Console.WriteLine(nm1.Equals(nm2));
            Console.WriteLine("deepa".CompareTo("diya"));

            Console.WriteLine("enter ur name");
            string name = Console.ReadLine();
            int v = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                    v++;
            }
            Console.WriteLine("No of vowels " + v);


            foreach (char ch in name)
                Console.WriteLine(ch);

            //str1==str2=0
            //str1<str2 return -1
            //str1>str2 return +1







            Console.WriteLine(str.Length);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];

            Console.WriteLine($"Enter {arr.Length} elements ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // int[] arr = { 11, 12,13, 14, 15 };
            /*for(int i=0;i<arr.Length;i++)
           Console.WriteLine(arr[i]);


            foreach(int data in arr)
               Console.WriteLine(data);
*/

            for (int i = arr.Length - 1; i >= 0; i--)
                Console.WriteLine(arr[i]);


            char[] arr2 = new char[10];
            char[] arr3 = { 'a', 'b', 'c', 'e' };
            char[] arr4 = new char[] { 'e', 's', 'h', 'a', 'n' };

            string[] names = new string[5];
            Console.WriteLine("enter 5 names");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            foreach (string s in names)
                Console.WriteLine(s);



        }
    }
}
