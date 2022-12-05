using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array data is");
            /*  arr[0] = 1;
              arr[1] = 2;
              arr[2] = 3;
              arr[3] = 4;*/
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }

    class Arrays
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Array Data Is");
            for (int i = 0; i < 5; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("Array in reverse order");
            for (int i = 4; i >= 0; i--)
                Console.Write(arr[i] + " ");
        }
    }

    class Array2
    {
        static void Main(string[] args)
        {
            int size;
            int sum = 0;
            Console.WriteLine("Enter The Size Of Array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("you enter " + size);
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array Data addition Is");
            for (int i = 0; i < size; i++)
            {

                sum += arr[i];
            }
            Console.Write(sum);
        }
    }

    class Addeven
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array Data Is");
            for (int i = 0; i < 5; i++)
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            Console.Write(sum);
        }
    }

    class CopyArray
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[5];
            Console.WriteLine("Enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
                arr1[i] = arr[i];
            Console.WriteLine("copy array");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr1[i] + " ");

        }
    }

    class Presentno
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());
            int no, cnt = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    cnt++;
            if (cnt == 0)
            {
                Console.WriteLine(no + " Number Is Not Present");
            }
            else
            {
                Console.WriteLine(no + " Present" + cnt + "Times");
            }

        }
    }

    class UpdateNo
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int no, cnt = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());

            int no1;
            Console.WriteLine("Enter any number to replace");
            no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    arr[i] = no1;
            Console.WriteLine("Modified Array is");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }


        }
    }

    class Delete
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to find in array:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (arr[i] == a)
                {
                    arr[i] = 0;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
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

    class SumAdd
    {
        static void Main(string[] args)
        {
            int size;
            int sum = 0;
            Console.WriteLine("Enter The Size Of Array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("you enter " + size);
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array alternet Data addition Is");
            for (int i = 0; i < size; i = i + 2)
            {

                sum += arr[i];
            }
            Console.Write(sum);
        }
    }

    class InsertArrayElement
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter The Size Of Array");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("you enter " + size);
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int pos, element;
            Console.WriteLine("Enter Position Where element inserted = ");
            pos = int.Parse(Console.ReadLine());
            if (pos <= size && pos != 0)
            {
                Console.WriteLine("Enter Element insert to be at position = " + pos);
                element = int.Parse(Console.ReadLine());
                arr[pos - 1] = element;
                Console.WriteLine("Revised Array is = ");
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(arr[i] + " ");
                }

            }
            else
            {
                Console.WriteLine("invalid Array index out of range");
            }
        }
    }

    class Search
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("Enter 5 element");
            for (int i = 0; i < 5; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int no, cnt = 0;
            Console.WriteLine("Enter any number");
            no = int.Parse(Console.ReadLine());

            int no1;
            Console.WriteLine("Enter any number to replace");
            no1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 4; i++)
                if (arr[i] == no)
                    arr[i] = no1;
            Console.WriteLine("Modified Array is");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }


        }
    }

    class Occurance
    {
        static void Main(string[] args)
        {


            int size;
            Console.WriteLine("Enter size of array := ");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter " + size + " elements in array := ");
            for (int i = 0; i < size; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Boolean[] found = new Boolean[size];
            for (int i = 0; i < size; i++)
                found[i] = false;


            for (int i = 0; i < size; i++)
            {
                if (found[i] == true)
                    continue;

                int cnt = 1;
                for (int j = i + 1; j < size; j++)

                    if (arr[i] == arr[j])
                    {
                        found[j] = true;
                        cnt++;
                    }

            }
            Console.WriteLine();
        }
    }

    class PosNeg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sizie of array");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];
            Console.WriteLine("Enter Array element");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] pos = new int[s];
            int[] neg = new int[s];
            int p = 0, n = 0;
            for (int i = 0; i < s; i++)
            {
                if (arr[i] > 0)
                {
                    pos[p++] = arr[i];

                }
                else
                {
                    neg[n++] = arr[i];

                }
            }
            Console.WriteLine("Positive array : ");
            for (int i = 0; i < p; i++)
            {
                Console.Write(pos[i] + " ");
            }

            Console.WriteLine("\nOdd array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(neg[i] + " ");
            }
        }
    }

    class SearchArrayIndex
    {
        static void Main(string[] args)
        {
            int count = 0, i;
            Console.WriteLine("Enter the size of array:");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array " + s + " elements:");
            int[] arr = new int[s];
            for (i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element you want to search:");
            int n = int.Parse(Console.ReadLine());

            for (i = 0; i < s; i++)
            {
                if (arr[i] == n)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 1)
            {
                Console.WriteLine("Element " + n + " is found at index: " + (i + 1));
            }
            else
            {
                Console.WriteLine("Element " + n + " is not found in the array");
            }
        }
    }

    class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < s; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element is " + max);
            Console.WriteLine("Minimun element is " + min);
        }
    }

    class CountNeg
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter array size:");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < s; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < s; i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Negative number in array is = " + count);
        }
    }

    class Prime
    {
        static void Main(String[] args)
        {
            int s;
            Console.WriteLine("Enter size");
            s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];
            Console.WriteLine("Enter array elements=");
            for (int i = 0; i < s; i++)
                arr[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("prime numbers in the array are -");
            for (int i = 0; i < s; i++)
            {
                int count = 0;
                for (int j = 2; j <= arr[i] / 2; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        count = 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

    class CharArr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    class FindChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} character elements of array ");
            char[] arr = new char[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            char ch;
            int cnt = 0;
            Console.WriteLine("Enter any character");
            ch = char.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
                if (arr[i] == ch)
                    cnt++;
            if (cnt == 0)
            {
                Console.WriteLine(ch + " character Is Not Present");
            }
            else
            {
                Console.WriteLine(ch + " Present is present");
            }
        }
    }

    /*class SameArray
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter array size:");
                int s = int.Parse(Console.ReadLine());

                int[] arr = new int[s];
                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < s; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }


                Console.WriteLine("Enter 2nd array size:");
                int n = int.Parse(Console.ReadLine());

                int[] ar = new int[n];
                Console.WriteLine("Enter array elements:");
                for (int j = 0; j < n; j++)
                {
                    ar[j] = int.Parse(Console.ReadLine());
                }

                if (arr[i] == ar[j])
                {
                    Console.WriteLine("same array");
                }
                else
                {
                    Console.WriteLine("Not Same");
                }
            
                
            
        }
    }*/

  /*  class SameArray 
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            int[] arr1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {size} array2 elements:");
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array1 is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\nThe array2 is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            int Count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    Count++;
                }
            }
            if (Count == size)
            {
                Console.WriteLine("\nArray1 is equal to Array 2");
            }
            else
            {
                Console.WriteLine("\nArray1 is not equal to Array 2");
            }
        }
    }*/

    class Equal
    {
        static void Main(string[] args)
        {

            Boolean isArrayEqual = true;

            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {size} array1 elements:");
            int[] arr1 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Enter {size} array2 elements:");
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (arr2[i] != arr1[i])
                    {

                        isArrayEqual = false;
                        break;
                    }
                }
            }
            if (isArrayEqual)
            {
                Console.WriteLine("Both arrays are equal");

            }
            else
            {
                Console.WriteLine("Both arrays are not equals");

            }
        }
    }

    class Concatination
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter array size:");
             int size = int.Parse(Console.ReadLine());
             Console.WriteLine($"Enter {size} array1 elements:");
             int[] arr1 = new int[size];
             for (int i = 0; i < size; i++)
             {
                 arr1[i] = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("The array1 is:");
             for (int i = 0; i < size; i++)
             {
                 Console.Write(arr1[i] + " ");
             }
             Console.WriteLine($"Enter {size} array2 elements:");
             int[] arr2 = new int[size];
             for (int i = 0; i < size; i++)
             {
                 arr2[i] = int.Parse(Console.ReadLine());
             }
             for (int i = 0; i < size; i++)*/

           
                int i, j;
                Console.WriteLine("Enter array 1 size:");
                int size1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter array 1 elements:");
                int[] arr1 = new int[size1];
                for (i = 0; i < size1; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Enter array 2 size:");
                int size2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter array 2 elements:");
                int[] arr2 = new int[size2];
                for (i = 0; i < size2; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                int[] arr3 = new int[size1 + size2];
                for (i = 0, j = 0; i < size1; i++)
                {
                    arr3[j++] = arr1[i];
                }
                for (i = 0; i < size2; i++)
                {
                    arr3[j++] = arr2[i];
                }
                Console.WriteLine("Elements of array 3 are:");
                for (i = 0; i < size1 + size2; i++)
                {
                    Console.Write(arr3[i] + " ");
                }
        }
    }

    class AlternetArray
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

            int[] arr3 = new int[size1 + size2];
            for (i = j = 0; i < size1; i++)
            {
                arr3[j++] = arr1[i];
                arr3[j++] = arr2[i];
            }

            Console.WriteLine("Alternate Elements of array 3 are:");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }
    }
}


