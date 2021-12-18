using System;

namespace Aquarium.Enities
{
	public class Fish
	{
		public string Name { get; }
		public Breed Breed { get; }
		public Meal Meal { get; set; }
	}
}
