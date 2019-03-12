using System.Globalization;

namespace HerancaPolimorfismoExFixacao.Entities
{
    class Product
    {
        private double customsFee;

        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product(string name, double price, double customsFee) : this(name, price)
        {
            this.customsFee = customsFee;
        }

        public virtual string PriceTag()
        {
            return $"{Name} $ "+ Price.ToString("F2", CultureInfo.InvariantCulture);
        }
      
    }
}
