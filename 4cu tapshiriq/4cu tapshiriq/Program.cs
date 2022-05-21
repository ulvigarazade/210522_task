
using System;

namespace _4cu_tapshiriq
{
    class Program
    {
        static void Main(string[] args)
        {
            Check(17, 55);
        }


        static void Check(int age, int score)
        {
            if (age >= 18)
            {
                if (score >= 50)
                {
                    Console.WriteLine("Xosh gelmishsiniz");
                }
            }
            else
            {
                Console.WriteLine("Teshekkur edirik");
            }
        }
    }
}