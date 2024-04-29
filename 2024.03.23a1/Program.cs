using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._03._23a1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine("呼叫 add10 之前");
            Console.WriteLine("a = {0},b= {1}", a, b);
            Add10(ref a,ref b);
            Console.WriteLine("呼叫 add10 之後");
            Console.WriteLine("a = {0},b= {1}", a, b);

        }
        public static void Add10(ref int x,ref int y)
        {
            x = x + 10;
            y = y + 10;
        }
}
}
