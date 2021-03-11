using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4
{
    class Matrix
    {
        public bool isToplitz(int[,]matrix)
        {
            int width = matrix.GetLength(0);
            int length = matrix.GetLength(1);
            int i = 0;
            int j = 0;
            int n, m;
            for (i = 0; i < width; i++)
            {
                j = 0;
                m = i;n = j;
                while ((m + 1) < width && (n + 1) < length)
                {
                    if (matrix[m,n] != matrix[m + 1,n + 1])
                        return false;
                    m++; n++;
                }
            }
            for(j=1;j<length;j++)
            {
                i = 0;
                m = i;n = j;
                while ((m + 1) < width && (n + 1) < length)
                {
                    if (matrix[m,n] != matrix[m + 1,n + 1])
                        return false;
                    m++; n++;
                }
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            int[,] matrix =new int[3,4]{ { 1,2,3,4},{ 5,1,2,3},{ 9 ,5,1,2} };
            if (m1.isToplitz(matrix))
                Console.WriteLine("是一个toplitz矩阵");
            else
                Console.WriteLine("不是一个toplitz矩阵");
        }
    }
}
