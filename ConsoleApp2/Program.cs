using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int SCORE;
            Console.WriteLine("請輸入你的分數");
            SCORE = Convert.ToInt32(Console.ReadLine());
            string RESULT = SCORE >= 60 ? "及格" : "不及格";
            Console.WriteLine("和同學>這次你{0}"， RESULT);


        }
    }
}
