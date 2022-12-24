using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oops
{
    class Parent
    {
        public virtual void Show()
        {
            Console.WriteLine("Parent");
        }
    }

    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("Child");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            /*Child C - new Child();
            c.Show();*/
            Parent P = new Child();
            P.Show();
        }
    }

  

}
