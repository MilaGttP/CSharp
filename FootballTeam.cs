
namespace Iterators
{
    interface IPlayers
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string PlayFootball();
        public string ToString();
    }
    class Player : IPlayers
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Player() {  Name = null; Number = 0; }
        public Player(string name, int number) { Name = name; Number = number; }
        public string PlayFootball() { return $"{Name} is playing football!\n"; }
        public override string ToString() { return $"{Name} number: {Number}"; }
    }
    class Team
    {
        public List <IPlayers> players { get; set; } = new List <IPlayers>()
        {
            new Player("Andrew", 2), new Player("Sergiy", 5), new Player("John", 9)
        };
        public IPlayers this[int index]
        {
            get
            {
                if (index >= 0 && index < players.Count) return players[index];
                throw new IndexOutOfRangeException();
            }
            set { players[index] = value; }
        }
        public IEnumerator <IPlayers> GetEnumerator()
        {
            for (int i = 0; i < players.Count; i++)
                yield return players[i];
        }
    }
}
