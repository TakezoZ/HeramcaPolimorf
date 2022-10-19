using System.Globalization;
using System.Runtime.InteropServices;

namespace ExercicioDeFixacao.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice(CustomFee)} (Custom fee: $ {CustomFee.ToString("F2",CultureInfo.InvariantCulture)})" ;
        }

        public double TotalPrice(double customFee)
        {
            return Price += customFee;
        }


    }
}
