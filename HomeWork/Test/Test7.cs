using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class EvenOdd1
    {
        //Even Odd numbers in array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements: ");
            int[] arr = new int[s];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int cnt = 0, flag = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    cnt++;
                }
                else
                    flag++;
            }
            Console.WriteLine("\nEven numbers are: " + cnt);
            Console.WriteLine("Odd numbers are: " + flag);
        }
    }
    class MinFreq
    {
        //Find minimun frequency char from array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements: ");
            char[] arr = new char[s];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int[] count = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[i] = 1;
                bool flag = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count[j]++;
                        }
                    }
                }
            }
            char ch = '0';
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > count[i] && count[i] != '0')
                {
                    min = count[i];
                    ch = arr[i];
                }
            }
            Console.WriteLine("\nMinimum Frequency char is: " + ch);
        }
    }
    class Structure
    {
        public string ReFill { get; set; }
        public double CapLength { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public string Brand { get; set; }
        public string InkColor { get; set; }
        public string Nib { get; set; }
        static void Main(string[] args)
        {
            Structure obj = new Structure();
            obj.ReFill = "Cello";
            obj.Brand = "Cello";
            obj.CapLength = 2;
            obj.InkColor = "Red";
            obj.Nib = "Metal";
            obj.Length = 2.2;
            obj.Width = 1.1;
            Console.WriteLine($"Refill: {obj.ReFill} \nBrand: {obj.Brand} \nCapLength: {obj.CapLength} \nLength: {obj.Length} \nWidth: {obj.Width} \nInkColor: {obj.InkColor} \nNib: {obj.Nib}");
        }
    }
    class ZeroNonZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }
            Console.WriteLine("\nSorted array is: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
    class Duplict
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int j;
            Console.WriteLine("\nDistinct array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        break;
                    }
                }
                if (i == j)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    class Numbers
    {
        public static void Main(string[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;
            }
        }
    }

    class Car
    {
        public int CarId { get; set; }
        public string CarColor { get; set; }
    }
    class Engine
    {
        public int EngineId { get; set; }
        public string LastEngineCleandate { get; set; }
    }
    class SubEngine
    {
        public string SubEngineType { get; set; }
    }
    class Gear
    {
        public string Type { get; set; }
    }
    class CarDetails
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            int a = int.Parse(Console.ReadLine());
            c.CarId = a;
            c.CarColor = "Black";
            Engine e = new Engine();
            e.EngineId = 1534;
            e.LastEngineCleandate = "12/4/2021";
            SubEngine s = new SubEngine();
            s.SubEngineType = "AAA";
            Gear g = new Gear();
            g.Type = "Auto";
            Console.WriteLine($"Car Id:{c.CarId} \nCar Color:{c.CarColor} \nEngine Id:{e.EngineId} \nLast Engine Clean date:{e.LastEngineCleandate} \nSub Engine Type:{s.SubEngineType} \nType:{g.Type} ");
        }
    }
    class PerfectSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int sq;
            Console.WriteLine("\nThe perfect square numbers are:");
            for (int i = 0; i < arr.Length; i++)
            {

                sq = (int)(Math.Sqrt(arr[i]));
                if (arr[i] == sq * sq && sq * sq != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    class ReplaceZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array:");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 1;
                }
            }
            Console.WriteLine("\nReplaced array is:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    class Loops
    {
        static void Main(string[] args)
        {
            int cnt = 0, count = 0, flag = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("buzfizz");
                    cnt++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("buzz");
                    count++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("fizz");
                    flag++;
                }
            }
            Console.WriteLine($"buzfizz: {cnt} \nbuzz: {count} \nfizz: {flag}");
        }
    }
}
