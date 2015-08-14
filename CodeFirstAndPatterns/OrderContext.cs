using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public class OrderContext : DbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
