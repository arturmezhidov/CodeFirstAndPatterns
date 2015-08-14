using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public abstract class SqlBaseRepository<T> : IRepository<T> where T : class
	{
		protected readonly DbContext context;
		protected readonly DbSet<T> dbSet;

		protected SqlBaseRepository(DbContext context, DbSet<T> dbSet)
		{
			this.context = context;
			this.dbSet = dbSet;
		}

		public virtual IEnumerable<T> GetAll()
		{
			return dbSet;
		}

		public virtual T Get(int id)
		{
			T result = dbSet.Find(id);
			return result;
		}

		public virtual void Create(T item)
		{
			dbSet.Add(item);
		}

		public virtual void Update(T item)
		{
			context.Entry(item).State = EntityState.Modified;
		}

		public virtual void Delete(int id)
		{
			T item = dbSet.Find(id);
			if (item != null)
				dbSet.Remove(item);
		}
	}
}
