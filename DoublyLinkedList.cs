
namespace Collections
{
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public T Data { get; set; }
    }
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new DoublyLinkedListNode<T>() { Data = data };
                Tail = Head;
            }
            else
            {
                var oldHead = Head;
                Head = new DoublyLinkedListNode<T>()
                {
                    Data = data,
                    Next = oldHead
                };
                oldHead.Previous = Head;
            }
        }
        public void Print()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
