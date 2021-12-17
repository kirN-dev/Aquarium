using Aquarium.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
	class Seagrass : IPlants
	{
		public Seagrass(string name)
		{
			Name = name;
		}

		public string Name { get; }

		public int TimeGrow => 0;

		public bool IsGrowUp => true;

		public float CountOxygen => .1f;
	}
}
