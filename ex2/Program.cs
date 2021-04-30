using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int byear = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?");
            int ayear = int.Parse(Console.ReadLine());
            int age = ayear - byear;
            double weeks = age * 52.143;
            Console.WriteLine("Sua idade é de " + age + " anos");
            Console.WriteLine("Sua idade é de " + weeks + " semanas");
        }
    }
}
