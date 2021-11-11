using System;

namespace Aquarium
{
    public abstract class Fish
    {
        public string Name { get; }
        public Breed Breed { get; private set; }

        public Fish(string name, Breed breed)
        {
                
        }
    }
}
