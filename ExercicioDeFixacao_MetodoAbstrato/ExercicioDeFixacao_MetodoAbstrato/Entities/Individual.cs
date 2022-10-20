namespace ExercicioDeFixacao_MetodoAbstrato.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(double healthExpenditures, string name, double anualIncome)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;

            if (AnualIncome <= 20000)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            tax -= HealthExpenditures * 0.50;

            return tax;
        }

    }
}
