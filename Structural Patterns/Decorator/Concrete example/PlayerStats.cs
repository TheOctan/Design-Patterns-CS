using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public struct PlayerStats
	{
		public float Strength { get; set; }
		public float Agility { get; set; }
		public float Intelligence { get; set; }
		public float Stamina { get; set; }

		public static PlayerStats operator + (PlayerStats left, PlayerStats right)
		{
			return new PlayerStats()
			{
				Strength = left.Strength + right.Strength,
				Agility = left.Agility + right.Agility,
				Intelligence = left.Intelligence + right.Intelligence,
				Stamina = left.Stamina + right.Stamina
			};
		}

		public static PlayerStats operator * (PlayerStats left, float value)
		{
			return new PlayerStats()
			{
				Strength = left.Strength * value,
				Agility = left.Agility * value,
				Intelligence = left.Intelligence + value,
				Stamina = left.Stamina * value
			};
		}
	}
}
