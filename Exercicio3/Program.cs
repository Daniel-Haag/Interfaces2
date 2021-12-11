using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number:");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy):");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value:");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number os intallments:");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            
        }
    }
}
