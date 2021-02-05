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

		public void Update(News data)
		{
			Console.WriteLine($"{Name} read {data.Title} : {data.Content}");
		}
	}
}
