using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
	public interface IModel
	{
		Task AddAdult(Adult adult);
		Task<IList<Adult>> GetAdults();
		Task<IList<Adult>> GetAdults(string searchCriteria);

	}
}
