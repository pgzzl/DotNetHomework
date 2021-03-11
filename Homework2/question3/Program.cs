using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Prime
    {
        public void FindPrime()
        {
            int[] array = new int[101];
            for(int i=0;i<101;i++)
            {
                array[i] = i ;
            }
            for(int j=2;j<=10;j++)
            {
                for(int n=2;j*n<=100;n++)
                {
                    array[n * j] = -1;
                }
            }
            for(int i=2;i<=100;i++)
            {
                if (array[i] != -1)
                    Console.WriteLine(array[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prime p1 = new Prime();
            Console.WriteLine("2-100的素数有");
            p1.FindPrime();
        }
    }
}
