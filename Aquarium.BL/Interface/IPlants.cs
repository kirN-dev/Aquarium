using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Interface
{
    public interface IPlants
    {
        string Name { get; }
        int TimeGrow { get; }
        bool IsGrowUp { get; }

        float CountOxygen { get; }
    }
}
