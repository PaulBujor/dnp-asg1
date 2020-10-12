using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
	public interface IModel
	{
		void AddAdult(Adult adult);
		IList<Adult> GetAdults();
		IList<Adult> GetAdults(string searchCriteria);

	}
}
