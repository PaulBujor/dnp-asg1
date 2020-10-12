using FileData;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
	public class Model : IModel
	{
		private IList<Adult> adults;
		private FileContext file;

		public Model()
		{
			file = new FileContext();
			adults = file.Adults;
		}

		public void AddAdult(Adult adult)
		{
			adults.Add(adult);
			file.SaveChanges();
		}

		public IList<Adult> GetAdults()
		{
			return adults;
		}

		public IList<Adult> GetAdults(string searchCriteria)
		{
			throw new NotImplementedException();
		}
	}
}
