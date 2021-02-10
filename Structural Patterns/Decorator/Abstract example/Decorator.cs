using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public abstract class Decorator : Component
	{
		protected readonly Component component;

		protected Decorator(Component component)
		{
			this.component = component;
		}

		public override void Operation()
		{
			component?.Operation();
		}
	}
}
