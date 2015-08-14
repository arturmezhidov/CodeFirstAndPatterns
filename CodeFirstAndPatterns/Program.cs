using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAndPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			using (UnitOfWork unitOfWork = new UnitOfWork())
			{
				//Book book = new Book()
				//{
				//	Name = "Super book 2222",
				//	Price = 10000000
				//};
				//unitOfWork.Books.Create(book);
				//unitOfWork.Save();

				var query = from b in unitOfWork.Books.GetAll()
							select b;

				foreach (var item in query)
				{
					Console.WriteLine(item.Name);
				}
			}
		}
	}
}
