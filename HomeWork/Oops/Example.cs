using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oops
{
    class Example
    {
        static void Main(string[] args)
        {
            string str = "India Is My Country";
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

    class DuplicateWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            str = str.ToLower();
            Console.WriteLine("The string is = " + str);
            string[] str1 = str.Split(" ");
            for (int i = 0; i < str1.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < str1.Length; j++)
                {
                    if (str1[i].Equals(str1[j]))
                    {
                        count++;
                        str1[j] = "0";
                    }
                }
                if (count > 0 && str1[i] != "0")
                {
                    Console.WriteLine(count + " " + str1[i]);
                }
            }
        }
    }

    class CountWords
    {
        static void Main(string[] args)
        {
            string str = "Welcome to prgramming word";
            Console.WriteLine(str);
            int count = 0;
            string[] str1 = str.Split(" ");
            foreach (string s in str1)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }

    /*class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();

            if (ch1.Length == ch2.Length)
            {
                Array.Sort(ch1);
                Array.Sort(ch2);
                Console.WriteLine(string.Join(" ", ch1));
                Console.WriteLine(string.Join(" ", ch2));
                string str = new string(ch1);
                string str1 = new string(ch2);
                Console.WriteLine(str + " " + str1);
                if (str.Equals(str1))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
            static void Main(string[] args)
            {
                Console.WriteLine("Enter first String");
                string str = Console.ReadLine();
                Console.WriteLine("Enter Second String");
                string str1 = Console.ReadLine();

                bool flag = Anagram.IsAnagram(s1, s2);
                Console.WriteLine(flag);

                if (flag)
                {
                    Console.WriteLine("Both String is Anagram");
                }
                else
                {
                    Console.WriteLine("not Anagram");
                }
            }
        
    }*/
    class Anagram
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first word:");
            string str1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }

    }

    class DecArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter Array Element ");
            for (int i = 0; i <arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Array.Sort(arr);         
            Array.Reverse(arr);
            foreach(int val in arr)
            {
                Console.Write(val+" ");
            }
        }
    }

    class MultyChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            int alphabet, digit, specialcharacter,i;
            alphabet = digit = specialcharacter=i = 0;
               
            while(i<str.Length)
            {
                if((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialcharacter++;
                }

                i++;
            }
            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialcharacter);
        }
    }

    class CaseConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            Console.WriteLine("Upper case "+str);
            Console.WriteLine(str.ToLower());
        }
    }

    class ReversArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 90, 45, 29, 37, 78 };
            Console.Write("The Array is\n");
            foreach(int val in arr)
            
                Console.Write(val+" ");
            
            Array.Reverse(arr);
            Console.WriteLine("\nRevers Array");
            foreach (int word in arr)
                
                Console.Write(word+" ");
            
        }
    }

    class Ascending
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 3, 2, 5, 8, 1, 4, 7, 0 };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending order");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }

    class ReplaceNo
    {
        static void Main(string[] args)
        {
            int[] arr = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int no = 0;
            int no1 = 1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == no)
                {
                    arr[i] = no1;
                }
            }
            Console.WriteLine("\nModifyde Array is\n");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }

  /*  class NegReplace
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i]
                }
            }
        }
    }*/
}
