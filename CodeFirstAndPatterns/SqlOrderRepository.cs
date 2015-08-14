using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public class SqlOrderRepository : SqlBaseRepository<Order>
	{
		public SqlOrderRepository(OrderContext context) 
			: base(context, context.Orders) { }

		public override IEnumerable<Order> GetAll()
		{
			IQueryable<Order> result = dbSet.Include(o => o.Book);
			return result;
		}
	}
}
