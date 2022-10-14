using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Test
{
    class Test2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if ((i % 5 == 0 && i % 10 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Loop
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    class Test3
    {
        static void Main(string[] args)
        {
            int i = 1;
            int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k ="+k +" i ="+i);

        }
    }

    class Test4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            int sum=0;
            int spy = 1;
            while (n > 0)
            {
                t = n % 10;
                n = n / 10;
                sum = sum + t;
                spy = spy * t;
            }
            if (sum == spy)
            {
                Console.WriteLine("Number is Spy = "+sum+"="+spy);
            }
            else
            {
                Console.WriteLine("Not Spy = " + sum + "=" + spy);
            }
        }
    }

    class Test5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());//4
            
            int sum = n * n * n;//64
            int t = sum % 10;//4
            if (t == n)
            {
                Console.WriteLine("number is trimorphic  number "+t+"="+n);
            }
            else
            {
                Console.WriteLine("Not trimorphic  number "+t+"=!"+n);
            }
            
        }
    }

    class Test6
    {
        static void Main(string[] args)
        {
            int spc, len = 1, count;
            Console.WriteLine("enter Row Number");
            count = Convert.ToInt32(Console.ReadLine());
            spc = count - 1;
            for(int i = 1; i <= count; i++)
            {
                for(int r = 1; r <= spc; r++)
                {
                    Console.Write(" ");
                }
                for(int s = 1; s <= len; s++)
                {
                    Console.Write(i);
                }
                spc--;
                len = len+2;
                Console.WriteLine();

            }
           
        }
    }

    class Test7
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }
                for(int l = i; l <= 4; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    class Test8
    {
        static void Main(string[] args)
        {
            for (int x = 5; x >= 1; x--)
            {
                for (int y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= x; z++)
                {
                    Console.Write(z);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Test9
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }
    }

    class Test10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            int n2 = int.Parse(Console.ReadLine());
            int c1=0, c2=0,d=0;
            for(int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    c1++;
                }
            }
            for (int i = 1; i <= n2; i++)
            {
                if (n2 % i == 0)
                {
                    c2++;
                }
            }
            d = n1 - n2;
            Console.WriteLine(d);
            if(d==2 && c1==2 && c2 == 2)
            {
                Console.WriteLine("Number Is Twin Number");
            }
            else
            {
                Console.WriteLine("Number Is Not Twin");
            }

        }
    }
    class Test11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 2; i <= n; i++)
            {
                sum = (i * i) + (i * i * i);
                Console.WriteLine(sum);
            }
        }
    }

    class Test12
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even = "+i);
                }
                else
                {
                    Console.WriteLine("Odd = "+ -i*i);
                }
            }
        }
    }

   /* class Test13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine("j="+j);
                    }
                    j++;
                }
                Console.WriteLine("i="+i);
            }

        }
    }*/

    class Test14
    {
        static void Main(string[] args)
        {
            int fact = 1;
            for(int i = 1; i <= 20; i++)
            {
                fact = fact * i;
                Console.WriteLine(i+" = "+fact);
            }
          
        }
    }

    class Test15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                fact = fact*i;
                sum = sum + fact;
                Console.Write(i+"!+");
            }
            Console.WriteLine("sum ="+sum);
        }
    }
}
