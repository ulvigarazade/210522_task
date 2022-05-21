using System;

namespace _1ci_tapshiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumArr(1, 2, 3, 4, 5));
        }
        static int Sum(int a, int b)
        {
            if (a < b)
            {
                return a + b;
            }
            return 0;
        }
        static int SumArr(params int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result = result + item;
            }
            return result;
        }
    }
}
