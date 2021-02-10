using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class Reader : IObserver<News>
	{
		public string Name { get; set; }

		public Reader(string name)
		{
			Name = name;
		}
		public void OnNext(News value)
		{
			Console.WriteLine($"{Name} read {value.Title} : {value.Content}");
		}

		public void OnCompleted()
		{
			
		}

		public void OnError(Exception error)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(error.Message);
			Console.ResetColor();
		}		
	}
}
