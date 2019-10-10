using System;

namespace Open_Lab_01._2
{
    class Program
    {
        public static int Sum(int fnum, int snum)
        {
            return (fnum + snum);

        }
        static void Main(string[] args)
        {
            int fnum;
            int snum;
            int sum;

            Console.WriteLine("Zadaj svoje prvé číslo");
            fnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Zadaj svoje druhé číslo");
            snum = int.Parse(Console.ReadLine());

            sum = Sum(fnum, snum);
             
            Console.WriteLine($"Sum is: { sum }");
        }
    }
} 