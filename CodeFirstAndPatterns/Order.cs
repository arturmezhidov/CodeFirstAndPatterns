using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public class Order
	{
		public int OrderId { get; set; }
		public string Number { get; set; }
		public int BookId { get; set; }
		public Book Book { get; set; }
	}
}
