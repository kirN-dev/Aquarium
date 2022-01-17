using System;
using Aquarium.Utilities;

namespace Aquarium.Enities
{
	public class Algae
	{
		private int _timeGrow;
		private CountDownTimer _timer;

		public Algae(string name, int timeGrow, Variety variety)
		{
			Name = name;
			TimeGrow = timeGrow;
			Variety = variety;
		}

		public event Action Growed;

		public Variety Variety { get; }

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
			Growed?.Invoke();
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
