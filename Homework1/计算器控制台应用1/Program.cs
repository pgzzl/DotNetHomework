using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 计算器控制台应用1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            string operation;
            int s = 0;
            Console.WriteLine("请输入第一个数：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            operation = Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            b = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case "+": s = a + b; break;
                case "-": s = a - b; break;
                case "*": s = a * b; break;
                case "/": s = a / b; break;
            }
            Console.Write($"{a}{operation}{b}={s}");

        }
    }
}
