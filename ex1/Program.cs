using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double months, days, hours, minutes;
            Console.WriteLine("Qual a sua idade em anos?");
            int age = int.Parse(Console.ReadLine());
            months = age*12;
            days = age*365;
            hours = days*24;
            minutes = hours*60;
            Console.WriteLine("Sua idade é de " + months + " meses");
            Console.WriteLine("Sua idade é de " + days + " dias");
            Console.WriteLine("Sua idade é de " + hours + " horas");
            Console.WriteLine("Sua idade é de " + minutes + " minutos");
        }
    }
}
