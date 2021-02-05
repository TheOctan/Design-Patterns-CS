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

		public IDisposable Subscribe(IObserver<News> observer)
		{
			observers.Add(observer);

			return new Unsubscriber<News>(observers, observer);
		}

		public void Notify(News news)
		{
			foreach (IObserver<News> observer in observers)
			{
				observer.OnNext(news);
			}
		}
	}
}
