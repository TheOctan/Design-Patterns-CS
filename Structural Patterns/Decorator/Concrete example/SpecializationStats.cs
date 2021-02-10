using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class SpecializationStats : StatsDecorator
	{
		private readonly PlayerSpecialization specialization;
		public SpecializationStats(IStatsProvider wrappedEntity, PlayerSpecialization specialization) : base(wrappedEntity)
		{
			this.specialization = specialization;
		}

		protected override PlayerStats GetStatsInternal()
		{
			return wrappedEntity.GetStats() + GetSpecStats(specialization);
		}

		private PlayerStats GetSpecStats(PlayerSpecialization specialization)
		{
			switch (specialization)
			{
				case PlayerSpecialization.Mechanic:
					return new PlayerStats()
					{
						Strength = 1,
						Agility = 1,
						Intelligence = 5,
						Stamina = 7
					};
				case PlayerSpecialization.Pilot:
					return new PlayerStats()
					{
						Strength = 1,
						Agility = 1,
						Intelligence = 5,
						Stamina = 7
					};
				case PlayerSpecialization.Сhemist:
					return new PlayerStats()
					{
						Strength = 1,
						Agility = 1,
						Intelligence = 5,
						Stamina = 7
					};
				default:
					throw new NotImplementedException($"Category {specialization} doesn't implemented!");
			}
		}
	}
}
