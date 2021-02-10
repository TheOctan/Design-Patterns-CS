using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class NewsAgregator : IObservable<News>
	{
		private readonly List<IObserver<News>> observers;

		public NewsAgregator()
		{
			observers = new List<IObserver<News>>();
		}

		public void Subscribe(IObserver<News> observer)
		{
			observers.Add(observer);
		}

		public void Unsubscribe(IObserver<News> observer)
		{
			observers.Remove(observer);
		}

		public void Notify(News data)
		{
			foreach (IObserver<News> observer in observers)
			{
				observer.OnNext(data);
			}
		}
	}
}
