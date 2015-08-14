using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public class SqlBookRepository : SqlBaseRepository<Book>
	{
		public SqlBookRepository(OrderContext context)
			: base(context, context.Books) { }

		// other realizations...

	}
}
