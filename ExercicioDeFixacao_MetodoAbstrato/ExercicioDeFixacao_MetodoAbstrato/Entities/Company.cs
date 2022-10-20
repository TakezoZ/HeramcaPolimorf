namespace ExercicioDeFixacao_MetodoAbstrato.Entities
{
    internal class Company : TaxPayer
    {
        public int NumeberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(int numeberOfEmployees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            NumeberOfEmployees = numeberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if (NumeberOfEmployees <= 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }
            return tax;
        }
    }
}
