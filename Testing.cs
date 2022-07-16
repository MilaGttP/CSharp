
using static System.Console;

namespace Collections
{
    partial class Collection
    {
        public static void SwapTesting()
        {
            Write("Enter left -> "); int left = Convert.ToInt32(ReadLine());
            Write("Enter right -> "); int right = Convert.ToInt32(ReadLine());
            WriteLine($"Your numbers before swap: {left}, {right}");
            Swap <int> (ref left, ref right);
            WriteLine($"Your numbers after swap: {left}, {right}");
        }
        public static void PriorityQueueTesting()
        {
            PriorityQueue<int> queue = new PriorityQueue<int>();
            queue.Enqueue(12); queue.Enqueue(15);
            WriteLine($"ToString(): {queue}");
            WriteLine($"Peek(): {queue.Peek()}");
            WriteLine($"Count(): {queue.Count()}");
            if (queue.IsConsistent() == true) { WriteLine("IsConsistent() == true"); }
            else { WriteLine("IsConsistent() == false"); }
            WriteLine($"Dequeue(): {queue.Dequeue()}");
        }
        public static void CircularQueueTesting()
        {
            CircularQueue<double> queue = new CircularQueue<double>(2);
            queue.Enqueue(3.213); queue.Enqueue(4.87);
            queue.Print();
            WriteLine($"Dequeue(): {queue.Dequeue()}");
        }
        public static void SinglyConnectedListTesting()
        {
            SinglyLinkedList<float> list = new SinglyLinkedList<float>();
            list.Add(41); list.Add(22);
            list.Print();
        }
        public static void DoublyConnectedListTesting()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("Hello!");
            list.Print();
        }
    }
}