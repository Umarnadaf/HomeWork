using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Prep
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            // 456123
            int count = 0;

            for (int i = 0,j=array.Length/2; i < array.Length/2; i++,j++)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;

                count++;
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }
    }

    class Primec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int a = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter The Elements of array");
            int[] arr = new int[a];
            for (int i = 0; i < a; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for(int j = 2; j <= arr[i]/2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count=1;
                        break;
                    }
                }
                if(count == 0)
                {
                    Console.WriteLine("Prime Numbers are"+arr[i]);
                }
            }
        }
    }

    class Tableof
    {
        static void Main(string[] args)
        {
            int i = 1, j = 1;
            while (i <= 10)
            {
                j = 1;
                while (j <= 10)
                {
                    Console.WriteLine( i * j);
                    j++;
                }
                i++;
            }
            Console.WriteLine();
        }
    }

    class mod
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 6, 5, 10, 12, 14, 16, 18, 20 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[i] += 1;
                }
                else
                {
                    array[i] += 3;
                }
                Console.Write(array[i]+" ");
            }
        }
    }

    //write code findout the common even element from 2 array and calculate the sum.

    class EvenComm
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = {5,2,8,3,7,9};
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr2.Length; j++)
                {
                    if(arr[i]==arr2[j] && arr[i] % 2 == 0)
                    {
                        Console.WriteLine(arr[i]+" ");
                        sum = arr[i] + arr2[j] ;
                        break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sum = "+sum);
        }
    }

    class strPalindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string str1 = "";
            for(int i =ch.Length-1; i>= 0; i--)
            {
                str1 += ch[i];
            }
            if (str == str1)
            {
                Console.WriteLine("pallindrom");
            }
            else
            {
                Console.WriteLine("Not pallindrom");
            }
            
        }
    }
}



