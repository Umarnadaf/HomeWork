using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Preparation
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            for(int i = 0,j=arr.Length/2; i < arr.Length / 2; i++,j++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }

    class prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Size of Array");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element of array");
            int[] arr = new int[s];
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for(int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count = 1;
                        break;
                    }
                }
                if(count == 0)
                {
                    Console.WriteLine(" Prime Elements are "+arr[i]);
                }
               
                
            }
        }
    }

    class SPrime
    {
        static void Main(string[] args)
        {
            int a = 9;
            int count = 0;
            for(int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
               
            }
            if (count == 2)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine( "Not prime");
            }
           
        }
    }
    class fact
    {
        static void Main(string[] args)
        {
            int a = 5;
            int fact = 1;
            for(int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }

    class PallindromeNum
    {
        static void Main(string[] args)
        {
            int n = 12321;//
            int temp = n;
            int t = 0;
            int sum = 0;
            while (n > 0)
            {
                t = n % 10;
                sum = (10 * sum) + t;
                n = n / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine("Pallindrom");
            }
            else
            {
                Console.WriteLine("Not Pallindrom");
            }
        }
    }

    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 strings");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }

        }
    }

    class stringRev
    {
        static void Main(string[] args)
        {
            string str1 = " hello world";
            string str2 = " ";
            for(int i = str1.Length - 1; i > 0; i--)
            {
                str2 += str1[i];
            }
            Console.WriteLine(str2);
        }
    }
    class dispEve
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

    class po_neg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            Console.WriteLine("Enter The Element");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            int[] pos = new int[a];
            int[] neg = new int[a];
            int p=0, n = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    pos[p++] = arr[i];

                }
                else
                {
                    neg[n++] = arr[i];
                }
            }
            Console.WriteLine("\npos");
            for(int i = 0; i < p; i++)
            {
                Console.Write(pos[i]+" ");
            }
            Console.WriteLine("\nneg");
            for (int i = 0; i < n; i++)
            {
                Console.Write(neg[i]+" ");
            }
        }
    }

    class replace
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            Console.WriteLine("Enter replace charachter");
            char ch = char.Parse(Console.ReadLine());
            string strop = " ";
            foreach(char str in str1)
            {
                if (str == 'a' || str == 'A' || str == 'e' || str == 'E' || str == 'i' || str == 'I' || str == 'o' || str == 'O' || str == 'u' || str == 'U')
                {
                     strop += ch;
                }
                else
                {
                    strop += str;
                }

            }
            Console.WriteLine(strop);
        }
    }
}
