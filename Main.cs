
namespace LINQToObject
{
    class Testing
    {
        static void TestFirstPositiveLastNegative()
        {
            int[] sequency = { -1, 2, 0, 1, 1, -2, -5, 9 };
            Console.WriteLine(sequency.FirstPositiveLastNegative()); // return 2 and -5
        }
        static void Main()
        {
            TestFirstPositiveLastNegative();
        }
    }
}
