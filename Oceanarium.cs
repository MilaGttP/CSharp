
namespace Iterators
{
    interface IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string ToString();
    }
    class Fish : IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public Fish()
        {
            Type = "Fish";
            Description = "aquatic vertebrate animals that have gills but lack limbs with digits, like fingers or toes";
        }
        public override string ToString()
        {
            return $"{Type} description: {Description}\n";
        }
    }
    class Dolpin : IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public Dolpin()
        {
            Type = "Dolpin";
            Description = "small-toothed cetaceans easily recognizable by their curved mouths, which give them a permanent “smile”";
        }
        public override string ToString()
        {
            return $"{Type} description: {Description}\n";
        }
    }
    class Crab : IInhabitants
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public Crab()
        {
            Type = "Crab";
            Description = "ecapod crustaceans which have a very short tail and are covered with a thick shell, or exoskeleton and are armed with a single pair of claws";
        }
        public override string ToString()
        {
            return $"{Type} description: {Description}\n";
        }
    }
    class Oceanarium
    {
        public List <IInhabitants> inhabitants = new List <IInhabitants>()
        {
            new Fish(), new Dolpin(), new Crab(),
        };
        public IEnumerator <IInhabitants> GetEnumerator()
        {
            for (int i = 0; i < inhabitants.Count; i++)
                yield return inhabitants[i];
        }
    }
}
