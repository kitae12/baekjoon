using System;
namespace algorithm.level_1
{
    public class AmulB
    {
        public AmulB(string s)
        {
            string[] ss = s.Split(); // 1 3
            int a = int.Parse(ss[0]); // 1 문자열
            int b = int.Parse(ss[1]); // 3 문자열
            Console.WriteLine(a * b);
        }
    }
}
