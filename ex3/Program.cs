using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu salário: ");
            double isalary = double.Parse(Console.ReadLine());
            double percentage = (isalary / 100) * 30;
            if (isalary <= 500)
            {
                double fsalary = isalary + percentage;
                Console.WriteLine("O valor do salário reajustado é de: R$" + fsalary);
            }
            else
            {
                Console.WriteLine("Funcionário não elegível para reajuste de salário");
            }
        }
    }
}
