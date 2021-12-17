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
        private  CountDownTimer _timer;

		public Algae(string name, int timeGrow)
		{
            Name = name;
            TimeGrow = timeGrow;
        }

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
                _timer = new CountDownTimer(_timeGrow);
				_timer.CountDownEnd += Grow;
                _timer.Start();
            } 
        }

        public bool IsGrowUp { get; private set; } = false;

        public float CountOxygen { get; private set; } = 0f;

        private void Grow(object sender, EventArgs e)
        {
            IsGrowUp = true;
            CountOxygen = .5f;
        }
    }
}
