using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    abstract class Shape
    {
        public abstract int getArea();
        public abstract bool isLegal();
        public abstract void print();
    }
    class Rectangle:Shape
    {
        private int length;
        private int width;
        public Rectangle()
        {
            this.length = 0;
            this.width = 0;
        }
        public Rectangle(int width,int length)
        {
            this.length = length;
            this.width = width;
        }
        public override int getArea()
        {
            return length * width;
        }


        public override bool isLegal()
        {
            if (this.length >= 0 && this.width >= 0)
                return true;
            return false;
        }


        public override void print()
        {
            Console.WriteLine("长方形");
        }
    }
    class Square:Rectangle
    {
        public Square(int length):base(length,length)
        {
          
        }
        public override void print()
        {
            Console.WriteLine("正方形");
        }
    }
    class Triangle:Shape
    {
        private int a;
        private int b;
        private int c;
        public Triangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }
        public Triangle(int newA,int newB,int newC)
        {
            this.a = newA;
            this.b = newB;
            this.c = newC;
        }
        public override int getArea()
        {
            double p = (double)(a + b + c) / 2;
            double s2 = p * (p - a) * (p - b) * (p - c);
            double s = Math.Sqrt(s2);
            return (int)s;
        }
        public override bool isLegal()
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return false;
            if (a + b <= c)
                return false;
            else if (a + c <= b)
                return false;
            else if (b + c <= b)
                return false;
            return true;
        }

        public override void print()
        {
            Console.WriteLine("三角形");
        }
    }
    //简单工厂模式创建对象
    class ShapeFactory
    {

        private Shape shape = null;
        public Shape CreatShape(int whichShape)
        {
            switch (whichShape)
            {
                case 1:shape = new Rectangle(2,4);break;
                case 2:shape = new Square(3);break;
                case 3:shape = new Triangle(3,5,4);break; 
            }
            return shape;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //第一题
            Rectangle rectangle = new Rectangle(1, 2);
            Square square = new Square(1);
            Triangle triangle = new Triangle(3, 4, 8);
            Triangle triangle1 = new Triangle(3, 4, 5);
            Console.WriteLine("第一问：");
            Console.WriteLine("长方形：");
            if (rectangle.isLegal())
                Console.WriteLine("面积：" + rectangle.getArea());
            else
                Console.WriteLine("不合法");
            Console.WriteLine("正方形：");
            if (square.isLegal())
                Console.WriteLine("面积：" + square.getArea());
            else
                Console.WriteLine("不合法");
            Console.WriteLine("三角形1：");
            if (triangle.isLegal())
                Console.WriteLine("面积：" + triangle.getArea());
            else
                Console.WriteLine("不合法");
            Console.WriteLine("三角形2：");
            if (triangle1.isLegal())
                Console.WriteLine("面积：" + triangle1.getArea());
            else
                Console.WriteLine("不合法");


            //第二题
            Console.WriteLine("第二问：");
            //实例化一个工厂类
            ShapeFactory shapeFactory = new ShapeFactory();
            Random ran = new Random();
            int RandKey;
            Shape[] shape=new Shape[10];
            for(int i=0;i<10;i++)
            {
                RandKey = ran.Next(1, 3);
                shape[i] = shapeFactory.CreatShape(RandKey);
            }
            //计算面积之和
            int sum=0;
            for (int i = 0; i < 10; i++)
                sum += shape[i].getArea();
            Console.WriteLine($"面积之和为{sum}");



        }
    }
}
