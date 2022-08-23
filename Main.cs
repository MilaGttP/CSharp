
namespace XMLOperations
{
    public partial class Testing
    {
        public static void SerializeTest()
        {
            List<Goods> goods = new List<Goods>
            {
                new Goods("Bread", "27.08.2022", 16.50),
                new Goods("Milk", "30.08.2022", 36.20),
                new Goods("Eggs", "28.08.2022", 39.10)
            };
            Order order = new Order(goods);
            order.ShowOrder();
            XMLOperation.Serialize<Order>(order, "Order.xml");
        }
        public static void DeserializeTest()
        {
            Order order = new Order();
            order = XMLOperation.Deserialize<Order>("Order.xml");
            Console.WriteLine("\n Your order is: \n"); order.ShowOrder();
        }
        public static void Main()
        {
            SerializeTest();
            DeserializeTest();
        }
    }
}