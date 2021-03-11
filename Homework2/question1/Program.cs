using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class PrimeNumber
    {
        public bool IsPrime(int x)
        {
            for(int i=2;i<x;i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }
       
        public void FindPrimeFactor(int x)
        {
            
            for(int i=2;i<=x;i++)
            {
                if ((x % i==0) && IsPrime(i))
                    Console.WriteLine(i);
            }
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrimeNumber a = new PrimeNumber();
            Console.WriteLine("请输入一个数，输出质数因子：");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("质数因子有：");
            a.FindPrimeFactor(x);
        }
    }
}
