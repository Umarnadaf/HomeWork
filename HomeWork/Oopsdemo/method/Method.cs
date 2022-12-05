using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo.method
{
    class Method
    {
        int id;
        string name;
        int m1;
        int network;
        int emf;
        float percentage;
        public void Details(int i,string sname,int m,int na,int e)
        {
            id = i;
            name = sname;
            m1 = m;
            network = na;
            emf = e;
        }

        public void Percentage(int m1,int network,int emf)
        {
            percentage = ((m1 + network + emf) / 3) * 100;

        }
        public void display()
        {
            Console.WriteLine(percentage+"%");
            Console.WriteLine(id+" "+name+" "+m1+" "+network+" "+emf);
        }
        static void Main(string[] args)
        {
            Method st = new Method();
            st.Details(23, "Umar", 72, 80, 65);
            st.Percentage(72, 80, 65);
            st.display();
        }
    }

    class Factor
    {
        int num;
        int fact = 1;
        int i;
        int sum;

        public void Answer(int num)
        {
            sum = 0;
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
                
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Factor ft = new Factor();
            ft.Answer(8);
        }
    }


}
