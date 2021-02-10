using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public sealed class News
	{
		public string Title { get; }
		public string Content { get; }

		public News(string titile, string content)
		{
			Title = titile;
			Content = content;
		}
	}
}
