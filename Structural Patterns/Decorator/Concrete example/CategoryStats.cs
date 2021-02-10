using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class CategoryStats : IStatsProvider
	{
		private readonly PlayerCategory category;

		public CategoryStats(PlayerCategory playerCategory)
		{
			this.category = playerCategory;
		}

		public PlayerStats GetStats()
		{
			switch (category)
			{
				case PlayerCategory.Beggar:
					return new PlayerStats()
					{
						Strength = 10,
						Agility = 6,
						Intelligence = 4,
						Stamina = 8
					};
				case PlayerCategory.Employee:
					return new PlayerStats()
					{
						Strength = 4,
						Agility = 8,
						Intelligence = 10,
						Stamina = 6
					};
				case PlayerCategory.Rich:
					return new PlayerStats()
					{
						Strength = 6,
						Agility = 10,
						Intelligence = 8,
						Stamina = 8
					};
				default:
					throw new NotImplementedException($"Category {category} doesn't implemented!");
			}
		}
	}
}
