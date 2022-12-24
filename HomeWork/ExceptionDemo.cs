using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class NotBinaryNumber : SystemException
    {
        public NotBinaryNumber()
        {
            Console.WriteLine("Number is not binary number");
        }
    }
    class BinaryException
    {
        public static void check(int num)
        {
            int count = 0, flag = 0;
            while (num > 0)
            {
                int j = num % 10;
                num = num / 10;
                if (j == 0 || j == 1)
                {
                    count++;
                }
                flag++;
            }
            if (count != flag)
            {
                throw new NotBinaryNumber();
            }
            Console.WriteLine("Binary number");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            try
            {
                check(num);
            }
            catch
            {
                Console.WriteLine("Handle.......");
            }
        }
    }

    class NoDigitNumber : SystemException
    {
        public NoDigitNumber()
        {
            Console.WriteLine("Number is contain Alphabet");
        }
    }
    class InvalidNumber : SystemException
    {
        public InvalidNumber()
        {
            Console.WriteLine("Number Is Not Sufficient");
        }
    }
    class AlphabetException
    {
        public static void onlyDigits(String str)
        {
         char[] ch = str.ToCharArray();
            int cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (Char.IsDigit(ch[i]))
                {
                    cnt++;
                }
                else
                {
                    throw new NoDigitNumber();
                }
            }
            if (cnt == 10)
            {
                Console.WriteLine("Valid Number");
            }
            else
            {
                throw new InvalidNumber();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string str =Console.ReadLine();
            try
            {
                onlyDigits(str);
            }
            catch
            {
                Console.WriteLine("Handle.......");
            }
        }
    }
}
