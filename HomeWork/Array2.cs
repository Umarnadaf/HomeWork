using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class ArrayRepeat
    {
        static void Main(string[] args)
        {
            int i, j;
            //Console.WriteLine("Enter array 1 size:");
            int size1 = 5;
            Console.WriteLine("Enter 5 elements of first array:");
            int[] arr1 = new int[size1];
            for (i = 0; i < size1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine("Enter array 2 size:");
            int size2 = 5;
            Console.WriteLine("Enter 5 elements of second array:");
            int[] arr2 = new int[size2];
            for (i = 0; i < size2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] arr3 = new int[arr1.Length + arr2.Length];
            int k = 0, cnt;
            for(i=0;i< arr1.Length; i++)
            {
                cnt = 0;
                for( j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr1[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr1[i];
                    k++;

                }
            }
            for (i = 0; i < arr2.Length; i++)
            {
                cnt = 0;
                for (j = k - 1; j >= 0; j--)
                {
                    if (arr3[j] == arr2[i])
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0)
                {
                    arr3[k] = arr2[i];
                    k++;

                }
            }
            Console.WriteLine("concatinated array is  = ");
            for (i = 0; i < k; i++)
            {
                Console.Write(arr3[i]+" ");
            }
        }
    }

    class Sort
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < size - 1; i++)
            {
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("Sorted Array is = ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class UpperLowerCase
    {
        static void Main(string[] args)
        {
            char[] str = new char[] { 'D', 'b', 'R', 'z', 'e' };
            Console.WriteLine("Data is");
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);

            }
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                {
                    str[i] = (char)(str[i] + 32);
                }
                else {
                    str[i] = (char)(str[i] - 32);
                }
            }
            Console.WriteLine("\n converted Data is");
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }

        }
    }

    class CopyMethod
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 15, 62, 52, 23 };
            Console.WriteLine("Lenght of Array is = "+ list.Length);

            int[] temp = list;
            int[] t = new int[list.Length];
            Array.Copy(list, t, list.Length);
            Console.WriteLine("Copyed Array ");
            foreach(int i in t)
            {
                Console.Write(i+" ");
            }
        }
    }

    class ReversArray
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 15, 62, 52, 23 };
            Console.WriteLine("Lenght of Array is = " + list.Length);
            int[] temp = list;
            int[] t = new int[list.Length];

            Console.WriteLine("Original Array");
            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            //revers Array
            Array.Reverse(temp);
            Console.Write("Reversed Array = ");

            foreach(int i in list)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();

            // sort the array
            Array.Sort(list);
            Console.Write("sorted  Array = ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
    }

    class IndexOfArray
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 15, 62, 52, 23 };
            Console.WriteLine("Lenght of Array is = " + list.Length);
            int[] temp = list;
            int[] t = new int[list.Length];

            int indx = Array.IndexOf(list, 13);
            Console.WriteLine("Index of element of 13 is "+ indx);

            // clear Element

            Array.Clear(list,3,3);
            Console.Write("clear  Array = ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }

    class EqualArray
    {
        static void Main(string[] args)
        {
            int[] a1= { 1, 2, 3, 4, 5 };
            int[] a2 = a1;

            if (Array.Equals(a1, a2))
            {
                Console.WriteLine("Array Are Equal");
            }
            else
            {
                Console.WriteLine("Array Not Equal");
            }


        }
    }

}
