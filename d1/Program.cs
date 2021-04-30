using System;

namespace d1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int age = int.Parse(Console.ReadLine());
            if (age >= 5 && age <= 7) {
                Console.WriteLine("Categoria: Infantil A");
            }
            if (age >= 8 && age <= 10) {
                Console.WriteLine("Categoria: Infantil B");
            }
            if (age >= 11 && age <= 13) {
                Console.WriteLine("Categoria: Juvenil A");
            }
            if (age >= 14 && age <= 17) {
                Console.WriteLine("Categoria: Juvenil B");
            }
            if (age >= 18) {
                Console.WriteLine("Categoria: Sênior");
            }
        }
    }
}
