using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class Player
	{
		private PlayerCategory category = PlayerCategory.Employee;
		private PlayerSpecialization specialization = PlayerSpecialization.Mechanic;

		private IStatsProvider provider;

		public Player()
		{
			provider = new CategoryStats(category);
			provider = new SpecializationStats(provider, specialization);
			provider = new MultiplierStats(provider, 2);
		}

		public PlayerStats GetStats()
		{
			return provider.GetStats();
		}
	}
}
