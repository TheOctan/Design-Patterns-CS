using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class MultiplierStats : StatsDecorator
	{
		private readonly float multiplier;
		public MultiplierStats(IStatsProvider wrappedEntity, float multiplier) : base(wrappedEntity)
		{
			this.multiplier = multiplier;
		}

		protected override PlayerStats GetStatsInternal()
		{
			return wrappedEntity.GetStats() * multiplier;
		}
	}
}
