
namespace Collections
{
    partial class Collection
    {
        public static void Swap <T> (ref T left, ref T right)
        {
            T tmp;
            tmp = left;
            left = right;
            right = tmp;
        }
    }
}
