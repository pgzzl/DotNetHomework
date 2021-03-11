using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    class ArrayQuestion
    {
        public int MaxNum(int[] array)
        {
            int max = array[0];
            for(int i=1;i<array.Length;i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }
        public int MinNum(int []array)
        {
            int min=array[0];
            foreach(int i in array)
            {
                if (i < min)
                    min = i;
            }
            return min;
        }
        public int SumNum(int []array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return sum;
        }
        public double AverageNum(int []array)
        {
            return SumNum(array) /(double) array.Length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayQuestion newAQ = new ArrayQuestion();
            int[] array1 = new int[10];
            Console.WriteLine("输入一个有十个数的数组：");
            for(int i=0;i<10;i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            } 
            Console.WriteLine(newAQ.MinNum(array1));
            Console.WriteLine("最大值");
            Console.WriteLine(newAQ.MaxNum(array1));
            Console.WriteLine("和");
            Console.WriteLine(newAQ.SumNum(array1));
            Console.WriteLine("平均值");
            Console.WriteLine(newAQ.AverageNum(array1));
        }
    }
}
