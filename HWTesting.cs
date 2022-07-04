
using static System.Console;

namespace Inheritance
{
    internal partial class Inheritance
    {
        static void MoneyAndProductTest()
        {
            Money money = new Money();
            money.EnterMoney();
            WriteLine(money.ToString());
            Product product = new Product();
            product.EnterProduct();
            WriteLine(product.ToString());
            product.Discount();
        }
        static void DevicesTest()
        {
            Kettle kettle = new Kettle();
            kettle.Sound(); kettle.Show(); kettle.Desc();
            Microwave microwave = new Microwave();
            microwave.Sound(); microwave.Show(); microwave.Desc();
            Car car = new Car();
            car.Sound(); car.Show(); car.Desc();
            Steamship steamShip = new Steamship();
            steamShip.Sound(); steamShip.Show(); steamShip.Desc();
        }
        static void MusicalInstrumentTest()
        {
            Violin violin = new Violin();
            violin.Sound(); violin.Show(); violin.Desc(); violin.History();
            Trombone trombone = new Trombone();
            trombone.Sound(); trombone.Show(); trombone.Desc(); trombone.History();
            Ukulele ukulele = new Ukulele();
            ukulele.Sound(); ukulele.Show(); ukulele.Desc(); ukulele.History();
            Cello cello = new Cello();
            cello.Sound(); cello.Show(); cello.Desc(); cello.History();
        }
        static void AbstractWorkerTest()
        {
            President president = new President();
            president.Print();
            Security security = new Security();
            security.Print();
            Manager manager = new Manager();
            manager.Print();
            Engineer engineer = new Engineer();
            engineer.Print();
        }
    }
}