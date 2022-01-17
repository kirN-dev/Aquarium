using System;

namespace Aquarium.Enities
{
	public class Fish
	{
		public string Name { get; set; }
		public Breed Breed { get; set; }
		public Meal Meal { get; set; }
		public Variety Variety { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
