
namespace Collections
{
    public class CircularQueue<T>
    {
        private int size, front, rear;
        private List <T> queue = new List<T>();
        public CircularQueue(int size)
        {
            this.size = size;
            this.front = this.rear = -1;
        }
        public void Enqueue(T data)
        {
            if (front == -1)
            {
                front = 0;
                rear = 0;
                queue.Add(data);
            }
            else if (rear == size - 1 && front != 0)
            {
                rear = 0;
                queue[rear] = data;
            }
            else
            {
                rear = (rear + 1);
                if (front <= rear) queue.Add(data);
                else queue[rear] = data;
            }
        }
        public T Dequeue()
        {
            T temp;
            if (front == -1) throw new Exception("Queue is empty");
            temp = queue[front];
            if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else if (front == size - 1) front = 0;
            else front = front + 1;
            return temp;
        }
        public void Print()
        {
            if (front == -1) throw new Exception("Queue is empty");
            Console.Write("Elements in the circular queue are: ");
            if (rear >= front)
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            else
            {
                for (int i = front; i < size; i++)
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                for (int i = 0; i <= rear; i++)
                {
                    Console.Write(queue[i]);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}