
namespace Iterators
{
    interface IWorkers
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string WorkInCafe();
        public string ToString();
    }
    class Worker : IWorkers
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Worker() { Name = null; Position = null; }
        public Worker(string name, string position) { Name = name; Position = position; }
        public string WorkInCafe() { return $"{Name} is working in cafe!\n"; }
        public override string ToString() { return $"{Name}`s position is {Position}"; }
    }
    class Cafe
    {
        public List <IWorkers> workers = new List <IWorkers>()
        { 
            new Worker("Nina", "manager"), new Worker("Vova", "seller"), new Worker("Zhenia", "director")
        };
        public IEnumerator <IWorkers> GetEnumerator()
        {
            for (int i = 0; i < workers.Count; i++)
                yield return workers[i];
        }
    }
}
