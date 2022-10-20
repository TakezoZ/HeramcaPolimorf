using ExercicioDeFixacao_MetodoAbstrato.Entities;
using System.Globalization;

namespace ExercicioDeFixacao_MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)?: ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(healthExpenditures, name, income));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numeberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(numeberOfEmployees, name, income));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (TaxPayer tp in list)
            {
                Console.WriteLine($"{tp.Name}: $ {tp.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                sum += tp.Tax();
            }

            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
