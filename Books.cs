
namespace OperatorOverload
{
    public class Book
    {
        public string Information { get; set; }
        public Book(string Information) { this.Information = Information; }
        public override string ToString() { return $"Book`s information: {Information}\n"; }
    }
    public class BookList
    {
        Book[] books;
        public BookList(int size) { books = new Book[size]; }
        public int Length { get { return books.Length; } }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length) return books[index];
                throw new IndexOutOfRangeException();
            }
            set { books[index] = value; }
        }
        public void Add(string information, int index)
        {
            books.SetValue(new Book(information), index);
        }
        public void Delete(string information)
        {
            int index = FindByInformation(information);
            books = books.Where((source, rem_in) => index != rem_in).ToArray();
        }
        public int FindByInformation(string information)
        {
            int i = 0;
            foreach (Book item in books)
            {
                if (item.Information == information) { return i; };
                i++;
            }
            return -1;
        }
        public void Print()
        {
            if (books.Length == 0 || books == null)
            {
                throw new Exception("Array of books is empty!");
            }
            else
            {
                foreach (Book? elem in books)
                    Console.Write($"{elem.Information}\t");
            }
        }
    }
}