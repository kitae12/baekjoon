using System;
using algorithm.level_1;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            AaddB aaddB = new AaddB(s);
            aaddB.GetResult();
        }
    }
}
