namespace ExercicioDeFixacao_MetodoAbstrato.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numeberOfEmployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numeberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
