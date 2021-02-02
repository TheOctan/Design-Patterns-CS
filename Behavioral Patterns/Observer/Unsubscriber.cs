using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class Unsubscriber<T> : IDisposable
	{
		private readonly List<IObserver<T>> observers;
		private readonly IObserver<T> observer;

		public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
		{
			this.observers = observers;
			this.observer = observer;
		}

		public void Dispose()
		{
			if (observers.Contains(observer))
			{
				observers.Remove(observer);
			}
		}
	}
}
