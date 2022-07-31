
using System.Collections;

namespace AnonMethodsAndLambda
{
    public delegate void BackpackDelegate(double volume, string name);
    public class Backpack
    {
        public string Color { get; set; }
        public string Author { get; set; }
        public string Cloth { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public Hashtable Items = new Hashtable();
        public Backpack()
        {
            Color = null; Author = null; Cloth = null; Weight = 0; 
            Volume = 0; Items = null;
        }
        public Backpack(double volume) : this() { Volume = volume; }
        public Backpack (string color, string author, string cloth, double weigth, double volume)
        {
            Color = color;  Author = author;
            Cloth = cloth; Weight = weigth; Volume = volume;
        }
        public event BackpackDelegate addingEvent;
        public void AddItem(double volume, string name)
        {
            if (addingEvent != null && volume < Volume) addingEvent(volume, name);
            else if (volume > Volume) throw new ArgumentException($"{name}'s volume is more than backpack`s volume!");
            else throw new NullReferenceException();
        }
    }
}
