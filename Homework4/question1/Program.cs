using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
   
    public class Node<T> where T : IComparable
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data=t;
        }
        /*public static  T CompareGeneric(T t1,T t2)
        {
            if(t1.CompareTo(t2)>0)
            {
                return t1;
            }
            else
            {
                return t2;
            }
        }*/
    }
    public class GenericList<T> where T : IComparable
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head =tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        //类似ForEach
      
        public void Traverse(Action<T> a)
        {
            if (head == null)
                return;
            Node<T> node = head;
            while(node!=null)
            {
                a(node.Data);
                node = node.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int sum=0;
            int max=0;
            int min = 1;
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(4);
            list.Add(3);;
            list.Traverse(data=> { sum += data; });
            Console.WriteLine($"和：{sum}");
            list.Traverse(data => max=max<data ?data:max);
            Console.WriteLine($"最大值：{max}");
            list.Traverse(data => min = min > data ? data : min);
            Console.WriteLine($"最小值：{min}");
        }
    }
}
