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
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numeberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new Company(numeberOfEmployees, name, anualIncome));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                sum += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.Write($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
