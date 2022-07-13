
using static System.Console;

namespace OperatorOverload
{
    public partial class Overloading
    {
        static void Main()
        {
            BookListTest();
        }
        static void BookListTest()
        {
            BookList bookList = new BookList(1);
            Write("Enter book`s information -> ");
            string inf = ReadLine();
            Write("Enter index -> ");
            int index = Convert.ToInt32(ReadLine());
            WriteLine("Operations with this: ");
            bookList.Add(inf, index);
            bookList.Print();
            WriteLine($"FindByInformation: {bookList.FindByInformation(inf)}");
            bookList.Delete(inf);
            bookList.Print();
        }
    }
}
