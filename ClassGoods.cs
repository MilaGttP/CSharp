
namespace XMLOperations
{
    public class Goods
    {
        public string Name { get; set; }
        public string ExpirationDate { get; set; }
        public double Price { get; set; }
        public Goods()
        {
            Name = null; ExpirationDate = null; Price = 0;
        }
        public Goods(string name, string date, double price)
        {
            Name = name; ExpirationDate = date; Price = price;
        }
        public override string ToString()
        {
            return $"Goods information: \n Name: {Name}, Expiration date: {ExpirationDate}, Price: {Price} \n\n";
        }
    }
}

