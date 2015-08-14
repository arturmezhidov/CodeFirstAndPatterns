using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	public interface IRepository<T> where T : class
	{
		T Get(int id);
		IEnumerable<T> GetAll();
		void Create(T item);
		void Update(T item);
		void Delete(int id);
	}
}
