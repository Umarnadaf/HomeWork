using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class NoChar
    {
        static void Main(string[] args)
        {
            String str = "Hello I am Disha";
            int count = 0;
            Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    count++;
            }
            Console.WriteLine(count);
        }

        class NoWords
        {
            static void Main(string[] args)
            {
                String str = "Hello I am Disha";
                Console.WriteLine(str);
                int count = 0;
                string[] word = str.Split();
                foreach (string w in word)
                {
                    count++;
                }
                Console.WriteLine(count);
            }
        }
    }

    class RevStr
    {
        //Reverse string except first and last word
        static void Main(string[] args)
        {
            string str = "Hello world of progamming";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            string myword = "";
            for (int i = 1; i < str1.Length - 1; i++)
            {
                string wordvalue = str1[i];
                string revword = "";
                for (int j = 0; j < wordvalue.Length; j++)
                {
                    revword = wordvalue[j] + revword;
                }
                myword = myword + " " + revword;
            }
            string word = str1[0] + myword + " " + str1[str1.Length - 1];
            Console.WriteLine(word);
        }
    }

    class LongWord
    {
        static void Main(string[] args)
        {
            string str = "India is My Country";
            Console.WriteLine(str);
            string[] str1 = str.Split();
            int count = 0;
            string word = "";
            foreach(string s in str1)
            {
                if (s.Length > count)
                {
                    word = s;
                    count = s.Length;
                }
            }
            Console.WriteLine(word);
        }
    }
}
