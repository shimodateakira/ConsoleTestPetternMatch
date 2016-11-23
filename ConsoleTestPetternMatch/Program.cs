using System;

namespace ConsoleTestPetternMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            while((s = Console.ReadLine()) != "")
            {
                // C#6までの書き方
                int n1 = 0;
                if (int.TryParse(s, out n1))
                {
                    Console.WriteLine($"入力した数字は{n1}です。");
                }
                else
                {
                    Console.WriteLine($"数字ではありません");
                }

                // C#7ではパターンマッチングと拡張メソッドでこのように書ける
                if (s.Parse() is int n2)
                {
                    Console.WriteLine($"入力した数字は{n2}です。");
                }
                else
                {
                    Console.WriteLine($"数字ではありません");
                }
            }
        }
    }

    static class StringExtension
    {
        public static int? Parse(this string s)
        {
            int n;
            return int.TryParse(s, out n) ? (int?)n : null;
        }
    }
}
