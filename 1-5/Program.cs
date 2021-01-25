using System;


namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();

            //int a = 1;
            //int b = 2;

            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            string s = Console.ReadLine();
            string[] ss = s.Split();
            int a = int.Parse(ss[0]);
            int b = int.Parse(ss[1]);
            Console.WriteLine(a + b);

        }
    }
}