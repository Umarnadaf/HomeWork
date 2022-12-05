using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    internal class Student
    {
        int id;
        string name;
        int marks;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        static void Main(string[] args)
        {
            Student[] stud = new Student[3];
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i] = new Student();
                Console.WriteLine("Enter Id = ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name = ");
                string name = (Console.ReadLine());
                Console.WriteLine("Enter Marks = ");
                int marks = int.Parse(Console.ReadLine());

                stud[i].Id = id;
                stud[i].Name = name;
                stud[i].Marks = marks;

            }
            Console.WriteLine("Id\tName\tMarks");
            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine(stud[i].Id + "\t" + stud[i].Name + "\t" + stud[i].Marks);
            }
        }

    }

    // Constructor
    internal class Students
    {
        int id;
        string name;
        int marks;

        public Students()//default constructor
        {
            int id;
            string name;
            int marks;
        }

        public Students(int id, string name, int marks)//default constructor
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }

        public void Display()
        {
            Console.WriteLine(id + "\t" + name + "\t" + marks);
        }

        static void Main(string[] args)
        {

            Students[] stud = new Students[3];
            for (int i = 0; i < stud.Length; i++)
            {

                Console.WriteLine("Enter Id = ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name = ");
                string name = (Console.ReadLine());
                Console.WriteLine("Enter Marks = ");
                int marks = int.Parse(Console.ReadLine());

                stud[i] = new Students(id, name, marks);
            }
            Console.WriteLine("Id\tName\tMarks");
            foreach (Students s in stud)
            {
                s.Display();

            }
        }
    }

    internal class MyArray
    {
        int[] arr = new int[10];
        public void accept()
        {
            Console.WriteLine("Enter Element To Array ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void display()
        {
            foreach (int no in arr)
            {
                Console.WriteLine(no + " ");
            }
        }
        public int retAvgOfEven()
        {
            int sum = 0, avg, cnt = 0;
            foreach (int no in arr)
            {
                if (no % 2 == 0)
                {
                    sum += no;
                    cnt++;
                }
            }
            avg = sum / cnt;
            return avg;
        }

        public void copy(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
        }
        public int[] sort()
        {
            Array.Sort(arr);
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 6, 5, 2 };
            MyArray obj = new MyArray();
            obj.copy(arr);
            obj.display();

        }
    }

    internal class OddArray
    {
        int[] arr = new int[10];
        public void accept()
        {
            Console.WriteLine("Enter Element To Array ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void display()
        {
            foreach (int no in arr)
            {
                Console.WriteLine(no + " ");
            }
        }
        public int retAvgOfOdd()
        {
            int sum = 0, avg, cnt = 0;
            foreach (int no in arr)
            {
                if (no % 2 != 0)
                {
                    sum += no;
                    cnt++;
                }
            }
            avg = sum / cnt;
            return avg;
        }
        public void copy(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
        }
        public int[] sort()
        {
            Array.Sort(arr);
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 4, 6, 5, 2 };
            OddArray obj = new OddArray();
            obj.accept();
            obj.display();
            int avg = obj.retAvgOfOdd();
            Console.WriteLine("Average of odd num = " + avg);
            arr = obj.sort();
            obj.display();
            obj.copy(arr);
            obj.display();

            Console.WriteLine("Sorted Array is ");
            foreach (int no in arr)
            {
                Console.WriteLine(no + " ");
            }
        }
    }

    // Two Dimenstional Array

    class Array2D
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Array2D obj = new Array2D();
            Console.WriteLine("enter elements of 2D array:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
        }
    }

    class RowSum
    {
        int[,] matrix = new int[3, 3];
        public void Accept()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void rowWiseSum()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Addition of " + i + " row is " + sum);
            }
        }
        public void colWiseSum()
        {
            int sum;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[j, i];
                }
                Console.WriteLine("Addition of " + i + " col is " + sum);
            }
        }
        public int sumOfDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        sum += matrix[i, j];
                }

            }
            return sum;
        }
        public int sumOfAntiDiagonal()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) == matrix.GetLength(0) - 1)
                        sum += matrix[i, j];
                }

            }
            return sum;
        }
        static void Main(string[] args)
        {
            RowSum obj = new RowSum();
            Console.WriteLine("enter elements of 2D array:");
            obj.Accept();
            Console.WriteLine("Matrix is:");
            obj.Display();
            obj.rowWiseSum();
            obj.colWiseSum();
            Console.WriteLine("Matrix of diagonal is " + obj.sumOfDiagonal());
            Console.WriteLine("Matrix of diagonal is " + obj.sumOfAntiDiagonal());
        }
    }

    class MatrixAdd
    {
        int[,] matrix = new int[3, 3];

        public void Add()
        {
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            Console.WriteLine("Enter first matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The first matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nEnter second matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The second matrix is:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("\nAddition of two matrix: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            MatrixAdd obj = new MatrixAdd();
            obj.Add();
        }
    }

    class LowerTrangularMatrix
    {
        int[,] matrix = new int[3, 3]
         {
            {1,0,0 },
            {4,5,0 },
            {7,8,9 }
         };

        public void Display()
        {
            Console.WriteLine("Matrix is := ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine("");
            }
        }
        public bool IsLowerTriangular()
        {
            bool lowerTriangular = true;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        if (matrix[i, j] != 0)
                        {
                            lowerTriangular = false;
                            break;
                        }

                    }
                }
            }
            return lowerTriangular;
        }

        static void Main(string[] args)
        {
            LowerTrangularMatrix obj = new LowerTrangularMatrix();
            obj.Display();
            if (obj.IsLowerTriangular())
                Console.WriteLine("Given Matrix is Lower Triangular Matrix");
            else
                Console.WriteLine("Not Lower Triangular Matrix");
            Console.ReadKey();
        }

    }

    class JaggedArray
    {
        static void Main(String[] args)
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 6 };
            jaggedArray[1] = new int[] { 5, 6 };
            jaggedArray[2] = new int[] { 7, 8, 9 };
            Console.WriteLine("Jagged Array is = ");
            Console.WriteLine();
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + " ");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
