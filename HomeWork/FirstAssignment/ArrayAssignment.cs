using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.FirstAssignment
{
    class ArrayAssignment//average of array index
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The size of Array");            
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] arr = new int[s];
            Console.WriteLine("Enter The Element");
            for(int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Elements Are");
            for(int i = 0; i < s; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for(int i = 0; i < s; i++)
            {
                sum += arr[i];
                
            }
            int avg = sum / arr.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
    }

    class Search
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The size of Array");
            int s = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] arr = new int[s];
            Console.WriteLine("Enter The Element");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Elements Are");
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("Enter the number you have to find");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                if (arr[i] == n)
                {
                    Console.WriteLine("number is present at " + " " + i);
                }
            }
        }
    }

    class SumPairs
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == 7)
                    {
                        Console.WriteLine(arr[i]+" "+arr[j]);
                    }
                }
            }
        }
    }
    class Evenodd
    {
        static void Main(string[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());

            int[] ar = new int[s];
            Console.WriteLine("Enter array");
            for (int i = 0; i < s; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }


            int[] even = new int[s];
            int[] odd = new int[s];
            int e, o;
            e = 0;
            o = 0;
            for (int i = 0; i < s; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    even[e++] = ar[i];

                }
                else
                {
                    odd[o++] = ar[i];

                }
            }

            Console.WriteLine("Even array : ");
            for (int i = 0; i < e; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < o; i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
    }


   
}

