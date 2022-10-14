using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Oopsdemo
{
    class Car
    {
        public int model;
        public string name;
        public int price;
        public string colour;

        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.model = 2015;
            car1.name = "Vrena";
            car1.price = 1500000;
            car1.colour = "White";
            Console.WriteLine(car1.model+" "+car1.name+" "+car1.price+" "+car1.colour);

            Car car2 = new Car();
            car2.model = 2015;
            car2.name = "Vrena";
            car2.price = 1500000;
            car2.colour = "White";
            Console.WriteLine(car2.model + " " + car2.name + " " + car2.price + " " + car2.colour);



        }
    }

    class Box
    {
        public int hight;
        public int weidth;
        public int length;

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.hight = 5;
            box1.weidth = 3;
            box1.length = 6;
            //surface area = 2*(l*w + l*h + w*h).
           int area = ( 2 * (box1.length * box1.weidth + box1.length * box1.hight + box1.weidth * box1.hight));
            Console.WriteLine("Area Of Box = "+area);
        }

    }
}
