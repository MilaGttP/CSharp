
namespace Collections
{
    public class SinglyLinkedListNode
    {
        public Object Value { get; set; }
        public SinglyLinkedListNode Next { get; set; }
    }
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode First { get; set; }
        public SinglyLinkedListNode Last { get; set; }
        public void Add(T value)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode();
            node.Value = value;
            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }
        public void Print()
        {
            SinglyLinkedListNode current = First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }

}
