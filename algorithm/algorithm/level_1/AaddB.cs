using System;
namespace algorithm.level_1
{
    public class AaddB
    {
        int a = 0;
        int b = 0;

        public AaddB(string s)
        {
            string[] ss = s.Split();
            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
        }

        public void GetResult()
        {
            Console.WriteLine(a + b);
        }
    }
}
