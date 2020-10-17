using System.Globalization;
using System.Text;

namespace exec_cap10_01.Entities
{
    class ImportedProduct :  Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" (Customs fee: $");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");
            return base.PriceTag() + sb.ToString();
        }
    }
}
