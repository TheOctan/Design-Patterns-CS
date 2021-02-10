using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class StatsDecorator : IStatsProvider
	{
		protected readonly IStatsProvider wrappedEntity;

		protected StatsDecorator(IStatsProvider wrappedEntity)
		{
			this.wrappedEntity = wrappedEntity;
		}

		public PlayerStats GetStats()
		{
			return GetStatsInternal();
		}

		protected abstract PlayerStats GetStatsInternal();
	}
}
