using System;

namespace alistirme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayi: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2.sayi: ");
            int b = int.Parse(Console.ReadLine());
            int c = a+b;
            Console.WriteLine("{0} ve {1} sayisinin toplami {2}",a,b,c);
        }
    }
}
