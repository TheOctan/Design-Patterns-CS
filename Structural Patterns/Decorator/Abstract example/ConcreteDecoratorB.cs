using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	public class ConcreteDecoratorB : Decorator
	{
		public ConcreteDecoratorB(Component component) : base(component)
		{
		}

		public override void Operation()
		{
			base.Operation();
			Console.WriteLine("Decorator B");
		}
	}
}
