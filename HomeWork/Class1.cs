using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class NoChar
    {
        static void Main(string[] args)
        {
            String str = "India Is My Country";
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
                String str = "India Is My Country";
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
               // myword = myword + " " + revword;
            }
            string word = str1[0] + myword + " " + str1[str1.Length - 1];
            Console.WriteLine(word);
        }
    }

    class LongWord
    {
        static void Main(string[] args)
        {
            string str = "program is in country";
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

    class StringTask2
    {
        // to calculate avg of digits present in string
        public static int AvgOfDigit(string s)
        {
            char[] ch = s.ToCharArray();
            int sum = 0, cnt = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (char.IsDigit(ch[i]))
                {
                    sum = sum + (int)char.GetNumericValue(ch[i]);
                    cnt++;
                }
            }
            int avg = sum / cnt;
            return avg;
        }
        // name to abbrevation
        public static string ToAbbrevatedForm(string s)
        {
            string[] str = s.Split();
            string abbrevation = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || i == 1)
                {
                    Char[] Word = str[i].ToCharArray();
                    for (int j = 0; j < 1; j++)
                    {
                        if (j == 0)
                        {
                            abbrevation = abbrevation + Word[j] + ". ";
                        }
                    }
                }
                else
                {
                    abbrevation = abbrevation + str[i];
                }
            }
            return abbrevation;
        }
        // valid string or not
        public static void ValidString(string str)
        {
            if (str.Length >= 3)
            {
                char[] ch = str.ToCharArray();
                bool IsDigit = true;
                for (int i = 0; i < ch.Length; i++)
                {
                    if (char.IsLetter(ch[i]))
                    {
                        Console.WriteLine("Error");
                        IsDigit = false;
                        break;
                    }
                }
                if (IsDigit)
                {
                    int StartSum = 0, LastSum = 0;
                    for (int S = 0, L = ch.Length - 1; S < 3; S++, L--)
                    {
                        StartSum += ch[S];
                        LastSum += ch[L];
                    }
                    if (StartSum == LastSum)
                    {
                        Console.WriteLine("Valid String");
                    }
                    else
                    {
                        Console.WriteLine("Not Valid String");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        // occurance of each character
        public static void OccuranceOfChar(string str)
        {
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                int cnt = 1;
                bool flag = true;
                for (int j = i - 1; j > -1; j--)
                {
                    if (ch[i] == ch[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            cnt++;
                        }
                    }
                    Console.WriteLine($" \'{ch[i]}\' Present {cnt} Time");
                }
            }
        }
        // count vowel in a string
        public static int CountVowel(string str)
        {
            char[] ch = str.ToCharArray();
            int VowelCount = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u' ||
                    ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U')
                {
                    VowelCount++;
                }
            }
            return VowelCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            // Console.WriteLine("Avg of Numbers in a string := "+StringTask2.AvgOfDigit(str));
            //Console.WriteLine("Abbrevated Name := \n"+StringTask2.ToAbbrevatedForm(str));
            StringTask2.ValidString(str);
            //StringTask2.OccuranceOfChar(str);

            // Console.WriteLine("Vowel Count := "+StringTask2.CountVowel(str));

        }
    }
}
