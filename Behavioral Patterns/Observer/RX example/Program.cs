using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			NewsAgregator newsAgregator = new NewsAgregator();
			Reader steve = new Reader("Steve");
			Reader bill = new Reader("Bill");

			IDisposable steveSubscription = newsAgregator.Subscribe(steve);
			IDisposable billSubscription = newsAgregator.Subscribe(bill);

			News news1 = new News("Title1", "Content1");
			News news2 = new News("Title2", "Content2");

			newsAgregator.Notify(news1);
			steveSubscription.Dispose();

			newsAgregator.Notify(news2);
			billSubscription.Dispose();
		}
	}
}
