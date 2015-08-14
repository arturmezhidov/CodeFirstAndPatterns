using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public class UnitOfWork : IDisposable
	{
		private OrderContext db = new OrderContext();
		private IRepository<Book> bookRepository;
		private IRepository<Order> orderRepository;
		private bool disposed = false;

		public IRepository<Book> Books
		{
			get
			{
				return bookRepository ?? (bookRepository = new SqlBookRepository(db));
			}
		}

		public IRepository<Order> Orders
		{
			get
			{
				return orderRepository ?? (orderRepository = new SqlOrderRepository(db));
			}
		}

		public void Save()
		{
			db.SaveChanges();
		}

		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					db.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
