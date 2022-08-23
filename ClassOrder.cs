
namespace XMLOperations
{
    public class Order
    {
        public List <Goods> order = new List <Goods> ();
        public Order()
        {
            List <Goods> order = new List <Goods> ();
        }
        public Order (List <Goods> list) => order = list;
        public void ShowOrder ()
        {
            foreach (var item in order)
                Console.WriteLine(item);
        }
    }
}
