using Aquarium.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    class Algae : IPlants
    {
        private int _timeGrow;
        private TimeSpan _time;
        public string Name { get; }
        public int TimeGrow 
        { 
            get => _timeGrow;
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(TimeGrow));
                }

                _timeGrow = value;
            } 
        }
        public bool IsGrowUp { get; }

        public void Destroy()
        {
            throw new NotImplementedException();
        }

        public void Grow()
        {
            //_time.Ticks;
            return;
        }
    }
}
