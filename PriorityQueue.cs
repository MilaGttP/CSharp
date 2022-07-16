
namespace Collections
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;
        public PriorityQueue()
        {
            data = new List<T>();
        }
        public void Enqueue(T item)
        {
            data.Add(item);
            int child = data.Count - 1;
            while (child > 0)
            {
                int parent = (child - 1) / 2;
                if (data[child].CompareTo(data[parent]) >= 0) break;
                T tmp = data[child]; 
                data[child] = data[parent]; 
                data[parent] = tmp;
                child = parent;
            }
        }
        public T Dequeue()
        {
            int last = data.Count - 1;
            T frontItem = data[0];
            data[0] = data[last];
            data.RemoveAt(last);
            --last;
            int parent = 0;
            while (true)
            {
                int child = parent * 2 + 1;
                if (child > last) break;
                int rightChild = child + 1;
                if (rightChild <= last && data[rightChild].CompareTo(data[child]) < 0)
                    child = rightChild;
                if (data[parent].CompareTo(data[child]) <= 0) break;
                T tmp = data[parent]; 
                data[parent] = data[child]; 
                data[child] = tmp;
                parent = child;
            }
            return frontItem;
        }
        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }
        public int Count()
        {
            return data.Count;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "Count = " + data.Count;
            return s;
        }
        public bool IsConsistent()
        {
            if (data.Count == 0) return true;
            int last = data.Count - 1;
            for (int parent = 0; parent < data.Count; ++parent)
            {
                int leftChild = 2 * parent + 1;
                int rightChild = 2 * parent + 2;
                if (leftChild <= last && data[parent].CompareTo(data[leftChild]) > 0) return false;
                if (rightChild <= last && data[parent].CompareTo(data[rightChild]) > 0) return false;
            }
            return true;
        }
    }
}
